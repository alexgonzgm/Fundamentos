
namespace Fundamentos
{
    partial class Form06DiaNacimientoSemana
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtanyo = new System.Windows.Forms.TextBox();
            this.btnmostrardia = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Día";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(147, 20);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(100, 35);
            this.txtdia.TabIndex = 3;
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(147, 77);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(100, 35);
            this.txtmes.TabIndex = 4;
            // 
            // txtanyo
            // 
            this.txtanyo.Location = new System.Drawing.Point(147, 133);
            this.txtanyo.Name = "txtanyo";
            this.txtanyo.Size = new System.Drawing.Size(100, 35);
            this.txtanyo.TabIndex = 5;
            // 
            // btnmostrardia
            // 
            this.btnmostrardia.Location = new System.Drawing.Point(303, 83);
            this.btnmostrardia.Name = "btnmostrardia";
            this.btnmostrardia.Size = new System.Drawing.Size(169, 55);
            this.btnmostrardia.TabIndex = 6;
            this.btnmostrardia.Text = "Mostrar día";
            this.btnmostrardia.UseVisualStyleBackColor = true;
            this.btnmostrardia.Click += new System.EventHandler(this.btnmostrardia_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblresultado.Location = new System.Drawing.Point(33, 203);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 29);
            this.lblresultado.TabIndex = 7;
            // 
            // Form06DiaNacimientoSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 259);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnmostrardia);
            this.Controls.Add(this.txtanyo);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form06DiaNacimientoSemana";
            this.Text = "Form05DiaNacimientoSemana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.TextBox txtanyo;
        private System.Windows.Forms.Button btnmostrardia;
        private System.Windows.Forms.Label lblresultado;
    }
}