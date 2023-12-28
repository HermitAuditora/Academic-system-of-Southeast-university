using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcademicSystem.App_Code
{
    public class Querygrade
    {
        public static List<List<string>> querygradeinfo(string sno)
        {
            return dbHelper.ExcuteQuiryWithNoIndex("select * from querygrade_View1 where 学号='" + sno + "'");
        }
        public static float avggpa(string sno)
        {
            float avggpa = 0;
            float totalcredit = 0;
            List<List<string>> lists = querygradeinfo(sno);
            foreach (List<string> list in lists)
            {
                avggpa += float.Parse(list[12]);
                totalcredit += float.Parse(list[5]);
            }
            return (float)Math.Round(avggpa/totalcredit,2);
        }
    }
}