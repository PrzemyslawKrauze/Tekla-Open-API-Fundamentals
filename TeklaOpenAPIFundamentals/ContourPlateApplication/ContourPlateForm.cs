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

using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using TSG = Tekla.Structures.Geometry3d;

namespace TeklaOpenAPIFundamentals
{
    public partial class ContourPlateAppForm : Form
    {
        public ContourPlateAppForm()
        {
            InitializeComponent();
        }
       
        private void InsertContourPlate(string contourPlateName)
        {
            Model model = new Model();

            ArrayList contourPoints = PickPolygonContour();

            ContourPlate contourPlate = new ContourPlate();
            contourPlate.Contour.ContourPoints = contourPoints; ;
            contourPlate.Profile.ProfileString = "PL25";
            contourPlate.Material.MaterialString = "S235";
            contourPlate.Class = "99";
            if (contourPlateName != string.Empty)
            {
                contourPlate.Name = contourPlateName;
            }
            else
            {
                contourPlate.Name = "Noname";
            }

            contourPlate.Insert();
            model.CommitChanges();
        }
        private void InsertPolyBeam(string polyBeamName)
        {
            Model model = new Model();

            ArrayList contourPoints = PickPolygonContour();

            PolyBeam polyBeam = new PolyBeam();
            polyBeam.Contour.ContourPoints = contourPoints; ;
            polyBeam.Profile.ProfileString = "HEA400";
            polyBeam.Material.MaterialString = "S235";
            polyBeam.Class = "8";
            if (polyBeamName != string.Empty)
            {
                polyBeam.Name = polyBeamName;
            }
            else
            {
                polyBeam.Name = "Noname";
            }

            polyBeam.Insert();
            model.CommitChanges();
        }

        private ArrayList PickPolygonContour()
        {
            Picker picker = new Picker();
            ArrayList pickedPoints = picker.PickPoints(Picker.PickPointEnum.PICK_POLYGON,
                "Pick polygon points");

            ArrayList contourPoints = new ArrayList();
            foreach (TSG.Point p in pickedPoints)
            {
                ContourPoint contourPoint = new ContourPoint(p, new Chamfer());
                contourPoints.Add(contourPoint);
            }
            return contourPoints;
        }
        private void InsertContourPlateButton_Click(object sender, EventArgs e)
        {
            string textBoxInput = nameTextBox.Text;
            InsertContourPlate(textBoxInput);
        }

        private void InsertPolyBeamButton_Click(object sender, EventArgs e)
        {
            string textBoxInput = nameTextBox.Text;
            InsertPolyBeam(textBoxInput);
        }
    }
}
