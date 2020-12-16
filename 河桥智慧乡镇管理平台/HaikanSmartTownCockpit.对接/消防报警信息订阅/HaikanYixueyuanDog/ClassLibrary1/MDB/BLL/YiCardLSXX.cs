using Haikan.DataTools;
using System;
using System.Data;
using System.Collections.Generic;
using ClassLibrary1.Model;
namespace ClassLibrary1.BLL
{
	/// <summary>
	/// һ��ͨ��ˮ��Ϣ��
	/// </summary>
	public partial class YiCardLSXX
	{
		private readonly ClassLibrary1.DAL.YiCardLSXX dal=new ClassLibrary1.DAL.YiCardLSXX();
		public YiCardLSXX()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(Guid YicardUuid)
		{
			return dal.Exists(YicardUuid);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ClassLibrary1.Model.YiCardLSXX model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ClassLibrary1.Model.YiCardLSXX model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(Guid YicardUuid)
		{
			
			return dal.Delete(YicardUuid);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(PageValidate.SafeLongFilter(Idlist,0) );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ClassLibrary1.Model.YiCardLSXX GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public ClassLibrary1.Model.YiCardLSXX GetModelByCache(int Id)
		{
			
			string CacheKey = "YiCardLSXXModel-" + Id;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Id);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ClassLibrary1.Model.YiCardLSXX)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ClassLibrary1.Model.YiCardLSXX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ClassLibrary1.Model.YiCardLSXX> DataTableToList(DataTable dt)
		{
			List<ClassLibrary1.Model.YiCardLSXX> modelList = new List<ClassLibrary1.Model.YiCardLSXX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ClassLibrary1.Model.YiCardLSXX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

