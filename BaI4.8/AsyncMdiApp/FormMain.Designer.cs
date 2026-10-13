namespace AsyncMdiApp
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuCatalog = new ToolStripMenuItem();
            mnuStudent = new ToolStripMenuItem();
            mnuProduct = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblMessage = new ToolStripStatusLabel();
            pbStatus = new ToolStripProgressBar();
            lblPercent = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuCatalog });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuExit });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(70, 20);
            mnuSystem.Text = "&Hệ thống";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(100, 22);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuCatalog
            // 
            mnuCatalog.DropDownItems.AddRange(new ToolStripItem[] { mnuStudent, mnuProduct });
            mnuCatalog.Name = "mnuCatalog";
            mnuCatalog.Size = new Size(70, 20);
            mnuCatalog.Text = "&Danh mục";
            // 
            // mnuStudent
            // 
            mnuStudent.Name = "mnuStudent";
            mnuStudent.Size = new Size(180, 22);
            mnuStudent.Text = "Quản lý Sinh viên";
            mnuStudent.Click += mnuStudent_Click;
            // 
            // mnuProduct
            // 
            mnuProduct.Name = "mnuProduct";
            mnuProduct.Size = new Size(180, 22);
            mnuProduct.Text = "Quản lý Sản phẩm";
            mnuProduct.Click += mnuProduct_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblMessage, pbStatus, lblPercent });
            statusStrip1.Location = new Point(0, 628);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblMessage
            // 
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(786, 17);
            lblMessage.Spring = true;
            lblMessage.Text = "Sẵn sàng.";
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbStatus
            // 
            pbStatus.Name = "pbStatus";
            pbStatus.Size = new Size(150, 16);
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = false;
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(45, 17);
            lblPercent.Text = "0%";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng MDI - Nạp dữ liệu bất đồng bộ";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuSystem;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuCatalog;
        private ToolStripMenuItem mnuStudent;
        private ToolStripMenuItem mnuProduct;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblMessage;
        private ToolStripProgressBar pbStatus;
        private ToolStripStatusLabel lblPercent;
    }
}
