
namespace Fundamentos
{
    partial class Form17MetodosEvento
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
            this.txtsolonumeros = new System.Windows.Forms.TextBox();
            this.txtsololetras = new System.Windows.Forms.TextBox();
            this.lblraton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sólo números:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sólo Letras:";
            // 
            // txtsolonumeros
            // 
            this.txtsolonumeros.Location = new System.Drawing.Point(238, 23);
            this.txtsolonumeros.Name = "txtsolonumeros";
            this.txtsolonumeros.Size = new System.Drawing.Size(252, 38);
            this.txtsolonumeros.TabIndex = 2;
            this.txtsolonumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsolonumeros_KeyPress);
            // 
            // txtsololetras
            // 
            this.txtsololetras.Location = new System.Drawing.Point(238, 96);
            this.txtsololetras.Name = "txtsololetras";
            this.txtsololetras.Size = new System.Drawing.Size(252, 38);
            this.txtsololetras.TabIndex = 3;
            this.txtsololetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsololetras_KeyPress);
            // 
            // lblraton
            // 
            this.lblraton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblraton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblraton.Location = new System.Drawing.Point(32, 185);
            this.lblraton.Name = "lblraton";
            this.lblraton.Size = new System.Drawing.Size(525, 266);
            this.lblraton.TabIndex = 4;
            this.lblraton.Text = "lblraton";
            this.lblraton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblraton.MouseHover += new System.EventHandler(this.lblraton_MouseHover);
            this.lblraton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblraton_MouseMove);
            // 
            // Form17MetodosEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 460);
            this.Controls.Add(this.lblraton);
            this.Controls.Add(this.txtsololetras);
            this.Controls.Add(this.txtsolonumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form17MetodosEvento";
            this.Text = "Form17MetodosEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsolonumeros;
        private System.Windows.Forms.TextBox txtsololetras;
        private System.Windows.Forms.Label lblraton;
    }
}