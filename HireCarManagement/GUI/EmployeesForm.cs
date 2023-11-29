using BUS;
using DAO;
using DoubleT.GUI;
using DTO;
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
    public partial class EmployeesForm : Form
    {
        BUS_Employee BUS_Employee = new();
        DataTable employees;
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            employees = BUS_Employee.getAllEmployee();
            dgvEmployee.DataSource = employees;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = tbSearch.Text;
            List<DTO_Employee> searchEmployee = new();
            foreach (DataRow row in employees.Rows)
            {
                searchEmployee.Add(new DTO_Employee(
                    Guid.Parse(row[0].ToString()),
                    row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
            }
            searchEmployee = searchEmployee.Where(employee => employee.Name.Contains(searchStr)).ToList();
            dgvEmployee.DataSource = searchEmployee;
        }
        private void Form2_FormClosedEvent(object sender, EventArgs e)
        {
            // Handle the event, e.g., reload Form1
            EmployeesForm_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.FormClosedEvent += Form2_FormClosedEvent;
            addEmployee.Show();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the data of the clicked row using the RowIndex
                DataGridViewRow selectedRow = dgvEmployee.Rows[e.RowIndex];

                AddEmployee addEmployee = new AddEmployee(new DTO_Employee(
                    Guid.Parse(selectedRow.Cells[0].Value.ToString()),
                    selectedRow.Cells[1].Value.ToString(),
                    selectedRow.Cells[2].Value.ToString(),
                    selectedRow.Cells[3].Value.ToString(),
                    selectedRow.Cells[4].Value.ToString()));

                addEmployee.Show();
                addEmployee.FormClosedEvent += Form2_FormClosedEvent;

            }
        }
    }
}
