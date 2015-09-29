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
        public static bool RegisterStudent(string studentName, int grade, int age, int contactNumber, int username)
        {
            int status = StudentDAL.CreateStudent(studentName, grade, age, contactNumber, username);
            return status == 1;
        }

        public static DataTable LoadStudent()
        {
            DataTable dt = StudentDAL.LoadStudent();
            return dt;
        }

        public static DataTable LoadStudent(string StudentName)
        {
            DataTable dt = StudentDAL.LoadStudent(StudentName);
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

        public static int MakePayment(int studentID, float payableAmt, DateTime date, int StaffId, string remark)
        {
            int result = StudentDAL.MakePayment(studentID, payableAmt, date, StaffId, remark);
            return result;
        }

        public static DataTable GetLatePaymentByMonth()
        {
            DateTime date = DateTime.Now.AddMonths(-3);
            DataTable dt = StudentDAL.GetLatePaymentByMonth(date);
            return dt;
        }
    }
}
