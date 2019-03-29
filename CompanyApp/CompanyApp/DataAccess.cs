using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace CompanyApp
{
    class DataAccess
    {
        public List<Department> getDepartment(string depNum)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CxnString("CompanyDB")))
            {
                var output = connection.Query<Department>($"dbo.usp_GetDepartment @DNumber", new { DNumber = depNum }).ToList();

                return output;
            }
        }
        public List<Department> getAllDepartments()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CxnString("CompanyDB")))
            {
                var output = connection.Query<Department>($"dbo.usp_GetAllDepartments").ToList();

                return output;
            }
        }

        public void updateDepartment(string name, int depNum)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CxnString("CompanyDB")))
            {
                connection.Query<Department>($"dbo.usp_UpdateDepartmentName @DName, @DNumber", new { DName = name, DNumber = depNum });

            }
        }

        public void createDepartment(string name, int Manager)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CxnString("CompanyDB")))
            {
                connection.Query<Department>($"dbo.usp_CreateDepartment @DName, @MgrSSN", new { DName = name, MgrSSN = Manager });
            }
        }
        public void deleteDepartment(int depNum)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CxnString("CompanyDB")))
            {
                connection.Query<Department>($"dbo.usp_DeleteDepartment @departmentNum", new { departmentNum = depNum });
            }
        }

    }
}
