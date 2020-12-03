
namespace Fundamentos
{
    partial class Form07DateTime
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmostrarfecha = new System.Windows.Forms.Button();
            this.txtincremento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbanyos = new System.Windows.Forms.RadioButton();
            this.rdbmeses = new System.Windows.Forms.RadioButton();
            this.rdbdias = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfechaactual = new System.Windows.Forms.TextBox();
            this.chkformato = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnuevafecha = new System.Windows.Forms.TextBox();
            this.lbldatos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnmostrarfecha);
            this.groupBox1.Controls.Add(this.txtincremento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbanyos);
            this.groupBox1.Controls.Add(this.rdbmeses);
            this.groupBox1.Controls.Add(this.rdbdias);
            this.groupBox1.Location = new System.Drawing.Point(43, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones Fecha";
            // 
            // btnmostrarfecha
            // 
            this.btnmostrarfecha.Location = new System.Drawing.Point(289, 163);
            this.btnmostrarfecha.Name = "btnmostrarfecha";
            this.btnmostrarfecha.Size = new System.Drawing.Size(278, 55);
            this.btnmostrarfecha.TabIndex = 5;
            this.btnmostrarfecha.Text = "Mostrar fecha";
            this.btnmostrarfecha.UseVisualStyleBackColor = true;
            this.btnmostrarfecha.Click += new System.EventHandler(this.btnmostrarfecha_Click);
            // 
            // txtincremento
            // 
            this.txtincremento.Location = new System.Drawing.Point(289, 107);
            this.txtincremento.Name = "txtincremento";
            this.txtincremento.Size = new System.Drawing.Size(100, 38);
            this.txtincremento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Incremento";
            // 
            // rdbanyos
            // 
            this.rdbanyos.AutoSize = true;
            this.rdbanyos.Location = new System.Drawing.Point(44, 163);
            this.rdbanyos.Name = "rdbanyos";
            this.rdbanyos.Size = new System.Drawing.Size(94, 35);
            this.rdbanyos.TabIndex = 2;
            this.rdbanyos.TabStop = true;
            this.rdbanyos.Text = "Años";
            this.rdbanyos.UseVisualStyleBackColor = true;
            // 
            // rdbmeses
            // 
            this.rdbmeses.AutoSize = true;
            this.rdbmeses.Location = new System.Drawing.Point(44, 107);
            this.rdbmeses.Name = "rdbmeses";
            this.rdbmeses.Size = new System.Drawing.Size(112, 35);
            this.rdbmeses.TabIndex = 1;
            this.rdbmeses.TabStop = true;
            this.rdbmeses.Text = "Meses";
            this.rdbmeses.UseVisualStyleBackColor = true;
            // 
            // rdbdias
            // 
            this.rdbdias.AutoSize = true;
            this.rdbdias.Location = new System.Drawing.Point(44, 50);
            this.rdbdias.Name = "rdbdias";
            this.rdbdias.Size = new System.Drawing.Size(87, 35);
            this.rdbdias.TabIndex = 0;
            this.rdbdias.TabStop = true;
            this.rdbdias.Text = "Días";
            this.rdbdias.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Actual";
            // 
            // txtfechaactual
            // 
            this.txtfechaactual.Location = new System.Drawing.Point(43, 43);
            this.txtfechaactual.Name = "txtfechaactual";
            this.txtfechaactual.Size = new System.Drawing.Size(611, 38);
            this.txtfechaactual.TabIndex = 2;
            // 
            // chkformato
            // 
            this.chkformato.AutoSize = true;
            this.chkformato.Location = new System.Drawing.Point(43, 98);
            this.chkformato.Name = "chkformato";
            this.chkformato.Size = new System.Drawing.Size(243, 35);
            this.chkformato.TabIndex = 3;
            this.chkformato.Text = "Cambiar Formato";
            this.chkformato.UseVisualStyleBackColor = true;
            this.chkformato.CheckedChanged += new System.EventHandler(this.chkformato_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva fecha";
            // 
            // txtnuevafecha
            // 
            this.txtnuevafecha.Location = new System.Drawing.Point(43, 429);
            this.txtnuevafecha.Name = "txtnuevafecha";
            this.txtnuevafecha.Size = new System.Drawing.Size(515, 38);
            this.txtnuevafecha.TabIndex = 5;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.ForeColor = System.Drawing.Color.Red;
            this.lbldatos.Location = new System.Drawing.Point(37, 487);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(108, 31);
            this.lbldatos.TabIndex = 6;
            this.lbldatos.Text = "lbldatos";
            // 
            // Form07DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 553);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.txtnuevafecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkformato);
            this.Controls.Add(this.txtfechaactual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form07DateTime";
            this.Text = "Form07DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbmeses;
        private System.Windows.Forms.RadioButton rdbdias;
        private System.Windows.Forms.Button btnmostrarfecha;
        private System.Windows.Forms.TextBox txtincremento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbanyos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfechaactual;
        private System.Windows.Forms.CheckBox chkformato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnuevafecha;
        private System.Windows.Forms.Label lbldatos;
    }
}