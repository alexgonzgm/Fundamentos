
namespace Fundamentos
{
    partial class Form12StringBuilder
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
            this.lbltiempo = new System.Windows.Forms.Label();
            this.btnreversestring = new System.Windows.Forms.Button();
            this.btnreversestringbuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(21, 57);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(531, 342);
            this.txttexto.TabIndex = 1;
            this.txttexto.Text = "";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.ForeColor = System.Drawing.Color.Red;
            this.lbltiempo.Location = new System.Drawing.Point(15, 418);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(122, 31);
            this.lbltiempo.TabIndex = 2;
            this.lbltiempo.Text = "lbltiempo";
            // 
            // btnreversestring
            // 
            this.btnreversestring.Location = new System.Drawing.Point(586, 57);
            this.btnreversestring.Name = "btnreversestring";
            this.btnreversestring.Size = new System.Drawing.Size(197, 71);
            this.btnreversestring.TabIndex = 3;
            this.btnreversestring.Text = "Reverse String";
            this.btnreversestring.UseVisualStyleBackColor = true;
            this.btnreversestring.Click += new System.EventHandler(this.btnreversestring_Click);
            // 
            // btnreversestringbuilder
            // 
            this.btnreversestringbuilder.Location = new System.Drawing.Point(586, 157);
            this.btnreversestringbuilder.Name = "btnreversestringbuilder";
            this.btnreversestringbuilder.Size = new System.Drawing.Size(197, 79);
            this.btnreversestringbuilder.TabIndex = 4;
            this.btnreversestringbuilder.Text = "Reverse StringBuilder";
            this.btnreversestringbuilder.UseVisualStyleBackColor = true;
            this.btnreversestringbuilder.Click += new System.EventHandler(this.btnreversestringbuilder_Click);
            // 
            // Form12StringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 477);
            this.Controls.Add(this.btnreversestringbuilder);
            this.Controls.Add(this.btnreversestring);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form12StringBuilder";
            this.Text = "Form12StringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txttexto;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Button btnreversestring;
        private System.Windows.Forms.Button btnreversestringbuilder;
    }
}