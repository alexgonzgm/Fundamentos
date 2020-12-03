
namespace Fundamentos
{
    partial class Form15ColeccionNumerosListBox
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
            this.lstnumeros = new System.Windows.Forms.ListBox();
            this.btngenerarnumeros = new System.Windows.Forms.Button();
            this.btnmostrardatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpares = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtimpares = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números";
            // 
            // lstnumeros
            // 
            this.lstnumeros.FormattingEnabled = true;
            this.lstnumeros.ItemHeight = 31;
            this.lstnumeros.Items.AddRange(new object[] {
            "14",
            "18",
            "22",
            "25",
            "33",
            "8",
            "7",
            "66",
            "55",
            "44"});
            this.lstnumeros.Location = new System.Drawing.Point(36, 71);
            this.lstnumeros.Name = "lstnumeros";
            this.lstnumeros.Size = new System.Drawing.Size(231, 345);
            this.lstnumeros.TabIndex = 1;
            // 
            // btngenerarnumeros
            // 
            this.btngenerarnumeros.Location = new System.Drawing.Point(344, 25);
            this.btngenerarnumeros.Name = "btngenerarnumeros";
            this.btngenerarnumeros.Size = new System.Drawing.Size(222, 63);
            this.btngenerarnumeros.TabIndex = 2;
            this.btngenerarnumeros.Text = "Generar";
            this.btngenerarnumeros.UseVisualStyleBackColor = true;
            this.btngenerarnumeros.Click += new System.EventHandler(this.btngenerarnumeros_Click);
            // 
            // btnmostrardatos
            // 
            this.btnmostrardatos.Location = new System.Drawing.Point(344, 112);
            this.btnmostrardatos.Name = "btnmostrardatos";
            this.btnmostrardatos.Size = new System.Drawing.Size(222, 70);
            this.btnmostrardatos.TabIndex = 3;
            this.btnmostrardatos.Text = "Mostrar datos";
            this.btnmostrardatos.UseVisualStyleBackColor = true;
            this.btnmostrardatos.Click += new System.EventHandler(this.btnmostrardatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma";
            // 
            // txtsuma
            // 
            this.txtsuma.Location = new System.Drawing.Point(457, 230);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.Size = new System.Drawing.Size(100, 38);
            this.txtsuma.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pares";
            // 
            // txtpares
            // 
            this.txtpares.Location = new System.Drawing.Point(457, 287);
            this.txtpares.Name = "txtpares";
            this.txtpares.Size = new System.Drawing.Size(100, 38);
            this.txtpares.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Impares";
            // 
            // txtimpares
            // 
            this.txtimpares.Location = new System.Drawing.Point(457, 347);
            this.txtimpares.Name = "txtimpares";
            this.txtimpares.Size = new System.Drawing.Size(100, 38);
            this.txtimpares.TabIndex = 9;
            // 
            // Form15ColeccionNumerosListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 435);
            this.Controls.Add(this.txtimpares);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmostrardatos);
            this.Controls.Add(this.btngenerarnumeros);
            this.Controls.Add(this.lstnumeros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form15ColeccionNumerosListBox";
            this.Text = "Form15ColeccionNumerosListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstnumeros;
        private System.Windows.Forms.Button btngenerarnumeros;
        private System.Windows.Forms.Button btnmostrardatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtimpares;
    }
}