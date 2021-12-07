
namespace Hotelli__Oma_
{
    partial class VARAUKSET
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
            this.TyhjennaKentatBT = new System.Windows.Forms.Button();
            this.PoistaVarausBT = new System.Windows.Forms.Button();
            this.MuokkaaBT = new System.Windows.Forms.Button();
            this.LisaaVarausBT = new System.Windows.Forms.Button();
            this.VarausTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VarauksetDG = new System.Windows.Forms.DataGridView();
            this.AsiakasTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HuonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HuoneennumeroCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.UlosDTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // TyhjennaKentatBT
            // 
            this.TyhjennaKentatBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaKentatBT.Location = new System.Drawing.Point(188, 220);
            this.TyhjennaKentatBT.Name = "TyhjennaKentatBT";
            this.TyhjennaKentatBT.Size = new System.Drawing.Size(113, 33);
            this.TyhjennaKentatBT.TabIndex = 46;
            this.TyhjennaKentatBT.Text = "Tyhjennä";
            this.TyhjennaKentatBT.UseVisualStyleBackColor = true;
            this.TyhjennaKentatBT.Click += new System.EventHandler(this.TyhjennaKentatBT_Click);
            // 
            // PoistaVarausBT
            // 
            this.PoistaVarausBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaVarausBT.Location = new System.Drawing.Point(527, 220);
            this.PoistaVarausBT.Name = "PoistaVarausBT";
            this.PoistaVarausBT.Size = new System.Drawing.Size(96, 33);
            this.PoistaVarausBT.TabIndex = 45;
            this.PoistaVarausBT.Text = "Poista";
            this.PoistaVarausBT.UseVisualStyleBackColor = true;
            this.PoistaVarausBT.Click += new System.EventHandler(this.PoistaVarausBT_Click);
            // 
            // MuokkaaBT
            // 
            this.MuokkaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuokkaaBT.Location = new System.Drawing.Point(409, 220);
            this.MuokkaaBT.Name = "MuokkaaBT";
            this.MuokkaaBT.Size = new System.Drawing.Size(112, 33);
            this.MuokkaaBT.TabIndex = 44;
            this.MuokkaaBT.Text = "Muokkaa";
            this.MuokkaaBT.UseVisualStyleBackColor = true;
            this.MuokkaaBT.Click += new System.EventHandler(this.MuokkaaBT_Click);
            // 
            // LisaaVarausBT
            // 
            this.LisaaVarausBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisaaVarausBT.Location = new System.Drawing.Point(307, 220);
            this.LisaaVarausBT.Name = "LisaaVarausBT";
            this.LisaaVarausBT.Size = new System.Drawing.Size(96, 33);
            this.LisaaVarausBT.TabIndex = 43;
            this.LisaaVarausBT.Text = "Lisää";
            this.LisaaVarausBT.UseVisualStyleBackColor = true;
            this.LisaaVarausBT.Click += new System.EventHandler(this.LisaaVarausBT_Click);
            // 
            // VarausTB
            // 
            this.VarausTB.BackColor = System.Drawing.Color.White;
            this.VarausTB.Enabled = false;
            this.VarausTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausTB.Location = new System.Drawing.Point(261, 33);
            this.VarausTB.Name = "VarausTB";
            this.VarausTB.Size = new System.Drawing.Size(121, 31);
            this.VarausTB.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Varaus ID";
            // 
            // VarauksetDG
            // 
            this.VarauksetDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VarauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VarauksetDG.Location = new System.Drawing.Point(111, 259);
            this.VarauksetDG.Name = "VarauksetDG";
            this.VarauksetDG.Size = new System.Drawing.Size(577, 168);
            this.VarauksetDG.TabIndex = 37;
            this.VarauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellClick);
            this.VarauksetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellContentClick);
            // 
            // AsiakasTB
            // 
            this.AsiakasTB.BackColor = System.Drawing.Color.White;
            this.AsiakasTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasTB.Location = new System.Drawing.Point(261, 76);
            this.AsiakasTB.Name = "AsiakasTB";
            this.AsiakasTB.Size = new System.Drawing.Size(121, 31);
            this.AsiakasTB.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Asiakas ID";
            // 
            // HuonetyyppiCB
            // 
            this.HuonetyyppiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuonetyyppiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuonetyyppiCB.FormattingEnabled = true;
            this.HuonetyyppiCB.Location = new System.Drawing.Point(261, 118);
            this.HuonetyyppiCB.Name = "HuonetyyppiCB";
            this.HuonetyyppiCB.Size = new System.Drawing.Size(121, 21);
            this.HuonetyyppiCB.TabIndex = 51;
            this.HuonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.HuonetyyppiCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Huoneen tyyppi";
            // 
            // HuoneennumeroCB
            // 
            this.HuoneennumeroCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuoneennumeroCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneennumeroCB.FormattingEnabled = true;
            this.HuoneennumeroCB.Location = new System.Drawing.Point(261, 157);
            this.HuoneennumeroCB.Name = "HuoneennumeroCB";
            this.HuoneennumeroCB.Size = new System.Drawing.Size(121, 21);
            this.HuoneennumeroCB.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Huoneen numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ulos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Sisään";
            // 
            // SisaanDTP
            // 
            this.SisaanDTP.CustomFormat = "dd/MM/yyyy";
            this.SisaanDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisaanDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SisaanDTP.Location = new System.Drawing.Point(500, 38);
            this.SisaanDTP.Name = "SisaanDTP";
            this.SisaanDTP.Size = new System.Drawing.Size(123, 26);
            this.SisaanDTP.TabIndex = 56;
            // 
            // UlosDTP
            // 
            this.UlosDTP.CustomFormat = "dd/MM/yyyy";
            this.UlosDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlosDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UlosDTP.Location = new System.Drawing.Point(500, 78);
            this.UlosDTP.Name = "UlosDTP";
            this.UlosDTP.Size = new System.Drawing.Size(123, 26);
            this.UlosDTP.TabIndex = 57;
            // 
            // VARAUKSET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UlosDTP);
            this.Controls.Add(this.SisaanDTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HuoneennumeroCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HuonetyyppiCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AsiakasTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TyhjennaKentatBT);
            this.Controls.Add(this.PoistaVarausBT);
            this.Controls.Add(this.MuokkaaBT);
            this.Controls.Add(this.LisaaVarausBT);
            this.Controls.Add(this.VarausTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VarauksetDG);
            this.Name = "VARAUKSET";
            this.Text = "VARAUKSET";
            this.Load += new System.EventHandler(this.VARAUKSET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TyhjennaKentatBT;
        private System.Windows.Forms.Button PoistaVarausBT;
        private System.Windows.Forms.Button MuokkaaBT;
        private System.Windows.Forms.Button LisaaVarausBT;
        private System.Windows.Forms.TextBox VarausTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VarauksetDG;
        private System.Windows.Forms.TextBox AsiakasTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HuonetyyppiCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox HuoneennumeroCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker SisaanDTP;
        private System.Windows.Forms.DateTimePicker UlosDTP;
    }
}