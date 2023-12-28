using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcademicSystem.App_Code
{
    public class Exam
    {
        public static List<string> getexaminfo(string sno)
        {
            List<List<string>> lists = dbHelper.ExcuteQuiryWithNoIndex("select * from exam_View1 where sno='"+sno+"' and examdate is not NULL");
            List<string> result = new List<string>();
            foreach(List<string> list in lists)
            {
                //学年-学期
                string str = list[0] + "-" + list[1] + "-";
                //课程名
                str += list[2] + "-";
                //日期 时间
                str += list[3] + "(" + list[4] + "-" + list[5] + ")-";
                //教室
                str += list[6] + "-" + list[7];
                result.Add(str);
            }
            return result;
        }
    }
}