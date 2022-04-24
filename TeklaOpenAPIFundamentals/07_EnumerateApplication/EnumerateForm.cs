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
using Tekla.Structures.Solid;


namespace TeklaOpenAPIFundamentals
{
    public partial class EnumerateForm : Form
    {
        private Model model = new Model();
        private static ArrayList objectList = new ArrayList();
        private int nFaces = 0;
        private int nLoops = 0;
        private int nVertexes = 0;

        public EnumerateForm()
        {
            InitializeComponent();
        }

        private void GetBeamsFromSelectedObjects()
        {
            Tekla.Structures.Model.UI.ModelObjectSelector modelObjectSelector = new Tekla.Structures.Model.UI.ModelObjectSelector();
            ModelObjectEnumerator selectedObjects = modelObjectSelector.GetSelectedObjects();

            foreach (ModelObject modelObject in selectedObjects)
            {
                Beam beam = modelObject as Beam;

                if (beam != null)
                {
                    //This part is missing in lesson, we can also check if beam.Type
                    // is BEAM as well 
                    if (Beam.BeamTypeEnum.BEAM == beam.Type)
                    {
                        beam.Class = "12";
                        beam.Modify();
                    }
                }
            }

            model.CommitChanges();
        }

        private void GetContourPlateFromSelectedObjects()
        {
            Tekla.Structures.Model.UI.ModelObjectSelector modelObjectSelector = new Tekla.Structures.Model.UI.ModelObjectSelector();            
            ModelObjectEnumerator selectedObjects = modelObjectSelector.GetSelectedObjects();
            

            foreach (ModelObject modelObject in selectedObjects)
            {
                ContourPlate contourPlate = modelObject as ContourPlate;

                if (contourPlate != null)
                {
                    contourPlate.Material.MaterialString = "S275JR";
                    contourPlate.Finish = "Galvanized";
                    contourPlate.Class = "2";
                    contourPlate.Modify();
                }
            }

            model.CommitChanges();
        }

        private void ExamineSolid()
        {
            //As we allready have application for adding beams there is no need of repeting code here, just pick a beam/part
            Picker picker = new Picker();
            ModelObject modelObject = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Pick part to examine");
            Part part = (Part)modelObject;

            if (!part.Select())
                MessageBox.Show("Part select failed");

            Solid solid = part.GetSolid();
            FaceEnumerator faceEnumerator = solid.GetFaceEnumerator();

            while (faceEnumerator.MoveNext())
            {
                nFaces++;
                Face face = faceEnumerator.Current;
                LoopEnumerator loopEnumerator = face.GetLoopEnumerator();

                while (loopEnumerator.MoveNext())
                {
                    nLoops++;
                    Loop loop = loopEnumerator.Current;
                    VertexEnumerator vertexEnumerator = loop.GetVertexEnumerator();

                    while (vertexEnumerator.MoveNext())
                    {
                        nVertexes++;
                    }
                }
            }

            string firstMessage = String.Format("nFaces: {0} nLoops: {1} nVertexes: {2}", nFaces, nLoops, nVertexes);
            MessageBox.Show(firstMessage);

        }

        private void ExamineSolidButton_Click(object sender, EventArgs e)
        {
            ExamineSolid();
        }

        private void GetBeamsButton_Click(object sender, EventArgs e)
        {
            GetBeamsFromSelectedObjects();
        }

        private void GetContourPlateButton_Click(object sender, EventArgs e)
        {
            GetContourPlateFromSelectedObjects();
        }
    }
}
