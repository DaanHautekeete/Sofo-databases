namespace Examen_login
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(97, 12);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(97, 38);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pass";
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(16, 75);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(75, 23);
            this.btnInloggen.TabIndex = 2;
            this.btnInloggen.Text = "Log in";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(122, 75);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreer.TabIndex = 2;
            this.btnRegistreer.Text = "Registreer";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 109);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.Button btnRegistreer;
    }
}

