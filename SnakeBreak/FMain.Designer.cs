namespace SnakeBreak
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this._msMain = new System.Windows.Forms.MenuStrip();
            this._tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiShowRankings = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiExtras = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiOptioins = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiLine = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._pnlSnake = new System.Windows.Forms.Panel();
            this._msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _msMain
            // 
            this._msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiMenu,
            this._tsmiExtras});
            this._msMain.Location = new System.Drawing.Point(0, 0);
            this._msMain.Name = "_msMain";
            this._msMain.Size = new System.Drawing.Size(429, 24);
            this._msMain.TabIndex = 0;
            this._msMain.Text = "menuStrip1";
            // 
            // _tsmiMenu
            // 
            this._tsmiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiShowRankings});
            this._tsmiMenu.Name = "_tsmiMenu";
            this._tsmiMenu.Size = new System.Drawing.Size(50, 20);
            this._tsmiMenu.Text = "Menu";
            // 
            // _tsmiShowRankings
            // 
            this._tsmiShowRankings.Name = "_tsmiShowRankings";
            this._tsmiShowRankings.Size = new System.Drawing.Size(152, 22);
            this._tsmiShowRankings.Text = "Rangliste";
            this._tsmiShowRankings.Click += new System.EventHandler(this._tsmiShowRankings_Click);
            // 
            // _tsmiExtras
            // 
            this._tsmiExtras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiOptioins,
            this._tsmiLine,
            this._tsmiHelp});
            this._tsmiExtras.Name = "_tsmiExtras";
            this._tsmiExtras.Size = new System.Drawing.Size(49, 20);
            this._tsmiExtras.Text = "Extras";
            // 
            // _tsmiOptioins
            // 
            this._tsmiOptioins.Name = "_tsmiOptioins";
            this._tsmiOptioins.Size = new System.Drawing.Size(116, 22);
            this._tsmiOptioins.Text = "Options";
            // 
            // _tsmiLine
            // 
            this._tsmiLine.Name = "_tsmiLine";
            this._tsmiLine.Size = new System.Drawing.Size(113, 6);
            // 
            // _tsmiHelp
            // 
            this._tsmiHelp.Name = "_tsmiHelp";
            this._tsmiHelp.Size = new System.Drawing.Size(116, 22);
            this._tsmiHelp.Text = "Help";
            // 
            // _pnlSnake
            // 
            this._pnlSnake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlSnake.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._pnlSnake.Location = new System.Drawing.Point(13, 26);
            this._pnlSnake.Name = "_pnlSnake";
            this._pnlSnake.Size = new System.Drawing.Size(400, 400);
            this._pnlSnake.TabIndex = 1;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 439);
            this.Controls.Add(this._pnlSnake);
            this.Controls.Add(this._msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._msMain;
            this.Name = "FMain";
            this.Text = "Snake Break";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FMain_KeyPress);
            this._msMain.ResumeLayout(false);
            this._msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _msMain;
        private System.Windows.Forms.ToolStripMenuItem _tsmiMenu;
        private System.Windows.Forms.ToolStripMenuItem _tsmiShowRankings;
        private System.Windows.Forms.ToolStripMenuItem _tsmiExtras;
        private System.Windows.Forms.ToolStripMenuItem _tsmiOptioins;
        private System.Windows.Forms.ToolStripSeparator _tsmiLine;
        private System.Windows.Forms.ToolStripMenuItem _tsmiHelp;
        private System.Windows.Forms.Panel _pnlSnake;
    }
}

