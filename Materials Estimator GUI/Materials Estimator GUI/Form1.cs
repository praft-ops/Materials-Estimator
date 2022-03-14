using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
// (attempt to) Call all data in "Materials_Estimator" namespace
//  from "Materials.cs"
using Materials_Estimator;

// See error for issue

namespace Materials_Estimator_GUI
{
    public partial class Form1 : Form
    {
        // Specify new DataTable
        DataTable materialsTable;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a DataTable when program loads
            materialsTable = new DataTable();
            // Add columns to data table
            //materialsTable.Columns.Add("Item #",typeof(int));
            materialsTable.Columns.Add("Item Name", typeof(string));
            materialsTable.Columns.Add("Quantity", typeof(int));
            materialsTable.Columns.Add("Unit Price", typeof(double));
            materialsTable.Columns.Add("Category", typeof(string));
            materialsTable.Columns.Add("Item Total", typeof(double));
            materialsTable.Columns.Add("Category Total", typeof(double));
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int x = 0;
            // Add user's input to "materialsTable" as a new row
            //  after clicking "Enter"; check which category
            //  was chosen

            // Indicates the user chose "Electric"
            if(itemCategoryComboBox.SelectedIndex == 1)
            {
                materialsTable.Rows.Add(
                    itemNameTxtBox,
                    quantityNumUpDown.Value,
                    unitPriceTxtBox,
                    itemCategoryComboBox,
                    /*
                     * How can we call the unit price the
                     *  user entered here?
                    */
                    UnitPrice.Materials_Estimator.Value
                    // item total value
                    // category total value
                    );
            }
            // Add other material categories

            ++x;
        }

        // Remove a selected entry from the data table
        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        // Calculate a grand total cost based on all entries in the
        //  datatable
        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        // Clear all entries from data table
        private void clearAllButton_Click(object sender, EventArgs e)
        {

        }

        // Record data onto a separate external file
        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
