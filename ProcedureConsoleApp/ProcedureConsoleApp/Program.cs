using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

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

                try
                {
                    i = int.Parse(System.Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            {
                                System.Console.WriteLine("MIAU 1");
                                break;
                            }
                        case 2:
                            {
                                System.Console.WriteLine("MIAU 2");
                                break;
                            }
                        case 3:
                            {
                                System.Console.WriteLine("MIAU 3");
                                break;
                            }
                        case 4:
                            {
                                System.Console.WriteLine("MIAU 4");
                                break;
                            }
                        case 5:
                            {
                                System.Console.WriteLine("MIAU 5");
                                break;
                            }
                        case 6:
                            {
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
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("UPS... YOU DIDN´T PRESS THE CORRECT NUMBER, RIGHT?");
                }
            }
            Console.ReadKey();
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
    }
}
