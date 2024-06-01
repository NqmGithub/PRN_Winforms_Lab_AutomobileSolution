namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lbCarIB = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            lbCarName = new Label();
            cboManufacturer = new ComboBox();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbCarIB
            // 
            lbCarIB.AutoSize = true;
            lbCarIB.Location = new Point(56, 40);
            lbCarIB.Name = "lbCarIB";
            lbCarIB.Size = new Size(56, 25);
            lbCarIB.TabIndex = 0;
            lbCarIB.Text = "CarID";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(179, 34);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(309, 31);
            txtCarID.TabIndex = 1;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(179, 103);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(309, 31);
            txtCarName.TabIndex = 3;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(56, 106);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(90, 25);
            lbCarName.TabIndex = 2;
            lbCarName.Text = "Car Name";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(179, 169);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(309, 33);
            cboManufacturer.TabIndex = 4;
            cboManufacturer.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(56, 172);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(117, 25);
            lbManufacturer.TabIndex = 5;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(56, 236);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 25);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(56, 296);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(107, 25);
            lbReleaseYear.TabIndex = 7;
            lbReleaseYear.Text = "Release Year";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(103, 364);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(333, 364);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(179, 233);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(309, 31);
            txtPrice.TabIndex = 12;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(179, 293);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(309, 31);
            txtReleaseYear.TabIndex = 13;
            txtReleaseYear.Text = "0";
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 450);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(cboManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbCarIB);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarIB;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private Label lbCarName;
        private ComboBox cboManufacturer;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private Button btnSave;
        private Button btnCancel;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
    }
}