using System;
using System.Data;
using System.Data.SqlClient;
using GymnasticRegister.Helper;

namespace GymnasticRegister.DataAccessLayer
{
    internal class StudentDAL
    {
        public static int CreateStudent(string studentName, int grade, DateTime DOB, int Gender, int contactNumber, int StaffId)
        {
            try
            {
                int status;
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd =
                    new SqlCommand(
                        "IF(NOT EXISTS(SELECT StudentID FROM Student WHERE StudentName = @studentName AND GradeID = @grade AND DOB = @dob AND Gender = @gender)) BEGIN INSERT INTO STUDENT (StudentName, GradeID, DOB, Gender, ContactNumber, CreatedBy) VALUES (@studentName, @grade, @dob, @gender, @contactNumber, @staffId) END",
                        conn);
                cmd.Parameters.AddWithValue("@studentName", studentName);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@gender", Gender);
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
                        "SELECT StudentID, StudentName, GradeName, DOB, DATEDIFF(yy, DOB, GETDATE()) as Age, ContactNumber, Username FROM Student AS a INNER JOIN Staff AS b ON a.CreatedBy = b.StaffID INNER JOIN GradeLevel AS c ON a.GradeID = c.GradeID",
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

        public static DataTable LoadStudent(string StudentName)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                cmd =
                    new SqlCommand(
                        "SELECT StudentID, StudentName, GradeName, DATEDIFF(yy, DOB, GETDATE()) as Age, ContactNumber, Username FROM Student AS a INNER JOIN Staff AS b ON a.CreatedBy = b.StaffID INNER JOIN GradeLevel AS c ON a.GradeID = c.GradeID WHERE StudentName = @studentName",
                        conn);
                cmd.Parameters.AddWithValue("@studentName", StudentName);

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

                cmd = new SqlCommand("SELECT s.StudentID, s.StudentName, g.GradeName, DATEDIFF(yy, DOB, GETDATE()) as Age, p.PaymentDate FROM Student AS s Left JOIN Payment AS p ON p.StudentID = s.StudentID INNER JOIN GradeLevel AS g ON s.GradeID = g.GradeID WHERE StudentName = @studentName ORDER BY p.PaymentDate DESC", conn);
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
                DateTime receivedate = new DateTime();
                receivedate = DateTime.Now;

                int result;
                SqlConnection conn = new SqlConnection(ConnectionConfig.GetConnectionString());
                SqlCommand cmd;

                cmd = new SqlCommand("INSERT INTO Payment (StudentID, PaidAmount, PaymentDate, ReceivedDate, ReceivedBy, Remark) VALUES (@studentID, @payableAmt, @date, @receivedDate, @StaffID, @remark)", conn);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@payableAmt", payableAmt);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@receivedDate", receivedate);
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
                DateTime endDate = DateTime.Now;

                //month/day/year
                string tempDate = endDate.Month + "/" + "01" + "/" + endDate.Year;
                endDate = DateTime.ParseExact(tempDate, "M/dd/yyyy", null);

                string tempDate1 = date.Month + "/" + "01" + "/" + date.Year;
                date = DateTime.ParseExact(tempDate1, "M/dd/yyyy", null);

                cmd = new SqlCommand("SELECT * FROM Student WHERE StudentID in (SELECT DISTINCT p.StudentID FROM Payment AS p INNER JOIN Student AS s ON s.StudentID = p.StudentID WHERE p.PaymentDate < Convert(date, @endDate) AND PaymentDate >= Convert(date, @startDate)) AND StudentID NOT IN (SELECT DISTINCT StudentID FROM Payment WHERE PaymentDate = Convert(date, @endDate))", conn);

                cmd.Parameters.AddWithValue("@startDate", date);
                cmd.Parameters.AddWithValue("@endDate", endDate);

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
