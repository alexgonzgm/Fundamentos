
namespace Fundamentos
{
    partial class Form25ClasesMeses
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
            this.lstmeses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaxima = new System.Windows.Forms.TextBox();
            this.txtminima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btngenerardatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meses";
            // 
            // lstmeses
            // 
            this.lstmeses.FormattingEnabled = true;
            this.lstmeses.ItemHeight = 31;
            this.lstmeses.Location = new System.Drawing.Point(34, 56);
            this.lstmeses.Name = "lstmeses";
            this.lstmeses.Size = new System.Drawing.Size(174, 345);
            this.lstmeses.TabIndex = 1;
            this.lstmeses.SelectedIndexChanged += new System.EventHandler(this.lstmeses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(283, 56);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(238, 38);
            this.txtnombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Máxima";
            // 
            // txtmaxima
            // 
            this.txtmaxima.ForeColor = System.Drawing.Color.Blue;
            this.txtmaxima.Location = new System.Drawing.Point(337, 139);
            this.txtmaxima.Name = "txtmaxima";
            this.txtmaxima.Size = new System.Drawing.Size(100, 38);
            this.txtmaxima.TabIndex = 5;
            this.txtmaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtminima
            // 
            this.txtminima.ForeColor = System.Drawing.Color.Blue;
            this.txtminima.Location = new System.Drawing.Point(337, 226);
            this.txtminima.Name = "txtminima";
            this.txtminima.Size = new System.Drawing.Size(100, 38);
            this.txtminima.TabIndex = 7;
            this.txtminima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(331, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mínima";
            // 
            // txtmedia
            // 
            this.txtmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedia.ForeColor = System.Drawing.Color.Green;
            this.txtmedia.Location = new System.Drawing.Point(337, 313);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(100, 38);
            this.txtmedia.TabIndex = 9;
            this.txtmedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Media";
            // 
            // btngenerardatos
            // 
            this.btngenerardatos.Location = new System.Drawing.Point(283, 377);
            this.btngenerardatos.Name = "btngenerardatos";
            this.btngenerardatos.Size = new System.Drawing.Size(212, 49);
            this.btngenerardatos.TabIndex = 10;
            this.btngenerardatos.Text = "Generar datos";
            this.btngenerardatos.UseVisualStyleBackColor = true;
            this.btngenerardatos.Click += new System.EventHandler(this.btngenerardatos_Click);
            // 
            // Form25ClasesMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 438);
            this.Controls.Add(this.btngenerardatos);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtminima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmaxima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstmeses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form25ClasesMeses";
            this.Text = "Form25ClasesMeses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstmeses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaxima;
        private System.Windows.Forms.TextBox txtminima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btngenerardatos;
    }
}