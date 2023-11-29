using BUS;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoubleT.GUI
{
    public partial class BillsForm : Form
    {
        BUS_Schedule BUS_Schedule = new();
        public BillsForm()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void load(object sender, EventArgs e)
        {
            DataTable schedules = BUS_Schedule.showBill();
            dgvBills.DataSource = schedules;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng SpreadsheetDocument với tên tệp Excel mới
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(@"..\\..\\..\\..\\..\\Excel\bills.xlsx", SpreadsheetDocumentType.Workbook))
            {
                // Tạo một WorkbookPart và thêm nó vào SpreadsheetDocument
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                // Tạo một WorksheetPart và thêm nó vào WorkbookPart
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet();

                // Tạo một Sheets object để chứa danh sách các Sheets
                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());

                // Tạo một Sheet object với tên là "Sheet1" và SheetId mới
                Sheet sheet = new Sheet()
                {
                    Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Sheet1"
                };
                sheets.Append(sheet);

                // Lấy SheetData object để thêm dữ liệu
                SheetData sheetData = worksheetPart.Worksheet.AppendChild(new SheetData());

                // Tạo hàng đầu tiên với các tiêu đề cột
                Row headerRow = new Row();
                foreach (DataGridViewColumn column in dgvBills.Columns)
                {
                    headerRow.AppendChild(new Cell(new CellValue(column.HeaderText)));
                }
                sheetData.AppendChild(headerRow);

                // Thêm dữ liệu từ DataGridView vào SheetData
                foreach (DataGridViewRow row in dgvBills.Rows)
                {
                    Row dataRow = new Row();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            object value = cell.Value;
                            Cell cellObject;
                            if (value is DateTime)
                            {
                                // Ép kiểu giá trị về DateTime
                                DateTime dateValue = (DateTime)value;
                                // Chuyển đổi DateTime thành chuỗi với định dạng Excel mong đợi
                                string stringValue = dateValue.ToString("MM/dd/yyyy");
                                // Tạo đối tượng Cell với giá trị kiểu chuỗi
                                cellObject = new Cell(new CellValue(stringValue));
                            }
                            else
                            {
                                // Giá trị không phải thời gian, tạo đối tượng Cell với giá trị kiểu chuỗi
                                cellObject = new Cell(new CellValue(value.ToString()));
                            }
                            dataRow.AppendChild(cellObject);
                        }
                    }
                    sheetData.AppendChild(dataRow);
                }

                // Lưu các thay đổi vào file Excel
                worksheetPart.Worksheet.Save();
                MessageBox.Show("Đã xuất excel thành công");
            }
        }
    }
}
