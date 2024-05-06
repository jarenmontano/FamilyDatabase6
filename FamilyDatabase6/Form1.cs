/* Family Database 6 
 * Author Jaren Montano
 * Date = 10/29/2023
 * purpose:Create a Windows form (or copy #3) to display the names, 
 * street addresses, and phone numbers of the members of your family 
 * who live in the same city (you provide as a filter). Do not include 
 * yourself in the query result. It may be necessary for you to go back 
 * into your database and modify some of the records for testing purposes. 
 * Display your results in text boxes as opposed to a data grid. 
 * Provide appropriate headings and labels.
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

namespace FamilyDatabase6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.familyDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'familyDataSet2.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.familyDataSet2.Members);
            // TODO: This line of code loads data into the 'familyDataSet1.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.familyDataSet1.Members);
            // TODO: This line of code loads data into the 'familyDataSet1.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.familyDataSet1.Members);
            // TODO: This line of code loads data into the 'familyDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.familyDataSet.Members);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.membersTableAdapter.FillBy(this.familyDataSet1.Members);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
