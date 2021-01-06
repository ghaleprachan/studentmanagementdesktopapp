namespace StudentInformationSystem
{
    partial class StudentForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.DateReg = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.DGStudent = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboSort = new System.Windows.Forms.ComboBox();
            this.DGReport = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.RBAsc = new System.Windows.Forms.RadioButton();
            this.RBDesc = new System.Windows.Forms.RadioButton();
            this.PanelReport = new System.Windows.Forms.Panel();
            this.PanelInputForm = new System.Windows.Forms.Panel();
            this.PanelDataGrid = new System.Windows.Forms.Panel();
            this.ChartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DGStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGReport)).BeginInit();
            this.PanelReport.SuspendLayout();
            this.PanelInputForm.SuspendLayout();
            this.PanelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(137, 12);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(209, 22);
            this.TxtFirstName.TabIndex = 1;
            // 
            // DateReg
            // 
            this.DateReg.CustomFormat = "dd/MM/yyyy";
            this.DateReg.Location = new System.Drawing.Point(137, 241);
            this.DateReg.Margin = new System.Windows.Forms.Padding(4);
            this.DateReg.Name = "DateReg";
            this.DateReg.Size = new System.Drawing.Size(209, 22);
            this.DateReg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Regiistration date";
            // 
            // ComboCourse
            // 
            this.ComboCourse.FormattingEnabled = true;
            this.ComboCourse.Items.AddRange(new object[] {
            "Computing",
            "Multimedia",
            "Networking"});
            this.ComboCourse.Location = new System.Drawing.Point(137, 208);
            this.ComboCourse.Margin = new System.Windows.Forms.Padding(4);
            this.ComboCourse.Name = "ComboCourse";
            this.ComboCourse.Size = new System.Drawing.Size(209, 24);
            this.ComboCourse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(248, 281);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(100, 28);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // DGStudent
            // 
            this.DGStudent.AllowUserToAddRows = false;
            this.DGStudent.AllowUserToDeleteRows = false;
            this.DGStudent.AllowUserToResizeColumns = false;
            this.DGStudent.AllowUserToResizeRows = false;
            this.DGStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGStudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGStudent.Location = new System.Drawing.Point(13, 12);
            this.DGStudent.Margin = new System.Windows.Forms.Padding(4);
            this.DGStudent.MultiSelect = false;
            this.DGStudent.Name = "DGStudent";
            this.DGStudent.RowHeadersWidth = 51;
            this.DGStudent.Size = new System.Drawing.Size(765, 254);
            this.DGStudent.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // ComboSort
            // 
            this.ComboSort.FormattingEnabled = true;
            this.ComboSort.Items.AddRange(new object[] {
            "First Name",
            "Registration Date"});
            this.ComboSort.Location = new System.Drawing.Point(512, 283);
            this.ComboSort.Margin = new System.Windows.Forms.Padding(4);
            this.ComboSort.Name = "ComboSort";
            this.ComboSort.Size = new System.Drawing.Size(265, 24);
            this.ComboSort.TabIndex = 3;
            // 
            // DGReport
            // 
            this.DGReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGReport.Location = new System.Drawing.Point(13, 14);
            this.DGReport.Margin = new System.Windows.Forms.Padding(4);
            this.DGReport.Name = "DGReport";
            this.DGReport.RowHeadersWidth = 51;
            this.DGReport.Size = new System.Drawing.Size(511, 272);
            this.DGReport.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Name";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(137, 47);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(209, 22);
            this.TxtLastName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(137, 79);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(209, 22);
            this.TxtAddress.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(137, 111);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(209, 22);
            this.TxtEmail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Contact No";
            // 
            // TxtContact
            // 
            this.TxtContact.Location = new System.Drawing.Point(137, 143);
            this.TxtContact.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(209, 22);
            this.TxtContact.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status";
            // 
            // ComboStatus
            // 
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "Processing",
            "Enrolled",
            "Rejected"});
            this.ComboStatus.Location = new System.Drawing.Point(137, 175);
            this.ComboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(209, 24);
            this.ComboStatus.TabIndex = 3;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(9, 281);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(100, 28);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 287);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sort By";
            // 
            // RBAsc
            // 
            this.RBAsc.AutoSize = true;
            this.RBAsc.Location = new System.Drawing.Point(121, 284);
            this.RBAsc.Margin = new System.Windows.Forms.Padding(4);
            this.RBAsc.Name = "RBAsc";
            this.RBAsc.Size = new System.Drawing.Size(95, 21);
            this.RBAsc.TabIndex = 10;
            this.RBAsc.TabStop = true;
            this.RBAsc.Text = "Ascending";
            this.RBAsc.UseVisualStyleBackColor = true;
            // 
            // RBDesc
            // 
            this.RBDesc.AutoSize = true;
            this.RBDesc.Location = new System.Drawing.Point(221, 284);
            this.RBDesc.Margin = new System.Windows.Forms.Padding(4);
            this.RBDesc.Name = "RBDesc";
            this.RBDesc.Size = new System.Drawing.Size(104, 21);
            this.RBDesc.TabIndex = 10;
            this.RBDesc.TabStop = true;
            this.RBDesc.Text = "Descending";
            this.RBDesc.UseVisualStyleBackColor = true;
            // 
            // PanelReport
            // 
            this.PanelReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelReport.Controls.Add(this.ChartReport);
            this.PanelReport.Controls.Add(this.DGReport);
            this.PanelReport.Location = new System.Drawing.Point(16, 340);
            this.PanelReport.Margin = new System.Windows.Forms.Padding(4);
            this.PanelReport.Name = "PanelReport";
            this.PanelReport.Size = new System.Drawing.Size(1162, 300);
            this.PanelReport.TabIndex = 11;
            // 
            // PanelInputForm
            // 
            this.PanelInputForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInputForm.Controls.Add(this.label1);
            this.PanelInputForm.Controls.Add(this.label2);
            this.PanelInputForm.Controls.Add(this.label4);
            this.PanelInputForm.Controls.Add(this.label3);
            this.PanelInputForm.Controls.Add(this.label5);
            this.PanelInputForm.Controls.Add(this.label8);
            this.PanelInputForm.Controls.Add(this.TxtFirstName);
            this.PanelInputForm.Controls.Add(this.BtnClear);
            this.PanelInputForm.Controls.Add(this.label6);
            this.PanelInputForm.Controls.Add(this.BtnSubmit);
            this.PanelInputForm.Controls.Add(this.TxtLastName);
            this.PanelInputForm.Controls.Add(this.label7);
            this.PanelInputForm.Controls.Add(this.ComboStatus);
            this.PanelInputForm.Controls.Add(this.TxtAddress);
            this.PanelInputForm.Controls.Add(this.ComboCourse);
            this.PanelInputForm.Controls.Add(this.TxtEmail);
            this.PanelInputForm.Controls.Add(this.DateReg);
            this.PanelInputForm.Controls.Add(this.TxtContact);
            this.PanelInputForm.Location = new System.Drawing.Point(16, 12);
            this.PanelInputForm.Margin = new System.Windows.Forms.Padding(4);
            this.PanelInputForm.Name = "PanelInputForm";
            this.PanelInputForm.Size = new System.Drawing.Size(362, 317);
            this.PanelInputForm.TabIndex = 12;
            // 
            // PanelDataGrid
            // 
            this.PanelDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDataGrid.Controls.Add(this.DGStudent);
            this.PanelDataGrid.Controls.Add(this.ComboSort);
            this.PanelDataGrid.Controls.Add(this.button1);
            this.PanelDataGrid.Controls.Add(this.RBDesc);
            this.PanelDataGrid.Controls.Add(this.label9);
            this.PanelDataGrid.Controls.Add(this.RBAsc);
            this.PanelDataGrid.Location = new System.Drawing.Point(387, 12);
            this.PanelDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDataGrid.Name = "PanelDataGrid";
            this.PanelDataGrid.Size = new System.Drawing.Size(791, 317);
            this.PanelDataGrid.TabIndex = 13;
            // 
            // ChartReport
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartReport.Legends.Add(legend1);
            this.ChartReport.Location = new System.Drawing.Point(541, 14);
            this.ChartReport.Margin = new System.Windows.Forms.Padding(4);
            this.ChartReport.Name = "ChartReport";
            this.ChartReport.Size = new System.Drawing.Size(608, 272);
            this.ChartReport.TabIndex = 8;
            this.ChartReport.Text = "Report Chart";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 652);
            this.Controls.Add(this.PanelDataGrid);
            this.Controls.Add(this.PanelInputForm);
            this.Controls.Add(this.PanelReport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGReport)).EndInit();
            this.PanelReport.ResumeLayout(false);
            this.PanelInputForm.ResumeLayout(false);
            this.PanelInputForm.PerformLayout();
            this.PanelDataGrid.ResumeLayout(false);
            this.PanelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.DateTimePicker DateReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.DataGridView DGStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboSort;
        private System.Windows.Forms.DataGridView DGReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton RBAsc;
        private System.Windows.Forms.RadioButton RBDesc;
        private System.Windows.Forms.Panel PanelReport;
        private System.Windows.Forms.Panel PanelInputForm;
        private System.Windows.Forms.Panel PanelDataGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReport;
    }
}

