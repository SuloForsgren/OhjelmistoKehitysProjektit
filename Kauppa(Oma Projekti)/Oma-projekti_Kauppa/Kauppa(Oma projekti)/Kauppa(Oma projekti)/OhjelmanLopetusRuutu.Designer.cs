
namespace Kauppa_Oma_projekti_
{
    partial class OhjelmanLopetusRuutu
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
            this.components = new System.ComponentModel.Container();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LatausPB = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 20;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Odotamme innolla paluutasi takaisin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kauppa_Oma_projekti_.Properties.Resources.Shoppingcart_01_icon;
            this.pictureBox1.Location = new System.Drawing.Point(188, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LatausPB
            // 
            this.LatausPB.BackColor = System.Drawing.Color.SteelBlue;
            this.LatausPB.ForeColor = System.Drawing.Color.White;
            this.LatausPB.Location = new System.Drawing.Point(12, 328);
            this.LatausPB.Name = "LatausPB";
            this.LatausPB.Size = new System.Drawing.Size(497, 23);
            this.LatausPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LatausPB.TabIndex = 5;
            this.LatausPB.Click += new System.EventHandler(this.LatausPB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tervetuloa uudelleen!";
            // 
            // OhjelmanLopetusRuutu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(517, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LatausPB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OhjelmanLopetusRuutu";
            this.Text = "OhjelmanLopetusRuutu";
            this.Load += new System.EventHandler(this.OhjelmanLopetusRuutu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer AjastinTM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar LatausPB;
        private System.Windows.Forms.Label label1;
    }
}