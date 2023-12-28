using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AcademicSystem.App_Code
{
    public class dbHelper
    {
        public dbHelper()
        {

        }
        private static String connectionstring = ConfigurationManager.ConnectionStrings["AcademicSystemConnectionString"].ConnectionString;
        public static List<List<string>> ExcuteQuiry(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataReader dr=null;
            List<List<string>> lists = new List<List<string>>();
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                dr = sqlCommand.ExecuteReader();
                int colcount = dr.FieldCount;
                int index = 0;
                while (dr.Read())
                {
                    List<string> list = new List<string>();
                    for(int i = 0; i < colcount; i++)
                        list.Add(dr[i].ToString());
                    //添加索引在最后一行
                    list.Add((index++).ToString());
                    lists.Add(list);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                lists = null;
            }
            return lists;
        }
        public static List<List<string>> ExcuteQuiryWithNoIndex(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataReader dr = null;
            List<List<string>> lists = new List<List<string>>();
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                dr = sqlCommand.ExecuteReader();
                int colcount = dr.FieldCount;
                int index = 0;
                while (dr.Read())
                {
                    List<string> list = new List<string>();
                    for (int i = 0; i < colcount; i++)
                        list.Add(dr[i].ToString());
                    lists.Add(list);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                lists = null;
            }
            return lists;
        }
        public static bool ExcuteUpdate(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            int impactrow = 0;
            bool result = false;
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                impactrow = sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            if(impactrow > 0)
                result = true;
            return result;
        }

    }
}    

