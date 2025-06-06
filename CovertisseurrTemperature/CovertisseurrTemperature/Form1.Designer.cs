namespace CovertisseurrTemperature
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContenu = new Panel();
            txbTemperatureFahrenheit = new TextBox();
            lblTypeFahrenheit = new Label();
            cbbTypeEntree = new ComboBox();
            lblTypeEntree = new Label();
            btnConvertir = new Button();
            txbTemperatureCelcius = new TextBox();
            lblTemperatureCelcius = new Label();
            txbTemperatureEntree = new TextBox();
            lblTemperatureEntree = new Label();
            lblTitreFenetre = new Label();
            pnlTitre = new Panel();
            pnlContenu.SuspendLayout();
            pnlTitre.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenu
            // 
            pnlContenu.BorderStyle = BorderStyle.FixedSingle;
            pnlContenu.Controls.Add(txbTemperatureFahrenheit);
            pnlContenu.Controls.Add(lblTypeFahrenheit);
            pnlContenu.Controls.Add(cbbTypeEntree);
            pnlContenu.Controls.Add(lblTypeEntree);
            pnlContenu.Controls.Add(btnConvertir);
            pnlContenu.Controls.Add(txbTemperatureCelcius);
            pnlContenu.Controls.Add(lblTemperatureCelcius);
            pnlContenu.Controls.Add(txbTemperatureEntree);
            pnlContenu.Controls.Add(lblTemperatureEntree);
            pnlContenu.Location = new Point(56, 83);
            pnlContenu.Name = "pnlContenu";
            pnlContenu.Size = new Size(679, 355);
            pnlContenu.TabIndex = 0;
            pnlContenu.Paint += pnlContenu_Paint;
            // 
            // txbTemperatureFahrenheit
            // 
            txbTemperatureFahrenheit.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTemperatureFahrenheit.Location = new Point(381, 289);
            txbTemperatureFahrenheit.Name = "txbTemperatureFahrenheit";
            txbTemperatureFahrenheit.ReadOnly = true;
            txbTemperatureFahrenheit.Size = new Size(233, 40);
            txbTemperatureFahrenheit.TabIndex = 8;
            txbTemperatureFahrenheit.TextChanged += txbTemperatureFahrenheit_TextChanged;
            // 
            // lblTypeFahrenheit
            // 
            lblTypeFahrenheit.AutoSize = true;
            lblTypeFahrenheit.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTypeFahrenheit.Location = new Point(54, 295);
            lblTypeFahrenheit.Name = "lblTypeFahrenheit";
            lblTypeFahrenheit.Size = new Size(317, 34);
            lblTypeFahrenheit.TabIndex = 7;
            lblTypeFahrenheit.Text = "Température Fahrenheit";
            // 
            // cbbTypeEntree
            // 
            cbbTypeEntree.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTypeEntree.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbTypeEntree.FormattingEnabled = true;
            cbbTypeEntree.Items.AddRange(new object[] { "Celcius", "Fahrenheit" });
            cbbTypeEntree.Location = new Point(381, 76);
            cbbTypeEntree.Name = "cbbTypeEntree";
            cbbTypeEntree.Size = new Size(233, 41);
            cbbTypeEntree.TabIndex = 6;
            cbbTypeEntree.SelectedIndexChanged += cbbTypeEntree_SelectedIndexChanged;
            // 
            // lblTypeEntree
            // 
            lblTypeEntree.AutoSize = true;
            lblTypeEntree.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTypeEntree.Location = new Point(294, 79);
            lblTypeEntree.Name = "lblTypeEntree";
            lblTypeEntree.Size = new Size(75, 34);
            lblTypeEntree.TabIndex = 5;
            lblTypeEntree.Text = "Type";
            lblTypeEntree.Click += lblTypeEntree_Click;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = SystemColors.MenuHighlight;
            btnConvertir.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir.Location = new Point(54, 142);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(563, 59);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "CONVERTIR";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txbTemperatureCelcius
            // 
            txbTemperatureCelcius.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTemperatureCelcius.Location = new Point(381, 230);
            txbTemperatureCelcius.Name = "txbTemperatureCelcius";
            txbTemperatureCelcius.ReadOnly = true;
            txbTemperatureCelcius.Size = new Size(233, 40);
            txbTemperatureCelcius.TabIndex = 3;
            txbTemperatureCelcius.TextChanged += txbTemperatureCelcius_TextChanged;
            // 
            // lblTemperatureCelcius
            // 
            lblTemperatureCelcius.AutoSize = true;
            lblTemperatureCelcius.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemperatureCelcius.Location = new Point(101, 236);
            lblTemperatureCelcius.Name = "lblTemperatureCelcius";
            lblTemperatureCelcius.Size = new Size(270, 34);
            lblTemperatureCelcius.TabIndex = 2;
            lblTemperatureCelcius.Text = "Température Celcius";
            // 
            // txbTemperatureEntree
            // 
            txbTemperatureEntree.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTemperatureEntree.Location = new Point(381, 17);
            txbTemperatureEntree.Name = "txbTemperatureEntree";
            txbTemperatureEntree.Size = new Size(233, 40);
            txbTemperatureEntree.TabIndex = 1;
            txbTemperatureEntree.TextChanged += txbTemperatureEntree_TextChanged;
            // 
            // lblTemperatureEntree
            // 
            lblTemperatureEntree.AutoSize = true;
            lblTemperatureEntree.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemperatureEntree.Location = new Point(196, 19);
            lblTemperatureEntree.Name = "lblTemperatureEntree";
            lblTemperatureEntree.Size = new Size(175, 34);
            lblTemperatureEntree.TabIndex = 0;
            lblTemperatureEntree.Text = "Température";
            lblTemperatureEntree.Click += lblTemperatureEntree_Click;
            // 
            // lblTitreFenetre
            // 
            lblTitreFenetre.AutoSize = true;
            lblTitreFenetre.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitreFenetre.Location = new Point(59, 8);
            lblTitreFenetre.Name = "lblTitreFenetre";
            lblTitreFenetre.Size = new Size(557, 36);
            lblTitreFenetre.TabIndex = 1;
            lblTitreFenetre.Text = "CONVERTISSEUR DE TEMPÉRATURE";
            lblTitreFenetre.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlTitre
            // 
            pnlTitre.BorderStyle = BorderStyle.FixedSingle;
            pnlTitre.Controls.Add(lblTitreFenetre);
            pnlTitre.Location = new Point(57, 18);
            pnlTitre.Name = "pnlTitre";
            pnlTitre.Size = new Size(679, 55);
            pnlTitre.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(pnlTitre);
            Controls.Add(pnlContenu);
            Name = "Form1";
            Text = "ConvertisseurTemperature";
            Load += Form1_Load;
            pnlContenu.ResumeLayout(false);
            pnlContenu.PerformLayout();
            pnlTitre.ResumeLayout(false);
            pnlTitre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenu;
        private Label lblTitreFenetre;
        private Label lblTemperatureEntree;
        private TextBox txbTemperatureEntree;
        private Button btnConvertir;
        private TextBox txbTemperatureCelcius;
        private Label lblTemperatureCelcius;
        private Panel pnlTitre;
        private Label lblTypeEntree;
        private ComboBox cbbTypeEntree;
        private TextBox txbTemperatureFahrenheit;
        private Label lblTypeFahrenheit;
    }
}
