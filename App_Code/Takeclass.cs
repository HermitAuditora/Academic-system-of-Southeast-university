using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace AcademicSystem.App_Code
{
    public class Takeclass
    {
        //小课表
        //返回本学期修的课
        public static List<List<string>> takeclassinfo(string sno)
        {
            List<List<string>> results = dbHelper.ExcuteQuiry("select * from takeclass_View2 where sno = '" + sno + "' and state ='在修'");
            return results;
        }
        public static List<string> processclassinfo(List<List<string>> results)
        {
            List<string> result = new List<string>();
            string chinesenum = "一二三四五六日";
            foreach (List<string> list in results)
            {
                //多少周
                string str = list[1] + "-" + list[2]+"周";
                //单双周
                if (list[3].Equals("单") || list[3].Equals("双"))
                    str += "("+list[3]+")";
                //上课时间
                str += "(" + list[4]+"-"+list[5]+"节)-";
                //星期几
                str += "星期" + chinesenum[Convert.ToInt32(list[6]) - 1]+"-";
                //课程名
                str += list[7] + "-";
                //教室
                str += list[8] + "-" + list[9] + "-";
                //教师名
                str += list[10];
                result.Add(str);
            }
            return result;
        }

        //大课表
        public static List<List<string>> takecourseinfo(string sno)
        {
            List<List<string>> results = dbHelper.ExcuteQuiry("select * from takeclass_View2 where sno = '" + sno + "'");
            return results;
        }
        public static List<string> processcourse(List<List<string>> results)
        {
            List<string> result = new List<string>();
            foreach (List<string> list in results)
            {
                //课程名
                string str = list[7]+ "</br>";
                //(x-x节)x-x周
                str += "(" + list[4] + "-" + list[5] + "节)" + list[1] + "-" + list[2] + "周</br>";
                //教师名字
                str += "教师:" + list[10] + "</br>";
                //教学班名
                str += "教学班:" + list[11] + "</br>";
                //教学班组成(有问题)
                str += "教学班组成:" + list[15] + "</br>";
                //周学时
                str += "周学时:"+list[14] + "</br>";
                //总学时
                str += "总学时:"+list[12] + "</br>";
                //总学分
                str += "总学分:"+list[13] + "</br>";
                result.Add(str);

            }
            return result;
        }

    }
}