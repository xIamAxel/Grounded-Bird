using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterProject
{
    public partial class Inputs : Form
    {
        public Inputs()
        {
            InitializeComponent();
            addInputsToListView();
        }

        private void addInputsToListView()
        {
            foreach (String input in twitterProject.formMain.inputArray)
            {
                inputListView.Items.Add(input);
            }
        }

        private void inputListView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void clearInputs_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in inputListView.SelectedItems)
            {
                inputListView.Items.Remove(eachItem);
            }
        }
    }
}
