using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            string file = ("ClockIn_ClockOut_Report " + System.DateTime.Now.ToString("yyyy-MM-dd HHTmm") + ".xls");
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("First Sheet");
            worksheet.Cells[0, 0] = new Cell("fld_id");
            worksheet.Cells[0, 1] = new Cell("fld_firstName");
            worksheet.Cells[0, 2] = new Cell("fld_lastName");
            worksheet.Cells[0, 3] = new Cell("fld_personalIDnumber");
            worksheet.Cells[0, 4] = new Cell("fld_deviceID");
            worksheet.Cells[0, 5] = new Cell("fld_latitube");
            worksheet.Cells[0, 6] = new Cell("fld_longitude");
            worksheet.Cells[0, 7] = new Cell("fld_dateTime");

            List<string[]>  queryResult=new back.SQLConnect().GetClassList();

            worksheet.Cells[1, 0] = new Cell(queryResult[0].ToArray()[0]);
            worksheet.Cells[1, 1] = new Cell(queryResult[0].ToArray()[1]);
            worksheet.Cells[1, 2] = new Cell(queryResult[0].ToArray()[2]);
            worksheet.Cells[1, 3] = new Cell(queryResult[0].ToArray()[3]);
            worksheet.Cells[1, 4] = new Cell(queryResult[0].ToArray()[4]);
            worksheet.Cells[1, 5] = new Cell(queryResult[0].ToArray()[5]);
            worksheet.Cells[1, 6] = new Cell(queryResult[0].ToArray()[6]);
            worksheet.Cells[1, 7] = new Cell(queryResult[0].ToArray()[7]);


            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);

            Workbook book = Workbook.Load(file); Worksheet sheet = book.Worksheets[0];

            //foreach (Pair, Cell> cell in sheet.Cells) 
            //{
            //    dgvCells[cell.Left.Right, cell.Left.Left].Value = cell.Right.Value;
            //}

            for (int rowIndex = sheet.Cells.FirstRowIndex; rowIndex <= sheet.Cells.LastRowIndex; rowIndex++)
            {
                Row row = sheet.Cells.GetRow(rowIndex);
                for (int colIndex = row.FirstColIndex; colIndex <= row.LastColIndex; colIndex++)
                {
                    Cell cell = row.GetCell(colIndex);
                }
            }

            MessageBox.Show("File Created");

        }

        private void databaseDVchocolateDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dVchocDataSet2.tbl_ClockIn' table. You can move, or remove it, as needed.
            this.tbl_ClockInTableAdapter.Fill(this.dVchocDataSet2.tbl_ClockIn);
            // TODO: This line of code loads data into the 'dVchocDataSet1.tbl_ClockOut' table. You can move, or remove it, as needed.
            this.tbl_ClockOutTableAdapter.Fill(this.dVchocDataSet1.tbl_ClockOut);
            // TODO: This line of code loads data into the 'database_DVchocolateDataSet1.tbl_Clockin' table. You can move, or remove it, as needed.
           // this.tbl_ClockinTableAdapter.Fill(this.database_DVchocolateDataSet1.tbl_Clockin);
            // TODO: This line of code loads data into the 'database_DVchocolateDataSet.tbl_ClockOut' table. You can move, or remove it, as needed.
          //  this.tbl_ClockOutTableAdapter.Fill(this.database_DVchocolateDataSet.tbl_ClockOut);

        }
    }
}
