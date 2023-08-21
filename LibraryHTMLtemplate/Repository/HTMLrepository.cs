using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryHTMLtemplate.model;
using Dapper;
using System.Data.SqlClient;


namespace LibraryHTMLtemplate.Repository
{
    public class HTMLrepository
    {
        public readonly string connectionstring;
        public HTMLrepository()
        {
            connectionstring = @"Data source=DESKTOP-531QTCP;Initial catalog=Employee;User Id=sa;Password=Anaiyaan@123";
        }
        public void Insertsp(HTMLmodels emp)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionstring);

                con.Open();
                con.Execute($"  exec insertstaff '{emp.name}','{emp.phonenumber}','{emp.emailaddress}','{emp.massage}");
                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}    
