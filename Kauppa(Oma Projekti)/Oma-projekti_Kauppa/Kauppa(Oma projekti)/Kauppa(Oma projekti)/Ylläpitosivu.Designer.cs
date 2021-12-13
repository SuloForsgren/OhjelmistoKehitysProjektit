
namespace Kauppa_Oma_projekti_
{
    partial class Ylläpitosivu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hallitseAsiakkaitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseOstoksiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallitseAsiakkaitaToolStripMenuItem,
            this.hallitseOstoksiaToolStripMenuItem,
            this.kirjauduUlosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hallitseAsiakkaitaToolStripMenuItem
            // 
            this.hallitseAsiakkaitaToolStripMenuItem.Name = "hallitseAsiakkaitaToolStripMenuItem";
            this.hallitseAsiakkaitaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.hallitseAsiakkaitaToolStripMenuItem.Text = "Hallitse asiakkaita";
            this.hallitseAsiakkaitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseAsiakkaitaToolStripMenuItem_Click);
            // 
            // hallitseOstoksiaToolStripMenuItem
            // 
            this.hallitseOstoksiaToolStripMenuItem.Name = "hallitseOstoksiaToolStripMenuItem";
            this.hallitseOstoksiaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.hallitseOstoksiaToolStripMenuItem.Text = "Hallitse ostoksia";
            this.hallitseOstoksiaToolStripMenuItem.Click += new System.EventHandler(this.hallitseOstoksiaToolStripMenuItem_Click);
            // 
            // kirjauduUlosToolStripMenuItem
            // 
            this.kirjauduUlosToolStripMenuItem.Name = "kirjauduUlosToolStripMenuItem";
            this.kirjauduUlosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.kirjauduUlosToolStripMenuItem.Text = "Kirjaudu ulos";
            this.kirjauduUlosToolStripMenuItem.Click += new System.EventHandler(this.kirjauduUlosToolStripMenuItem_Click);
            // 
            // Ylläpitosivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::Kauppa_Oma_projekti_.Properties.Resources._47486941e0c432321ea89aa3efa9deeb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ylläpitosivu";
            this.Text = "Ylläpitosivu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hallitseAsiakkaitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseOstoksiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirjauduUlosToolStripMenuItem;
    }
}