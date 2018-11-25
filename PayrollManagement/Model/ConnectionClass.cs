using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConnectionClass
/// </summary>
public static class ConnectionClass
{
    private static SqlConnection cn;
    private static SqlCommand cmd;


    static ConnectionClass()
    {

        cn = new SqlConnection(@"Data Source=LAPTOP-47BNNCUR\COMP229_SQL;Initial Catalog=Software_ProjectDB;Integrated Security=True");
    }



    public static List<PaystubInfo> FindShifts(int Employee_ID)
    {
        string start = "";
        string end = "";
        List<PaystubInfo> listOfShifts = new List<PaystubInfo>();
        string query = string.Format(@"SELECT LogInDate, LogOutTime FROM HoursWorked WHERE EmployeeID={0}", Employee_ID);
        cmd = new SqlCommand(query, cn);
        try
        {
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    start = reader["LogInDate"].ToString();
                    end = reader["LogOutTime"].ToString();

                    DateTime startDate = Convert.ToDateTime(start);
                    DateTime endDate = Convert.ToDateTime(end);

                    PaystubInfo tempStub = new PaystubInfo(startDate, endDate, 15.00);

                    listOfShifts.Add(tempStub);
                }



                reader.Close();


                return listOfShifts;
            }
            else
            {
                reader.Close();
                return null;
            }

        }
        finally
        {
            cn.Close();
        }
    } //end of class



    public static double FindCurrentPayRate(int ID)
    {
        double value = 0;
        string query = string.Format(@" Select hourlyPayRate from Employee where EmployeeID = {0}", ID);
        cmd = new SqlCommand(query, cn);

        try
        {
            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    value = Convert.ToDouble(reader.GetDecimal(0));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
        }
        catch (Exception e)
        {
        }


        finally
        {
            cn.Close();
        }

        return value;
    }  //end Of Class





    public static Employee GetEmployeeInfo(int Employee_ID)
    {
        int id = 0;
        string firstName = "";
        string lastName = "";
        string social = "";
        string pay = "";

        List<PaystubInfo> listOfShifts = new List<PaystubInfo>();
        string query = string.Format(@"SELECT EmployeeID, FirstName, LastName, Social_Security_Num, hourlyPayRate FROM Employee WHERE EmployeeID={0}", Employee_ID);
        cmd = new SqlCommand(query, cn);
        try
        {
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = (int)reader["EmployeeID"];
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                    pay = reader["hourlyPayRate"].ToString();
                    social = reader["Social_Security_Num"].ToString();
                }

                Employee employee = new Employee(firstName, lastName, 14, "", 0, "");
                employee.SocialNumber = Convert.ToInt32(social);
                employee.PayRate = Convert.ToDouble(pay);

                reader.Close();


                return employee;
            }
            else
            {
                reader.Close();
                return null;
            }

        }
        finally
        {
            cn.Close();
        }
    } //end of class




    public static int FindPrimaryKeyValue(string table)
    {
        int value = 0;
        string query = string.Format(@"Select Count(*) from {0}", table);
        cmd = new SqlCommand(query, cn);

        try
        {
            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    value = reader.GetInt32(0);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
        }


        finally
        {
            cn.Close();
        }

        return value;
    }
}