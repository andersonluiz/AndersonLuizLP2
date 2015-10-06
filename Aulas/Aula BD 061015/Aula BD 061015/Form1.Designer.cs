namespace Aula_BD_061015
{
    partial class Form1
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtOpção2 = new System.Windows.Forms.TextBox();
            this.txtOpção1 = new System.Windows.Forms.TextBox();
            this.txtOpção3 = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(139, 230);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 30);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(282, 164);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 13);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Opção 3";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(151, 164);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 13);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Opção 2";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(28, 164);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 13);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Opção 1 ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(130, 105);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(118, 13);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Opções para presente :";
            // 
            // txtOpção2
            // 
            this.txtOpção2.Location = new System.Drawing.Point(133, 194);
            this.txtOpção2.Name = "txtOpção2";
            this.txtOpção2.Size = new System.Drawing.Size(100, 20);
            this.txtOpção2.TabIndex = 18;
            // 
            // txtOpção1
            // 
            this.txtOpção1.Location = new System.Drawing.Point(12, 194);
            this.txtOpção1.Name = "txtOpção1";
            this.txtOpção1.Size = new System.Drawing.Size(100, 20);
            this.txtOpção1.TabIndex = 17;
            // 
            // txtOpção3
            // 
            this.txtOpção3.Location = new System.Drawing.Point(267, 194);
            this.txtOpção3.Name = "txtOpção3";
            this.txtOpção3.Size = new System.Drawing.Size(100, 20);
            this.txtOpção3.TabIndex = 16;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(77, 43);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 14;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 46);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 13);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Sobrenome :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Nome :";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(154, 266);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(60, 31);
            this.btnStatus.TabIndex = 25;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 297);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtOpção2);
            this.Controls.Add(this.txtOpção1);
            this.Controls.Add(this.txtOpção3);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnRegistrar;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtOpção2;
        internal System.Windows.Forms.TextBox txtOpção1;
        internal System.Windows.Forms.TextBox txtOpção3;
        internal System.Windows.Forms.TextBox txtSobrenome;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnStatus;
    }
}

