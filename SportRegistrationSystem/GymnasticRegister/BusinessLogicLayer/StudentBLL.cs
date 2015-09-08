using System;
using System.Collections.Generic;
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
    }
}
