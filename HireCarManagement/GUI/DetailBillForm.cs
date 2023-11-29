using BUS;
using DTO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HireCarManagement.GUI
{
    public partial class DetailBillForm : Form
    {
        BUS_Schedule BUS_Schedule = new();
        Guid id;
        string customerName;
        string cccd;
        string carName;
        DateTime hiredAt;
        DateTime returnedAt;
        string price;
        Guid carId;

        public DetailBillForm(Guid id, string customerName, string cccd, string carName, DateTime hiredAt, DateTime returnedAt, string price, Guid carId)
        {
            InitializeComponent();
            this.id = id;
            this.customerName = customerName;
            this.cccd = cccd;
            this.carName = carName;
            this.hiredAt = hiredAt;
            this.returnedAt = returnedAt;
            this.price = price;
            this.carId = carId;
        }

        private void load(object sender, EventArgs e)
        {
            lbID.Text = id.ToString();
            lbName.Text = customerName;
            lbCCCD.Text = cccd;
            lbCarName.Text = carName;
            dtpHiredAt.Text = hiredAt.ToString();
            dtpReturnedAt.Text = returnedAt.ToString();
            lbPrice.Text = price;
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the path where you want to save the PDF file
                string filePath = "D:\\demo.pdf";

                // Create a PdfWriter object to write the PDF file
                using (PdfWriter writer = new(filePath))
                {
                    // Create a PdfDocument object
                    using PdfDocument pdf = new(writer);
                    // Create a Document object to add elements (e.g., paragraphs) to the PDF
                    Document document = new(pdf);
                    Paragraph subheader = new Paragraph("DETAIL BILL PDF")
                                               .SetTextAlignment(TextAlignment.CENTER)
                                               .SetFontSize(15);
                    document.Add(subheader);

                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph($"Bill's ID: {id}"));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph($"Customer's name: {customerName}"));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph($"CCCD: {cccd}"));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph($"Car's name: {carName}"));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph($"Hired date: {hiredAt}"));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph($"Returned date: {returnedAt}"));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph($"Price: {price} VND"));

                    // You can add more content as needed

                    // Close the document
                    document.Close();
                }

                MessageBox.Show("PDF exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BUS_Schedule.updateSchedule(new DTO_Schedule(id, hiredAt, returnedAt, Convert.ToInt32(price), true));
                BUS_Car BUS_car = new BUS_Car();
                BUS_car.returnCar(carId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
