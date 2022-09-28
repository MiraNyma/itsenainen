namespace _28._8itsenäinen_tehtävä
{
    partial class Form1
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
            this.labl = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Noppa2 = new System.Windows.Forms.Button();
            this.Noppa1 = new System.Windows.Forms.Button();
            this.Resetointi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Location = new System.Drawing.Point(147, 88);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(70, 20);
            this.labl.TabIndex = 0;
            this.labl.Text = "Pelaaja1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(449, 88);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(74, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Pelaaja 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pelaaja Voitti!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Noppa2
            // 
            this.Noppa2.Location = new System.Drawing.Point(412, 131);
            this.Noppa2.Name = "Noppa2";
            this.Noppa2.Size = new System.Drawing.Size(123, 53);
            this.Noppa2.TabIndex = 3;
            this.Noppa2.Text = "Hietä noppaa!";
            this.Noppa2.UseVisualStyleBackColor = true;
            this.Noppa2.Click += new System.EventHandler(this.Noppa2_Click);
            // 
            // Noppa1
            // 
            this.Noppa1.Location = new System.Drawing.Point(105, 131);
            this.Noppa1.Name = "Noppa1";
            this.Noppa1.Size = new System.Drawing.Size(132, 53);
            this.Noppa1.TabIndex = 4;
            this.Noppa1.Text = "Heitä noppaa!";
            this.Noppa1.UseVisualStyleBackColor = true;
            this.Noppa1.Click += new System.EventHandler(this.Noppa1_Click);
            // 
            // Resetointi
            // 
            this.Resetointi.Location = new System.Drawing.Point(237, 295);
            this.Resetointi.Name = "Resetointi";
            this.Resetointi.Size = new System.Drawing.Size(94, 50);
            this.Resetointi.TabIndex = 5;
            this.Resetointi.Text = "Resetoi";
            this.Resetointi.UseVisualStyleBackColor = true;
            this.Resetointi.Click += new System.EventHandler(this.Resetointi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resetointi);
            this.Controls.Add(this.Noppa1);
            this.Controls.Add(this.Noppa2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.labl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Noppa2;
        private System.Windows.Forms.Button Noppa1;
        private System.Windows.Forms.Button Resetointi;
    }
}

