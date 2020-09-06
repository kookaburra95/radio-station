namespace RadioStation
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalaryReport = new System.Windows.Forms.Button();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.btDeleteEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chIsFiltered = new System.Windows.Forms.CheckBox();
            this.cbFilterPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 62);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(942, 562);
            this.dataGridView.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btSalaryReport);
            this.panel1.Controls.Add(this.btAddEmployee);
            this.panel1.Controls.Add(this.btDeleteEmployee);
            this.panel1.Location = new System.Drawing.Point(948, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 562);
            this.panel1.TabIndex = 5;
            // 
            // btSalaryReport
            // 
            this.btSalaryReport.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSalaryReport.Location = new System.Drawing.Point(12, 126);
            this.btSalaryReport.Name = "btSalaryReport";
            this.btSalaryReport.Size = new System.Drawing.Size(198, 57);
            this.btSalaryReport.TabIndex = 4;
            this.btSalaryReport.Text = "Отчёт по средней зарплате";
            this.btSalaryReport.UseVisualStyleBackColor = true;
            this.btSalaryReport.Click += new System.EventHandler(this.btSalaryReport_Click);
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddEmployee.Location = new System.Drawing.Point(12, 0);
            this.btAddEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(198, 57);
            this.btAddEmployee.TabIndex = 2;
            this.btAddEmployee.Text = "Добавить сотрудника";
            this.btAddEmployee.UseVisualStyleBackColor = true;
            this.btAddEmployee.Click += new System.EventHandler(this.BtAddEmployee_Click);
            // 
            // btDeleteEmployee
            // 
            this.btDeleteEmployee.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDeleteEmployee.Location = new System.Drawing.Point(12, 63);
            this.btDeleteEmployee.Name = "btDeleteEmployee";
            this.btDeleteEmployee.Size = new System.Drawing.Size(198, 57);
            this.btDeleteEmployee.TabIndex = 3;
            this.btDeleteEmployee.Text = "Удалить сотрудника";
            this.btDeleteEmployee.UseVisualStyleBackColor = true;
            this.btDeleteEmployee.Click += new System.EventHandler(this.BtDeleteEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chIsFiltered);
            this.panel2.Controls.Add(this.cbFilterPosition);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 50);
            this.panel2.TabIndex = 6;
            // 
            // chIsFiltered
            // 
            this.chIsFiltered.AutoSize = true;
            this.chIsFiltered.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chIsFiltered.Location = new System.Drawing.Point(3, 3);
            this.chIsFiltered.Name = "chIsFiltered";
            this.chIsFiltered.Size = new System.Drawing.Size(125, 27);
            this.chIsFiltered.TabIndex = 4;
            this.chIsFiltered.Text = "Фильтр по:";
            this.chIsFiltered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chIsFiltered.UseVisualStyleBackColor = true;
            this.chIsFiltered.CheckedChanged += new System.EventHandler(this.СhIsFiltered_CheckedChanged);
            // 
            // cbFilterPosition
            // 
            this.cbFilterPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterPosition.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFilterPosition.Location = new System.Drawing.Point(134, 0);
            this.cbFilterPosition.Name = "cbFilterPosition";
            this.cbFilterPosition.Size = new System.Drawing.Size(271, 31);
            this.cbFilterPosition.TabIndex = 3;
            this.cbFilterPosition.SelectionChangeCommitted += new System.EventHandler(this.СbFilterPosition_SelectionChangeCommitted);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSalaryReport;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.Button btDeleteEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbFilterPosition;
        private System.Windows.Forms.CheckBox chIsFiltered;
    }
}

