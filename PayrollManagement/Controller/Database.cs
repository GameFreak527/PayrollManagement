using PayrollManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PayrollManagement.Controller
{
    public static class Database
    {
        static SqlConnection con;

        // Database Queries still to create and due for the iteration 2

        static Database()
        {
            con = new SqlConnection("Conenction String");
        }
        public static int insertIntoTable(Employee parameters)
        {
           
            return 1;
        }

        public static int updateTable(int employeeId, String password)
        {
            return 1;
        }

        public static int authenticateUser(int employeeId, String password)
        {
            return 1;
        }

        public static void insertHours(int employeeId, String clockInTime, String clockOutTime)
        {
            return;
        }

    }
}