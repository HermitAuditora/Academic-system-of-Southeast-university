using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcademicSystem.App_Code
{
    public class Rebuildclass
    {
        public static List<List<string>> getrebuildinfo(string sno)
        {
            return dbHelper.ExcuteQuiry("select * from rebuildclass_View1 where sno='" + sno + "'");
        }
        public static List<List<string>> processinfo(List<List<string>> info)
        {
            List<List<string>> lists = new List<List<string>>();
            foreach(var item in info)
            {
                List<string> list = new List<string>();
                list.Add(item[1].ToString());
                list.Add(item[2].ToString());
                list.Add(item[3].ToString());
                list.Add(item[4].ToString());
                if (!item[5].Equals("已修"))
                    list.Add("待审批");
                else
                    list.Add("");
                lists.Add(list);
            }
            return lists;
        }
        public static bool updatestate(string sno, string cno, string state)
        {
            return dbHelper.ExcuteUpdate("update takeclass set state = '" + state + "' where sno ='" + sno + "' and cno='"+ cno +"'");
        }
    }  
}