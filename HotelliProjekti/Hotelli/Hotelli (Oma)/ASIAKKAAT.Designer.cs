
namespace Hotelli__Oma_
{
    partial class ASIAKKAAT
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
            this.TietoboksiDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.ETTB = new System.Windows.Forms.TextBox();
            this.SNTB = new System.Windows.Forms.TextBox();
            this.EMAILTB = new System.Windows.Forms.TextBox();
            this.PUHTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.PaivitysBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.Tyhjenna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TietoboksiDG)).BeginInit();
            this.SuspendLayout();
            // 
            // TietoboksiDG
            // 
            this.TietoboksiDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietoboksiDG.Location = new System.Drawing.Point(135, 270);
            this.TietoboksiDG.Name = "TietoboksiDG";
            this.TietoboksiDG.Size = new System.Drawing.Size(577, 168);
            this.TietoboksiDG.TabIndex = 0;
            this.TietoboksiDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Etunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sukunimi";
            // 
            // IDTB
            // 
            this.IDTB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.IDTB.Enabled = false;
            this.IDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTB.Location = new System.Drawing.Point(269, 34);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(100, 31);
            this.IDTB.TabIndex = 4;
            this.IDTB.TextChanged += new System.EventHandler(this.IDTB_TextChanged);
            // 
            // ETTB
            // 
            this.ETTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETTB.Location = new System.Drawing.Point(269, 91);
            this.ETTB.Name = "ETTB";
            this.ETTB.Size = new System.Drawing.Size(100, 31);
            this.ETTB.TabIndex = 5;
            // 
            // SNTB
            // 
            this.SNTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNTB.Location = new System.Drawing.Point(269, 146);
            this.SNTB.Name = "SNTB";
            this.SNTB.Size = new System.Drawing.Size(100, 31);
            this.SNTB.TabIndex = 6;
            // 
            // EMAILTB
            // 
            this.EMAILTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMAILTB.Location = new System.Drawing.Point(531, 146);
            this.EMAILTB.Name = "EMAILTB";
            this.EMAILTB.Size = new System.Drawing.Size(100, 31);
            this.EMAILTB.TabIndex = 11;
            // 
            // PUHTB
            // 
            this.PUHTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUHTB.Location = new System.Drawing.Point(531, 88);
            this.PUHTB.Name = "PUHTB";
            this.PUHTB.Size = new System.Drawing.Size(100, 31);
            this.PUHTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sähköposti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Puhelinnumero";
            // 
            // LisaaBT
            // 
            this.LisaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisaaBT.Location = new System.Drawing.Point(331, 231);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(96, 33);
            this.LisaaBT.TabIndex = 12;
            this.LisaaBT.Text = "Lisää";
            this.LisaaBT.UseVisualStyleBackColor = true;
            this.LisaaBT.Click += new System.EventHandler(this.LisaaBT_Click);
            // 
            // PaivitysBT
            // 
            this.PaivitysBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivitysBT.Location = new System.Drawing.Point(433, 231);
            this.PaivitysBT.Name = "PaivitysBT";
            this.PaivitysBT.Size = new System.Drawing.Size(96, 33);
            this.PaivitysBT.TabIndex = 13;
            this.PaivitysBT.Text = "Päivitä";
            this.PaivitysBT.UseVisualStyleBackColor = true;
            this.PaivitysBT.Click += new System.EventHandler(this.PaivitysBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.Location = new System.Drawing.Point(535, 231);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(96, 33);
            this.PoistaBT.TabIndex = 14;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // Tyhjenna
            // 
            this.Tyhjenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tyhjenna.Location = new System.Drawing.Point(212, 231);
            this.Tyhjenna.Name = "Tyhjenna";
            this.Tyhjenna.Size = new System.Drawing.Size(113, 33);
            this.Tyhjenna.TabIndex = 15;
            this.Tyhjenna.Text = "Tyhjennä";
            this.Tyhjenna.UseVisualStyleBackColor = true;
            this.Tyhjenna.Click += new System.EventHandler(this.Tyhjenna_Click);
            // 
            // ASIAKKAAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tyhjenna);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PaivitysBT);
            this.Controls.Add(this.LisaaBT);
            this.Controls.Add(this.EMAILTB);
            this.Controls.Add(this.PUHTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SNTB);
            this.Controls.Add(this.ETTB);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TietoboksiDG);
            this.Name = "ASIAKKAAT";
            this.Text = "ASIAKKAAT";
            this.Load += new System.EventHandler(this.ASIAKKAAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietoboksiDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TietoboksiDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.TextBox ETTB;
        private System.Windows.Forms.TextBox SNTB;
        private System.Windows.Forms.TextBox EMAILTB;
        private System.Windows.Forms.TextBox PUHTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LisaaBT;
        private System.Windows.Forms.Button PaivitysBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button Tyhjenna;
    }
}