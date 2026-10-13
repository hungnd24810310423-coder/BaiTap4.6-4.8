namespace StudentManager
{
    partial class FrmStudentManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            pnlLeft = new Panel();
            pnlButtons = new Panel();
            tlpButtons = new TableLayoutPanel();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExportCsv = new Button();
            grpInfo = new GroupBox();
            lblStudentId = new Label();
            lblFullName = new Label();
            lblAge = new Label();
            lblGender = new Label();
            txtStudentId = new TextBox();
            txtFullName = new TextBox();
            txtAge = new TextBox();
            cboGender = new ComboBox();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            pnlRight = new Panel();
            dgvStudents = new DataGridView();
            colStudentId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colAvatarPath = new DataGridViewTextBoxColumn();
            errorProvider = new ErrorProvider(components);
            statusStrip1.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlButtons.SuspendLayout();
            tlpButtons.SuspendLayout();
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 528);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(120, 17);
            lblStatus.Text = "Tổng số sinh viên: 0";
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(pnlButtons);
            pnlLeft.Controls.Add(grpInfo);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(10);
            pnlLeft.Size = new Size(360, 528);
            pnlLeft.TabIndex = 0;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(tlpButtons);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(10, 400);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(340, 118);
            pnlButtons.TabIndex = 1;
            // 
            // tlpButtons
            // 
            tlpButtons.ColumnCount = 2;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtons.Controls.Add(btnAdd, 0, 0);
            tlpButtons.Controls.Add(btnDelete, 1, 0);
            tlpButtons.Controls.Add(btnUpdate, 0, 1);
            tlpButtons.Controls.Add(btnExportCsv, 1, 1);
            tlpButtons.Dock = DockStyle.Top;
            tlpButtons.Location = new Point(0, 0);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 2;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpButtons.Size = new Size(340, 100);
            tlpButtons.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 44);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(173, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 44);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.Location = new Point(3, 53);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(164, 44);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Dock = DockStyle.Fill;
            btnExportCsv.Location = new Point(173, 53);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(164, 44);
            btnExportCsv.TabIndex = 3;
            btnExportCsv.Text = "Xuất file CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblStudentId);
            grpInfo.Controls.Add(lblFullName);
            grpInfo.Controls.Add(lblAge);
            grpInfo.Controls.Add(lblGender);
            grpInfo.Controls.Add(txtStudentId);
            grpInfo.Controls.Add(txtFullName);
            grpInfo.Controls.Add(txtAge);
            grpInfo.Controls.Add(cboGender);
            grpInfo.Controls.Add(picAvatar);
            grpInfo.Controls.Add(btnChooseImage);
            grpInfo.Dock = DockStyle.Top;
            grpInfo.Location = new Point(10, 10);
            grpInfo.Name = "grpInfo";
            grpInfo.Padding = new Padding(10);
            grpInfo.Size = new Size(340, 390);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin sinh viên";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(15, 33);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(41, 15);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã SV";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(15, 68);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(43, 15);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ tên";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(15, 103);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(30, 15);
            lblAge.TabIndex = 4;
            lblAge.Text = "Tuổi";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(15, 138);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 15);
            lblGender.TabIndex = 6;
            lblGender.Text = "Giới tính";
            // 
            // txtStudentId
            // 
            txtStudentId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentId.Location = new Point(90, 30);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(235, 23);
            txtStudentId.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.Location = new Point(90, 65);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(235, 23);
            txtFullName.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAge.Location = new Point(90, 100);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(235, 23);
            txtAge.TabIndex = 5;
            // 
            // cboGender
            // 
            cboGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new Point(90, 135);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(235, 23);
            cboGender.TabIndex = 7;
            // 
            // picAvatar
            // 
            picAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(15, 175);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(310, 160);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnChooseImage.Location = new Point(15, 345);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(310, 32);
            btnChooseImage.TabIndex = 9;
            btnChooseImage.Text = "Chọn ảnh...";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(dgvStudents);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(360, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(0, 10, 10, 10);
            pnlRight.Size = new Size(624, 528);
            pnlRight.TabIndex = 1;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = SystemColors.Window;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colStudentId, colFullName, colAge, colGender, colAvatarPath });
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(0, 10);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(614, 508);
            dgvStudents.TabIndex = 0;
            // 
            // colStudentId
            // 
            colStudentId.DataPropertyName = "StudentId";
            colStudentId.FillWeight = 15F;
            colStudentId.HeaderText = "Mã SV";
            colStudentId.MinimumWidth = 70;
            colStudentId.Name = "colStudentId";
            colStudentId.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.FillWeight = 35F;
            colFullName.HeaderText = "Họ tên";
            colFullName.MinimumWidth = 120;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colAge
            // 
            colAge.DataPropertyName = "Age";
            colAge.FillWeight = 10F;
            colAge.HeaderText = "Tuổi";
            colAge.MinimumWidth = 50;
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.FillWeight = 12F;
            colGender.HeaderText = "Giới tính";
            colGender.MinimumWidth = 70;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            // 
            // colAvatarPath
            // 
            colAvatarPath.DataPropertyName = "AvatarPath";
            colAvatarPath.FillWeight = 35F;
            colAvatarPath.HeaderText = "Đường dẫn ảnh";
            colAvatarPath.MinimumWidth = 100;
            colAvatarPath.Name = "colAvatarPath";
            colAvatarPath.ReadOnly = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmStudentManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 550);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(900, 520);
            Name = "FrmStudentManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Sinh viên";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            tlpButtons.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Panel pnlLeft;
        private Panel pnlButtons;
        private TableLayoutPanel tlpButtons;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExportCsv;
        private GroupBox grpInfo;
        private Label lblStudentId;
        private Label lblFullName;
        private Label lblAge;
        private Label lblGender;
        private TextBox txtStudentId;
        private TextBox txtFullName;
        private TextBox txtAge;
        private ComboBox cboGender;
        private PictureBox picAvatar;
        private Button btnChooseImage;
        private Panel pnlRight;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colStudentId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colAvatarPath;
        private ErrorProvider errorProvider;
    }
}
