﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using MxWeiXinPF.DBUtility;//Please add references
namespace MxWeiXinPF.DAL
{
	/// <summary>
	/// 数据访问类:wx_message_setting
	/// </summary>
	public partial class wx_message_setting
	{
		public wx_message_setting()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "wx_message_setting"); 
		}


        public string GetListDetailpicUrl(int wid, string openid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,wid,userName,title,parentId,openId,createDate,sort_id ");
            strSql.Append(" FROM wx_message_list ");
            if (openid != "" && wid != 0)
            {
                strSql.Append(" where openid='" + openid + "' and wid='" + wid + "' ");
            }

            return DbHelperSQL.Query(strSql.ToString()).Tables[0].Rows[0]["picUrl"].ToString();
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from wx_message_setting");
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
		public int Add(MxWeiXinPF.Model.wx_message_setting model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into wx_message_setting(");
			strSql.Append("wid,title,adminOpenid,picUrl,needSH)");
			strSql.Append(" values (");
			strSql.Append("@wid,@title,@adminOpenid,@picUrl,@needSH)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@wid", SqlDbType.Int,8),
					new SqlParameter("@title", SqlDbType.VarChar,200),
					new SqlParameter("@adminOpenid", SqlDbType.VarChar,100),
					new SqlParameter("@picUrl", SqlDbType.VarChar,800),
					new SqlParameter("@needSH", SqlDbType.Bit,1)};
			parameters[0].Value = model.wid;
			parameters[1].Value = model.title;
			parameters[2].Value = model.adminOpenid;
			parameters[3].Value = model.picUrl;
			parameters[4].Value = model.needSH;

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
		public bool Update(MxWeiXinPF.Model.wx_message_setting model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update wx_message_setting set ");
			strSql.Append("wid=@wid,");
			strSql.Append("title=@title,");
			strSql.Append("adminOpenid=@adminOpenid,");
			strSql.Append("picUrl=@picUrl,");
			strSql.Append("needSH=@needSH");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@wid", SqlDbType.Int,8),
					new SqlParameter("@title", SqlDbType.VarChar,200),
					new SqlParameter("@adminOpenid", SqlDbType.VarChar,100),
					new SqlParameter("@picUrl", SqlDbType.VarChar,800),
					new SqlParameter("@needSH", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.Int,8)};
			parameters[0].Value = model.wid;
			parameters[1].Value = model.title;
			parameters[2].Value = model.adminOpenid;
			parameters[3].Value = model.picUrl;
			parameters[4].Value = model.needSH;
			parameters[5].Value = model.id;

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
			strSql.Append("delete from wx_message_setting ");
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
			strSql.Append("delete from wx_message_setting ");
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
		public MxWeiXinPF.Model.wx_message_setting GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,wid,title,adminOpenid,picUrl,needSH from wx_message_setting ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,8)
			};
			parameters[0].Value = id;

			MxWeiXinPF.Model.wx_message_setting model=new MxWeiXinPF.Model.wx_message_setting();
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
		public MxWeiXinPF.Model.wx_message_setting DataRowToModel(DataRow row)
		{
			MxWeiXinPF.Model.wx_message_setting model=new MxWeiXinPF.Model.wx_message_setting();
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
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["adminOpenid"]!=null)
				{
					model.adminOpenid=row["adminOpenid"].ToString();
				}
				if(row["picUrl"]!=null)
				{
					model.picUrl=row["picUrl"].ToString();
				}
				if(row["needSH"]!=null && row["needSH"].ToString()!="")
				{
					if((row["needSH"].ToString()=="1")||(row["needSH"].ToString().ToLower()=="true"))
					{
						model.needSH=true;
					}
					else
					{
						model.needSH=false;
					}
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,wid,title,adminOpenid,picUrl,needSH ");
			strSql.Append(" FROM wx_message_setting ");
			if(id.ToString().Trim()!="")
			{
				strSql.Append(" where wid='"+id+"' ");
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
			strSql.Append(" id,wid,title,adminOpenid,picUrl,needSH ");
			strSql.Append(" FROM wx_message_setting ");
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
			strSql.Append("select count(1) FROM wx_message_setting ");
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
			strSql.Append(")AS Row, T.*  from wx_message_setting T ");
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
			parameters[0].Value = "wx_message_setting";
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

		#endregion  ExtensionMethod
	}
}

