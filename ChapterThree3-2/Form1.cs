/*
 * Mason Holmes
 * 6/16/2021
 * This program provides a gui for navigating a database.
 * 
 * outputs: - titleTextBox : TextBox, displays book title 
 *          - year_PublishedTextBox : TextBox, displays year book was published
 *          - iSBNTextBox : TextBox, displays book ISBN number
 *          - pubIDTextBox : TextBox, displays book publisher ID
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapterThree3_2
{
    public partial class frmTitles : Form
    {
        public frmTitles()
        {
            InitializeComponent();
        }

        private void titlesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titlesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sQLBooksDBDataSet);

        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sQLBooksDBDataSet.Titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.sQLBooksDBDataSet.Titles);

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
