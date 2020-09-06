namespace RadioStation
{
    partial class GetDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetDataForm));
            this.btSave = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbFName = new System.Windows.Forms.Label();
            this.LbPos = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.mtbName = new System.Windows.Forms.MaskedTextBox();
            this.mtbFName = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSave.Location = new System.Drawing.Point(155, 244);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(117, 39);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Добавить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(155, 126);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(249, 31);
            this.cbPosition.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(100, 57);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 23);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Имя:";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.Location = new System.Drawing.Point(99, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(247, 25);
            this.lbInfo.TabIndex = 3;
            this.lbInfo.Text = "Добавление сотрудника";
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFName.Location = new System.Drawing.Point(55, 93);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(94, 23);
            this.lbFName.TabIndex = 5;
            this.lbFName.Text = "Фамилия:";
            // 
            // LbPos
            // 
            this.LbPos.AutoSize = true;
            this.LbPos.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbPos.Location = new System.Drawing.Point(37, 129);
            this.LbPos.Name = "LbPos";
            this.LbPos.Size = new System.Drawing.Size(112, 23);
            this.LbPos.TabIndex = 7;
            this.LbPos.Text = "Должность:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYear.Location = new System.Drawing.Point(12, 166);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(137, 23);
            this.lbYear.TabIndex = 8;
            this.lbYear.Text = "Год рождения:";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSalary.Location = new System.Drawing.Point(53, 202);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(96, 23);
            this.lbSalary.TabIndex = 9;
            this.lbSalary.Text = "Зарплата:";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(287, 244);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(117, 39);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // numSalary
            // 
            this.numSalary.DecimalPlaces = 2;
            this.numSalary.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSalary.Location = new System.Drawing.Point(155, 199);
            this.numSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(249, 30);
            this.numSalary.TabIndex = 13;
            this.numSalary.ThousandsSeparator = true;
            // 
            // numYear
            // 
            this.numYear.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numYear.Location = new System.Drawing.Point(155, 163);
            this.numYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(249, 30);
            this.numYear.TabIndex = 14;
            this.numYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // mtbName
            // 
            this.mtbName.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbName.Location = new System.Drawing.Point(155, 54);
            this.mtbName.Mask = " >L<LLLLLLLLLLLLLL";
            this.mtbName.Name = "mtbName";
            this.mtbName.Size = new System.Drawing.Size(249, 30);
            this.mtbName.TabIndex = 15;
            // 
            // mtbFName
            // 
            this.mtbFName.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbFName.Location = new System.Drawing.Point(155, 90);
            this.mtbFName.Mask = " >L<LLLLLLLLLLLLLLLLL";
            this.mtbFName.Name = "mtbFName";
            this.mtbFName.Size = new System.Drawing.Size(249, 30);
            this.mtbFName.TabIndex = 16;
            // 
            // GetDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 295);
            this.ControlBox = false;
            this.Controls.Add(this.mtbFName);
            this.Controls.Add(this.mtbName);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.numSalary);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.LbPos);
            this.Controls.Add(this.lbFName);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.GetDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.Label LbPos;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.MaskedTextBox mtbName;
        private System.Windows.Forms.MaskedTextBox mtbFName;
    }
}