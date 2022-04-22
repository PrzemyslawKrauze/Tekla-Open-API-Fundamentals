using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using TSG = Tekla.Structures.Geometry3d;

namespace TeklaOpenAPIFundamentals
{
    public partial class ModifyObjectForm : Form
    {
        private Position.PlaneEnum planePosition = Position.PlaneEnum.MIDDLE;
        private Position.DepthEnum depthPosition = Position.DepthEnum.MIDDLE;
        private Position.RotationEnum rotationPosition = Position.RotationEnum.TOP;
        private string name = string.Empty;
        public ModifyObjectForm()
        {
            InitializeComponent();
        }

        private void ModifyBeam()
        {
            //Get current model
            Model myModel = new Model();
            if (myModel.GetConnectionStatus())
            {
                //Pick start and end point for beam
                Picker _picker = new Picker();
                ModelObject pickedObject = _picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Pick beam");
                Beam beam;
                if (!(pickedObject is Beam))
                {
                    MessageBox.Show("Picked object is not a beam");
                    return;
                }
                else
                {
                    beam = (Beam)pickedObject;
                }

                //Set Beam properties
                beam.Position.Plane = planePosition;
                beam.Position.Depth = depthPosition;
                beam.Position.Rotation = rotationPosition;

                beam.Modify();
                myModel.CommitChanges();
            }
        }

        private void UpdatePlanePosition(int index)
        {
            switch (index)
            {
                case 0:
                    planePosition = Position.PlaneEnum.LEFT;
                    break;
                case 1:
                    planePosition = Position.PlaneEnum.MIDDLE;
                    break;
                case 2:
                    planePosition = Position.PlaneEnum.RIGHT;
                    break;
                default:
                    planePosition = Position.PlaneEnum.MIDDLE;
                    break;
            }
        }
        private void UpdateDepthPosition(int index)
        {
            switch (index)
            {
                case 0:
                    depthPosition = Position.DepthEnum.FRONT;
                    break;
                case 1:
                    depthPosition = Position.DepthEnum.MIDDLE;
                    break;
                case 2:
                    depthPosition = Position.DepthEnum.BEHIND;
                    break;
                default:
                    depthPosition = Position.DepthEnum.MIDDLE;
                    break;
            }
        }
        private void UpdateRotationPosition(int index)
        {
            switch(index)
            {
                case 0:
                    rotationPosition = Position.RotationEnum.TOP;
                    break;
                case 1:
                    rotationPosition = Position.RotationEnum.FRONT;
                    break;
                case 2:
                    rotationPosition = Position.RotationEnum.BACK;
                    break;
                case 3:
                    rotationPosition = Position.RotationEnum.BELOW;
                    break;
                default:
                    rotationPosition= Position.RotationEnum.TOP;
                    break;
            }
        }
     

        private void OnModifyButton_Click(object sender, EventArgs e)
        {
            UpdatePlanePosition(OnPlaneComboBox.SelectedIndex);
            UpdateDepthPosition(DepthComboBox.SelectedIndex);
            UpdateRotationPosition(RotationComboBox.SelectedIndex);
            ModifyBeam();
        }
    }

}
