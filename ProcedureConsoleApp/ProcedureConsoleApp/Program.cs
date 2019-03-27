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
                                try{
                                    SqlCommand cmd = new SqlCommand("usp_UpdateDepartmentName", Conection.conectionDB);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.ExecuteReader();
                                    System.Console.WriteLine("MIAU 2");
                                }
                                catch(SqlException ex){
                                    Console.WriteLine("The name that you put is using right now by other Dept.");
                                }
                                break;
                            }
                        case 3:
                            {
                                UpdateDManager();
                                System.Console.WriteLine("MIAU 3");
                                break;
                            }
                        case 4:
                            {
                                DeleteDepartment();
                                System.Console.WriteLine("MIAU 4");
                                break;
                            }
                        case 5:
                            {
                                GetDepartment();
                                System.Console.WriteLine("MIAU 5");
                                break;
                            }
                        case 6:
                            {
                                GetAll();
                                System.Console.WriteLine("MIAU 6");
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
           // try
           // {
                SqlCommand cmd = new SqlCommand("usp_CreateDepartment", Conection.conectionDB);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@DName";
                param1.Value = "NEW DEPARTMENT";
                param1.SqlDbType = SqlDbType.NVarChar;
                param1.Size = 50;
                cmd.Parameters.Add(param1);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@MgrSSN";
                param2.Value = "123456879";
                param2.SqlDbType = SqlDbType.Int;
                param2.Size = 9;
                cmd.Parameters.Add(param2);
                cmd.ExecuteNonQuery();
                System.Console.WriteLine("MIAU 1");
            //}
            /*catch (SqlException ex)
            {
                Console.WriteLine("The name that you put is using right now by other Dept.");
            }*/
        }

        private static void UpdateDManager()//DDBBConection Conection)
        {
            SqlCommand cmd = new SqlCommand("usp_CreateDepartment", Conection.conectionDB);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@DName";
            param1.Value = "NEW DEPARTMENT";
            param1.SqlDbType = SqlDbType.NVarChar;
            param1.Size = 50;
            cmd.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@MgrSSN";
            param2.Value = "123456879";
            param2.SqlDbType = SqlDbType.Int;
            param2.Size = 9;
            cmd.Parameters.Add(param2);
            cmd.ExecuteNonQuery();
        }

        private static void DeleteDepartment(DDBBConection Conection)
        {
            SqlCommand cmd = new SqlCommand("usp_CreateDepartment", Conection.conectionDB);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@DName";
            param1.Value = "NEW DEPARTMENT";
            param1.SqlDbType = SqlDbType.NVarChar;
            param1.Size = 50;
            cmd.Parameters.Add(param1);
            
            cmd.ExecuteNonQuery();
        }

        private static void GetDepartment(DDBBConection Conection)
        {
            SqlCommand cmd = new SqlCommand("usp_CreateDepartment", Conection.conectionDB);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@DName";
            param1.Value = "NEW DEPARTMENT";
            param1.SqlDbType = SqlDbType.NVarChar;
            param1.Size = 50;
            cmd.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@MgrSSN";
            param2.Value = "123456879";
            param2.SqlDbType = SqlDbType.Int;
            param2.Size = 9;
            cmd.Parameters.Add(param2);
            cmd.ExecuteNonQuery();
        }

        private static void GetAll(DDBBConection Conection)
        {

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
