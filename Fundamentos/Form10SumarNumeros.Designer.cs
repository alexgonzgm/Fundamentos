
namespace Fundamentos
{
    partial class Form10SumarNumeros
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
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.btnsumarnumeros = new System.Windows.Forms.Button();
            this.lblsuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números:";
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(187, 20);
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(214, 38);
            this.txtnumeros.TabIndex = 1;
            // 
            // btnsumarnumeros
            // 
            this.btnsumarnumeros.Location = new System.Drawing.Point(105, 80);
            this.btnsumarnumeros.Name = "btnsumarnumeros";
            this.btnsumarnumeros.Size = new System.Drawing.Size(228, 48);
            this.btnsumarnumeros.TabIndex = 2;
            this.btnsumarnumeros.Text = "Sumar números";
            this.btnsumarnumeros.UseVisualStyleBackColor = true;
            this.btnsumarnumeros.Click += new System.EventHandler(this.btnsumarnumeros_Click);
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.ForeColor = System.Drawing.Color.Blue;
            this.lblsuma.Location = new System.Drawing.Point(181, 161);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(107, 31);
            this.lblsuma.TabIndex = 3;
            this.lblsuma.Text = "lblsuma";
            // 
            // Form10SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 239);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.btnsumarnumeros);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form10SumarNumeros";
            this.Text = "Form10SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Button btnsumarnumeros;
        private System.Windows.Forms.Label lblsuma;
    }
}