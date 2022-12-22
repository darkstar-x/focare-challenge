using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    class Employees
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Genero { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public string Stado { get; set; }
        public string Modalidade { get; set; }
        public decimal Salario { get; set; }
        public int Nivel { get; set; }

        // All employees
        public static DataTable GetEmployees(string search = "")
        {
            var dataTable = new DataTable();
            var sqlCommand = "select * from Tbl_Employees";

            if (search != "")
                sqlCommand += "near * FROM Tbl_Employees.Nome WHERE Nome ' + search + '";

            try
            {
                using (var connection = new MySqlConnection(SQL_Connection.connectionStr))
                {
                    connection.Open();
                    using (var da = new MySqlDataAdapter(sqlCommand, connection))
                    {
                        da.Fill(dataTable);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
           return dataTable;
        }

        // Get EmployeeById
        public void GetEmployeeById(int id)
        {
            var sqlCommand = "select * from Tbl_Employees where id=" + id;

            try
            {
                using (var connection = new MySqlConnection(SQL_Connection.connectionStr))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(sqlCommand, connection))
                    {
                        using (var dataRead = command.ExecuteReader())
                        {
                            if(dataRead.HasRows)
                            {
                                if(dataRead.Read())
                                {
                                    this.Id = Convert.ToInt32(dataRead["id"]);
                                    this.Nome = dataRead["nome"].ToString();
                                    this.Genero = Convert.ToChar(dataRead["genero"]);
                                    this.Idade = Convert.ToInt32(dataRead["idade"]);
                                    this.Cargo = dataRead["cargo"].ToString();
                                    this.Stado = dataRead["stado"].ToString();
                                    this.Modalidade = dataRead["modalidade"].ToString();
                                    this.Salario = Convert.ToDecimal(dataRead["salario"]);
                                    this.Nivel = Convert.ToInt32(dataRead["nivel"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void DeleteEmployee()
        {
            var sqlCommand = "DELETE FROM Tbl_Employees WHERE id=" + this.Id;

            try
            {
                using (var connection = new MySqlConnection(SQL_Connection.connectionStr))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(sqlCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void WriteUpdateData()
        {
            var sqlCommand = "";
            if (this.Id == 0)
            {
                sqlCommand = "INSERT INTO Tbl_Employees (nome, genero, idade, cargo, stado, modalidade, salario, nivel) VALUES (@nome, @genero, @idade, @cargo, @stado, @modalidade, @salario, @nivel)";
            }
            else
                sqlCommand = "UPDATE Tbl_Employees SET nome=@nome, genero=@genero, idade=@idade, stado=@stado, nivel=@nivel, modalidade=@modalidade, cargo=@cargo, salario=@salario WHERE id=" + this.Id;

            try
            {
                using (var connection = new MySqlConnection(SQL_Connection.connectionStr))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(sqlCommand, connection))
                    {
                        command.Parameters.AddWithValue("@nome", this.Nome);
                        command.Parameters.AddWithValue("@genero", this.Genero);
                        command.Parameters.AddWithValue("@idade", this.Idade);
                        command.Parameters.AddWithValue("@stado", this.Stado);
                        command.Parameters.AddWithValue("@nivel", this.Nivel);
                        command.Parameters.AddWithValue("@modalidade", this.Modalidade);
                        command.Parameters.AddWithValue("@cargo", this.Cargo);
                        command.Parameters.AddWithValue("@salario", this.Salario);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }
    }
}
