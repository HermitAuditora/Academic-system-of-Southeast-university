using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcademicSystem.App_Code
{
    public class Delayedexam
    {
        public static List<List<string>> delayedexaminfo(string sno)
        {
            return dbHelper.ExcuteQuiryWithNoIndex("select * from delayedexam_View1 where sno='"+sno+"'");
        }
        public static List<List<string>> processdata(List<List<string>> data)
        {
            List<List<string>> lists = new List<List<string>>();
            foreach (var item in data)
            {
                List<string> list = new List<string>();
                for(int i = 1; i < item.Count-1; i++)
                    list.Add(item[i].ToString());
                if (item[6].Equals("否"))
                    list.Add("");
                else
                    list.Add(item[6]);
                lists.Add(list);
            }
            return lists;
        }
        public static bool updatestate(string sno,string cno,string state)
        {
            return dbHelper.ExcuteUpdate("update takeclass set delayedexam = '"+ state+"' where sno ='" + sno + "' and cno='" + cno +"'");
        }
    }
}