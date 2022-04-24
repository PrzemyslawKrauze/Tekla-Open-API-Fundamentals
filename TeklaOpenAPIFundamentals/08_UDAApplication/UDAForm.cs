using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;

namespace TeklaOpenAPIFundamentals
{
    public partial class UDAForm : Form
    {
        private Model model = new Model();
        private const string UDA_USER_COMMENT_NAME = "USER_COMMENT";
        private const string UDA_PRIORITY_NAME = "PRIORITY";
        private const string UDA_WIDTH_NAME = "WIDTH";
        private const string UDA_LENGTH_NAME = "LENGTH";
        private const string UDA_WIDTH_ROUNDED_NAME = "WIDTH_ROUNDED";
        private const string UDA_LENGTH_ROUNDED_NAME = "LENGTH_ROUNDED";
        private static Part pickedPart = null;
        private static int roundToNearest = 0;
        public UDAForm()
        {
            InitializeComponent();
        }
        private void PickPart()
        {
            Picker picker = new Picker();
            ModelObject modelObject = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Pick part");
            Part part = modelObject as Part;
            if (part != null)
            {
                pickedPart = part;
            }
        }
        private void CreateUDA(string udaName, string udaValue)
        {
            pickedPart.SetUserProperty(udaName, udaValue);
            model.CommitChanges();
        }
        private void RoundUDA(string udaName, string roundedUDAName)
        {
            double value = 0;
            pickedPart.GetReportProperty(udaName, ref value);
            //Since fractional digits of report properties are affected by Tekla settings 
            //value will be rounded to centimeters/meters etc. for better visibility 
            value = Math.Round(value / roundToNearest) * roundToNearest;
            pickedPart.SetUserProperty(roundedUDAName, value);

            model.CommitChanges();
        }
      
        private void SetRoundToNearest()
        {
            try
            {
                string textBoxInput = RoundToNearestTextBox.Text;
                if (textBoxInput != string.Empty)
                {
                    roundToNearest = Convert.ToInt32(textBoxInput);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input in {0}", FractionalDigitsLabel.Text);
            }
        }

        private void CreateUDAButton_Click(object sender, EventArgs e)
        {
            PickPart();
            CreateUDA(UDA_USER_COMMENT_NAME, UserCommentTextBox.Text);
            CreateUDA(UDA_PRIORITY_NAME, PriorityTextBox.Text);
        }

        private void RoundUDAButton_Click(object sender, EventArgs e)
        {
            SetRoundToNearest();
            PickPart();
            RoundUDA(UDA_WIDTH_NAME, UDA_WIDTH_ROUNDED_NAME);
            RoundUDA(UDA_LENGTH_NAME, UDA_LENGTH_ROUNDED_NAME);
        }
    }
}
