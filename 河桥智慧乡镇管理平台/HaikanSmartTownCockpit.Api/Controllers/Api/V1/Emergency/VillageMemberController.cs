﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Haikan3.Utils;
using HaikanSmartTownCockpit.Api.Entities;
using HaikanSmartTownCockpit.Api.Entities.Enums;
using HaikanSmartTownCockpit.Api.Extensions;
using HaikanSmartTownCockpit.Api.Extensions.AuthContext;
using HaikanSmartTownCockpit.Api.Extensions.CustomException;
using HaikanSmartTownCockpit.Api.logs.TolLog;
using HaikanSmartTownCockpit.Api.Models.Response;
using HaikanSmartTownCockpit.Api.RequestPayload.Emergency;
using HaikanSmartTownCockpit.Api.ViewModels.Emergency;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HaikanSmartTownCockpit.Api.Controllers.Api.V1.Emergency
{
    [Route("api/v1/emergency/[controller]/[action]")]
    [ApiController]
    [CustomAuthorize]
    public class VillageMemberController : ControllerBase
    {
        private readonly haikanHeQiaoContext _dbContext;
        private readonly IMapper _mapper;
        private IWebHostEnvironment _hostingEnvironment;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="mapper"></param>
        public VillageMemberController(haikanHeQiaoContext dbContext, IMapper mapper, IWebHostEnvironment hostingEnvironment)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }

        #region 获取可用小队列表
        /// <summary>
        /// 显示小队列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult VillageList()
        {
            using (_dbContext)
            {
                var query = from p in _dbContext.Village
                            where p.IsDelete == 0
                            orderby p.OrderBy
                            select new
                            {
                                p.VillageUuid,
                                p.VillageName
                            };

                var response = ResponseModelFactory.CreateResultInstance;
                response.SetData(query.ToList());
                return Ok(response);
            }
        }
        #endregion
        #region 后台管理列表
        /// <summary>
        /// 显示所有信息
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult List(VillageMemberRequestPayload payload)
        {
            using (_dbContext)
            {
                var query = from p in _dbContext.VillageMember
                            select new
                            {
                                p.VillageMemberUuid,
                                p.VillageUu.VillageName,
                                p.MemberName,
                                p.MemberSex,
                                p.MemberPhone,
                                p.IsDelete,
                                p.Id
                            };
                if (!string.IsNullOrEmpty(payload.Kw))
                {
                    query = query.Where(x => x.VillageName.Contains(payload.Kw.Trim()) || x.MemberName.Contains(payload.Kw.Trim()));
                }

                if (payload.IsDeleted > CommonEnum.IsDeleted.All)
                {
                    query = query.Where(x => x.IsDelete == Convert.ToInt32(((CommonEnum.IsDeleted)payload.IsDeleted)));
                }

                query = query.OrderByDescending(x => x.Id);
                var list = query.Paged(payload.CurrentPage, payload.PageSize).ToList();

                var totalCount = query.Count();
                var response = ResponseModelFactory.CreateResultInstance;
                response.SetData(list, totalCount);
                ToLog.AddLog("查询", "成功:查询:村干部信息数据", _dbContext);
                return Ok(response);
            }
        }
        #endregion
        #region 创建
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model">视图实体</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        public IActionResult Create(VillageMemberViewModel model)
        {
            var response = ResponseModelFactory.CreateInstance;

            using (_dbContext)
            {
                //if (_dbContext.VillageMember.Count(x => x.MemberName == model.MemberName) > 0)
                //{
                //    response.SetFailed("名称已存在");
                //    return Ok(response);
                //}

                var entity = _mapper.Map<VillageMemberViewModel, VillageMember>(model);
                entity.VillageMemberUuid = Guid.NewGuid();
                entity.IsDelete = 0;
                entity.AddPeople = AuthContextService.CurrentUser.DisplayName;
                _dbContext.VillageMember.Add(entity);
                int res = _dbContext.SaveChanges();
                if (res > 0)
                {
                    ToLog.AddLog("添加", "成功:添加:村干部信息一条数据", _dbContext);
                }
                response.SetSuccess();
                return Ok(response);
            }
        }
        #endregion
        #region 编辑
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="guid">惟一编码</param>
        /// <returns></returns>
        [HttpGet("{guid}")]
        [ProducesResponseType(200)]
        public IActionResult Edit(Guid guid)
        {
            using (_dbContext)
            {
                var entity = _dbContext.VillageMember.FirstOrDefault(x => x.VillageMemberUuid == guid);
                var response = ResponseModelFactory.CreateInstance;
                response.SetData(_mapper.Map<VillageMember, VillageMemberViewModel>(entity));
                return Ok(response);
            }
        }
        /// <summary>
        /// 保存编辑后的信息
        /// </summary>
        /// <param name="model">视图实体</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        public IActionResult Edit(VillageMemberViewModel model)
        {
            var response = ResponseModelFactory.CreateInstance;

            using (_dbContext)
            {
                var entity = _dbContext.VillageMember.FirstOrDefault(x => x.VillageMemberUuid == model.VillageMemberUuid);
                if (entity == null)
                {
                    response.SetFailed("不存在");
                    return Ok(response);
                }
                //if (_dbContext.VillageMember.Count(x => x.TeamName == model.TeamName && x.VillageMemberUuid != model.VillageMemberUuid) > 0)
                //{
                //    response.SetFailed("名称已存在");
                //    return Ok(response);
                //}
                entity.VillageUuid = model.VillageUuid;
                entity.MemberName = model.MemberName;
                entity.MemberSex = model.MemberSex;
                entity.MemberPhone = model.MemberPhone;
                int res = _dbContext.SaveChanges();
                if (res > 0)
                {
                    ToLog.AddLog("编辑", "成功:编辑:村干部信息一条数据", _dbContext);
                }
                response = ResponseModelFactory.CreateInstance;
                return Ok(response);
            }
        }
        #endregion
        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids">ID,多个以逗号分隔</param>
        /// <returns></returns>
        [HttpGet("{ids}")]
        [ProducesResponseType(200)]
        public IActionResult Delete(string ids)
        {
            var response = ResponseModelFactory.CreateInstance;
            response = UpdateIsDelete(CommonEnum.IsDeleted.Yes, ids);
            return Ok(response);
        }
        /// <summary>
        /// 批量操作
        /// </summary>
        /// <param name="command"></param>
        /// <param name="ids">ID,多个以逗号分隔</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult Batch(string command, string ids)
        {
            var response = ResponseModelFactory.CreateInstance;
            switch (command)
            {
                case "delete":
                    response = UpdateIsDelete(CommonEnum.IsDeleted.Yes, ids);
                    break;
                case "recover":
                    response = UpdateIsDelete(CommonEnum.IsDeleted.No, ids);
                    break;

                default:
                    break;
            }
            return Ok(response);
        }
        #region 私有方法

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="isDeleted"></param>
        /// <param name="ids">ID字符串,多个以逗号隔开</param>
        /// <returns></returns>
        private ResponseModel UpdateIsDelete(CommonEnum.IsDeleted isDeleted, string ids)
        {
            using (_dbContext)
            {
                var parameters = ids.Split(",").Select((id, index) => new SqlParameter(string.Format("@p{0}", index), id)).ToList();
                var parameterNames = string.Join(", ", parameters.Select(p => p.ParameterName));
                var sql = string.Format("UPDATE VillageMember SET IsDelete=@IsDel WHERE VillageMemberUUID IN ({0})", parameterNames);
                parameters.Add(new SqlParameter("@IsDel", (int)isDeleted));
                _dbContext.Database.ExecuteSqlRaw(sql, parameters);
                ToLog.AddLog("删除", "成功:删除:村干部信息一条数据", _dbContext);
                var response = ResponseModelFactory.CreateInstance;
                return response;
            }
        }
        #endregion
        #endregion

        #region 导入导出
        /// <summary>
        /// 导入信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult VillageMemberImport(IFormFile excelfile)
        {
            var response = ResponseModelFactory.CreateInstance;
            using (_dbContext)
            {
                DateTime beginTime = DateTime.Now;

                string sWebRootFolder = _hostingEnvironment.WebRootPath + "\\UploadFiles\\ImportEmergencyExcel";


                //var schoolinfo = _dbContext.SchoolInforManagement.AsQueryable();
                string uploadtitle = "村干部信息导入" + DateTime.Now.ToString("yyyyMMddHHmmss");
                string sFileName = $"{uploadtitle}.xlsx";
                FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
                //string conStr = ConnectionStrings.DefaultConnection;
                string responsemsgsuccess = "";
                string responsemsgrepeat = "";
                string responsemsgdefault = "";
                int successcount = 0;
                int repeatcount = 0;
                int defaultcount = 0;
                //string today = DateTime.Now.ToString("yyyy-MM-dd");
                try
                {
                    //把excelfile中的数据复制到file中
                    using (FileStream fs = new FileStream(file.ToString(), FileMode.Create)) //初始化一个指定路径和创建模式的FileStream
                    {
                        excelfile.CopyTo(fs);
                        fs.Flush();  //清空stream的缓存，并且把缓存中的数据输出到file
                    }
                    DataTable dt = Haikan3.Utils.ExcelTools.ExcelToDataTable(file.ToString(), "Sheet1", true);

                    if (dt == null || dt.Rows.Count == 0)
                    {
                        response.SetFailed("表格无数据");
                        return Ok(response);
                    }
                    else
                    {
                        if (!dt.Columns.Contains("村庄名称"))
                        {
                            response.SetFailed("无‘村庄名称’列");
                            return Ok(response);
                        }
                        if (!dt.Columns.Contains("姓名"))
                        {
                            response.SetFailed("无‘姓名’列");
                            return Ok(response);
                        }
                        if (!dt.Columns.Contains("性别"))
                        {
                            response.SetFailed("无‘性别’列");
                            return Ok(response);
                        }
                        if (!dt.Columns.Contains("联系电话"))
                        {
                            response.SetFailed("无‘联系电话’列");
                            return Ok(response);
                        }


                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            var entity = new VillageMember();
                            entity.VillageMemberUuid = Guid.NewGuid();
                            if (!string.IsNullOrEmpty(dt.Rows[i]["村庄名称"].ToString()))
                            {
                                var village = _dbContext.Village.FirstOrDefault(x=>x.VillageName== dt.Rows[i]["村庄名称"].ToString());
                                if(village==null)
                                {
                                    responsemsgdefault += "<p style='color:red'>" + "第" + (i + 2) + "行村庄名称不存在" + "</p></br>";
                                    defaultcount++;
                                    continue;
                                }
                                else
                                {
                                    entity.VillageUuid = village.VillageUuid;
                                }
                            }
                            else
                            {
                                responsemsgdefault += "<p style='color:red'>" + "第" + (i + 2) + "行村庄名称为空" + "</p></br>";
                                defaultcount++;
                                continue;
                            }
                            if (!string.IsNullOrEmpty(dt.Rows[i]["姓名"].ToString()))
                            {
                                entity.MemberName = dt.Rows[i]["姓名"].ToString();  
                            }
                            else
                            {
                                responsemsgdefault += "<p style='color:red'>" + "第" + (i + 2) + "行姓名为空" + "</p></br>";
                                defaultcount++;
                                continue;
                            }
                            if (!string.IsNullOrEmpty(dt.Rows[i]["性别"].ToString()))
                            {
                                entity.MemberSex = dt.Rows[i]["性别"].ToString();
                            }
                            else
                            {
                                responsemsgdefault += "<p style='color:red'>" + "第" + (i + 2) + "行性别为空" + "</p></br>";
                                defaultcount++;
                                continue;
                            }
                            if (!string.IsNullOrEmpty(dt.Rows[i]["联系电话"].ToString()))
                            {
                                entity.MemberPhone = dt.Rows[i]["联系电话"].ToString();
                            }
                            else
                            {
                                responsemsgdefault += "<p style='color:red'>" + "第" + (i + 2) + "行联系电话为空" + "</p></br>";
                                defaultcount++;
                                continue;
                            }

                            //entity.AddTime = DateTime.Now.ToString("yyyy-MM-dd");
                            entity.AddPeople = AuthContextService.CurrentUser.DisplayName;
                            entity.IsDelete = 0;
                            _dbContext.VillageMember.Add(entity);
                            _dbContext.SaveChanges();
                            successcount++;
                        }
                    }
                    responsemsgsuccess = "<p style='color:green'>导入成功:" + successcount + "条</p></br>" + responsemsgsuccess;
                    responsemsgrepeat = "<p style='color:orange'>重复需手动修改数据:" + repeatcount + "条</p></br>" + responsemsgrepeat;
                    responsemsgdefault = "<p style='color:red'>导入失败:" + defaultcount + "条</p></br>" + responsemsgdefault;

                    ToLog.AddLog("导入", "成功:导入:村干部信息数据", _dbContext);
                    //DateTime endTime = DateTime.Now;
                    //TimeSpan useTime = endTime - beginTime;
                    //string taketime = "导入时间" + useTime.TotalSeconds.ToString() + "秒  ";
                    response.SetData(JsonConvert.DeserializeObject(JsonConvert.SerializeObject(new
                    {
                        //time = taketime,
                        successmsg = responsemsgsuccess
                        ,
                        repeatmsg = responsemsgrepeat,
                        defaultmsg = responsemsgdefault
                    })));
                    return Ok(response);
                }
                catch (Exception ex)
                {

                    response.SetFailed(ex.Message);
                    return Ok(response);
                }
            }
        }

        /// <summary>
        /// 导出信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult VillageMemberExport(string ids)
        {
            var response = ResponseModelFactory.CreateResultInstance;
            using (_dbContext)
            {
                var column = new List<string>()
                    {
                        "村庄名称","姓名","性别","联系电话"
                    };
                var column2 = new List<string>()
                    {
                        "VillageName","MemberName","MemberSex","MemberPhone"
                    };
                if (!string.IsNullOrEmpty(ids))
                {
                    var parameters = ids.Trim().Split(",");
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        parameters[i] = parameters[i].ToUpper();
                    }
                    var query = _dbContext.VillageMember.Where(x => x.IsDelete != 1 && parameters.Contains(x.VillageMemberUuid.ToString())).Select(x => new
                    {
                        VillageName = x.VillageUu.VillageName,
                        MemberName = x.MemberName,
                        MemberSex = x.MemberSex,
                        MemberPhone = x.MemberPhone
                    }).ToList();
                    string sWebRootFolder = _hostingEnvironment.WebRootPath + "\\UploadFiles\\ImportEmergencyExcel\\";
                    string uploadtitle = "村庄成员信息导出" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string sFileName = $"{sWebRootFolder + uploadtitle}.xlsx";

                    DataToExcel.TablesToExcel(query, sFileName, column, column2);
                    response.SetData("\\UploadFiles\\ImportEmergencyExcel\\" + uploadtitle + ".xlsx");
                    ToLog.AddLog("导出", "成功:导出:村干部信息数据", _dbContext);
                    return Ok(response);
                }
                else
                {

                    var query = _dbContext.VillageMember.Where(x => x.IsDelete != 1).Select(x => new
                    {
                        VillageName = x.VillageUu.VillageName,
                        MemberName = x.MemberName,
                        MemberSex = x.MemberSex,
                        MemberPhone = x.MemberPhone
                    }).ToList();
                    string sWebRootFolder = _hostingEnvironment.WebRootPath + "\\UploadFiles\\ImportEmergencyExcel\\";
                    string uploadtitle = "村庄成员信息导出" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string sFileName = $"{sWebRootFolder + uploadtitle}.xlsx";

                    DataToExcel.TablesToExcel(query, sFileName, column, column2);
                    response.SetData("\\UploadFiles\\ImportEmergencyExcel\\" + uploadtitle + ".xlsx");
                    ToLog.AddLog("导出", "成功:导出:村干部信息数据", _dbContext);
                    return Ok(response);
                }
            }
        }
        #endregion
    }
}
