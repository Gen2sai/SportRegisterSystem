using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymnasticRegister.DataAccessLayer;

namespace GymnasticRegister.BusinessLogicLayer
{
    internal class StudentBLL
    {
        public static bool RegisterStudent(string studentName, int grade, int age, int contactNumber, string username)
        {
            int status = StudentDAL.CreateStudent(studentName, grade, age, contactNumber, username);
            return status == 1;
        }

        public static DataTable LoadStudent()
        {
            DataTable dt = StudentDAL.LoadStudent();
            return dt;
        }

        public static DataTable GetStudentInfo(string studentName)
        {
            DataTable dt = StudentDAL.GetStudentInfo(studentName);
            return dt;
        }

        public static List<string> GetStudentName(DataTable dt)
        {
            List<string> studentNameList = (from DataRow row in dt.Rows select row.Field<string>(1)).ToList();
            return studentNameList;
        }
    }
}
