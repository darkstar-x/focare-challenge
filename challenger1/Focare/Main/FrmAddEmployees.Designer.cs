
namespace Main
{
    partial class FrmAddEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEmployees));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeModal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeePay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmployeeLevel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(215, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Focare - Registrar novo funcionário";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(657, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 20;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(58, 99);
            this.txtEmployeeName.MaxLength = 50;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(269, 23);
            this.txtEmployeeName.TabIndex = 21;
            // 
            // txtEmployeeState
            // 
            this.txtEmployeeState.Location = new System.Drawing.Point(402, 137);
            this.txtEmployeeState.MaxLength = 20;
            this.txtEmployeeState.Name = "txtEmployeeState";
            this.txtEmployeeState.Size = new System.Drawing.Size(269, 23);
            this.txtEmployeeState.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(347, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Stado:";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(401, 98);
            this.txtOcupacion.MaxLength = 30;
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(269, 23);
            this.txtOcupacion.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(346, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cargo:";
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.Location = new System.Drawing.Point(59, 137);
            this.txtEmployeeAge.MaxLength = 2;
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(269, 23);
            this.txtEmployeeAge.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(4, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Idade:";
            // 
            // txtEmployeeModal
            // 
            this.txtEmployeeModal.Location = new System.Drawing.Point(94, 175);
            this.txtEmployeeModal.MaxLength = 15;
            this.txtEmployeeModal.Name = "txtEmployeeModal";
            this.txtEmployeeModal.Size = new System.Drawing.Size(234, 23);
            this.txtEmployeeModal.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(3, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Modalidade:";
            // 
            // txtEmployeePay
            // 
            this.txtEmployeePay.Location = new System.Drawing.Point(402, 175);
            this.txtEmployeePay.MaxLength = 10;
            this.txtEmployeePay.Name = "txtEmployeePay";
            this.txtEmployeePay.Size = new System.Drawing.Size(269, 23);
            this.txtEmployeePay.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(347, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Salário:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(3, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Nivel:";
            // 
            // txtEmployeeLevel
            // 
            this.txtEmployeeLevel.Location = new System.Drawing.Point(59, 213);
            this.txtEmployeeLevel.MaxLength = 1;
            this.txtEmployeeLevel.Name = "txtEmployeeLevel";
            this.txtEmployeeLevel.Size = new System.Drawing.Size(269, 23);
            this.txtEmployeeLevel.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(346, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Gênero:";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWrite.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnWrite.Image")));
            this.btnWrite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWrite.Location = new System.Drawing.Point(215, 261);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(229, 31);
            this.btnWrite.TabIndex = 37;
            this.btnWrite.Text = "Salvar cadastro";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.ForeColor = System.Drawing.Color.Snow;
            this.rbtMale.Location = new System.Drawing.Point(421, 213);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(80, 19);
            this.rbtMale.TabIndex = 38;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Mascúlino";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.ForeColor = System.Drawing.Color.Snow;
            this.rbtFemale.Location = new System.Drawing.Point(531, 213);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(75, 19);
            this.rbtFemale.TabIndex = 39;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Feminino";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteEmployee.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(215, 261);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(229, 31);
            this.btnDeleteEmployee.TabIndex = 40;
            this.btnDeleteEmployee.Text = "Apagar";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Visible = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // FrmAddEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(685, 304);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.rbtFemale);
            this.Controls.Add(this.rbtMale);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmployeeLevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmployeeModal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmployeePay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmployeeAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmployeeState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddEmployees";
            this.Opacity = 0.97D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAddEmployees_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeModal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeePay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmployeeLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}