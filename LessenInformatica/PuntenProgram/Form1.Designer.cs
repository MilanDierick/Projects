namespace PuntenProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbPunten = new System.Windows.Forms.TextBox();
            this.txtbMaxPunten = new System.Windows.Forms.TextBox();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punten";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MaxPunten";
            // 
            // txtbPunten
            // 
            this.txtbPunten.Location = new System.Drawing.Point(79, 20);
            this.txtbPunten.Name = "txtbPunten";
            this.txtbPunten.Size = new System.Drawing.Size(100, 20);
            this.txtbPunten.TabIndex = 2;
            // 
            // txtbMaxPunten
            // 
            this.txtbMaxPunten.Location = new System.Drawing.Point(79, 56);
            this.txtbMaxPunten.Name = "txtbMaxPunten";
            this.txtbMaxPunten.Size = new System.Drawing.Size(100, 20);
            this.txtbMaxPunten.TabIndex = 3;
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Location = new System.Drawing.Point(50, 100);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(35, 13);
            this.lblResultaat.TabIndex = 4;
            this.lblResultaat.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResultaat);
            this.Controls.Add(this.txtbMaxPunten);
            this.Controls.Add(this.txtbPunten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbPunten;
        private System.Windows.Forms.TextBox txtbMaxPunten;
        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.Button button1;
    }
}

