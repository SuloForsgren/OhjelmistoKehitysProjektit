
namespace Hotellivarausja
{
    partial class Kirjautumisikkuna
    {
        
        private System.ComponentModel.IContainer components = null;

       
      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            this.KÄYTTÄJÄTUNNUSTB = new System.Windows.Forms.TextBox();
            this.SALASANATB = new System.Windows.Forms.TextBox();
            this.KäyttäjätunnusLB = new System.Windows.Forms.Label();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.SIsäänkirjautumissivuLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KÄYTTÄJÄTUNNUSTB
            // 
            this.KÄYTTÄJÄTUNNUSTB.Location = new System.Drawing.Point(161, 134);
            this.KÄYTTÄJÄTUNNUSTB.Name = "KÄYTTÄJÄTUNNUSTB";
            this.KÄYTTÄJÄTUNNUSTB.Size = new System.Drawing.Size(125, 27);
            this.KÄYTTÄJÄTUNNUSTB.TabIndex = 0;
            // 
            // SALASANATB
            // 
            this.SALASANATB.Location = new System.Drawing.Point(161, 177);
            this.SALASANATB.Name = "SALASANATB";
            this.SALASANATB.Size = new System.Drawing.Size(125, 27);
            this.SALASANATB.TabIndex = 1;
            // 
            // KäyttäjätunnusLB
            // 
            this.KäyttäjätunnusLB.AutoSize = true;
            this.KäyttäjätunnusLB.Location = new System.Drawing.Point(46, 137);
            this.KäyttäjätunnusLB.Name = "KäyttäjätunnusLB";
            this.KäyttäjätunnusLB.Size = new System.Drawing.Size(109, 20);
            this.KäyttäjätunnusLB.TabIndex = 2;
            this.KäyttäjätunnusLB.Text = "Käyttäjätunnus:";
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Location = new System.Drawing.Point(77, 184);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(67, 20);
            this.SalasanaLB.TabIndex = 3;
            this.SalasanaLB.Text = "Salasana";
            // 
            // SIsäänkirjautumissivuLB
            // 
            this.SIsäänkirjautumissivuLB.AutoSize = true;
            this.SIsäänkirjautumissivuLB.Location = new System.Drawing.Point(92, 25);
            this.SIsäänkirjautumissivuLB.Name = "SIsäänkirjautumissivuLB";
            this.SIsäänkirjautumissivuLB.Size = new System.Drawing.Size(152, 20);
            this.SIsäänkirjautumissivuLB.TabIndex = 4;
            this.SIsäänkirjautumissivuLB.Text = "Sisäänkirjautumis sivu";
            // 
            // Kirjautumisikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SIsäänkirjautumissivuLB);
            this.Controls.Add(this.SalasanaLB);
            this.Controls.Add(this.KäyttäjätunnusLB);
            this.Controls.Add(this.SALASANATB);
            this.Controls.Add(this.KÄYTTÄJÄTUNNUSTB);
            this.Name = "Kirjautumisikkuna";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KÄYTTÄJÄTUNNUSTB;
        private System.Windows.Forms.TextBox SALASANATB;
        private System.Windows.Forms.Label KäyttäjätunnusLB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label SIsäänkirjautumissivuLB;
    }
}

