namespace ver_1._1
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
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.dgvInGarage = new System.Windows.Forms.DataGridView();
            this.dgvTakenCar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnParkIn = new System.Windows.Forms.Button();
            this.btnDriveOut = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInGarage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakenCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDrivers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDrivers.Location = new System.Drawing.Point(12, 52);
            this.dgvDrivers.MultiSelect = false;
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.RowTemplate.Height = 25;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(406, 195);
            this.dgvDrivers.TabIndex = 0;
            this.dgvDrivers.SelectionChanged += new System.EventHandler(this.dgvDrivers_SelectionChanged);
            // 
            // dgvInGarage
            // 
            this.dgvInGarage.AllowUserToAddRows = false;
            this.dgvInGarage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInGarage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvInGarage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInGarage.Location = new System.Drawing.Point(660, 52);
            this.dgvInGarage.MultiSelect = false;
            this.dgvInGarage.Name = "dgvInGarage";
            this.dgvInGarage.RowTemplate.Height = 25;
            this.dgvInGarage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInGarage.Size = new System.Drawing.Size(542, 195);
            this.dgvInGarage.TabIndex = 1;
            // 
            // dgvTakenCar
            // 
            this.dgvTakenCar.AllowUserToAddRows = false;
            this.dgvTakenCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakenCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvTakenCar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTakenCar.Location = new System.Drawing.Point(12, 348);
            this.dgvTakenCar.MultiSelect = false;
            this.dgvTakenCar.Name = "dgvTakenCar";
            this.dgvTakenCar.RowTemplate.Height = 25;
            this.dgvTakenCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakenCar.Size = new System.Drawing.Size(441, 186);
            this.dgvTakenCar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drivers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taken Cars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "In Garage";
            // 
            // btnParkIn
            // 
            this.btnParkIn.Location = new System.Drawing.Point(506, 62);
            this.btnParkIn.Name = "btnParkIn";
            this.btnParkIn.Size = new System.Drawing.Size(99, 69);
            this.btnParkIn.TabIndex = 6;
            this.btnParkIn.Text = "Park In";
            this.btnParkIn.UseVisualStyleBackColor = true;
            this.btnParkIn.Click += new System.EventHandler(this.btnParkIn_Click);
            // 
            // btnDriveOut
            // 
            this.btnDriveOut.Location = new System.Drawing.Point(506, 159);
            this.btnDriveOut.Name = "btnDriveOut";
            this.btnDriveOut.Size = new System.Drawing.Size(99, 69);
            this.btnDriveOut.TabIndex = 7;
            this.btnDriveOut.Text = "Drive Out";
            this.btnDriveOut.UseVisualStyleBackColor = true;
            this.btnDriveOut.Click += new System.EventHandler(this.btnDriveOut_Click);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "Name";
            this.Column6.HeaderText = "Name";
            this.Column6.Name = "Column6";
            this.Column6.Width = 64;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "Surname";
            this.Column7.HeaderText = "Surname";
            this.Column7.Name = "Column7";
            this.Column7.Width = 79;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "BirthYear";
            this.Column8.HeaderText = "Birth Year";
            this.Column8.Name = "Column8";
            this.Column8.Width = 82;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.DataPropertyName = "PhoneNumber";
            this.Column9.HeaderText = "Phone Number";
            this.Column9.Name = "Column9";
            this.Column9.Width = 113;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.DataPropertyName = "RegNumber";
            this.Column10.HeaderText = "Registration Number";
            this.Column10.Name = "Column10";
            this.Column10.Width = 130;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.DataPropertyName = "Company";
            this.Column11.HeaderText = "Company";
            this.Column11.Name = "Column11";
            this.Column11.Width = 84;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.DataPropertyName = "Model";
            this.Column12.HeaderText = "Model";
            this.Column12.Name = "Column12";
            this.Column12.Width = 66;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column13.DataPropertyName = "Year";
            this.Column13.HeaderText = "Year";
            this.Column13.Name = "Column13";
            this.Column13.Width = 54;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column14.DataPropertyName = "VehicleType";
            this.Column14.HeaderText = "Type";
            this.Column14.Name = "Column14";
            this.Column14.Width = 56;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "RegNumber";
            this.Column1.HeaderText = "Registration Number";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Company";
            this.Column2.HeaderText = "Company";
            this.Column2.Name = "Column2";
            this.Column2.Width = 84;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Model";
            this.Column3.HeaderText = "Model";
            this.Column3.Name = "Column3";
            this.Column3.Width = 66;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Year";
            this.Column4.HeaderText = "Year";
            this.Column4.Name = "Column4";
            this.Column4.Width = 54;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "VehicleType";
            this.Column5.HeaderText = "Type ";
            this.Column5.Name = "Column5";
            this.Column5.Width = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 642);
            this.Controls.Add(this.btnDriveOut);
            this.Controls.Add(this.btnParkIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTakenCar);
            this.Controls.Add(this.dgvInGarage);
            this.Controls.Add(this.dgvDrivers);
            this.Name = "Form1";
            this.Text = "Parking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInGarage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakenCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDrivers;
        private DataGridView dgvInGarage;
        private DataGridView dgvTakenCar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnParkIn;
        private Button btnDriveOut;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
    }
}