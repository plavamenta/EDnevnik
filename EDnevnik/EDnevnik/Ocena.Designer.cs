﻿namespace EDnevnik
{
    partial class Ocena
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
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.cmb_profesor = new System.Windows.Forms.ComboBox();
            this.cmb_ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_ocena = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.lbl_godina = new System.Windows.Forms.Label();
            this.lbl_predmet = new System.Windows.Forms.Label();
            this.lbl_profesor = new System.Windows.Forms.Label();
            this.lbl_odeljenje = new System.Windows.Forms.Label();
            this.lbl_ucenik = new System.Windows.Forms.Label();
            this.lbl_ocena = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.grid_ocena = new System.Windows.Forms.DataGridView();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ocena)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(331, 70);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(121, 21);
            this.cmb_predmet.TabIndex = 0;
            this.cmb_predmet.SelectedValueChanged += new System.EventHandler(this.cmb_predmet_SelectedValueChanged);
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(39, 158);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(121, 21);
            this.cmb_odeljenje.TabIndex = 1;
            this.cmb_odeljenje.SelectedValueChanged += new System.EventHandler(this.cmb_odeljenje_SelectedValueChanged);
            // 
            // cmb_godina
            // 
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(39, 70);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(121, 21);
            this.cmb_godina.TabIndex = 2;
            this.cmb_godina.SelectedValueChanged += new System.EventHandler(this.cmb_godina_SelectedValueChanged);
            // 
            // cmb_profesor
            // 
            this.cmb_profesor.FormattingEnabled = true;
            this.cmb_profesor.Location = new System.Drawing.Point(185, 70);
            this.cmb_profesor.Name = "cmb_profesor";
            this.cmb_profesor.Size = new System.Drawing.Size(121, 21);
            this.cmb_profesor.TabIndex = 3;
            this.cmb_profesor.SelectedValueChanged += new System.EventHandler(this.cmb_profesor_SelectedValueChanged);
            // 
            // cmb_ucenik
            // 
            this.cmb_ucenik.FormattingEnabled = true;
            this.cmb_ucenik.Location = new System.Drawing.Point(185, 158);
            this.cmb_ucenik.Name = "cmb_ucenik";
            this.cmb_ucenik.Size = new System.Drawing.Size(121, 21);
            this.cmb_ucenik.TabIndex = 4;
            // 
            // cmb_ocena
            // 
            this.cmb_ocena.FormattingEnabled = true;
            this.cmb_ocena.Location = new System.Drawing.Point(331, 158);
            this.cmb_ocena.Name = "cmb_ocena";
            this.cmb_ocena.Size = new System.Drawing.Size(121, 21);
            this.cmb_ocena.TabIndex = 5;
            // 
            // Datum
            // 
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum.Location = new System.Drawing.Point(252, 233);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(200, 20);
            this.Datum.TabIndex = 6;
            // 
            // lbl_godina
            // 
            this.lbl_godina.AutoSize = true;
            this.lbl_godina.Location = new System.Drawing.Point(36, 42);
            this.lbl_godina.Name = "lbl_godina";
            this.lbl_godina.Size = new System.Drawing.Size(44, 13);
            this.lbl_godina.TabIndex = 7;
            this.lbl_godina.Text = "Godina:";
            // 
            // lbl_predmet
            // 
            this.lbl_predmet.AutoSize = true;
            this.lbl_predmet.Location = new System.Drawing.Point(328, 42);
            this.lbl_predmet.Name = "lbl_predmet";
            this.lbl_predmet.Size = new System.Drawing.Size(49, 13);
            this.lbl_predmet.TabIndex = 8;
            this.lbl_predmet.Text = "Predmet:";
            // 
            // lbl_profesor
            // 
            this.lbl_profesor.AutoSize = true;
            this.lbl_profesor.Location = new System.Drawing.Point(182, 42);
            this.lbl_profesor.Name = "lbl_profesor";
            this.lbl_profesor.Size = new System.Drawing.Size(49, 13);
            this.lbl_profesor.TabIndex = 9;
            this.lbl_profesor.Text = "Profesor:";
            // 
            // lbl_odeljenje
            // 
            this.lbl_odeljenje.AutoSize = true;
            this.lbl_odeljenje.Location = new System.Drawing.Point(36, 129);
            this.lbl_odeljenje.Name = "lbl_odeljenje";
            this.lbl_odeljenje.Size = new System.Drawing.Size(54, 13);
            this.lbl_odeljenje.TabIndex = 10;
            this.lbl_odeljenje.Text = "Odeljenje:";
            // 
            // lbl_ucenik
            // 
            this.lbl_ucenik.AutoSize = true;
            this.lbl_ucenik.Location = new System.Drawing.Point(182, 129);
            this.lbl_ucenik.Name = "lbl_ucenik";
            this.lbl_ucenik.Size = new System.Drawing.Size(44, 13);
            this.lbl_ucenik.TabIndex = 11;
            this.lbl_ucenik.Text = "Ucenik:";
            // 
            // lbl_ocena
            // 
            this.lbl_ocena.AutoSize = true;
            this.lbl_ocena.Location = new System.Drawing.Point(328, 129);
            this.lbl_ocena.Name = "lbl_ocena";
            this.lbl_ocena.Size = new System.Drawing.Size(42, 13);
            this.lbl_ocena.TabIndex = 12;
            this.lbl_ocena.Text = "Ocena:";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(249, 208);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(38, 13);
            this.lbl_datum.TabIndex = 13;
            this.lbl_datum.Text = "Datum";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(39, 236);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 14;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(511, 68);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "Dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(511, 156);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Izmeni";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(511, 230);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Obrisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // grid_ocena
            // 
            this.grid_ocena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ocena.Location = new System.Drawing.Point(39, 311);
            this.grid_ocena.Name = "grid_ocena";
            this.grid_ocena.Size = new System.Drawing.Size(537, 206);
            this.grid_ocena.TabIndex = 18;
            this.grid_ocena.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ocena_CellClick);
            this.grid_ocena.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ocena_CellContentClick);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(36, 208);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 19;
            this.lbl_id.Text = "ID:";
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 539);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.grid_ocena);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_ocena);
            this.Controls.Add(this.lbl_ucenik);
            this.Controls.Add(this.lbl_odeljenje);
            this.Controls.Add(this.lbl_profesor);
            this.Controls.Add(this.lbl_predmet);
            this.Controls.Add(this.lbl_godina);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.cmb_ocena);
            this.Controls.Add(this.cmb_ucenik);
            this.Controls.Add(this.cmb_profesor);
            this.Controls.Add(this.cmb_godina);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.cmb_predmet);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ocena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.ComboBox cmb_profesor;
        private System.Windows.Forms.ComboBox cmb_ucenik;
        private System.Windows.Forms.ComboBox cmb_ocena;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.Label lbl_godina;
        private System.Windows.Forms.Label lbl_predmet;
        private System.Windows.Forms.Label lbl_profesor;
        private System.Windows.Forms.Label lbl_odeljenje;
        private System.Windows.Forms.Label lbl_ucenik;
        private System.Windows.Forms.Label lbl_ocena;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView grid_ocena;
        private System.Windows.Forms.Label lbl_id;
    }
}