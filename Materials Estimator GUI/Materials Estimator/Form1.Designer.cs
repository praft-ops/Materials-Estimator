namespace Materials_Estimator
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
            this.itemNameTxtBox = new System.Windows.Forms.TextBox();
            this.unitPriceTxtBox = new System.Windows.Forms.TextBox();
            this.itemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quantityNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemNameTxtLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.itemCategoryLabel = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.electricLabel = new System.Windows.Forms.Label();
            this.flooringLabel = new System.Windows.Forms.Label();
            this.hvacLabel = new System.Windows.Forms.Label();
            this.insulationLabel = new System.Windows.Forms.Label();
            this.landscapeLabel = new System.Windows.Forms.Label();
            this.masonryLabel = new System.Windows.Forms.Label();
            this.plumbingLabel = new System.Windows.Forms.Label();
            this.electricTotalAmtLabel = new System.Windows.Forms.Label();
            this.flooringTotalLabel = new System.Windows.Forms.Label();
            this.hvacTotalLabel = new System.Windows.Forms.Label();
            this.insulationTotalLabel = new System.Windows.Forms.Label();
            this.landscapeTotalLabel = new System.Windows.Forms.Label();
            this.masonryTotalLabel = new System.Windows.Forms.Label();
            this.plumbingTotalLabel = new System.Windows.Forms.Label();
            this.categoryTotalsLabel = new System.Windows.Forms.Label();
            this.grandTotalAmtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameTxtBox
            // 
            this.itemNameTxtBox.Location = new System.Drawing.Point(913, 34);
            this.itemNameTxtBox.Name = "itemNameTxtBox";
            this.itemNameTxtBox.Size = new System.Drawing.Size(153, 23);
            this.itemNameTxtBox.TabIndex = 0;
            // 
            // unitPriceTxtBox
            // 
            this.unitPriceTxtBox.Location = new System.Drawing.Point(913, 149);
            this.unitPriceTxtBox.Name = "unitPriceTxtBox";
            this.unitPriceTxtBox.Size = new System.Drawing.Size(153, 23);
            this.unitPriceTxtBox.TabIndex = 2;
            // 
            // itemCategoryComboBox
            // 
            this.itemCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCategoryComboBox.FormattingEnabled = true;
            this.itemCategoryComboBox.Items.AddRange(new object[] {
            "",
            "Electric",
            "Flooring",
            "HVAC",
            "Insulation",
            "Landscape",
            "Masonry",
            "Plumbing"});
            this.itemCategoryComboBox.Location = new System.Drawing.Point(913, 207);
            this.itemCategoryComboBox.Name = "itemCategoryComboBox";
            this.itemCategoryComboBox.Size = new System.Drawing.Size(123, 23);
            this.itemCategoryComboBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(758, 384);
            this.dataGridView1.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(813, 286);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // quantityNumUpDown
            // 
            this.quantityNumUpDown.Location = new System.Drawing.Point(913, 90);
            this.quantityNumUpDown.Name = "quantityNumUpDown";
            this.quantityNumUpDown.Size = new System.Drawing.Size(79, 23);
            this.quantityNumUpDown.TabIndex = 7;
            // 
            // itemNameTxtLabel
            // 
            this.itemNameTxtLabel.AutoSize = true;
            this.itemNameTxtLabel.Location = new System.Drawing.Point(829, 37);
            this.itemNameTxtLabel.Name = "itemNameTxtLabel";
            this.itemNameTxtLabel.Size = new System.Drawing.Size(69, 15);
            this.itemNameTxtLabel.TabIndex = 8;
            this.itemNameTxtLabel.Text = "Item Name:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(842, 92);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(56, 15);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity:";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(837, 152);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(61, 15);
            this.unitPriceLabel.TabIndex = 10;
            this.unitPriceLabel.Text = "Unit price:";
            // 
            // itemCategoryLabel
            // 
            this.itemCategoryLabel.AutoSize = true;
            this.itemCategoryLabel.Location = new System.Drawing.Point(813, 210);
            this.itemCategoryLabel.Name = "itemCategoryLabel";
            this.itemCategoryLabel.Size = new System.Drawing.Size(85, 15);
            this.itemCategoryLabel.TabIndex = 11;
            this.itemCategoryLabel.Text = "Item Category:";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(909, 286);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 12;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1003, 286);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Location = new System.Drawing.Point(813, 341);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(70, 15);
            this.grandTotalLabel.TabIndex = 14;
            this.grandTotalLabel.Text = "Grand Total:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(813, 246);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 15;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(909, 246);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 16;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // electricLabel
            // 
            this.electricLabel.AutoSize = true;
            this.electricLabel.Location = new System.Drawing.Point(813, 403);
            this.electricLabel.Name = "electricLabel";
            this.electricLabel.Size = new System.Drawing.Size(48, 15);
            this.electricLabel.TabIndex = 17;
            this.electricLabel.Text = "Electric:";
            // 
            // flooringLabel
            // 
            this.flooringLabel.AutoSize = true;
            this.flooringLabel.Location = new System.Drawing.Point(813, 439);
            this.flooringLabel.Name = "flooringLabel";
            this.flooringLabel.Size = new System.Drawing.Size(54, 15);
            this.flooringLabel.TabIndex = 18;
            this.flooringLabel.Text = "Flooring:";
            // 
            // hvacLabel
            // 
            this.hvacLabel.AutoSize = true;
            this.hvacLabel.Location = new System.Drawing.Point(813, 472);
            this.hvacLabel.Name = "hvacLabel";
            this.hvacLabel.Size = new System.Drawing.Size(41, 15);
            this.hvacLabel.TabIndex = 19;
            this.hvacLabel.Text = "HVAC:";
            // 
            // insulationLabel
            // 
            this.insulationLabel.AutoSize = true;
            this.insulationLabel.Location = new System.Drawing.Point(813, 500);
            this.insulationLabel.Name = "insulationLabel";
            this.insulationLabel.Size = new System.Drawing.Size(62, 15);
            this.insulationLabel.TabIndex = 20;
            this.insulationLabel.Text = "Insulation:";
            // 
            // landscapeLabel
            // 
            this.landscapeLabel.AutoSize = true;
            this.landscapeLabel.Location = new System.Drawing.Point(953, 403);
            this.landscapeLabel.Name = "landscapeLabel";
            this.landscapeLabel.Size = new System.Drawing.Size(66, 15);
            this.landscapeLabel.TabIndex = 21;
            this.landscapeLabel.Text = "Landscape:";
            // 
            // masonryLabel
            // 
            this.masonryLabel.AutoSize = true;
            this.masonryLabel.Location = new System.Drawing.Point(953, 439);
            this.masonryLabel.Name = "masonryLabel";
            this.masonryLabel.Size = new System.Drawing.Size(56, 15);
            this.masonryLabel.TabIndex = 22;
            this.masonryLabel.Text = "Masonry:";
            // 
            // plumbingLabel
            // 
            this.plumbingLabel.AutoSize = true;
            this.plumbingLabel.Location = new System.Drawing.Point(953, 472);
            this.plumbingLabel.Name = "plumbingLabel";
            this.plumbingLabel.Size = new System.Drawing.Size(62, 15);
            this.plumbingLabel.TabIndex = 23;
            this.plumbingLabel.Text = "Plumbing:";
            // 
            // electricTotalAmtLabel
            // 
            this.electricTotalAmtLabel.AutoSize = true;
            this.electricTotalAmtLabel.Location = new System.Drawing.Point(867, 403);
            this.electricTotalAmtLabel.Name = "electricTotalAmtLabel";
            this.electricTotalAmtLabel.Size = new System.Drawing.Size(12, 15);
            this.electricTotalAmtLabel.TabIndex = 24;
            this.electricTotalAmtLabel.Text = "?";
            // 
            // flooringTotalLabel
            // 
            this.flooringTotalLabel.AutoSize = true;
            this.flooringTotalLabel.Location = new System.Drawing.Point(867, 439);
            this.flooringTotalLabel.Name = "flooringTotalLabel";
            this.flooringTotalLabel.Size = new System.Drawing.Size(12, 15);
            this.flooringTotalLabel.TabIndex = 25;
            this.flooringTotalLabel.Text = "?";
            // 
            // hvacTotalLabel
            // 
            this.hvacTotalLabel.AutoSize = true;
            this.hvacTotalLabel.Location = new System.Drawing.Point(855, 472);
            this.hvacTotalLabel.Name = "hvacTotalLabel";
            this.hvacTotalLabel.Size = new System.Drawing.Size(12, 15);
            this.hvacTotalLabel.TabIndex = 26;
            this.hvacTotalLabel.Text = "?";
            // 
            // insulationTotalLabel
            // 
            this.insulationTotalLabel.AutoSize = true;
            this.insulationTotalLabel.Location = new System.Drawing.Point(881, 500);
            this.insulationTotalLabel.Name = "insulationTotalLabel";
            this.insulationTotalLabel.Size = new System.Drawing.Size(12, 15);
            this.insulationTotalLabel.TabIndex = 27;
            this.insulationTotalLabel.Text = "?";
            // 
            // landscapeTotalLabel
            // 
            this.landscapeTotalLabel.AutoSize = true;
            this.landscapeTotalLabel.Location = new System.Drawing.Point(1025, 403);
            this.landscapeTotalLabel.Name = "landscapeTotalLabel";
            this.landscapeTotalLabel.Size = new System.Drawing.Size(12, 15);
            this.landscapeTotalLabel.TabIndex = 28;
            this.landscapeTotalLabel.Text = "?";
            // 
            // masonryTotalLabel
            // 
            this.masonryTotalLabel.AutoSize = true;
            this.masonryTotalLabel.Location = new System.Drawing.Point(1015, 439);
            this.masonryTotalLabel.Name = "masonryTotalLabel";
            this.masonryTotalLabel.Size = new System.Drawing.Size(12, 15);
            this.masonryTotalLabel.TabIndex = 29;
            this.masonryTotalLabel.Text = "?";
            // 
            // plumbingTotalLabel
            // 
            this.plumbingTotalLabel.AutoSize = true;
            this.plumbingTotalLabel.Location = new System.Drawing.Point(1021, 472);
            this.plumbingTotalLabel.Name = "plumbingTotalLabel";
            this.plumbingTotalLabel.Size = new System.Drawing.Size(12, 15);
            this.plumbingTotalLabel.TabIndex = 30;
            this.plumbingTotalLabel.Text = "?";
            // 
            // categoryTotalsLabel
            // 
            this.categoryTotalsLabel.AutoSize = true;
            this.categoryTotalsLabel.Location = new System.Drawing.Point(813, 373);
            this.categoryTotalsLabel.Name = "categoryTotalsLabel";
            this.categoryTotalsLabel.Size = new System.Drawing.Size(99, 15);
            this.categoryTotalsLabel.TabIndex = 31;
            this.categoryTotalsLabel.Text = "Category Total(s):";
            // 
            // grandTotalAmtLabel
            // 
            this.grandTotalAmtLabel.AutoSize = true;
            this.grandTotalAmtLabel.Location = new System.Drawing.Point(889, 341);
            this.grandTotalAmtLabel.Name = "grandTotalAmtLabel";
            this.grandTotalAmtLabel.Size = new System.Drawing.Size(12, 15);
            this.grandTotalAmtLabel.TabIndex = 32;
            this.grandTotalAmtLabel.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 557);
            this.Controls.Add(this.grandTotalAmtLabel);
            this.Controls.Add(this.categoryTotalsLabel);
            this.Controls.Add(this.plumbingTotalLabel);
            this.Controls.Add(this.masonryTotalLabel);
            this.Controls.Add(this.landscapeTotalLabel);
            this.Controls.Add(this.insulationTotalLabel);
            this.Controls.Add(this.hvacTotalLabel);
            this.Controls.Add(this.flooringTotalLabel);
            this.Controls.Add(this.electricTotalAmtLabel);
            this.Controls.Add(this.plumbingLabel);
            this.Controls.Add(this.masonryLabel);
            this.Controls.Add(this.landscapeLabel);
            this.Controls.Add(this.insulationLabel);
            this.Controls.Add(this.hvacLabel);
            this.Controls.Add(this.flooringLabel);
            this.Controls.Add(this.electricLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.itemCategoryLabel);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemNameTxtLabel);
            this.Controls.Add(this.quantityNumUpDown);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.itemCategoryComboBox);
            this.Controls.Add(this.unitPriceTxtBox);
            this.Controls.Add(this.itemNameTxtBox);
            this.Name = "Form1";
            this.Text = "Materials Estimator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox itemNameTxtBox;
        private TextBox unitPriceTxtBox;
        private ComboBox itemCategoryComboBox;
        private DataGridView dataGridView1;
        private Button calculateButton;
        private NumericUpDown quantityNumUpDown;
        private Label itemNameTxtLabel;
        private Label quantityLabel;
        private Label unitPriceLabel;
        private Label itemCategoryLabel;
        private Button clearAllButton;
        private Button saveButton;
        private Label grandTotalLabel;
        private Button enterButton;
        private Button removeButton;
        private Label electricLabel;
        private Label flooringLabel;
        private Label hvacLabel;
        private Label insulationLabel;
        private Label landscapeLabel;
        private Label masonryLabel;
        private Label plumbingLabel;
        private Label electricTotalAmtLabel;
        private Label flooringTotalLabel;
        private Label hvacTotalLabel;
        private Label insulationTotalLabel;
        private Label landscapeTotalLabel;
        private Label masonryTotalLabel;
        private Label plumbingTotalLabel;
        private Label categoryTotalsLabel;
        private Label grandTotalAmtLabel;
    }
}