import axios from '@/libs/api.request'

//查询数据
export const getdatalist = (data) => {
  return axios.request({
    url: 'task/wocanyutask/list',
    method: 'post',
    data
  })
}