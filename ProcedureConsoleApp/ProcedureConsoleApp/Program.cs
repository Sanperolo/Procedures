using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace ProcedureConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DDBBConection Conection = new DDBBConection();
            Conection.open();
            int i;
            bool loop = true;
           
            while (loop)
            {
                Console.WriteLine("┌───────────────────────────────┐");
                Console.WriteLine("| Select your favourite option: |");
                Console.WriteLine("| 1. CreateDepartment           |");
                Console.WriteLine("| 2. UpdateDepartmentName       |");
                Console.WriteLine("| 3. UpdateDepartmentManager    |");
                Console.WriteLine("| 4. DeleteDepartment           |");
                Console.WriteLine("| 5. GetDepartment              |");
                Console.WriteLine("| 6. GetAllDepartments          |");
                Console.WriteLine("| 7. EXIT                       |");
                Console.WriteLine("└───────────────────────────────┘");
                Console.Write("├───> ");

               /* try
                {*/
                    i = int.Parse(System.Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            {
                                CreateDepartment(Conection);
                                break;
                            }
                        case 2:
                            {
                                UpdateDName(Conection);
                                break;
                        }
                        case 3:
                            {
                                UpdateDManager(Conection);
                                break;
                            }
                        case 4:
                            {
                                DeleteDepartment(Conection);
                                break;
                            }
                        case 5:
                            {
                                GetDepartment(Conection);
                                break;
                            }
                        case 6:
                            {
                                GetAll(Conection);
                                break;
                            }
                        case 7:
                            {
                                System.Console.WriteLine("See you ...... (^_^)");
                                loop = false;
                                break;
                            }
                    }
                //}
                /*catch(Exception e)
                {
                    System.Console.WriteLine("UPS... YOU DIDN´T PRESS THE CORRECT NUMBER, RIGHT?");
                }*/
            }
            Conection.close();
            Console.ReadKey();
        }

        private static void CreateDepartment(DDBBConection Conection)
        {
            SqlCommand cmd = new SqlCommand("usp_CreateDepartment", Conection.conectionDB);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@DName";
            param1.Value = "NEW DEPARTMENT";
            param1.SqlDbType = SqlDbType.NVarChar;
            param1.Size = 50;
            cmd.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@MgrSSN", 188665555);
            cmd.Parameters.Add(param2);
            cmd.ExecuteNonQuery();
        }

        private static void UpdateDName(DDBBConection Conection)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateDepartmentName", Conection.conectionDB);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@DName";
            param1.Value = "Update DEPARTMENT";
            param1.SqlDbType = SqlDbType.NVarChar;
            param1.Size = 50;
            cmd.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@DNumber";
            param2.Value = "6";
            param2.SqlDbType = SqlDbType.Int;
            param2.Size = 4;
            cmd.Parameters.Add(param2);
            cmd.ExecuteNonQuery();
        }

        private static void UpdateDManager(DDBBConection Conection)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateDepartmentManager", Conection.conectionDB);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@DNumber";
            param1.Value = "6";
            param1.SqlDbType = SqlDbType.NVarChar;
            param1.Size = 4;
            cmd.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@MgrSSN";
            param2.Value = "188665551";
            param2.SqlDbType = SqlDbType.Int;
            param2.Size = 9;
            cmd.Parameters.Add(param2);
            cmd.ExecuteNonQuery();
        }

        private static void DeleteDepartment(DDBBConection Conection)
        {
            SqlCommand cmd = new SqlCommand("usp_DeleteDepartment", Conection.conectionDB);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@DNumber";
            param1.Value = "6";
            param1.SqlDbType = SqlDbType.Int;
            param1.Size = 4;
            cmd.Parameters.Add(param1);
            
            cmd.ExecuteNonQuery();
        }

        private static void GetDepartment(DDBBConection Conection)
        {
            SqlCommand cmd = new SqlCommand("usp_GetDepartment", Conection.conectionDB);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@DNumber";
            param1.Value = "99";
            param1.SqlDbType = SqlDbType.Int;
            param1.Size = 4;
            cmd.Parameters.Add(param1);
            
            cmd.ExecuteReader();
        }

        private static void GetAll(DDBBConection Conection)
        {
            SqlCommand cmd = new SqlCommand("usp_GetAllDepartments", Conection.conectionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            SqlParameter return_Name = new SqlParameter("@RETURN_Name", SqlDbType.NVarChar);
            return_Name.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(return_Name);
            int i = 0;
            while (reader.Read())
            {
                Console.WriteLine(reader.ToString());
            }
            reader.Close();
        }
    }

    class DDBBConection
    {
        string key = "Data Source = SANPEROLO; Initial Catalog = Company; Integrated Security = True ";
        public SqlConnection conectionDB = new SqlConnection();

        public DDBBConection()
        {
            conectionDB.ConnectionString = key;
        }

        public void open()
        {
            try
            {
                conectionDB.Open();
                Console.WriteLine("Conection Sucsesfully!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something goes wrong Conection!"+ex.Message);
            }
        }

        public void close()
        {
            try
            {
                conectionDB.Close();
                Console.WriteLine("Conection Closed, Bye!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something goes wrong Conection!"+ex.Message);
            }
        }
    }
}
