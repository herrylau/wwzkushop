﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using MxWeiXinPF.DBUtility;
using MxWeiXinPF.Common;//Please add references
namespace MxWeiXinPF.DAL
{
	/// <summary>
	/// 数据访问类:wx_ucard_adver
	/// </summary>
	public partial class wx_ucard_adver
	{
		public wx_ucard_adver()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "wx_ucard_adver"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from wx_ucard_adver");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,8)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MxWeiXinPF.Model.wx_ucard_adver model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into wx_ucard_adver(");
			strSql.Append("wid,adverName,picUrl,linkUrl,isShow,sort_id,createDate)");
			strSql.Append(" values (");
			strSql.Append("@wid,@adverName,@picUrl,@linkUrl,@isShow,@sort_id,@createDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@wid", SqlDbType.Int,8),
					new SqlParameter("@adverName", SqlDbType.VarChar,50),
					new SqlParameter("@picUrl", SqlDbType.VarChar,800),
					new SqlParameter("@linkUrl", SqlDbType.VarChar,200),
					new SqlParameter("@isShow", SqlDbType.Bit,1),
					new SqlParameter("@sort_id", SqlDbType.Int,8),
					new SqlParameter("@createDate", SqlDbType.DateTime)};
			parameters[0].Value = model.wid;
			parameters[1].Value = model.adverName;
			parameters[2].Value = model.picUrl;
			parameters[3].Value = model.linkUrl;
			parameters[4].Value = model.isShow;
			parameters[5].Value = model.sort_id;
			parameters[6].Value = model.createDate;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(MxWeiXinPF.Model.wx_ucard_adver model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update wx_ucard_adver set ");
			strSql.Append("wid=@wid,");
			strSql.Append("adverName=@adverName,");
			strSql.Append("picUrl=@picUrl,");
			strSql.Append("linkUrl=@linkUrl,");
			strSql.Append("isShow=@isShow,");
			strSql.Append("sort_id=@sort_id,");
			strSql.Append("createDate=@createDate");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@wid", SqlDbType.Int,8),
					new SqlParameter("@adverName", SqlDbType.VarChar,50),
					new SqlParameter("@picUrl", SqlDbType.VarChar,800),
					new SqlParameter("@linkUrl", SqlDbType.VarChar,200),
					new SqlParameter("@isShow", SqlDbType.Bit,1),
					new SqlParameter("@sort_id", SqlDbType.Int,8),
					new SqlParameter("@createDate", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,8)};
			parameters[0].Value = model.wid;
			parameters[1].Value = model.adverName;
			parameters[2].Value = model.picUrl;
			parameters[3].Value = model.linkUrl;
			parameters[4].Value = model.isShow;
			parameters[5].Value = model.sort_id;
			parameters[6].Value = model.createDate;
			parameters[7].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from wx_ucard_adver ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,8)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from wx_ucard_adver ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		/// 得到一个对象实体
		/// </summary>
		public MxWeiXinPF.Model.wx_ucard_adver GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,wid,adverName,picUrl,linkUrl,isShow,sort_id,createDate from wx_ucard_adver ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,8)
			};
			parameters[0].Value = id;

			MxWeiXinPF.Model.wx_ucard_adver model=new MxWeiXinPF.Model.wx_ucard_adver();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
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
		/// 得到一个对象实体
		/// </summary>
		public MxWeiXinPF.Model.wx_ucard_adver DataRowToModel(DataRow row)
		{
			MxWeiXinPF.Model.wx_ucard_adver model=new MxWeiXinPF.Model.wx_ucard_adver();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["wid"]!=null && row["wid"].ToString()!="")
				{
					model.wid=int.Parse(row["wid"].ToString());
				}
				if(row["adverName"]!=null)
				{
					model.adverName=row["adverName"].ToString();
				}
				if(row["picUrl"]!=null)
				{
					model.picUrl=row["picUrl"].ToString();
				}
				if(row["linkUrl"]!=null)
				{
					model.linkUrl=row["linkUrl"].ToString();
				}
				if(row["isShow"]!=null && row["isShow"].ToString()!="")
				{
					if((row["isShow"].ToString()=="1")||(row["isShow"].ToString().ToLower()=="true"))
					{
						model.isShow=true;
					}
					else
					{
						model.isShow=false;
					}
				}
				if(row["sort_id"]!=null && row["sort_id"].ToString()!="")
				{
					model.sort_id=int.Parse(row["sort_id"].ToString());
				}
				if(row["createDate"]!=null && row["createDate"].ToString()!="")
				{
					model.createDate=DateTime.Parse(row["createDate"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,wid,adverName,picUrl,linkUrl,isShow,sort_id,createDate ");
			strSql.Append(" FROM wx_ucard_adver ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,wid,adverName,picUrl,linkUrl,isShow,sort_id,createDate ");
			strSql.Append(" FROM wx_ucard_adver ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM wx_ucard_adver ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
		/// 分页获取数据列表
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from wx_ucard_adver T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
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
			parameters[0].Value = "wx_ucard_adver";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

        /// <summary>
        /// 修改一列数据
        /// </summary>
        public void UpdateField(int id, string strValue)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update wx_ucard_adver set " + strValue);
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from wx_ucard_adver  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where  " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
		#endregion  ExtensionMethod
	}
}

