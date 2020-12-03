
namespace Fundamentos
{
    partial class Form11Isbn
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
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnisbn = new System.Windows.Forms.Button();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.ForeColor = System.Drawing.Color.Blue;
            this.lblmensaje.Location = new System.Drawing.Point(179, 160);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(143, 31);
            this.lblmensaje.TabIndex = 7;
            this.lblmensaje.Text = "lblmensaje";
            // 
            // btnisbn
            // 
            this.btnisbn.Location = new System.Drawing.Point(146, 80);
            this.btnisbn.Name = "btnisbn";
            this.btnisbn.Size = new System.Drawing.Size(228, 48);
            this.btnisbn.TabIndex = 6;
            this.btnisbn.Text = "Comprobar ISBN";
            this.btnisbn.UseVisualStyleBackColor = true;
            this.btnisbn.Click += new System.EventHandler(this.btnisbn_Click);
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(242, 19);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(251, 38);
            this.txtisbn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número ISBN:";
            // 
            // Form11Isbn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 215);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnisbn);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form11Isbn";
            this.Text = "Form11Isbn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnisbn;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.Label label1;
    }
}