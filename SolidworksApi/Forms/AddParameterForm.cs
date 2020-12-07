using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidworksApi.Forms
{
    public partial class AddParameterForm : Form
    {
        private Form1 _form1;
        public AddParameterForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void btnAddParameterToList_Click(object sender, EventArgs e)
        {
            
            var dataGridRowModel = new DataGridViewRow();

            var length = txtLength.Text;
            var width = txtWidth.Text;
            var height = txtHeight.Text;

            _form1.dgvParameter.Rows.Add(length,width,height);

            this.Close();
        }
    }
}
