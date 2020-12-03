
namespace Fundamentos
{
    partial class Form24PruebaClases
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
            this.lstdatos = new System.Windows.Forms.ListBox();
            this.btncrearpersona = new System.Windows.Forms.Button();
            this.btncrearempleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos";
            // 
            // lstdatos
            // 
            this.lstdatos.FormattingEnabled = true;
            this.lstdatos.ItemHeight = 31;
            this.lstdatos.Location = new System.Drawing.Point(29, 48);
            this.lstdatos.Name = "lstdatos";
            this.lstdatos.Size = new System.Drawing.Size(509, 345);
            this.lstdatos.TabIndex = 1;
            // 
            // btncrearpersona
            // 
            this.btncrearpersona.Location = new System.Drawing.Point(556, 48);
            this.btncrearpersona.Name = "btncrearpersona";
            this.btncrearpersona.Size = new System.Drawing.Size(172, 77);
            this.btncrearpersona.TabIndex = 2;
            this.btncrearpersona.Text = "Crear Persona";
            this.btncrearpersona.UseVisualStyleBackColor = true;
            this.btncrearpersona.Click += new System.EventHandler(this.btncrearpersona_Click);
            // 
            // btncrearempleado
            // 
            this.btncrearempleado.Location = new System.Drawing.Point(556, 145);
            this.btncrearempleado.Name = "btncrearempleado";
            this.btncrearempleado.Size = new System.Drawing.Size(172, 75);
            this.btncrearempleado.TabIndex = 3;
            this.btncrearempleado.Text = "Crear Empleado";
            this.btncrearempleado.UseVisualStyleBackColor = true;
            this.btncrearempleado.Click += new System.EventHandler(this.btncrearempleado_Click);
            // 
            // Form24PruebaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 419);
            this.Controls.Add(this.btncrearempleado);
            this.Controls.Add(this.btncrearpersona);
            this.Controls.Add(this.lstdatos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form24PruebaClases";
            this.Text = "Form24PruebaClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstdatos;
        private System.Windows.Forms.Button btncrearpersona;
        private System.Windows.Forms.Button btncrearempleado;
    }
}