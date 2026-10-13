namespace MdiManager
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            sepSystem = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuCatalog = new ToolStripMenuItem();
            mnuStudent = new ToolStripMenuItem();
            mnuProduct = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            sepWindow = new ToolStripSeparator();
            mnuRefresh = new ToolStripMenuItem();
            mnuCloseAll = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbStudent = new ToolStripButton();
            tsbProduct = new ToolStripButton();
            tsSep1 = new ToolStripSeparator();
            tsbCascade = new ToolStripButton();
            tsbTileHorizontal = new ToolStripButton();
            tsbTileVertical = new ToolStripButton();
            tsSep2 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            tsbLogout = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblMessage = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            ctxMain = new ContextMenuStrip(components);
            ctxCascade = new ToolStripMenuItem();
            ctxTileHorizontal = new ToolStripMenuItem();
            ctxTileVertical = new ToolStripMenuItem();
            ctxSep = new ToolStripSeparator();
            ctxCloseAll = new ToolStripMenuItem();
            timerClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ctxMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuCatalog, mnuWindow });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = mnuWindow;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, sepSystem, mnuExit });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(70, 20);
            mnuSystem.Text = "&Hệ thống";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(160, 22);
            mnuLogout.Text = "Đăng xuất";
            mnuLogout.Click += mnuLogout_Click;
            // 
            // sepSystem
            // 
            sepSystem.Name = "sepSystem";
            sepSystem.Size = new Size(157, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.ShortcutKeys = Keys.Control | Keys.Q;
            mnuExit.Size = new Size(160, 22);
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
            mnuStudent.ShortcutKeys = Keys.Control | Keys.D1;
            mnuStudent.Size = new Size(210, 22);
            mnuStudent.Text = "Quản lý Sinh viên";
            mnuStudent.Click += mnuStudent_Click;
            // 
            // mnuProduct
            // 
            mnuProduct.Name = "mnuProduct";
            mnuProduct.ShortcutKeys = Keys.Control | Keys.D2;
            mnuProduct.Size = new Size(210, 22);
            mnuProduct.Text = "Quản lý Sản phẩm";
            mnuProduct.Click += mnuProduct_Click;
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical, sepWindow, mnuRefresh, mnuCloseAll });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(63, 20);
            mnuWindow.Text = "&Cửa sổ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(260, 22);
            mnuCascade.Text = "Cascade";
            mnuCascade.Click += mnuCascade_Click;
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(260, 22);
            mnuTileHorizontal.Text = "Tile Horizontal";
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(260, 22);
            mnuTileVertical.Text = "Tile Vertical";
            mnuTileVertical.Click += mnuTileVertical_Click;
            // 
            // sepWindow
            // 
            sepWindow.Name = "sepWindow";
            sepWindow.Size = new Size(257, 6);
            // 
            // mnuRefresh
            // 
            mnuRefresh.Name = "mnuRefresh";
            mnuRefresh.ShortcutKeys = Keys.F5;
            mnuRefresh.Size = new Size(260, 22);
            mnuRefresh.Text = "Làm mới cửa sổ hiện hành";
            mnuRefresh.Click += mnuRefresh_Click;
            // 
            // mnuCloseAll
            // 
            mnuCloseAll.Name = "mnuCloseAll";
            mnuCloseAll.Size = new Size(260, 22);
            mnuCloseAll.Text = "Đóng tất cả";
            mnuCloseAll.Click += mnuCloseAll_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbStudent, tsbProduct, tsSep1, tsbCascade, tsbTileHorizontal, tsbTileVertical, tsSep2, tsbRefresh, tsbLogout });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1100, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbStudent
            // 
            tsbStudent.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbStudent.Name = "tsbStudent";
            tsbStudent.Size = new Size(80, 22);
            tsbStudent.Text = "🎓 Sinh viên";
            tsbStudent.ToolTipText = "Quản lý Sinh viên (Ctrl+1)";
            tsbStudent.Click += mnuStudent_Click;
            // 
            // tsbProduct
            // 
            tsbProduct.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbProduct.Name = "tsbProduct";
            tsbProduct.Size = new Size(80, 22);
            tsbProduct.Text = "📦 Sản phẩm";
            tsbProduct.ToolTipText = "Quản lý Sản phẩm (Ctrl+2)";
            tsbProduct.Click += mnuProduct_Click;
            // 
            // tsSep1
            // 
            tsSep1.Name = "tsSep1";
            tsSep1.Size = new Size(6, 25);
            // 
            // tsbCascade
            // 
            tsbCascade.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbCascade.Name = "tsbCascade";
            tsbCascade.Size = new Size(70, 22);
            tsbCascade.Text = "🗗 Cascade";
            tsbCascade.ToolTipText = "Xếp chồng các cửa sổ";
            tsbCascade.Click += mnuCascade_Click;
            // 
            // tsbTileHorizontal
            // 
            tsbTileHorizontal.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbTileHorizontal.Name = "tsbTileHorizontal";
            tsbTileHorizontal.Size = new Size(80, 22);
            tsbTileHorizontal.Text = "▤ Ngang";
            tsbTileHorizontal.ToolTipText = "Tile Horizontal";
            tsbTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // tsbTileVertical
            // 
            tsbTileVertical.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbTileVertical.Name = "tsbTileVertical";
            tsbTileVertical.Size = new Size(70, 22);
            tsbTileVertical.Text = "▥ Dọc";
            tsbTileVertical.ToolTipText = "Tile Vertical";
            tsbTileVertical.Click += mnuTileVertical_Click;
            // 
            // tsSep2
            // 
            tsSep2.Name = "tsSep2";
            tsSep2.Size = new Size(6, 25);
            // 
            // tsbRefresh
            // 
            tsbRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(70, 22);
            tsbRefresh.Text = "⟳ Làm mới";
            tsbRefresh.ToolTipText = "Làm mới cửa sổ hiện hành (F5)";
            tsbRefresh.Click += mnuRefresh_Click;
            // 
            // tsbLogout
            // 
            tsbLogout.Alignment = ToolStripItemAlignment.Right;
            tsbLogout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbLogout.Name = "tsbLogout";
            tsbLogout.Size = new Size(80, 22);
            tsbLogout.Text = "⏻ Đăng xuất";
            tsbLogout.ToolTipText = "Đăng xuất";
            tsbLogout.Click += mnuLogout_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUser, lblMessage, lblClock });
            statusStrip1.Location = new Point(0, 628);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1100, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(120, 17);
            lblUser.Text = "Người dùng: ";
            // 
            // lblMessage
            // 
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(836, 17);
            lblMessage.Spring = true;
            lblMessage.Text = "Sẵn sàng.";
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClock
            // 
            lblClock.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(129, 17);
            lblClock.Text = "dd/MM/yyyy HH:mm:ss";
            // 
            // ctxMain
            // 
            ctxMain.Items.AddRange(new ToolStripItem[] { ctxCascade, ctxTileHorizontal, ctxTileVertical, ctxSep, ctxCloseAll });
            ctxMain.Name = "ctxMain";
            ctxMain.Size = new Size(181, 98);
            // 
            // ctxCascade
            // 
            ctxCascade.Name = "ctxCascade";
            ctxCascade.Size = new Size(180, 22);
            ctxCascade.Text = "Cascade";
            ctxCascade.Click += mnuCascade_Click;
            // 
            // ctxTileHorizontal
            // 
            ctxTileHorizontal.Name = "ctxTileHorizontal";
            ctxTileHorizontal.Size = new Size(180, 22);
            ctxTileHorizontal.Text = "Tile Horizontal";
            ctxTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // ctxTileVertical
            // 
            ctxTileVertical.Name = "ctxTileVertical";
            ctxTileVertical.Size = new Size(180, 22);
            ctxTileVertical.Text = "Tile Vertical";
            ctxTileVertical.Click += mnuTileVertical_Click;
            // 
            // ctxSep
            // 
            ctxSep.Name = "ctxSep";
            ctxSep.Size = new Size(177, 6);
            // 
            // ctxCloseAll
            // 
            ctxCloseAll.Name = "ctxCloseAll";
            ctxCloseAll.Size = new Size(180, 22);
            ctxCloseAll.Text = "Đóng tất cả";
            ctxCloseAll.Click += mnuCloseAll_Click;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 650);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(900, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý (MDI)";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ctxMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuSystem;
        private ToolStripMenuItem mnuLogout;
        private ToolStripSeparator sepSystem;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuCatalog;
        private ToolStripMenuItem mnuStudent;
        private ToolStripMenuItem mnuProduct;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private ToolStripSeparator sepWindow;
        private ToolStripMenuItem mnuRefresh;
        private ToolStripMenuItem mnuCloseAll;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbStudent;
        private ToolStripButton tsbProduct;
        private ToolStripSeparator tsSep1;
        private ToolStripButton tsbCascade;
        private ToolStripButton tsbTileHorizontal;
        private ToolStripButton tsbTileVertical;
        private ToolStripSeparator tsSep2;
        private ToolStripButton tsbRefresh;
        private ToolStripButton tsbLogout;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblMessage;
        private ToolStripStatusLabel lblClock;
        private ContextMenuStrip ctxMain;
        private ToolStripMenuItem ctxCascade;
        private ToolStripMenuItem ctxTileHorizontal;
        private ToolStripMenuItem ctxTileVertical;
        private ToolStripSeparator ctxSep;
        private ToolStripMenuItem ctxCloseAll;
        private System.Windows.Forms.Timer timerClock;
    }
}
