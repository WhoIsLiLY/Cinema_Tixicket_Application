namespace Celikoor_Tixycket
{
    partial class FormTransaksiMenu
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
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownQtyBeverage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQtyFood = new System.Windows.Forms.NumericUpDown();
            this.labelNominalTotalBeverage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalNominalFood = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBeverage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.labelDurasi = new System.Windows.Forms.Label();
            this.buttonTambahGenre = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.labelSisaKursi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtyBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtyFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AllowUserToAddRows = false;
            this.dataGridViewMenu.AllowUserToDeleteRows = false;
            this.dataGridViewMenu.AllowUserToResizeColumns = false;
            this.dataGridViewMenu.AllowUserToResizeRows = false;
            this.dataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu,
            this.quantity,
            this.totalPrice});
            this.dataGridViewMenu.Location = new System.Drawing.Point(12, 280);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.ReadOnly = true;
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(773, 215);
            this.dataGridViewMenu.TabIndex = 48;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // menu
            // 
            this.menu.HeaderText = "menu name";
            this.menu.MinimumWidth = 6;
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 50F;
            this.quantity.HeaderText = "quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "total price";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.NavajoWhite;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(292, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(186, 28);
            this.label.TabIndex = 55;
            this.label.Text = "Ordered Item";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.numericUpDownQtyBeverage);
            this.panel2.Controls.Add(this.numericUpDownQtyFood);
            this.panel2.Controls.Add(this.labelNominalTotalBeverage);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelTotalNominalFood);
            this.panel2.Controls.Add(this.labelMenu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxBeverage);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxFood);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.labelDurasi);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 218);
            this.panel2.TabIndex = 56;
            // 
            // numericUpDownQtyBeverage
            // 
            this.numericUpDownQtyBeverage.Location = new System.Drawing.Point(495, 125);
            this.numericUpDownQtyBeverage.Name = "numericUpDownQtyBeverage";
            this.numericUpDownQtyBeverage.Size = new System.Drawing.Size(94, 22);
            this.numericUpDownQtyBeverage.TabIndex = 141;
            this.numericUpDownQtyBeverage.ValueChanged += new System.EventHandler(this.numericUpDownQtyBeverage_ValueChanged);
            // 
            // numericUpDownQtyFood
            // 
            this.numericUpDownQtyFood.Location = new System.Drawing.Point(122, 125);
            this.numericUpDownQtyFood.Name = "numericUpDownQtyFood";
            this.numericUpDownQtyFood.Size = new System.Drawing.Size(94, 22);
            this.numericUpDownQtyFood.TabIndex = 140;
            this.numericUpDownQtyFood.ValueChanged += new System.EventHandler(this.numericUpDownQtyFood_ValueChanged);
            // 
            // labelNominalTotalBeverage
            // 
            this.labelNominalTotalBeverage.AutoSize = true;
            this.labelNominalTotalBeverage.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelNominalTotalBeverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNominalTotalBeverage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNominalTotalBeverage.ForeColor = System.Drawing.Color.Black;
            this.labelNominalTotalBeverage.Location = new System.Drawing.Point(588, 166);
            this.labelNominalTotalBeverage.Name = "labelNominalTotalBeverage";
            this.labelNominalTotalBeverage.Size = new System.Drawing.Size(21, 20);
            this.labelNominalTotalBeverage.TabIndex = 139;
            this.labelNominalTotalBeverage.Text = "0";
            this.labelNominalTotalBeverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(388, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 138;
            this.label5.Text = "Beverage Price: Rp.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalNominalFood
            // 
            this.labelTotalNominalFood.AutoSize = true;
            this.labelTotalNominalFood.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelTotalNominalFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalNominalFood.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalNominalFood.ForeColor = System.Drawing.Color.Black;
            this.labelTotalNominalFood.Location = new System.Drawing.Point(189, 166);
            this.labelTotalNominalFood.Name = "labelTotalNominalFood";
            this.labelTotalNominalFood.Size = new System.Drawing.Size(21, 20);
            this.labelTotalNominalFood.TabIndex = 137;
            this.labelTotalNominalFood.Text = "0";
            this.labelTotalNominalFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMenu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(30, 166);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(153, 20);
            this.labelMenu.TabIndex = 136;
            this.labelMenu.Text = "Food Price: Rp.";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(389, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 133;
            this.label3.Text = "Quantity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 131;
            this.label2.Text = "Quantity:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxBeverage
            // 
            this.comboBoxBeverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBeverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBeverage.FormattingEnabled = true;
            this.comboBoxBeverage.Location = new System.Drawing.Point(495, 75);
            this.comboBoxBeverage.Name = "comboBoxBeverage";
            this.comboBoxBeverage.Size = new System.Drawing.Size(239, 26);
            this.comboBoxBeverage.TabIndex = 61;
            this.comboBoxBeverage.SelectedIndexChanged += new System.EventHandler(this.comboBoxBeverage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(388, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Beverages:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(122, 75);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(239, 26);
            this.comboBoxFood.TabIndex = 59;
            this.comboBoxFood.SelectedIndexChanged += new System.EventHandler(this.comboBoxFood_SelectedIndexChanged);
            // 
            // labelDurasi
            // 
            this.labelDurasi.AutoSize = true;
            this.labelDurasi.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelDurasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDurasi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurasi.ForeColor = System.Drawing.Color.Black;
            this.labelDurasi.Location = new System.Drawing.Point(58, 78);
            this.labelDurasi.Name = "labelDurasi";
            this.labelDurasi.Size = new System.Drawing.Size(54, 18);
            this.labelDurasi.TabIndex = 54;
            this.labelDurasi.Text = "Food:";
            this.labelDurasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTambahGenre
            // 
            this.buttonTambahGenre.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonTambahGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahGenre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahGenre.ForeColor = System.Drawing.Color.White;
            this.buttonTambahGenre.Location = new System.Drawing.Point(13, 237);
            this.buttonTambahGenre.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambahGenre.Name = "buttonTambahGenre";
            this.buttonTambahGenre.Size = new System.Drawing.Size(215, 36);
            this.buttonTambahGenre.TabIndex = 130;
            this.buttonTambahGenre.Text = "ADD";
            this.buttonTambahGenre.UseVisualStyleBackColor = false;
            this.buttonTambahGenre.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(12, 501);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(143, 39);
            this.buttonKeluar.TabIndex = 58;
            this.buttonKeluar.Text = "&CLOSE";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(637, 501);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(148, 39);
            this.buttonSimpan.TabIndex = 57;
            this.buttonSimpan.Text = "&SAVE";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // labelSisaKursi
            // 
            this.labelSisaKursi.AutoSize = true;
            this.labelSisaKursi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(66)))));
            this.labelSisaKursi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSisaKursi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSisaKursi.ForeColor = System.Drawing.Color.Red;
            this.labelSisaKursi.Location = new System.Drawing.Point(382, 237);
            this.labelSisaKursi.Name = "labelSisaKursi";
            this.labelSisaKursi.Size = new System.Drawing.Size(403, 18);
            this.labelSisaKursi.TabIndex = 131;
            this.labelSisaKursi.Text = "(Make the quantity 0 if you don\'t want to order)";
            this.labelSisaKursi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTransaksiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(797, 551);
            this.Controls.Add(this.labelSisaKursi);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonTambahGenre);
            this.Name = "FormTransaksiMenu";
            this.Text = "FormTransaksiMenu";
            this.Load += new System.EventHandler(this.FormTransaksiMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtyBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtyFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDurasi;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.ComboBox comboBoxBeverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTambahGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQtyBeverage;
        private System.Windows.Forms.NumericUpDown numericUpDownQtyFood;
        private System.Windows.Forms.Label labelNominalTotalBeverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalNominalFood;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelSisaKursi;
    }
}