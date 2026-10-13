namespace AsyncMdiApp
{
    partial class FormStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTop = new Panel();
            btnLoad = new Button();
            chkSimulateError = new CheckBox();
            progressBar = new ProgressBar();
            lblPercent = new Label();
            dgvStudents = new DataGridView();
            colStudentId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnLoad);
            pnlTop.Controls.Add(chkSimulateError);
            pnlTop.Controls.Add(progressBar);
            pnlTop.Controls.Add(lblPercent);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(700, 55);
            pnlTop.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(130, 32);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Nạp dữ liệu";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // chkSimulateError
            // 
            chkSimulateError.AutoSize = true;
            chkSimulateError.Location = new Point(155, 18);
            chkSimulateError.Name = "chkSimulateError";
            chkSimulateError.Size = new Size(92, 19);
            chkSimulateError.TabIndex = 1;
            chkSimulateError.Text = "Giả lập lỗi";
            chkSimulateError.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(265, 17);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(375, 22);
            progressBar.TabIndex = 2;
            // 
            // lblPercent
            // 
            lblPercent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(650, 21);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(23, 15);
            lblPercent.TabIndex = 3;
            lblPercent.Text = "0%";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = SystemColors.Window;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colStudentId, colFullName, colAge, colGender });
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(0, 55);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(700, 345);
            dgvStudents.TabIndex = 0;
            // 
            // colStudentId
            // 
            colStudentId.DataPropertyName = "StudentId";
            colStudentId.FillWeight = 20F;
            colStudentId.HeaderText = "Mã SV";
            colStudentId.MinimumWidth = 60;
            colStudentId.Name = "colStudentId";
            colStudentId.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.FillWeight = 45F;
            colFullName.HeaderText = "Họ tên";
            colFullName.MinimumWidth = 60;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colAge
            // 
            colAge.DataPropertyName = "Age";
            colAge.FillWeight = 12F;
            colAge.HeaderText = "Tuổi";
            colAge.MinimumWidth = 60;
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.FillWeight = 18F;
            colGender.HeaderText = "Giới tính";
            colGender.MinimumWidth = 60;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(dgvStudents);
            Controls.Add(pnlTop);
            MinimumSize = new Size(500, 300);
            Name = "FormStudent";
            Text = "Quản lý Sinh viên";
            FormClosing += FormStudent_FormClosing;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnLoad;
        private CheckBox chkSimulateError;
        private ProgressBar progressBar;
        private Label lblPercent;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colStudentId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colGender;
    }
}
