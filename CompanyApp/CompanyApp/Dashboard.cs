using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyApp
{
    public partial class Dashboard : Form
    {
        DataAccess db = new DataAccess();
        List<Department> departments = new List<Department>();

        public Dashboard()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            departmentEmployeesList.DataSource = departments;
            departmentEmployeesList.DisplayMember = "DepartmentEmployeeCount";

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void departmentEmployeesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
                
        private void departmentIdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void departmentIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void getDepartmentByIdBtn_Click(object sender, EventArgs e)
        {
            departments = db.getDepartment(departmentIdText.Text);

            displayData();

        }
        
        private void getAllDepartmentsBtn_Click(object sender, EventArgs e)
        {
            departments = db.getAllDepartments();

            displayData();
        }

        private void deleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            int index = departmentEmployeesList.SelectedIndex;
            db.deleteDepartment(departments[index].DNumber);

        }
        
        private void managerText_TextChanged(object sender, EventArgs e)
        {

        }

        private void managerLabel_Click(object sender, EventArgs e)
        {

        }

        private void editDepartmentBtn_Click(object sender, EventArgs e)
        {
            db.updateDepartment(departmentText.Text, int.Parse(departmentIdText.Text));

        }

        private void departmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {
            db.createDepartment(departmentIdText.Text, int.Parse(managerText.Text));
        }

        private void departmentText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
