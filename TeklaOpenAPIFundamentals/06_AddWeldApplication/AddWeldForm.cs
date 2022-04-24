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

        private void CreateWeld()
        {
            Picker picker = new Picker();
            ModelObject primaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Pick first part");
            ModelObject secondaryPart = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Pick second part");
            objectList.Add(primaryPart);
            objectList.Add(secondaryPart);

            Weld weld = new Weld();
            weld.MainObject = primaryPart;
            weld.SecondaryObject = secondaryPart;
            weld.TypeAbove = BaseWeld.WeldTypeEnum.WELD_TYPE_FILLET;
            weld.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_FILLET;
            weld.SizeAbove = 6;
            weld.SizeBelow = 6;
            weld.Position = Weld.WeldPositionEnum.WELD_POSITION_PLUS_X;
            weld.AroundWeld = false;
            weld.ShopWeld = true;

            if(!weld.Insert())
            {
                MessageBox.Show("Weld insert failed");
            }

            model.CommitChanges();
        }

        private void AddWeldButton_Click(object sender, EventArgs e)
        {
            CreateWeld();
        }
    }
}
