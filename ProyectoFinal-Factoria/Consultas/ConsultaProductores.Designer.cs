namespace ProyectoFinal_Factoria.Consultas
{
    partial class ConsultaProductores
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
            this.FactoriasComboBox = new System.Windows.Forms.ComboBox();
            this.Factorias = new System.Windows.Forms.Label();
            this.ProductoresDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FactoriasComboBox
            // 
            this.FactoriasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FactoriasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactoriasComboBox.FormattingEnabled = true;
            this.FactoriasComboBox.Location = new System.Drawing.Point(144, 38);
            this.FactoriasComboBox.Name = "FactoriasComboBox";
            this.FactoriasComboBox.Size = new System.Drawing.Size(262, 32);
            this.FactoriasComboBox.TabIndex = 0;
            // 
            // Factorias
            // 
            this.Factorias.AutoSize = true;
            this.Factorias.BackColor = System.Drawing.Color.Transparent;
            this.Factorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Factorias.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factorias.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Factorias.Location = new System.Drawing.Point(29, 39);
            this.Factorias.Name = "Factorias";
            this.Factorias.Size = new System.Drawing.Size(109, 26);
            this.Factorias.TabIndex = 1;
            this.Factorias.Text = "Factorias";
            // 
            // ProductoresDataGridView
            // 
            this.ProductoresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoresDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductoresDataGridView.Location = new System.Drawing.Point(34, 92);
            this.ProductoresDataGridView.Name = "ProductoresDataGridView";
            this.ProductoresDataGridView.Size = new System.Drawing.Size(508, 189);
            this.ProductoresDataGridView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ProyectoFinal_Factoria.Properties.Resources.BotonBusqueda;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(423, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaProductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_Factoria.Properties.Resources.paraConsultas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductoresDataGridView);
            this.Controls.Add(this.Factorias);
            this.Controls.Add(this.FactoriasComboBox);
            this.Name = "ConsultaProductores";
            this.Text = "Consulta de Productores";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FactoriasComboBox;
        private System.Windows.Forms.Label Factorias;
        private System.Windows.Forms.DataGridView ProductoresDataGridView;
        private System.Windows.Forms.Button button1;
    }
}