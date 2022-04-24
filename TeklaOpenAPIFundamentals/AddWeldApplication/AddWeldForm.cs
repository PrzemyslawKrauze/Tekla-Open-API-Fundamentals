using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using TSG = Tekla.Structures.Geometry3d;
using TSM = Tekla.Structures.Model;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;

namespace TeklaOpenAPIFundamentals
{
    public partial class AddWeldForm : Form
    {
        private static Model model = new Model();
        private static ArrayList objectList = new ArrayList();
        public AddWeldForm()
        {
            InitializeComponent();
        }


    }
}
