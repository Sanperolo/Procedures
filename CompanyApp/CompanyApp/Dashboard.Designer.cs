namespace CompanyApp
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentEmployeesList = new System.Windows.Forms.ListBox();
            this.departmentIdText = new System.Windows.Forms.TextBox();
            this.departmentIdLabel = new System.Windows.Forms.Label();
            this.getDepartmentByIdBtn = new System.Windows.Forms.Button();
            this.getAllDepartmentsBtn = new System.Windows.Forms.Button();
            this.deleteDepartmentBtn = new System.Windows.Forms.Button();
            this.managerLabel = new System.Windows.Forms.Label();
            this.managerText = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.departmentText = new System.Windows.Forms.TextBox();
            this.editDepartmentBtn = new System.Windows.Forms.Button();
            this.addDepartmentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmentEmployeesList
            // 
            this.departmentEmployeesList.FormattingEnabled = true;
            this.departmentEmployeesList.ItemHeight = 30;
            this.departmentEmployeesList.Location = new System.Drawing.Point(47, 102);
            this.departmentEmployeesList.Name = "departmentEmployeesList";
            this.departmentEmployeesList.Size = new System.Drawing.Size(646, 484);
            this.departmentEmployeesList.TabIndex = 0;
            this.departmentEmployeesList.SelectedIndexChanged += new System.EventHandler(this.departmentEmployeesList_SelectedIndexChanged);
            // 
            // departmentIdText
            // 
            this.departmentIdText.Location = new System.Drawing.Point(185, 42);
            this.departmentIdText.Name = "departmentIdText";
            this.departmentIdText.Size = new System.Drawing.Size(110, 37);
            this.departmentIdText.TabIndex = 1;
            this.departmentIdText.TextChanged += new System.EventHandler(this.departmentIdText_TextChanged);
            // 
            // departmentIdLabel
            // 
            this.departmentIdLabel.AutoSize = true;
            this.departmentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentIdLabel.Location = new System.Drawing.Point(42, 54);
            this.departmentIdLabel.Name = "departmentIdLabel";
            this.departmentIdLabel.Size = new System.Drawing.Size(137, 25);
            this.departmentIdLabel.TabIndex = 2;
            this.departmentIdLabel.Text = "Department ID";
            this.departmentIdLabel.Click += new System.EventHandler(this.departmentIdLabel_Click);
            // 
            // getDepartmentByIdBtn
            // 
            this.getDepartmentByIdBtn.AccessibleName = "";
            this.getDepartmentByIdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDepartmentByIdBtn.Location = new System.Drawing.Point(301, 34);
            this.getDepartmentByIdBtn.Name = "getDepartmentByIdBtn";
            this.getDepartmentByIdBtn.Size = new System.Drawing.Size(157, 45);
            this.getDepartmentByIdBtn.TabIndex = 3;
            this.getDepartmentByIdBtn.Text = "Get Department ";
            this.getDepartmentByIdBtn.UseVisualStyleBackColor = true;
            this.getDepartmentByIdBtn.Click += new System.EventHandler(this.getDepartmentByIdBtn_Click);
            // 
            // getAllDepartmentsBtn
            // 
            this.getAllDepartmentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllDepartmentsBtn.Location = new System.Drawing.Point(495, 34);
            this.getAllDepartmentsBtn.Name = "getAllDepartmentsBtn";
            this.getAllDepartmentsBtn.Size = new System.Drawing.Size(198, 45);
            this.getAllDepartmentsBtn.TabIndex = 5;
            this.getAllDepartmentsBtn.Text = "Get All Departments ";
            this.getAllDepartmentsBtn.UseVisualStyleBackColor = true;
            this.getAllDepartmentsBtn.Click += new System.EventHandler(this.getAllDepartmentsBtn_Click);
            // 
            // deleteDepartmentBtn
            // 
            this.deleteDepartmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDepartmentBtn.Location = new System.Drawing.Point(536, 592);
            this.deleteDepartmentBtn.Name = "deleteDepartmentBtn";
            this.deleteDepartmentBtn.Size = new System.Drawing.Size(157, 45);
            this.deleteDepartmentBtn.TabIndex = 6;
            this.deleteDepartmentBtn.Text = "DELETE";
            this.deleteDepartmentBtn.UseVisualStyleBackColor = true;
            this.deleteDepartmentBtn.Click += new System.EventHandler(this.deleteDepartmentBtn_Click);
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLabel.Location = new System.Drawing.Point(698, 163);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(90, 25);
            this.managerLabel.TabIndex = 8;
            this.managerLabel.Text = "Manager";
            this.managerLabel.Click += new System.EventHandler(this.managerLabel_Click);
            // 
            // managerText
            // 
            this.managerText.Location = new System.Drawing.Point(841, 155);
            this.managerText.Name = "managerText";
            this.managerText.Size = new System.Drawing.Size(84, 37);
            this.managerText.TabIndex = 7;
            this.managerText.TextChanged += new System.EventHandler(this.managerText_TextChanged);
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.Location = new System.Drawing.Point(698, 110);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(113, 25);
            this.departmentLabel.TabIndex = 10;
            this.departmentLabel.Text = "Department";
            this.departmentLabel.Click += new System.EventHandler(this.departmentLabel_Click);
            // 
            // departmentText
            // 
            this.departmentText.Location = new System.Drawing.Point(841, 102);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(84, 37);
            this.departmentText.TabIndex = 9;
            this.departmentText.TextChanged += new System.EventHandler(this.departmentText_TextChanged);
            // 
            // editDepartmentBtn
            // 
            this.editDepartmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDepartmentBtn.Location = new System.Drawing.Point(1094, 127);
            this.editDepartmentBtn.Name = "editDepartmentBtn";
            this.editDepartmentBtn.Size = new System.Drawing.Size(157, 45);
            this.editDepartmentBtn.TabIndex = 11;
            this.editDepartmentBtn.Text = "EDIT";
            this.editDepartmentBtn.UseVisualStyleBackColor = true;
            this.editDepartmentBtn.Click += new System.EventHandler(this.editDepartmentBtn_Click);
            // 
            // addDepartmentBtn
            // 
            this.addDepartmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentBtn.Location = new System.Drawing.Point(931, 127);
            this.addDepartmentBtn.Name = "addDepartmentBtn";
            this.addDepartmentBtn.Size = new System.Drawing.Size(157, 45);
            this.addDepartmentBtn.TabIndex = 12;
            this.addDepartmentBtn.Text = "ADD";
            this.addDepartmentBtn.UseVisualStyleBackColor = true;
            this.addDepartmentBtn.Click += new System.EventHandler(this.addDepartmentBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.addDepartmentBtn);
            this.Controls.Add(this.editDepartmentBtn);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.departmentText);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.managerText);
            this.Controls.Add(this.deleteDepartmentBtn);
            this.Controls.Add(this.getAllDepartmentsBtn);
            this.Controls.Add(this.getDepartmentByIdBtn);
            this.Controls.Add(this.departmentIdLabel);
            this.Controls.Add(this.departmentIdText);
            this.Controls.Add(this.departmentEmployeesList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "CompanyAppWindow";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox departmentEmployeesList;
        private System.Windows.Forms.TextBox departmentIdText;
        private System.Windows.Forms.Label departmentIdLabel;
        private System.Windows.Forms.Button getDepartmentByIdBtn;
        private System.Windows.Forms.Button getAllDepartmentsBtn;
        private System.Windows.Forms.Button deleteDepartmentBtn;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.TextBox managerText;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox departmentText;
        private System.Windows.Forms.Button editDepartmentBtn;
        private System.Windows.Forms.Button addDepartmentBtn;
    }
}

