namespace StudentsRecord
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtRoll = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            cmbGender = new ComboBox();
            dtpBirthday = new DateTimePicker();
            dataGridView1 = new DataGridView();
            clmRoll = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            btnView = new Button();
            btnClose = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 140);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 7;
            label1.Text = "Student Roll";
            // 
            // txtRoll
            // 
            txtRoll.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoll.Location = new Point(44, 166);
            txtRoll.Name = "txtRoll";
            txtRoll.Size = new Size(317, 30);
            txtRoll.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(44, 229);
            txtName.Name = "txtName";
            txtName.Size = new Size(317, 30);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 203);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(209, 271);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 10;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 271);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 9;
            label4.Text = "Gender";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(44, 363);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(317, 30);
            txtEmail.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(44, 337);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(44, 296);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(146, 31);
            cmbGender.TabIndex = 3;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(209, 297);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(152, 30);
            dtpBirthday.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmRoll, clmName, clmEmail });
            dataGridView1.Location = new Point(395, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(654, 350);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // 
            // clmRoll
            // 
            clmRoll.DataPropertyName = "stu_roll";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            clmRoll.DefaultCellStyle = dataGridViewCellStyle2;
            clmRoll.HeaderText = "Roll";
            clmRoll.MinimumWidth = 6;
            clmRoll.Name = "clmRoll";
            clmRoll.ReadOnly = true;
            clmRoll.Resizable = DataGridViewTriState.False;
            clmRoll.Width = 80;
            // 
            // clmName
            // 
            clmName.DataPropertyName = "stu_name";
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            clmName.Resizable = DataGridViewTriState.False;
            clmName.Width = 260;
            // 
            // clmEmail
            // 
            clmEmail.DataPropertyName = "stu_email";
            clmEmail.HeaderText = "Email";
            clmEmail.MinimumWidth = 6;
            clmEmail.Name = "clmEmail";
            clmEmail.ReadOnly = true;
            clmEmail.Resizable = DataGridViewTriState.False;
            clmEmail.Width = 260;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.InactiveCaption;
            btnView.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.Location = new Point(230, 483);
            btnView.Name = "btnView";
            btnView.Size = new Size(133, 33);
            btnView.TabIndex = 12;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click_1;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.InactiveCaption;
            btnClose.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(955, 522);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 33);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.InactiveCaption;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(230, 444);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.InactiveCaption;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(44, 483);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 33);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.InactiveCaption;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(44, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 33);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(577, 129);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(325, 30);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.InactiveCaption;
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(908, 127);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 33);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(265, 9);
            label5.Name = "label5";
            label5.Size = new Size(523, 45);
            label5.TabIndex = 19;
            label5.Text = "Student Information Record Booth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(395, 130);
            label7.Name = "label7";
            label7.Size = new Size(176, 25);
            label7.TabIndex = 20;
            label7.Text = "Student Record List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1097, 615);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(btnView);
            Controls.Add(dataGridView1);
            Controls.Add(dtpBirthday);
            Controls.Add(cmbGender);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtRoll);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox txtRoll;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label6;
        private ComboBox cmbGender;
        private DateTimePicker dtpBirthday;
        private DataGridView dataGridView1;
        private Button btnView;
        private Button btnClose;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridViewTextBoxColumn clmRoll;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmEmail;
        private Label label5;
        private Label label7;
    }
}