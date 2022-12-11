using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-19E94AR\SQLEXPRESS;Database=crudDB;User Id=sa ;Password=caiovargas01@;");
                strSQL = "INSERT INTO FUNCIONARIO (MATRICULA, NOME, ENDERECO, SEXO, DTNASCIMENTO, SALARIO, TELEFONE, IDADE) VALUES (@MATRICULA, @NOME, @ENDERECO, @SEXO, @DTNASCIMENTO, @SALARIO, @TELEFONE, @IDADE)";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@MATRICULA", tbMat.Text);
                comando.Parameters.AddWithValue("@NOME", tbNom.Text);
                comando.Parameters.AddWithValue("@ENDERECO", tbEnd.Text);
                comando.Parameters.AddWithValue("@SEXO", tbSex.Text);
                comando.Parameters.AddWithValue("@DTNASCIMENTO", Databox.Value);
                comando.Parameters.AddWithValue("@SALARIO", tbSal.Text);
                comando.Parameters.AddWithValue("@TELEFONE", tbTel.Text);
                comando.Parameters.AddWithValue("@IDADE", tbIdade.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }


        }

        private void btnConsul_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-19E94AR\SQLEXPRESS;Database=crudDB;User Id=sa ;Password=caiovargas01@;");
                strSQL = "SELECT * FROM FUNCIONARIO WHERE MATRICULA = @MATRICULA";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@MATRICULA", tbMat.Text);

                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    tbNom.Text = (string)dr["nome"];
                    tbEnd.Text = (string)dr["endereco"];
                    tbSex.Text = (string)dr["sexo"];
                    tbSal.Text = Convert.ToString(dr["salario"]);
                    tbTel.Text = (string)dr["telefone"];
                    tbIdade.Text = Convert.ToString(dr["idade"]);



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void btnExib_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-19E94AR\SQLEXPRESS;Database=crudDB;User Id=sa ;Password=caiovargas01@;");
                strSQL = "SELECT * FROM FUNCIONARIO";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-19E94AR\SQLEXPRESS;Database=crudDB;User Id=sa ;Password=caiovargas01@;");
                strSQL = "UPDATE FUNCIONARIO SET MATRICULA = @MATRICULA, NOME = @NOME, ENDERECO = @ENDERECO, SEXO = @SEXO, DTNASCIMENTO = @DTNASCIMENTO, SALARIO = @SALARIO, TELEFONE = @TELEFONE, IDADE = @IDADE";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@MATRICULA", tbMat.Text);
                comando.Parameters.AddWithValue("@NOME", tbNom.Text);
                comando.Parameters.AddWithValue("@ENDERECO", tbEnd.Text);
                comando.Parameters.AddWithValue("@SEXO", tbSex.Text);
                comando.Parameters.AddWithValue("@DTNASCIMENTO", Databox.Value);
                comando.Parameters.AddWithValue("@SALARIO", tbSal.Text);
                comando.Parameters.AddWithValue("@TELEFONE", tbTel.Text);
                comando.Parameters.AddWithValue("@IDADE", tbIdade.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbSex_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExclu_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-19E94AR\SQLEXPRESS;Database=crudDB;User Id=sa ;Password=caiovargas01@;");
                strSQL = "DELETE FUNCIONARIO WHERE MATRICULA = @MATRICULA";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@MATRICULA", tbMat.Text);
                comando.Parameters.AddWithValue("@NOME", tbNom.Text);
                comando.Parameters.AddWithValue("@ENDERECO", tbEnd.Text);
                comando.Parameters.AddWithValue("@SEXO", tbSex.Text);
                comando.Parameters.AddWithValue("@DTNASCIMENTO", Databox.Value);
                comando.Parameters.AddWithValue("@SALARIO", tbSal.Text);
                comando.Parameters.AddWithValue("@TELEFONE", tbTel.Text);
                comando.Parameters.AddWithValue("@IDADE", tbIdade.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
