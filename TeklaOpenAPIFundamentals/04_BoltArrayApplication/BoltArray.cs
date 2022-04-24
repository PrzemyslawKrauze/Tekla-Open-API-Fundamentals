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
    public partial class BoltArray : Form
    {
        //Global variable 
        private static Model model = new Model();
        private static TransformationPlane currentPlane;
        private static double boltYDistance = 100;
        private static double boltXDistance = 100;
        private static double contourPlateOffset = 100;
        private static string boltStandard = "NELSON";
        private static double boltSize = 15.87;
        private static int beamClass = 3;
        public BoltArray()
        {
            InitializeComponent();
        }
        private void InsertBoltArray()
        {
            //Pick beam and column to connect
            Picker picker = new Picker();
            ModelObject firstPick = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Pick beam");
            Part beam = firstPick as Part;
            ModelObject secondPick = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Pick column");
            Part column = secondPick as Part;

            TSG.Point startPoint = picker.PickPoint();
            TSG.Point endPoint = picker.PickPoint();

            SetLocalPlane(beam);

            ContourPlate contourPlate = CreateContourPlate(startPoint, endPoint);

            //Create BoltArray
            TSM.BoltArray boltArray = new TSM.BoltArray();

            boltArray.PartToBeBolted = contourPlate;
            boltArray.PartToBoltTo = column;

            boltArray.FirstPosition = startPoint;
            boltArray.SecondPosition = endPoint;

            boltArray.BoltSize = boltSize;
            boltArray.Tolerance = 3.0;
            boltArray.BoltStandard = boltStandard;
            boltArray.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_WORKSHOP;
            boltArray.Length = 150;
            boltArray.ThreadInMaterial = BoltGroup.BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO;

            boltArray.Position.Depth = Position.DepthEnum.MIDDLE;
            boltArray.Position.Plane = Position.PlaneEnum.MIDDLE; ;
            boltArray.Position.Rotation = Position.RotationEnum.TOP;

            boltArray.AddBoltDistX(boltXDistance);
            boltArray.StartPointOffset.Dx = 100;

            boltArray.AddBoltDistY(boltYDistance);
            boltArray.EndPointOffset.Dy = 0;

            if (!boltArray.Insert())
            {
                MessageBox.Show("BoltArray failed");
            }

            beam.Class = beamClass.ToString();
            beam.Modify();
            model.CommitChanges();
        }
        public ContourPlate CreateContourPlate(TSG.Point boltArrayStartPoint, TSG.Point boltArrayEndPoint)
        {
            ContourPlate contourPlate = new ContourPlate();
            TSG.Point firstPoint = new TSG.Point(boltArrayStartPoint);
            firstPoint.Translate(0, 0, -contourPlateOffset);
            TSG.Point secondPoint = new TSG.Point(boltArrayEndPoint);
            secondPoint.Translate(0, 0, -contourPlateOffset);
            TSG.Point thirdPoint = new TSG.Point(boltArrayEndPoint);
            thirdPoint.Translate(0, 0, contourPlateOffset);
            TSG.Point fourthPoint = new TSG.Point(boltArrayStartPoint);
            fourthPoint.Translate(0, 0, contourPlateOffset);
            TSG.Point[] points = new TSG.Point[] { firstPoint, secondPoint, thirdPoint, fourthPoint };

            ArrayList contourPoints = new ArrayList();
            foreach (TSG.Point p in points)
            {
                ContourPoint contourPoint = new ContourPoint(p, new Chamfer());
                contourPoints.Add(contourPoint);
            }

            contourPlate.Contour.ContourPoints = contourPoints;
            contourPlate.Profile.ProfileString = "PL20";
            contourPlate.Material.MaterialString = "S235";
            contourPlate.Position.Depth = Position.DepthEnum.BEHIND;

            if (!contourPlate.Insert())
            {
                MessageBox.Show("BoltArray failed");
                return null;
            }

            return contourPlate;
        }
        private void SetLocalPlane(Part part)
        {
            TransformationPlane localPlane = new TransformationPlane(part.GetCoordinateSystem());
            model.GetWorkPlaneHandler().SetCurrentTransformationPlane(localPlane);
        }
        private void SetXDistance()
        {
            try
            {
                string textBoxInput = XDistanceTextBox.Text;
                if (textBoxInput != string.Empty)
                {              
                    boltXDistance  = Convert.ToDouble(textBoxInput);                    
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Wrong input in {0}",XDistanceLabel.Text);
            }
        }
        private void SetYDistance()
        {
            try
            {
                string textBoxInput = YDistanceTextBox.Text;
                if (textBoxInput != string.Empty)
                {
                    boltYDistance = Convert.ToDouble(textBoxInput);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Wrong input in {0}",YDistanceLabel.Text);
            }           
        }
        private void SetBoltStandard()
        {
            string textBoxInput = BoltStandardTextBox.Text;
            if (textBoxInput != string.Empty)
            {
                boltStandard = textBoxInput;
            }
        }
        private void SetBoltSize()
        {
            try
            {
                string textBoxInput = BoltSizeTextBox.Text;
                if (textBoxInput != string.Empty)
                {
                    boltSize = Convert.ToDouble(textBoxInput);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input in {0}",BoltSizeLabel.Text);
            }
        }
        private void SetBeamClass()
        {
            try
            {
                string textBoxInput = BeamClassTextBox.Text;
                if (textBoxInput != string.Empty)
                {
                    beamClass = Convert.ToInt32(textBoxInput);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input in {0}", BeamClassLabel.Text);
            }
        }
        
        private void InsertBoltArrayButton_Click(object sender, EventArgs e)
        {
            //Store current plane
            currentPlane = model.GetWorkPlaneHandler().GetCurrentTransformationPlane();
            SetXDistance();
            SetYDistance();
            SetBeamClass();
            SetBoltStandard();
            SetBoltSize();

            InsertBoltArray();

            //Restore user plane
            model.GetWorkPlaneHandler().SetCurrentTransformationPlane(currentPlane);
        }
    }
}
