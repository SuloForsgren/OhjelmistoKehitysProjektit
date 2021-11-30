
namespace Hotelli__Oma_
{
    partial class PaisaikkunaFM
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asiakkaidenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huoneetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kirjaudu_ulosBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotelli__Oma_.Properties.Resources.wallpapers_3d_hotel_design_hd_wallpaper_artistic_hd_wallpapers;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tervetuloa sisään hallintasivulle!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asiakkaidenHallintaToolStripMenuItem,
            this.huoneetToolStripMenuItem,
            this.varauksetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asiakkaidenHallintaToolStripMenuItem
            // 
            this.asiakkaidenHallintaToolStripMenuItem.Name = "asiakkaidenHallintaToolStripMenuItem";
            this.asiakkaidenHallintaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.asiakkaidenHallintaToolStripMenuItem.Text = "Asiakkaat";
            this.asiakkaidenHallintaToolStripMenuItem.Click += new System.EventHandler(this.asiakkaidenHallintaToolStripMenuItem_Click);
            // 
            // varauksetToolStripMenuItem
            // 
            this.varauksetToolStripMenuItem.Name = "varauksetToolStripMenuItem";
            this.varauksetToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.varauksetToolStripMenuItem.Text = "Varaukset";
            this.varauksetToolStripMenuItem.Click += new System.EventHandler(this.varauksetToolStripMenuItem_Click);
            // 
            // huoneetToolStripMenuItem
            // 
            this.huoneetToolStripMenuItem.Name = "huoneetToolStripMenuItem";
            this.huoneetToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.huoneetToolStripMenuItem.Text = "Huoneet";
            this.huoneetToolStripMenuItem.Click += new System.EventHandler(this.huoneetToolStripMenuItem_Click);
            // 
            // Kirjaudu_ulosBT
            // 
            this.Kirjaudu_ulosBT.BackColor = System.Drawing.Color.Lime;
            this.Kirjaudu_ulosBT.Location = new System.Drawing.Point(715, 420);
            this.Kirjaudu_ulosBT.Name = "Kirjaudu_ulosBT";
            this.Kirjaudu_ulosBT.Size = new System.Drawing.Size(85, 23);
            this.Kirjaudu_ulosBT.TabIndex = 3;
            this.Kirjaudu_ulosBT.Text = "Kirjaudu ulos";
            this.Kirjaudu_ulosBT.UseVisualStyleBackColor = false;
            this.Kirjaudu_ulosBT.Click += new System.EventHandler(this.Kirjaudu_ulosBT_Click);
            // 
            // PaisaikkunaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kirjaudu_ulosBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaisaikkunaFM";
            this.Text = "Paaikkuna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaisaikkunaFM_FormClosing);
            this.Load += new System.EventHandler(this.PaisaikkunaFM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asiakkaidenHallintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varauksetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huoneetToolStripMenuItem;
        private System.Windows.Forms.Button Kirjaudu_ulosBT;
    }
}