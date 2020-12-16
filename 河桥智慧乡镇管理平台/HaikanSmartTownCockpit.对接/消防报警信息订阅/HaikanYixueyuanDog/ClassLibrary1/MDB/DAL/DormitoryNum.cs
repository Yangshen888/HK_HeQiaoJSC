using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Haikan.DBHelper;
namespace ClassLibrary1.DAL
{
	/// <summary>
	/// ���ݷ�����:DormitoryNum
	/// </summary>
	public partial class DormitoryNum
	{
		public DormitoryNum()
		{}
		#region  BasicMethod

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(Guid DormitoryNumUuid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DormitoryNum");
			strSql.Append(" where DormitoryNumUuid=@DormitoryNumUuid ");
			SqlParameter[] parameters = {
					new SqlParameter("@DormitoryNumUuid", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = DormitoryNumUuid;

			return DbHelperSql.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(ClassLibrary1.Model.DormitoryNum model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DormitoryNum(");
			strSql.Append("CreateTime,DormitoryNumUuid,DormitoryUuid,DormitoryNumName,IsDeleted,AddTime,AddPeople)");
			strSql.Append(" values (");
			strSql.Append("@CreateTime,@DormitoryNumUuid,@DormitoryUuid,@DormitoryNumName,@IsDeleted,@AddTime,@AddPeople)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CreateTime", SqlDbType.DateTime2,8),
					new SqlParameter("@DormitoryNumUuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@DormitoryUuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@DormitoryNumName", SqlDbType.VarChar,255),
					new SqlParameter("@IsDeleted", SqlDbType.Int,4),
					new SqlParameter("@AddTime", SqlDbType.VarChar,255),
					new SqlParameter("@AddPeople", SqlDbType.VarChar,255)};
			parameters[0].Value = model.CreateTime;
			parameters[1].Value = model.DormitoryNumUuid;
			parameters[2].Value = model.DormitoryUuid;
			parameters[3].Value = model.DormitoryNumName;
			parameters[4].Value = model.IsDeleted;
			parameters[5].Value = model.AddTime;
			parameters[6].Value = model.AddPeople;

			object obj = DbHelperSql.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ClassLibrary1.Model.DormitoryNum model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DormitoryNum set ");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("DormitoryUuid=@DormitoryUuid,");
			strSql.Append("DormitoryNumName=@DormitoryNumName,");
			strSql.Append("IsDeleted=@IsDeleted,");
			strSql.Append("AddTime=@AddTime,");
			strSql.Append("AddPeople=@AddPeople");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CreateTime", SqlDbType.DateTime2,8),
					new SqlParameter("@DormitoryUuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@DormitoryNumName", SqlDbType.VarChar,255),
					new SqlParameter("@IsDeleted", SqlDbType.Int,4),
					new SqlParameter("@AddTime", SqlDbType.VarChar,255),
					new SqlParameter("@AddPeople", SqlDbType.VarChar,255),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DormitoryNumUuid", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.CreateTime;
			parameters[1].Value = model.DormitoryUuid;
			parameters[2].Value = model.DormitoryNumName;
			parameters[3].Value = model.IsDeleted;
			parameters[4].Value = model.AddTime;
			parameters[5].Value = model.AddPeople;
			parameters[6].Value = model.ID;
			parameters[7].Value = model.DormitoryNumUuid;

			int rows=DbHelperSql.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DormitoryNum ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSql.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(Guid DormitoryNumUuid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DormitoryNum ");
			strSql.Append(" where DormitoryNumUuid=@DormitoryNumUuid ");
			SqlParameter[] parameters = {
					new SqlParameter("@DormitoryNumUuid", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = DormitoryNumUuid;

			int rows=DbHelperSql.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// ����ɾ������
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DormitoryNum ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSql.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ClassLibrary1.Model.DormitoryNum GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CreateTime,DormitoryNumUuid,DormitoryUuid,DormitoryNumName,IsDeleted,AddTime,AddPeople from DormitoryNum ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			ClassLibrary1.Model.DormitoryNum model=new ClassLibrary1.Model.DormitoryNum();
			DataSet ds=DbHelperSql.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ClassLibrary1.Model.DormitoryNum DataRowToModel(DataRow row)
		{
			ClassLibrary1.Model.DormitoryNum model=new ClassLibrary1.Model.DormitoryNum();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["DormitoryNumUuid"]!=null && row["DormitoryNumUuid"].ToString()!="")
				{
					model.DormitoryNumUuid= new Guid(row["DormitoryNumUuid"].ToString());
				}
				if(row["DormitoryUuid"]!=null && row["DormitoryUuid"].ToString()!="")
				{
					model.DormitoryUuid= new Guid(row["DormitoryUuid"].ToString());
				}
				if(row["DormitoryNumName"]!=null)
				{
					model.DormitoryNumName=row["DormitoryNumName"].ToString();
				}
				if(row["IsDeleted"]!=null && row["IsDeleted"].ToString()!="")
				{
					model.IsDeleted=int.Parse(row["IsDeleted"].ToString());
				}
				if(row["AddTime"]!=null)
				{
					model.AddTime=row["AddTime"].ToString();
				}
				if(row["AddPeople"]!=null)
				{
					model.AddPeople=row["AddPeople"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CreateTime,DormitoryNumUuid,DormitoryUuid,DormitoryNumName,IsDeleted,AddTime,AddPeople ");
			strSql.Append(" FROM DormitoryNum ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSql.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,CreateTime,DormitoryNumUuid,DormitoryUuid,DormitoryNumName,IsDeleted,AddTime,AddPeople ");
			strSql.Append(" FROM DormitoryNum ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSql.Query(strSql.ToString());
		}

		/// <summary>
		/// ��ȡ��¼����
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DormitoryNum ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSql.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from DormitoryNum T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSql.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "DormitoryNum";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSql.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

