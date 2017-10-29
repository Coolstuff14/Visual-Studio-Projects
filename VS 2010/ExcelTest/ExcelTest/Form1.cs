using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTest
{
    public partial class Form1 : Form
    {
        String fileUrl;
        String fileDir;
        String fileUrlNoExt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            
            xlApp = new Excel.Application();
            xlApp.DisplayAlerts = false;
            //xlApp.Visible = true;

            xlWorkBook = xlApp.Workbooks.Open(fileUrl);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            Excel.Range chartRange ; 
            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);

            //Left, Top, Width, Height
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(0,0,1000,600);
            Excel.Chart chartPage = myChart.Chart;

           
            int lastRow = xlWorkSheet.UsedRange.Rows.Count;

            chartRange = xlWorkSheet.get_Range("B1", "D"+lastRow);
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlXYScatterSmoothNoMarkers;

            Excel.Axis horizAxis = chartPage.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
            horizAxis.MaximumScaleIsAuto = false;
            horizAxis.MaximumScale = lastRow;
            horizAxis.MinimumScaleIsAuto = false;
            horizAxis.MinimumScale = 0;
            horizAxis.HasTitle = false;
            //horizAxis.AxisTitle.Text = "across the bottom";

            Excel.Axis vertAxis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
            vertAxis.HasMajorGridlines = false; // change this to whatever you wish
            vertAxis.HasTitle = true;
            vertAxis.AxisTitle.Text = "Volts";
            vertAxis.MaximumScaleIsAuto = true;
            //vertAxis.MaximumScale = 4; // you can pick this based on your input
            vertAxis.MinimumScaleIsAuto = true;
           // vertAxis.MinimumScale = -4;
            

            //chartPage.ApplyChartTemplate("c:\\ctmp.crtx");
            chartPage.Export(fileDir+"/Chart1.PNG", "PNG", false);
            Image image = Image.FromFile(fileDir+"/Chart1.PNG");
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //xlWorkBook.SaveAs(fileUrlNoExt, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                  fileUrl = openFileDialog1.FileName;
                  fileUrlNoExt = Path.GetFileNameWithoutExtension(fileUrl);
                  fileDir = Path.GetDirectoryName(fileUrl);
                    
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
    }
}
