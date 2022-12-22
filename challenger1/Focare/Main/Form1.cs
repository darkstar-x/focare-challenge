using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Main
{
    public partial class Form1 : Form
    {
        Employees employees = new Employees();
        DataTable dataTable = new DataTable();

        // Mover janela com o botão esquerdo mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int message, int wparam, int lparam);

        public Form1()
        {
            InitializeComponent();
            StartedDataSource();
        }

        // Inirialize database resources
        private void StartedDataSource()
        {
            dataTable = Employees.GetEmployees();
            mainDataGrid.DataSource = dataTable;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(mainDataGrid.Rows[mainDataGrid.CurrentCell.RowIndex].Cells["Id"].Value);

            using (var frmAddEmployees = new FrmAddEmployees(id))
            {
                frmAddEmployees.ShowDialog();
                mainDataGrid.DataSource = Employees.GetEmployees();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var frmAddEmployees = new FrmAddEmployees(0))
            {
                frmAddEmployees.ShowDialog();
                mainDataGrid.DataSource = Employees.GetEmployees();
            }
        }

        private void pngGithub_MouseHover(object sender, EventArgs e)
        {
            lblGithub.Visible = true;
        }

        private void pngGithub_MouseLeave(object sender, EventArgs e)
        {
            lblGithub.Visible = false;
        }

        private void pngSearchEmployee_Click(object sender, EventArgs e)
        {
            dataTable = Employees.GetEmployees(txtSearchEmployee.Text);
            mainDataGrid.DataSource = dataTable;
            //SetupDataEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(mainDataGrid.Rows[mainDataGrid.CurrentCell.RowIndex].Cells["Id"].Value);

            using (var frm = new FrmAddEmployees(id, true))
            {
                frm.ShowDialog();
                mainDataGrid.DataSource = Employees.GetEmployees();
            }
        }
    }
}
