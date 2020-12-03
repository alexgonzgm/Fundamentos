
namespace Fundamentos
{
    partial class Form26FicherosPlanos
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
            this.txttexto = new System.Windows.Forms.RichTextBox();
            this.btnleerfichero = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lstnombres = new System.Windows.Forms.ListBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca un texto:";
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(38, 60);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(261, 232);
            this.txttexto.TabIndex = 1;
            this.txttexto.Text = "";
            // 
            // btnleerfichero
            // 
            this.btnleerfichero.Location = new System.Drawing.Point(318, 57);
            this.btnleerfichero.Name = "btnleerfichero";
            this.btnleerfichero.Size = new System.Drawing.Size(176, 61);
            this.btnleerfichero.TabIndex = 2;
            this.btnleerfichero.Text = "Leer fichero";
            this.btnleerfichero.UseVisualStyleBackColor = true;
            this.btnleerfichero.Click += new System.EventHandler(this.btnleerfichero_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(318, 144);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(176, 77);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar fichero";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(670, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(244, 38);
            this.txtnombre.TabIndex = 5;
            // 
            // lstnombres
            // 
            this.lstnombres.FormattingEnabled = true;
            this.lstnombres.ItemHeight = 31;
            this.lstnombres.Location = new System.Drawing.Point(670, 102);
            this.lstnombres.Name = "lstnombres";
            this.lstnombres.Size = new System.Drawing.Size(244, 252);
            this.lstnombres.TabIndex = 6;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(532, 42);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(117, 50);
            this.btnnuevo.TabIndex = 7;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // Form26FicherosPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 379);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.lstnombres);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnleerfichero);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form26FicherosPlanos";
            this.Text = "Form26FicherosPlanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txttexto;
        private System.Windows.Forms.Button btnleerfichero;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ListBox lstnombres;
        private System.Windows.Forms.Button btnnuevo;
    }
}