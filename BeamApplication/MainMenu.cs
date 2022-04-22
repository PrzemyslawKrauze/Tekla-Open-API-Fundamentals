using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeklaOpenAPIFundamentals
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BeamAplltication_Click(object sender, EventArgs e)
        {
           new BeamAppForm().Show();
        }

        private void ContourPlateButton_Click(object sender, EventArgs e)
        {
            new ContourPlateAppForm().Show();
        }

        private void ModifyObjectButton_Click(object sender, EventArgs e)
        {
            new ModifyObjectForm().Show();
        }
    }
}
