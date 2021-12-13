
namespace Kauppa_Oma_projekti_
{
    partial class Kauppa
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
            this.KoriBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TuotteetDG = new System.Windows.Forms.DataGridView();
            this.KoriPL = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.KoriLB = new System.Windows.Forms.Label();
            this.TuotteenimiTB = new System.Windows.Forms.TextBox();
            this.MaksaBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TuotteetDG)).BeginInit();
            this.KoriPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // KoriBT
            // 
            this.KoriBT.BackColor = System.Drawing.Color.White;
            this.KoriBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KoriBT.ForeColor = System.Drawing.Color.Blue;
            this.KoriBT.Location = new System.Drawing.Point(97, 177);
            this.KoriBT.Name = "KoriBT";
            this.KoriBT.Size = new System.Drawing.Size(128, 65);
            this.KoriBT.TabIndex = 0;
            this.KoriBT.Text = "Lisää koriin";
            this.KoriBT.UseVisualStyleBackColor = false;
            this.KoriBT.Click += new System.EventHandler(this.KoriBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.BackColor = System.Drawing.Color.White;
            this.PoistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.ForeColor = System.Drawing.Color.Blue;
            this.PoistaBT.Location = new System.Drawing.Point(231, 177);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(128, 65);
            this.PoistaBT.TabIndex = 1;
            this.PoistaBT.Text = "Poista korista";
            this.PoistaBT.UseVisualStyleBackColor = false;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // TuotteetDG
            // 
            this.TuotteetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TuotteetDG.Location = new System.Drawing.Point(12, 248);
            this.TuotteetDG.Name = "TuotteetDG";
            this.TuotteetDG.Size = new System.Drawing.Size(432, 190);
            this.TuotteetDG.TabIndex = 2;
            this.TuotteetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TuotteetDG_CellContentClick);
            // 
            // KoriPL
            // 
            this.KoriPL.BackColor = System.Drawing.Color.White;
            this.KoriPL.Controls.Add(this.label1);
            this.KoriPL.Controls.Add(this.KoriLB);
            this.KoriPL.Location = new System.Drawing.Point(474, 248);
            this.KoriPL.Name = "KoriPL";
            this.KoriPL.Size = new System.Drawing.Size(314, 190);
            this.KoriPL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(104, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tuotteet";
            // 
            // KoriLB
            // 
            this.KoriLB.AutoSize = true;
            this.KoriLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KoriLB.Location = new System.Drawing.Point(104, 6);
            this.KoriLB.Name = "KoriLB";
            this.KoriLB.Size = new System.Drawing.Size(0, 25);
            this.KoriLB.TabIndex = 0;
            // 
            // TuotteenimiTB
            // 
            this.TuotteenimiTB.Enabled = false;
            this.TuotteenimiTB.Location = new System.Drawing.Point(13, 222);
            this.TuotteenimiTB.Name = "TuotteenimiTB";
            this.TuotteenimiTB.Size = new System.Drawing.Size(82, 20);
            this.TuotteenimiTB.TabIndex = 5;
            // 
            // MaksaBT
            // 
            this.MaksaBT.BackColor = System.Drawing.Color.White;
            this.MaksaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaksaBT.ForeColor = System.Drawing.Color.Blue;
            this.MaksaBT.Location = new System.Drawing.Point(548, 177);
            this.MaksaBT.Name = "MaksaBT";
            this.MaksaBT.Size = new System.Drawing.Size(159, 65);
            this.MaksaBT.TabIndex = 6;
            this.MaksaBT.Text = "Maksa ja tilaa";
            this.MaksaBT.UseVisualStyleBackColor = false;
            this.MaksaBT.Click += new System.EventHandler(this.MaksaBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vaihe 1. Valitse tuote datagridistä.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vaihe 2.  Paina lisää koriin joka lisää tuotteesi paneeliin oikealle alas.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(462, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vaihe 4.  Poista korista jos tarve (HUOM! Poistaa kaiken korista!)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(602, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vaihe 3. Tarkista tässä vaiheessa että kaikki ostoskorissa olevat tuotteet ovat o" +
    "ikein.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(643, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vaihe 5. Paina maksa ja tilaa hoitaaksesi tilauksen loppuun kiitos että käytit oh" +
    "jelmaamme!";
            // 
            // CloseLB
            // 
            this.CloseLB.AutoSize = true;
            this.CloseLB.BackColor = System.Drawing.Color.Orange;
            this.CloseLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLB.ForeColor = System.Drawing.Color.Red;
            this.CloseLB.Location = new System.Drawing.Point(756, 0);
            this.CloseLB.Name = "CloseLB";
            this.CloseLB.Size = new System.Drawing.Size(44, 42);
            this.CloseLB.TabIndex = 40;
            this.CloseLB.Text = "X";
            this.CloseLB.Click += new System.EventHandler(this.CloseLB_Click);
            // 
            // Kauppa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseLB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaksaBT);
            this.Controls.Add(this.TuotteenimiTB);
            this.Controls.Add(this.KoriPL);
            this.Controls.Add(this.TuotteetDG);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.KoriBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kauppa";
            this.Text = "Kauppa";
            this.Load += new System.EventHandler(this.Kauppa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TuotteetDG)).EndInit();
            this.KoriPL.ResumeLayout(false);
            this.KoriPL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KoriBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.DataGridView TuotteetDG;
        private System.Windows.Forms.Panel KoriPL;
        private System.Windows.Forms.TextBox TuotteenimiTB;
        private System.Windows.Forms.Label KoriLB;
        private System.Windows.Forms.Button MaksaBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CloseLB;
    }
}