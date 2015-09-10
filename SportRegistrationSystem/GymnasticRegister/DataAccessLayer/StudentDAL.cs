using System;
using System.Data;
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
                    "IF(NOT EXISTS(SELECT StudentID FROM Student WHERE StudentName = @studentName AND GradeID = @grade AND Age = @age)) BEGIN INSERT INTO STUDENT (StudentName, GradeID, Age, ContactNumber, CreatedBy) VALUES (@studentName, @grade, @age, @contactNumber, (SELECT StaffID from Staff WHERE Username = @username)) END",
                    conn);
                cmd.Parameters.AddWithValue("@studentName", studentName);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();
                status = cmd.ExecuteNonQuery();
                conn.Close();

                return status;
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return 0;
            }
        }

        public static DataTable LoadStudent()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cmd =
                    new SqlCommand(
                        "SELECT StudentID, StudentName, GradeName, Age,ContactNumber, Username FROM Student AS a INNER JOIN Staff AS b ON a.CreatedBy = b.StaffID INNER JOIN GradeLevel AS c ON a.GradeID = c.GradeID",
                        conn);

                conn.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return null;
            }
        }
    }
}
