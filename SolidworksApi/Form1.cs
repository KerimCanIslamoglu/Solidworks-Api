using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidworksApi.Forms;

namespace SolidworksApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SldWorks swApp=new SldWorks();
            ModelDoc2 swModel;
            Feature swFeature;
            Configuration config;
            CustomPropertyManager cusPropMgr;
            bool status;

            //swApp = SolidWorksSingleton.GetApplication();

            swModel = swApp.ActiveDoc;

            swFeature = swModel.FeatureByPositionReverse(3);
            swFeature.Name = "Front";

            swFeature = swModel.FeatureByPositionReverse(2);
            swFeature.Name = "Top";

            swFeature = swModel.FeatureByPositionReverse(1);
            swFeature.Name = "Right";

            status = swModel.Extension.SelectByID2("Top", "PLANE", 0, 0, 0, false, 0, null, 0);

            swModel.InsertSketch2(true);

            swModel.CreateCircleByRadius2(0, 0, 0, 0.5);
            swModel.CreateCircleByRadius2(0, 0, 0, 0.2);

            swModel.InsertSketch2(true);

            swFeature = swModel.FeatureByPositionReverse(0);
            swFeature.Name = "PipeSketch";

            status = swModel.Extension.SelectByID2("PipeSketch", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swFeature = swModel.FeatureManager.FeatureExtrusion3(true, false, false, (int)swEndConditions_e.swEndCondBlind, 0, 0.8, 0, false, false, false, false, 0, 0, false, false, false, false, false, false, false, 0, 0, false);

            swFeature = swModel.FeatureByPositionReverse(0);
            swFeature.Name = "PipeModel";

            swModel.ForceRebuild3(true);
            swModel.ViewZoomtofit2();

            config = swModel.GetActiveConfiguration();
            cusPropMgr = config.CustomPropertyManager;

            cusPropMgr.Add3("Description", (int)swCustomInfoType_e.swCustomInfoText, "Pipe / Boru", (int)swCustomPropertyAddOption_e.swCustomPropertyDeleteAndAdd);

            cusPropMgr.Add3("Dimensions", (int)swCustomInfoType_e.swCustomInfoText, "800mm", (int)swCustomPropertyAddOption_e.swCustomPropertyDeleteAndAdd);

            //swModel.SaveAs("Cube_1");
        }

        private void btnGenerateCube_Click(object sender, EventArgs e)
        {
            SldWorks swApp=new SldWorks();
            ModelDoc2 swModel;
            Feature swFeature;
            Configuration config;
            CustomPropertyManager cusPropMgr;
            bool status;
            //swApp = SolidWorksSingleton.GetApplication();

            var length = Convert.ToInt32(txtLength.Text);
            var width = Convert.ToInt32(txtWidth.Text);
            var height = Convert.ToInt32(txtHeight.Text);

            swModel = swApp.ActiveDoc;

            swFeature = swModel.FeatureByPositionReverse(3);
            swFeature.Name = "Front";

            swFeature = swModel.FeatureByPositionReverse(2);
            swFeature.Name = "Top";

            swFeature = swModel.FeatureByPositionReverse(1);
            swFeature.Name = "Right";

            status = swModel.Extension.SelectByID2("Top", "PLANE", 0, 0, 0, false, 0, null, 0);

            swModel.InsertSketch2(true);

            //swModel.CreateCircleByRadius2(0, 0, 0, 0.5);
            //swModel.CreateCircleByRadius2(0, 0, 0, 0.2);

            //swModel.CreateLine2(0, 0, 0, length, 0, 0);
            //swModel.CreateLine2(length, 0, 0, 0, width, 0);
            //swModel.CreateLine2(length, width, 0, 0, width, 0);
            //swModel.CreateLine2(0, width, 0, 0, 0, 0);

            //w:1 l:2
            swModel.CreateLine2(0, 0, 0, width, 0, 0);
            swModel.CreateLine2(width, 0, 0, width, length, 0);
            swModel.CreateLine2(width, length, 0, 0, length, 0);
            swModel.CreateLine2(0, length, 0, 0, 0, 0);

            swModel.InsertSketch2(true);

            swFeature = swModel.FeatureByPositionReverse(0);
            swFeature.Name = "CubeSketch";

            status = swModel.Extension.SelectByID2("CubeSketch", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swFeature = swModel.FeatureManager.FeatureExtrusion3(true, false, false, (int)swEndConditions_e.swEndCondBlind, 0, height, 0, false, false, false, false, 0, 0, false, false, false, false, false, false, false, 0, 0, false);

            swFeature = swModel.FeatureByPositionReverse(0);
            swFeature.Name = "CubeModel";

            swModel.ForceRebuild3(true);
            swModel.ViewZoomtofit2();

            config = swModel.GetActiveConfiguration();
            cusPropMgr = config.CustomPropertyManager;

            cusPropMgr.Add3("Description", (int)swCustomInfoType_e.swCustomInfoText, "Cube", (int)swCustomPropertyAddOption_e.swCustomPropertyDeleteAndAdd);

            cusPropMgr.Add3("Dimensions", (int)swCustomInfoType_e.swCustomInfoText, "800mm", (int)swCustomPropertyAddOption_e.swCustomPropertyDeleteAndAdd);
        }

        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            AddParameterForm addParameterForm = new AddParameterForm(this);
            addParameterForm.Show();
        }

        private void btnGenerateCubesList_Click(object sender, EventArgs e)
        {
            SldWorks swApp = new SldWorks();
            ModelDoc2 swModel;
            Feature swFeature;
            Configuration config;
            CustomPropertyManager cusPropMgr;
            bool status;

            //swApp = SolidWorksSingleton.GetApplication();
            if (dgvParameter.RowCount>0)
            {
                for (int i = 0; i < dgvParameter.RowCount; i++)
                {
                    var length = Convert.ToInt32(dgvParameter.Rows[i].Cells[0].Value);
                    var width = Convert.ToInt32(dgvParameter.Rows[i].Cells[1].Value);
                    var height = Convert.ToInt32(dgvParameter.Rows[i].Cells[2].Value);

                    swModel = swApp.ActiveDoc;

                    swFeature = swModel.FeatureByPositionReverse(3);
                    swFeature.Name = "Front";

                    swFeature = swModel.FeatureByPositionReverse(2);
                    swFeature.Name = "Top";

                    swFeature = swModel.FeatureByPositionReverse(1);
                    swFeature.Name = "Right";

                    status = swModel.Extension.SelectByID2("Top", "PLANE", 0, 0, 0, false, 0, null, 0);

                    swModel.InsertSketch2(true);
                  
                    //w:1 l:2
                    swModel.CreateLine2(0, 0, 0, width, 0, 0);
                    swModel.CreateLine2(width, 0, 0, width, length, 0);
                    swModel.CreateLine2(width, length, 0, 0, length, 0);
                    swModel.CreateLine2(0, length, 0, 0, 0, 0);

                    swModel.InsertSketch2(true);

                    swFeature = swModel.FeatureByPositionReverse(0);
                    swFeature.Name = "CubeSketch";

                    status = swModel.Extension.SelectByID2("CubeSketch", "SKETCH", 0, 0, 0, false, 0, null, 0);
                    swFeature = swModel.FeatureManager.FeatureExtrusion3(true, false, false, (int)swEndConditions_e.swEndCondBlind, 0, height, 0, false, false, false, false, 0, 0, false, false, false, false, false, false, false, 0, 0, false);

                    swFeature = swModel.FeatureByPositionReverse(0);
                    swFeature.Name = "CubeModel";

                    swModel.ForceRebuild3(true);
                    swModel.ViewZoomtofit2();

                    config = swModel.GetActiveConfiguration();
                    cusPropMgr = config.CustomPropertyManager;

                    cusPropMgr.Add3("Description", (int)swCustomInfoType_e.swCustomInfoText, "Cube", (int)swCustomPropertyAddOption_e.swCustomPropertyDeleteAndAdd);

                    cusPropMgr.Add3("Dimensions", (int)swCustomInfoType_e.swCustomInfoText, "800mm", (int)swCustomPropertyAddOption_e.swCustomPropertyDeleteAndAdd);

                    swModel.SaveAs("Cube");

                    //swModel.DeleteFeatureMgrView(0);
                    //swModel.DeleteFeatureMgrView(0);
                }
            }
        }
    }
}
