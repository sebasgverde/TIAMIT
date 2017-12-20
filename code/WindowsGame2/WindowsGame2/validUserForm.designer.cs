namespace Vista
{
    partial class validUserForm
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
            this.ingresar = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usu = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingresar
            // 
            this.ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.Location = new System.Drawing.Point(103, 450);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(89, 35);
            this.ingresar.TabIndex = 0;
            this.ingresar.Text = "Log in";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // registro
            // 
            this.registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Location = new System.Drawing.Point(270, 439);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(103, 57);
            this.registro.TabIndex = 1;
            this.registro.Text = "Create Account";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(455, 450);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(87, 35);
            this.salir.TabIndex = 2;
            this.salir.Text = "Close";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(100, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // usu
            // 
            this.usu.Location = new System.Drawing.Point(103, 259);
            this.usu.Multiline = true;
            this.usu.Name = "usu";
            this.usu.Size = new System.Drawing.Size(119, 21);
            this.usu.TabIndex = 5;
            this.usu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(103, 365);
            this.pwd.Multiline = true;
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(119, 21);
            this.pwd.TabIndex = 6;
            this.pwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pristina", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(227, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 126);
            this.label3.TabIndex = 7;
            this.label3.Text = "TIAMIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(290, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 73);
            this.label4.TabIndex = 8;
            this.label4.Text = "Welcome";
            // 
            // validUsurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.usu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.ingresar);
            this.Name = "validUsurForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIAMIT - Login, Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Button registro;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usu;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}