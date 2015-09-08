using System;
using System.Data.SqlClient;
using GymnasticRegister.Helper;

namespace GymnasticRegister.DataAccessLayer
{
    class StudentDAL
    {
        public static int CreateStudent(string studentName, int grade, int age, int contactNumber, string username)
        {
            try
            {
                int status;
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd =
                new SqlCommand(
                    "IF(NOT EXISTS(SELECT StudentID FROM Student WHERE StudentName = @studentName AND GradeID = @grade AND Age = @age)) BEGIN INSERT INTO STUDENT (StudentName, GradeID, Age, ContactNumber, CreatedBy) VALUES (@studentName, @grade, @age, @contactNumber, @username) END",
                    conn);
                cmd.Parameters.AddWithValue("@studentName", studentName);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();
                status = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return 0;
            }
        }
    }
}
