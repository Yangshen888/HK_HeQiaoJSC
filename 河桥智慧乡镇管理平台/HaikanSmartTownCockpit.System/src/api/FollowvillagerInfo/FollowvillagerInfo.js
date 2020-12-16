import axios from '@/libs/api.request'

//列表
export const UserInfoList = (data) => {
  return axios.request({
    url: 'FollowvillagerInfo/FollowvillagerInfo/UserInfoList',
    method: 'post',
    data
  })
}
 
//添加
export const UserInfoCreate = (data) => {
  return axios.request({
    url: 'FollowvillagerInfo/FollowvillagerInfo/UserInfoCreate',
    method: 'post',
    data
  })
}

//获取数据
export const UserInfoGet = (data) => {
  return axios.request({
    url: 'FollowvillagerInfo/FollowvillagerInfo/UserInfoGet?guid=' + data,
    method: 'get',
  })
}

//编辑
export const UserInfoEdit = (data) => {
  return axios.request({
    url: 'FollowvillagerInfo/FollowvillagerInfo/UserInfoEdit',
    method: 'post',
    data
  })
}

// delete department
export const deleteDepartment = (ids) => {
  return axios.request({
    url: 'FollowvillagerInfo/FollowvillagerInfo/delete/' + ids,
    method: 'get'
  })
}

// batch command
export const batchCommand = (data) => {
  return axios.request({
    url: 'FollowvillagerInfo/FollowvillagerInfo/batch',
    method: 'get',
    params: data
  })
} 

//导入
export const UserInfoImport = (data) => {
  return axios.request({
    url: 'FollowvillagerInfo/FollowvillagerInfo/UserInfoImport',
    method: 'post',
    data
  })
}

//导出
export const UserInfoExport = (ids) => {
  return axios.request({
    url: 'FollowvillagerInfo/FollowvillagerInfo/ExportPass?ids=' + ids,
    method: 'get'
  })
}





