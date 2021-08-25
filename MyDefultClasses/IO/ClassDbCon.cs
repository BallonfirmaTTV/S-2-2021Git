using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace IO
{
    public class ClassDbCon
    {

        private string _connectionString;

        protected SqlConnection con;

        private SqlCommand _command;

        public ClassDbCon()
        {
            _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=FamilyDB;Trusted_Connection=True;";

            con = new SqlConnection(_connectionString);
        }

        public ClassDbCon(string inConnectionString)
        {
            _connectionString = inConnectionString;

            con = new SqlConnection(_connectionString);
        }

        protected void SetCon(String inConnectionString)        
        {
            _connectionString = inConnectionString;

            con = new SqlConnection(_connectionString);
        }

        protected void OpenDB()
        {
            try
            {
                if (this.con != null && con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                else
                {
                    if (con.State == ConnectionState.Open)
                    {
                        CloseDB();

                        OpenDB();
                    }
                    else
                    {
                        con = new SqlConnection(_connectionString);

                        OpenDB();
                    }
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        protected void CloseDB() 
        {
            try
            {
                con.Close();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        protected int ExecuteNonQuery(string sqlQuery)
        {
            int res = 0;

            _command = new SqlCommand(sqlQuery,con);

            try
            {
                OpenDB();

                res = _command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally 
            {
                CloseDB();
            }


            return res;

        }

        protected DataTable DbReturnDataTable(string sqlQuery)
        {
            DataTable dtRes = new DataTable();

            try
            {
                OpenDB();

                using (_command = new SqlCommand(sqlQuery,con))
                {
                    using (var adapter = new SqlDataAdapter(_command))
                    {
                        adapter.Fill(dtRes);
                    }
                }
            }
            catch (SqlException ex)
            { 
                throw ex;
            }
            finally
            {
                CloseDB();
            }

            return dtRes;
        }

        protected string DbReturnString(string sqlQuery)
        {
            string res = "";

            bool foundOne = false;

            try
            {
                OpenDB();

                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        res = reader.GetString(0);

                        foundOne = true;
                    }
                    if (!foundOne)
                    {
                        res = "No data found!";
                    }
                }
            }
            catch (SqlException ex)
            { 
                throw ex;
            }
            finally 
            {
                CloseDB();
            }

            return res;
        }

        protected DataTable MakeCallToStoredProcedure(SqlCommand inCommand) 
        {
            DataTable dtRes = new DataTable();

            try
            {
                OpenDB();

                using (SqlDataAdapter adapter = new SqlDataAdapter(inCommand))
                {
                    adapter.Fill(dtRes);
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                CloseDB();
            }

            return dtRes;
        }

    }
}
