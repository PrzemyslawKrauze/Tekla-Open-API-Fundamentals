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
using TSM = Tekla.Structures.Model;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;


namespace TeklaOpenAPIFundamentals
{
    public partial class CutAndFittingForm : Form
    {
        private static Model model = new Model();
        public CutAndFittingForm()
        {
            InitializeComponent();
        }
        private Beam CreateBeam()
        {
            Beam myBeam = new Beam();
            myBeam.StartPoint = new TSG.Point(0, 0, 0);
            myBeam.EndPoint = new TSG.Point(1000, 0, 0);
            myBeam.Profile.ProfileString = "HEA400";
            myBeam.Material.MaterialString = "S235";
            myBeam.Class = "3";
            myBeam.Insert();

            return myBeam;
        }
        private void CreateFitting()
        {
            Beam myBeam =  CreateBeam();

            Fitting fitting = new Fitting();
            fitting.Plane = new Plane();
            fitting.Plane.Origin = new TSG.Point(500, 0, 0);
            fitting.Plane.AxisX = new TSG.Vector(0, 1000, 0);
            fitting.Plane.AxisY = new TSG.Vector(0, 0, -1000);
            fitting.Father = myBeam;
            fitting.Insert();

            model.CommitChanges();
        }

        private void CreateCut()
        {
            Beam myBeam = CreateBeam();

            CutPlane cutPlane = new CutPlane();
            cutPlane.Plane = new Plane();
            cutPlane.Plane.Origin = new TSG.Point(500, 0, 0);
            cutPlane.Plane.AxisX = new TSG.Vector(0, 1000, 0);
            cutPlane.Plane.AxisY = new TSG.Vector(0,0,-1000);   
            cutPlane.Father = myBeam;
            cutPlane.Insert();

            model.CommitChanges();
        }

        private void CreateFittingButton_Click(object sender, EventArgs e)
        {
            CreateFitting();
        }

        private void CreateCutButton_Click(object sender, EventArgs e)
        {
            CreateCut();
        }
    }
}
