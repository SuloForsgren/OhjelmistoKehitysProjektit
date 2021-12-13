
namespace Kauppa_Oma_projekti_
{
    partial class OstosSivu
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
            this.CloseLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.PäivitäBT = new System.Windows.Forms.Button();
            this.TyhjennysBT = new System.Windows.Forms.Button();
            this.TuotteetDG = new System.Windows.Forms.DataGridView();
            this.NimiLB = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.HintaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TuotteetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLB
            // 
            this.CloseLB.AutoSize = true;
            this.CloseLB.BackColor = System.Drawing.Color.SteelBlue;
            this.CloseLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLB.ForeColor = System.Drawing.Color.Red;
            this.CloseLB.Location = new System.Drawing.Point(756, 0);
            this.CloseLB.Name = "CloseLB";
            this.CloseLB.Size = new System.Drawing.Size(44, 42);
            this.CloseLB.TabIndex = 2;
            this.CloseLB.Text = "X";
            this.CloseLB.Click += new System.EventHandler(this.CloseLB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.TyhjennysBT);
            this.panel1.Controls.Add(this.PäivitäBT);
            this.panel1.Controls.Add(this.PoistaBT);
            this.panel1.Controls.Add(this.LisaaBT);
            this.panel1.Location = new System.Drawing.Point(-6, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 464);
            this.panel1.TabIndex = 3;
            // 
            // LisaaBT
            // 
            this.LisaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisaaBT.Location = new System.Drawing.Point(32, 175);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(129, 32);
            this.LisaaBT.TabIndex = 0;
            this.LisaaBT.Text = "Lisää tuote";
            this.LisaaBT.UseVisualStyleBackColor = true;
            this.LisaaBT.Click += new System.EventHandler(this.LisaaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.Location = new System.Drawing.Point(32, 310);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(129, 32);
            this.PoistaBT.TabIndex = 1;
            this.PoistaBT.Text = "Poista tuote";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // PäivitäBT
            // 
            this.PäivitäBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PäivitäBT.Location = new System.Drawing.Point(32, 232);
            this.PäivitäBT.Name = "PäivitäBT";
            this.PäivitäBT.Size = new System.Drawing.Size(129, 52);
            this.PäivitäBT.TabIndex = 2;
            this.PäivitäBT.Text = "Päivitä tuotteen tietoja";
            this.PäivitäBT.UseVisualStyleBackColor = true;
            this.PäivitäBT.Click += new System.EventHandler(this.PäivitäBT_Click);
            // 
            // TyhjennysBT
            // 
            this.TyhjennysBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennysBT.Location = new System.Drawing.Point(32, 117);
            this.TyhjennysBT.Name = "TyhjennysBT";
            this.TyhjennysBT.Size = new System.Drawing.Size(129, 32);
            this.TyhjennysBT.TabIndex = 3;
            this.TyhjennysBT.Text = " Tyhjennä tiedot";
            this.TyhjennysBT.UseVisualStyleBackColor = true;
            this.TyhjennysBT.Click += new System.EventHandler(this.TyhjennysBT_Click);
            // 
            // TuotteetDG
            // 
            this.TuotteetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TuotteetDG.Location = new System.Drawing.Point(501, 45);
            this.TuotteetDG.Name = "TuotteetDG";
            this.TuotteetDG.Size = new System.Drawing.Size(287, 393);
            this.TuotteetDG.TabIndex = 4;
            this.TuotteetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TuotteetDG_CellContentClick);
            // 
            // NimiLB
            // 
            this.NimiLB.AutoSize = true;
            this.NimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NimiLB.Location = new System.Drawing.Point(199, 194);
            this.NimiLB.Name = "NimiLB";
            this.NimiLB.Size = new System.Drawing.Size(148, 25);
            this.NimiLB.TabIndex = 5;
            this.NimiLB.Text = "Tuotteen nimi:";
            // 
            // NimiTB
            // 
            this.NimiTB.Location = new System.Drawing.Point(330, 243);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(143, 20);
            this.NimiTB.TabIndex = 6;
            // 
            // HintaTB
            // 
            this.HintaTB.Location = new System.Drawing.Point(330, 334);
            this.HintaTB.Name = "HintaTB";
            this.HintaTB.Size = new System.Drawing.Size(143, 20);
            this.HintaTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tuotteen hinta (Kokonaisina euroina):";
            // 
            // IDTB
            // 
            this.IDTB.Enabled = false;
            this.IDTB.Location = new System.Drawing.Point(330, 145);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(143, 20);
            this.IDTB.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID:";
            // 
            // OstosSivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HintaTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.NimiLB);
            this.Controls.Add(this.TuotteetDG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OstosSivu";
            this.Text = "OstosSivu";
            this.Load += new System.EventHandler(this.OstosSivu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TuotteetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LisaaBT;
        private System.Windows.Forms.Button TyhjennysBT;
        private System.Windows.Forms.Button PäivitäBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.DataGridView TuotteetDG;
        private System.Windows.Forms.Label NimiLB;
        private System.Windows.Forms.TextBox NimiTB;
        private System.Windows.Forms.TextBox HintaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Label label2;
    }
}