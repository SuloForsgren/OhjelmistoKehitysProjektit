
namespace Kauppa_Oma_projekti_
{
    partial class Asiakkaiden_hallinta
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
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KtunnusTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tyhjenna = new System.Windows.Forms.Button();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TietoboksiDG = new System.Windows.Forms.DataGridView();
            this.CloseLB = new System.Windows.Forms.Label();
            this.PoistaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TietoboksiDG)).BeginInit();
            this.SuspendLayout();
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(523, 117);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(100, 31);
            this.SalasanaTB.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SlateGray;
            this.label4.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 30);
            this.label4.TabIndex = 37;
            this.label4.Text = "Salasana";
            // 
            // KtunnusTB
            // 
            this.KtunnusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KtunnusTB.Location = new System.Drawing.Point(523, 60);
            this.KtunnusTB.Name = "KtunnusTB";
            this.KtunnusTB.Size = new System.Drawing.Size(100, 31);
            this.KtunnusTB.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SlateGray;
            this.label7.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 30);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ktunnus";
            // 
            // Tyhjenna
            // 
            this.Tyhjenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tyhjenna.Location = new System.Drawing.Point(260, 231);
            this.Tyhjenna.Name = "Tyhjenna";
            this.Tyhjenna.Size = new System.Drawing.Size(113, 33);
            this.Tyhjenna.TabIndex = 34;
            this.Tyhjenna.Text = "Tyhjennä";
            this.Tyhjenna.UseVisualStyleBackColor = true;
            this.Tyhjenna.Click += new System.EventHandler(this.Tyhjenna_Click);
            // 
            // LisaaBT
            // 
            this.LisaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisaaBT.Location = new System.Drawing.Point(379, 231);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(96, 33);
            this.LisaaBT.TabIndex = 31;
            this.LisaaBT.Text = "Lisää";
            this.LisaaBT.UseVisualStyleBackColor = true;
            this.LisaaBT.Click += new System.EventHandler(this.LisaaBT_Click);
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SukunimiTB.Location = new System.Drawing.Point(245, 168);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(100, 31);
            this.SukunimiTB.TabIndex = 26;
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtunimiTB.Location = new System.Drawing.Point(245, 113);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(100, 31);
            this.EtunimiTB.TabIndex = 25;
            // 
            // IDTB
            // 
            this.IDTB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.IDTB.Enabled = false;
            this.IDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTB.Location = new System.Drawing.Point(245, 56);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(100, 31);
            this.IDTB.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateGray;
            this.label3.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sukunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Etunimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // TietoboksiDG
            // 
            this.TietoboksiDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietoboksiDG.Location = new System.Drawing.Point(130, 270);
            this.TietoboksiDG.Name = "TietoboksiDG";
            this.TietoboksiDG.Size = new System.Drawing.Size(577, 168);
            this.TietoboksiDG.TabIndex = 20;
            this.TietoboksiDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietoboksiDG_CellContentClick);
            // 
            // CloseLB
            // 
            this.CloseLB.AutoSize = true;
            this.CloseLB.BackColor = System.Drawing.Color.SlateGray;
            this.CloseLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLB.ForeColor = System.Drawing.Color.Red;
            this.CloseLB.Location = new System.Drawing.Point(756, 0);
            this.CloseLB.Name = "CloseLB";
            this.CloseLB.Size = new System.Drawing.Size(44, 42);
            this.CloseLB.TabIndex = 39;
            this.CloseLB.Text = "X";
            this.CloseLB.Click += new System.EventHandler(this.CloseLB_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.Location = new System.Drawing.Point(481, 231);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(96, 33);
            this.PoistaBT.TabIndex = 40;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // Asiakkaiden_hallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.CloseLB);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KtunnusTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tyhjenna);
            this.Controls.Add(this.LisaaBT);
            this.Controls.Add(this.SukunimiTB);
            this.Controls.Add(this.EtunimiTB);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TietoboksiDG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asiakkaiden_hallinta";
            this.Text = "Asiakkaiden_hallinta";
            this.Load += new System.EventHandler(this.Asiakkaiden_hallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietoboksiDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KtunnusTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Tyhjenna;
        private System.Windows.Forms.Button LisaaBT;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TietoboksiDG;
        private System.Windows.Forms.Label CloseLB;
        private System.Windows.Forms.Button PoistaBT;
    }
}