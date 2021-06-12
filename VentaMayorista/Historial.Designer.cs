
namespace VentaMayorista
{
    partial class Historial
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
            this.lblHist = new System.Windows.Forms.Label();
            this.lblHistor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHist
            // 
            this.lblHist.AutoSize = true;
            this.lblHist.Location = new System.Drawing.Point(-6, -74);
            this.lblHist.Name = "lblHist";
            this.lblHist.Size = new System.Drawing.Size(0, 15);
            this.lblHist.TabIndex = 1;
            // 
            // lblHistor
            // 
            this.lblHistor.AutoSize = true;
            this.lblHistor.Location = new System.Drawing.Point(12, 9);
            this.lblHistor.Name = "lblHistor";
            this.lblHistor.Size = new System.Drawing.Size(38, 15);
            this.lblHistor.TabIndex = 2;
            this.lblHistor.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHistor);
            this.Controls.Add(this.lblHist);
            this.Name = "Historial";
            this.Text = "Historial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHist;
        private System.Windows.Forms.Label lblHistor;
        private System.Windows.Forms.Button button1;
    }
}