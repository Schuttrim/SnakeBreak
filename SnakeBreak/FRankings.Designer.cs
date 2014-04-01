namespace SnakeBreak
{
    partial class FRankings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRankings));
            this._lblTitle = new System.Windows.Forms.Label();
            this._dgvRangliste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._dgvRangliste)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblTitle
            // 
            this._lblTitle.AutoSize = true;
            this._lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTitle.Location = new System.Drawing.Point(7, 10);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(103, 26);
            this._lblTitle.TabIndex = 0;
            this._lblTitle.Text = "Rangliste";
            // 
            // _dgvRangliste
            // 
            this._dgvRangliste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvRangliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvRangliste.Location = new System.Drawing.Point(13, 40);
            this._dgvRangliste.Name = "_dgvRangliste";
            this._dgvRangliste.Size = new System.Drawing.Size(217, 324);
            this._dgvRangliste.TabIndex = 1;
            // 
            // FRankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 376);
            this.Controls.Add(this._dgvRangliste);
            this.Controls.Add(this._lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRankings";
            this.Text = "Rangliste";
            ((System.ComponentModel.ISupportInitialize)(this._dgvRangliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.DataGridView _dgvRangliste;
    }
}