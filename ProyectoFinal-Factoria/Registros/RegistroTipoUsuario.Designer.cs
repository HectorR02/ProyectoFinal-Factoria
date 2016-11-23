namespace ProyectoFinal_Factoria.Registros
{
    partial class RegistroTipoUsuario
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
            System.Windows.Forms.Label tipoUsuarioIdLabel;
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tipoUsuarioIdTextBox = new System.Windows.Forms.TextBox();
            nombreLabel = new System.Windows.Forms.Label();
            tipoUsuarioIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            nombreLabel.Location = new System.Drawing.Point(19, 83);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(63, 19);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre";
            // 
            // tipoUsuarioIdLabel
            // 
            tipoUsuarioIdLabel.AutoSize = true;
            tipoUsuarioIdLabel.BackColor = System.Drawing.Color.Transparent;
            tipoUsuarioIdLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoUsuarioIdLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            tipoUsuarioIdLabel.Location = new System.Drawing.Point(59, 35);
            tipoUsuarioIdLabel.Name = "tipoUsuarioIdLabel";
            tipoUsuarioIdLabel.Size = new System.Drawing.Size(23, 19);
            tipoUsuarioIdLabel.TabIndex = 6;
            tipoUsuarioIdLabel.Text = "Id";
            // 
            // BuscarButton
            // 
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = global::ProyectoFinal_Factoria.Properties.Resources.BotonBusqueda;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(325, 20);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(118, 45);
            this.BuscarButton.TabIndex = 0;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.FlatAppearance.BorderSize = 0;
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::ProyectoFinal_Factoria.Properties.Resources.BotonAñadir;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(23, 137);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(117, 50);
            this.NuevoButton.TabIndex = 1;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.FlatAppearance.BorderSize = 0;
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::ProyectoFinal_Factoria.Properties.Resources.BotonGuardar1;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(160, 137);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(129, 50);
            this.GuardarButton.TabIndex = 2;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.FlatAppearance.BorderSize = 0;
            this.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::ProyectoFinal_Factoria.Properties.Resources.BotonCancelar1;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(313, 137);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(130, 50);
            this.EliminarButton.TabIndex = 3;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(88, 82);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(355, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // tipoUsuarioIdTextBox
            // 
            this.tipoUsuarioIdTextBox.Location = new System.Drawing.Point(88, 34);
            this.tipoUsuarioIdTextBox.Name = "tipoUsuarioIdTextBox";
            this.tipoUsuarioIdTextBox.Size = new System.Drawing.Size(213, 20);
            this.tipoUsuarioIdTextBox.TabIndex = 7;
            // 
            // RegistroTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_Factoria.Properties.Resources.cacao_3_318x212;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 207);
            this.Controls.Add(tipoUsuarioIdLabel);
            this.Controls.Add(this.tipoUsuarioIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Name = "RegistroTipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroTipoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox tipoUsuarioIdTextBox;
    }
}