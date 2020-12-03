
namespace Fundamentos
{
    partial class Form09ValidarMail
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
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btncomprobar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(142, 31);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(454, 38);
            this.txtemail.TabIndex = 1;
            // 
            // btncomprobar
            // 
            this.btncomprobar.Location = new System.Drawing.Point(194, 92);
            this.btncomprobar.Name = "btncomprobar";
            this.btncomprobar.Size = new System.Drawing.Size(280, 62);
            this.btncomprobar.TabIndex = 2;
            this.btncomprobar.Text = "Comprobar Mail";
            this.btncomprobar.UseVisualStyleBackColor = true;
            this.btncomprobar.Click += new System.EventHandler(this.btncomprobar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.ForeColor = System.Drawing.Color.Red;
            this.lblmensaje.Location = new System.Drawing.Point(38, 185);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(143, 31);
            this.lblmensaje.TabIndex = 3;
            this.lblmensaje.Text = "lblmensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 186);
            this.label2.TabIndex = 4;
            this.label2.Text = "- Exista @\r\n- @ al principio o final\r\n- Más de una @\r\n- Exista un punto\r\n- Punto " +
    "despues de la @\r\n- Dominio de 2 a 4 caracteres";
            // 
            // Form09ValidarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btncomprobar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form09ValidarMail";
            this.Text = "Form09ValidarMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btncomprobar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label label2;
    }
}