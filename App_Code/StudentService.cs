using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace AcademicSystem.App_Code
{
   
    public class StudentService
    {
        public static Boolean validaccount(string sno, string password)
        {
            List<List<String>> reader = dbHelper.ExcuteQuiry("select * from student_account_View1 where sno = '" + sno + "'");
            string pwd = null;
            if (reader.Count!=0)
            {
                pwd = reader[0][1];
            }
            if(pwd!=null&&pwd.Equals(password))
                return true;
            return false;
        }
        public static List<string> findviewbyid(string sno)
        {
            List<List<string>> reader = dbHelper.ExcuteQuiry("select * from student_View1 where sno = '" + sno + "'");
            return reader[0];
        }

        public static string findnamebyid(string sno)
        {
            List<List<string>> reader = dbHelper.ExcuteQuiry("select * from student where sno = '" + sno + "'");
            return reader[0][1].ToString();
        }
    }
}