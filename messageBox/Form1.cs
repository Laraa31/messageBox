using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mbButton_Click(object sender, EventArgs e)
        {
            DialogResult rez= MessageBox.Show("Odaberite Da/Ne/Odustani", "Naslovna linija Dijaloga za poruke", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            
            switch (rez)

            {

                case DialogResult.Yes:

                    txtBoxRezultat.Text = "Izabrali ste dugme DA";

                    break;

                case DialogResult.No:

                    txtBoxRezultat.Text = "Izabrali ste dugme NE";

                    break;

                case DialogResult.Cancel:

                    txtBoxRezultat.Text = "Izabrali ste dugme ODUSTANI";

                    break;

            }
        }
    }
}
