﻿namespace Fundamentos
{
    partial class SerializarColeccion
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
            this.lstproductos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguardarproductos = new System.Windows.Forms.Button();
            this.btnleerproductos = new System.Windows.Forms.Button();
            this.btninsertarproducto = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstproductos
            // 
            this.lstproductos.FormattingEnabled = true;
            this.lstproductos.Location = new System.Drawing.Point(489, 104);
            this.lstproductos.Name = "lstproductos";
            this.lstproductos.Size = new System.Drawing.Size(280, 277);
            this.lstproductos.TabIndex = 17;
            this.lstproductos.SelectedIndexChanged += new System.EventHandler(this.lstproductos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Productos";
            // 
            // btnguardarproductos
            // 
            this.btnguardarproductos.Location = new System.Drawing.Point(250, 267);
            this.btnguardarproductos.Name = "btnguardarproductos";
            this.btnguardarproductos.Size = new System.Drawing.Size(197, 77);
            this.btnguardarproductos.TabIndex = 15;
            this.btnguardarproductos.Text = "Guardar productos";
            this.btnguardarproductos.UseVisualStyleBackColor = true;
            this.btnguardarproductos.Click += new System.EventHandler(this.btnguardarproductos_Click);
            // 
            // btnleerproductos
            // 
            this.btnleerproductos.Location = new System.Drawing.Point(250, 186);
            this.btnleerproductos.Name = "btnleerproductos";
            this.btnleerproductos.Size = new System.Drawing.Size(197, 75);
            this.btnleerproductos.TabIndex = 14;
            this.btnleerproductos.Text = "Leer productos";
            this.btnleerproductos.UseVisualStyleBackColor = true;
            this.btnleerproductos.Click += new System.EventHandler(this.btnleerproductos_Click);
            // 
            // btninsertarproducto
            // 
            this.btninsertarproducto.Location = new System.Drawing.Point(250, 83);
            this.btninsertarproducto.Name = "btninsertarproducto";
            this.btninsertarproducto.Size = new System.Drawing.Size(197, 85);
            this.btninsertarproducto.TabIndex = 13;
            this.btninsertarproducto.Text = "Insertar producto";
            this.btninsertarproducto.UseVisualStyleBackColor = true;
            this.btninsertarproducto.Click += new System.EventHandler(this.btninsertarproducto_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(37, 213);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio";
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(37, 118);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(159, 20);
            this.txtnombreproducto.TabIndex = 10;
            this.txtnombreproducto.TextChanged += new System.EventHandler(this.txtnombreproducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // SerializarColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstproductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnguardarproductos);
            this.Controls.Add(this.btnleerproductos);
            this.Controls.Add(this.btninsertarproducto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.label1);
            this.Name = "SerializarColeccion";
            this.Text = "SerializarColeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstproductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguardarproductos;
        private System.Windows.Forms.Button btnleerproductos;
        private System.Windows.Forms.Button btninsertarproducto;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.Label label1;
    }
}