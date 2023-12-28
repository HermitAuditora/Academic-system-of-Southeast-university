using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademicSystem.App_Code;

namespace AcademicSystem.App_Code
{
    public class Selectcourse
    {
        //查询选修课视图中所有的元素
        public static List<List<string>> QueryCourseView()
        {
            List<List<string>> list = dbHelper.ExcuteQuiry("select * from selectclass_View1");
            return list;
        }
        //课程号 课程名 学分 教学班名称 上课教师 上课时间 教学地点 课程归属 已选/容量
        public static List<List<string>> QueryCourse(List<List<string>> lists)
        {
            string trans = "一二三四五六日";
            List<List<string>> results = new List<List<string>>();
            foreach (var list in lists)
            {
                List<string> result = new List<string>();
                result.Add(list[12]);
                result.Add(list[13]);
                result.Add(list[15]);
                result.Add(list[1]);
                result.Add(list[3]);
                result.Add("星期" + trans[Convert.ToInt32(list[4]) - 1] + "第" + list[5] + "-" + list[6] + "节(" + list[7] + "-" + list[8]+"周)");
                result.Add(list[10] + "-" + list[11]);
                result.Add(list[14]);
                result.Add(list[16] + "/" + list[17]);
                results.Add(result);
            }
            return results;
        }
        //返回教学班个数
        public static int countteachclass(string cno)
        {
            List<List<string>> list = dbHelper.ExcuteQuiry("select * from selectclass_View1 where cno='"+cno+"'");
            return list.Count;
        }
        //返回是否修课程
        public static bool iftakeclass(string sno,string cno)
        {
            bool result = false;
            List<List<string>> lists = dbHelper.ExcuteQuiry("select * from takeclass where sno='" + sno + "'" + " and cno ='" + cno + "'");
            if (lists!=null&&lists.Count!=0)
                result = true;
            return result;
        }
        //返回是否修某门教学班的课
        public static bool iftaketeachclass(string sno,string cno,string tclassid)
        {
            bool result = false;
            List<List<string>> lists = dbHelper.ExcuteQuiry("select * from takeclass where sno='" + sno + "'" + " and cno ='" + cno + "' and tclassid='" + tclassid + "'");
            if ( lists != null&& lists.Count!=0)
                result = true;
            return result;
        }
        //课程号 课程名 学分 教学班个数 状态
        public static List<string> QueryCourseinfo(List<List<string>> lists,string sno)
        {
            List<string> result = new List<string>();
            foreach (List<string> list in lists)
            {
                //课程号
                string str = "(" + list[12] + ")";
                //课程名
                str += list[13] + " - ";
                //学分
                str += list[15] +"学分   ";
                //教学班个数
                str += "教学班个数:"+countteachclass(list[12]);
                //状态
                string state = "";
                if (iftakeclass(sno, list[12]))
                    state = "已选";
                else
                    state = "未选";
                str += "   状态:"+ state;
                result.Add(str);
            }
            return result;
        }
        //检测两组数的范围是否有冲突
        public static bool checkconflict(int num1, int num2, int num3, int num4)
        {
            for(int i=num1; i<=num2; i++)
                if (i == num3 || i == num4)
                    return true;
            return false;

        }
        //学生选课
        public static bool stuselectcourse(string sno, string cno, string tclassid)
        {
            //判断冲突
            List<List<string>> lists = dbHelper.ExcuteQuiry("select * from selectclass_View1 where cno='" + cno + "' and tclassid='" + tclassid + "'");
            List<string> list = lists[0];
            List<List<string>> coursing = Takeclass.takeclassinfo(sno);
            bool result = true;
            bool result1 = false;
            int startweek = Convert.ToInt32(list[7]), endweek = Convert.ToInt32(list[8]);
            int starttime = Convert.ToInt32(list[5]), endtime = Convert.ToInt32(list[6]);
            int whichday = Convert.ToInt32(list[4]);
            foreach (List<string> list2 in coursing)
            {
                if (checkconflict(startweek, endweek, Convert.ToInt32(list2[1]), Convert.ToInt32(list2[2])))
                {
                    if (whichday == Convert.ToInt32(list2[6]))
                        if (checkconflict(starttime, endtime, Convert.ToInt32(list2[4]), Convert.ToInt32(list2[5])))
                            result = false;
                }
            }
            if(result)
                result1 = dbHelper.ExcuteUpdate("insert into takeclass values ('" + sno + "','" + cno + "','" + tclassid + "',NULL,'在修','否',NULL)");
            return result1;
        }
        //学生退课
        public static bool studropcourse(string sno, string cno, string tclassid)
        {

            return dbHelper.ExcuteUpdate("delete from takeclass where sno='" + sno + "' and cno='" + cno + "' and tclassid='" + tclassid+"'");
        }
        //通过教学班名字查找课程号,教学班号
        public static List<string> findcno_tclassid(string tclassname)
        {
            List<List<string>> lists = dbHelper.ExcuteQuiry("select cno,tclassid from selectclass_View1 where tclassname='"+tclassname+"'");
            return lists[0];
        }
    }
}