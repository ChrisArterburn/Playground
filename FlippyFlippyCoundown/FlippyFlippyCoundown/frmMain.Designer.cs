namespace FlippyFlippyCoundown
{
    partial class frmMain
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
            lstItems = new ListBox();
            menuStrip1 = new MenuStrip();
            mnuAdd = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.Dock = DockStyle.Fill;
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 30;
            lstItems.Location = new Point(0, 38);
            lstItems.Margin = new Padding(5, 6, 5, 6);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(1371, 862);
            lstItems.TabIndex = 0;
            lstItems.DoubleClick += lstItems_DoubleClick;
            lstItems.KeyUp += frmMain_KeyUp;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAdd, mnuDelete });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1371, 38);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(69, 34);
            mnuAdd.Text = "Add";
            mnuAdd.Click += mnuAdd_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(91, 34);
            mnuDelete.Text = "Delete";
            mnuDelete.Click += mnuDelete_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(lstItems);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmMain";
            Text = "Flippy Flippy Countdown";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            KeyUp += frmMain_KeyUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstItems;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuDelete;
    }
}