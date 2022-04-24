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

namespace TeklaOpenAPIFundamentals
{
    public partial class BeamAppForm : Form
    {
        public BeamAppForm()
        {
            InitializeComponent();
        }

        private void InsertBeam(string beamName)
        {
            //Get current model
            Model myModel = new Model();
            if(myModel.GetConnectionStatus())
            {
                //Pick start and end point for beam
                Tekla.Structures.Model.UI.Picker _picker = new Tekla.Structures.Model.UI.Picker();
                TSG.Point startPoint = _picker.PickPoint("Pick the start point");
                TSG.Point endPoint = _picker.PickPoint("Pick the end point");

                //Set Beam properties
                Beam myBeam = new Beam(startPoint,endPoint);
                myBeam.Profile.ProfileString = "HEA400";
                myBeam.Material.MaterialString = "S235";
                myBeam.Class = "3";
                myBeam.Name = beamName;

                myBeam.Insert();
                myModel.CommitChanges();
            }
        }

        private void OnInsertButtonClick(object sender, System.EventArgs e)
        {
            string beamName = nameTextBox.Text;
            InsertBeam(beamName);
        }
    }
}
