namespace ProyectoFinal_Factoria.Principales
{
    partial class Login
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label contraseñaLabel;
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.IniciarSesionbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            nombreLabel.Location = new System.Drawing.Point(68, 84);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(68, 19);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.BackColor = System.Drawing.Color.Transparent;
            contraseñaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseñaLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            contraseñaLabel.Location = new System.Drawing.Point(46, 143);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(91, 19);
            contraseñaLabel.TabIndex = 5;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(150, 81);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(232, 26);
            this.nombreTextBox.TabIndex = 4;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTextBox.Location = new System.Drawing.Point(151, 140);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(202, 26);
            this.contraseñaTextBox.TabIndex = 6;
            // 
            // IniciarSesionbutton
            // 
            this.IniciarSesionbutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IniciarSesionbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarSesionbutton.FlatAppearance.BorderSize = 0;
            this.IniciarSesionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IniciarSesionbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesionbutton.Image = global::ProyectoFinal_Factoria.Properties.Resources.FlechaDerecha25x25;
            this.IniciarSesionbutton.Location = new System.Drawing.Point(352, 140);
            this.IniciarSesionbutton.Name = "IniciarSesionbutton";
            this.IniciarSesionbutton.Size = new System.Drawing.Size(30, 26);
            this.IniciarSesionbutton.TabIndex = 7;
            this.IniciarSesionbutton.UseVisualStyleBackColor = false;
            this.IniciarSesionbutton.Click += new System.EventHandler(this.IniciarSesionbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(107, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Proyecto Final - Factoria";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ProyectoFinal_Factoria.Properties.Resources.slide_311423_2767019_free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IniciarSesionbutton);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.Button IniciarSesionbutton;
        private System.Windows.Forms.Label label1;
    }
}