namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            txtCarID = new TextBox();
            btnLoad = new Button();
            dgvCarList = new DataGridView();
            txtCarName = new TextBox();
            lbCarName = new Label();
            txtManufacturer = new TextBox();
            lbManufacturer = new Label();
            txtReleaseYear = new TextBox();
            lbReleaseYear = new Label();
            txtPrice = new TextBox();
            lbPrice = new Label();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(44, 32);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(56, 25);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "CarID";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(175, 29);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(217, 31);
            txtCarID.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(83, 162);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 202);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 62;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(776, 221);
            dgvCarList.TabIndex = 3;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(175, 66);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(217, 31);
            txtCarName.TabIndex = 5;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(44, 69);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(90, 25);
            lbCarName.TabIndex = 4;
            lbCarName.Text = "Car Name";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(175, 103);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(217, 31);
            txtManufacturer.TabIndex = 7;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(44, 106);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(117, 25);
            lbManufacturer.TabIndex = 6;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(545, 66);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(200, 31);
            txtReleaseYear.TabIndex = 11;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(414, 69);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(107, 25);
            lbReleaseYear.TabIndex = 10;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(545, 29);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 31);
            txtPrice.TabIndex = 9;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(414, 32);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 25);
            lbPrice.TabIndex = 8;
            lbPrice.Text = "Price";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(348, 162);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(583, 162);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(348, 429);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 476);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(txtReleaseYear);
            Controls.Add(lbReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(dgvCarList);
            Controls.Add(btnLoad);
            Controls.Add(txtCarID);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private TextBox txtCarID;
        private Button btnLoad;
        private DataGridView dgvCarList;
        private TextBox txtCarName;
        private Label lbCarName;
        private TextBox txtManufacturer;
        private Label lbManufacturer;
        private TextBox txtReleaseYear;
        private Label lbReleaseYear;
        private TextBox txtPrice;
        private Label lbPrice;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
    }
}