using System;
using System.Data;
using System.Data.SqlClient;
using GymnasticRegister.Helper;

namespace GymnasticRegister.DataAccessLayer
{
    internal class StudentDAL
    {
        public static int CreateStudent(string studentName, int grade, int age, int contactNumber, int StaffId)
        {
            try
            {
                int status;
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd =
                    new SqlCommand(
                        "IF(NOT EXISTS(SELECT StudentID FROM Student WHERE StudentName = @studentName AND GradeID = @grade AND Age = @age)) BEGIN INSERT INTO STUDENT (StudentName, GradeID, Age, ContactNumber, CreatedBy) VALUES (@studentName, @grade, @age, @contactNumber, @staffId) END",
                        conn);
                cmd.Parameters.AddWithValue("@studentName", studentName);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@staffId", StaffId);

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
                        "SELECT StudentID, StudentName, GradeName, Age, ContactNumber, Username FROM Student AS a INNER JOIN Staff AS b ON a.CreatedBy = b.StaffID INNER JOIN GradeLevel AS c ON a.GradeID = c.GradeID",
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

        public static DataTable GetStudentInfo(string studentName)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cmd = new SqlCommand("SELECT s.StudentID, s.StudentName, g.GradeName, s.Age, p.PaymentDate FROM Student AS s Left JOIN Payment AS p ON p.StudentID = s.StudentID INNER JOIN GradeLevel AS g ON s.GradeID = g.GradeID WHERE StudentName = @studentName ORDER BY p.PaymentDate DESC", conn);
                cmd.Parameters.AddWithValue("@studentName", studentName);

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

        public static int MakePayment(int studentID, float payableAmt, DateTime date, int StaffId, string remark)
        {
            try
            {
                int result;
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd = new SqlCommand("INSERT INTO Payment (StudentID, PaidAmount, PaymentDate, ReceivedBy, Remark) VALUES (@studentID, @payableAmt, @date, @StaffID, @remark)", conn);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@payableAmt", payableAmt);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@StaffID", StaffId);
                cmd.Parameters.AddWithValue("@remark", remark);

                conn.Open();
                result = cmd.ExecuteNonQuery();
                conn.Close();

                return result;
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
                return 0;
            }
        }

        public static DataTable GetLatePaymentByMonth(DateTime date)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DateTime endDate = DateTime.Now.AddMonths(-1);

                cmd = new SqlCommand("SELECT s.StudentID, s.StudentName, p.PaymentDate FROM Student AS s INNER JOIN Payment AS p ON s.StudentID = p.StudentID  WHERE s.StudentID NOT in (SELECT DISTINCT s.StudentID FROM Payment AS p INNER JOIN Student AS s ON s.StudentID = p.StudentID WHERE p.PaymentDate <= Convert(date, @endDate) AND PaymentDate >= Convert(date, @startDate))ORDER BY p.PaymentDate DESC", conn);
                cmd.Parameters.AddWithValue("@startDate", date.Date);
                cmd.Parameters.AddWithValue("@endDate", endDate.Date);

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
