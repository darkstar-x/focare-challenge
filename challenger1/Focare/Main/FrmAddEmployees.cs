using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class FrmAddEmployees : Form
    {
        int id;
        bool delete = false;
        Employees employee = new Employees();

        // Mouse down event for drag position
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int message, int wparam, int lparam);

        public FrmAddEmployees(int id, bool delete = false)
        {
            InitializeComponent();
            this.id = id;
            this.delete = delete;

            if(this.id > 0)
            {
                employee.GetEmployeeById(this.id);
                txtEmployeeName.Text = employee.Nome;
                txtEmployeeAge.Text = employee.Idade.ToString();
                txtEmployeeModal.Text = employee.Modalidade;
                txtEmployeeState.Text = employee.Stado;
                txtEmployeeLevel.Text = employee.Nivel.ToString();
                txtEmployeePay.Text = employee.Salario.ToString();
                txtOcupacion.Text = employee.Cargo;
                
                // Checkable button
                if(employee.Genero == 'M')
                    rbtMale.Checked = true;
                else
                    rbtFemale.Checked = true;
            }

            if (this.delete == true)
            {
                LockFormFields();
                btnWrite.Visible = false;
                btnDeleteEmployee.Visible = true;
            }
        }
        
        public void LockFormFields()
        {
            txtEmployeeName.Enabled = false;
            txtEmployeeModal.Enabled = false;
            txtEmployeeAge.Enabled = false;
            txtEmployeePay.Enabled = false;
            txtEmployeeState.Enabled = false;
            txtOcupacion.Enabled = false;
            txtEmployeeLevel.Enabled = false;
            rbtFemale.Enabled = false;
            rbtMale.Enabled = false;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                employee.Nome = txtEmployeeName.Text;
                employee.Idade = Convert.ToInt32(txtEmployeeAge.Text);
                employee.Stado = txtEmployeeState.Text;
                employee.Nivel = Convert.ToInt32(txtEmployeeLevel.Text);
                employee.Modalidade = txtEmployeeModal.Text;
                employee.Salario = Convert.ToDecimal(txtEmployeePay.Text);
                employee.Cargo = txtOcupacion.Text;

                if (rbtMale.Checked == true)
                    employee.Genero = 'M';
                else
                    employee.Genero = 'F';

                // Update and write data 
                employee.WriteUpdateData();

                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Mouse down instance
        private void FrmAddEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private bool ValidateForm()
        {
            if (txtEmployeeName.Text == "")
            {
                MessageBox.Show("Name is required");
                txtEmployeeName.Focus();
                return false;
            }
            else if (txtEmployeeAge.Text == "")
            {
                MessageBox.Show("Age is required");
                txtEmployeeAge.Focus();
                return false;
            }
            else if (txtEmployeeModal.Text == "")
            {
                MessageBox.Show("Modal is required");
                txtEmployeeModal.Focus();
                return false;
            }
            else if (txtEmployeePay.Text == "")
            {
                MessageBox.Show("Pay is required");
                txtEmployeePay.Focus();
                return false;
            }
            else if (txtEmployeeState.Text == "")
            {
                MessageBox.Show("State is required");
                txtEmployeeState.Focus();
                return false;
            }
            else if (txtOcupacion.Text == "")
            {
                MessageBox.Show("Ocupation is required");
                txtOcupacion.Focus();
                return false;
            }
            else if (txtEmployeeLevel.Text == "")
            {
                MessageBox.Show("Level is required");
                txtEmployeeLevel.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            employee.DeleteEmployee();
            Close();
        }
    }
}
