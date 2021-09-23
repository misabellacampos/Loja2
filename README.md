# Loja2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Loja_de_tênis_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "tênis";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();


        }
        private void limparCampos()
        {
            tbID.Clear();
            tbMarca.Clear();
            tbModelo.Clear();
            tbCor.Clear();
            tbAno.Clear();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();

        }
        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaconexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaconexaoBD.Open();
                MySqlCommand comandoMySql = realizaconexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM tênis ";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgTenis.Rows.Clear();
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgTenis.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//MARCA
                    row.Cells[2].Value = reader.GetString(2);//MODELO
                    row.Cells[3].Value = reader.GetString(3);//COR
                    row.Cells[4].Value = reader.GetString(4);//ANO
                    dgTenis.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaconexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL CONECTAR!");
                Console.WriteLine(ex.Message);
            }


        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO tênis (marcaTênis,modeloTênis,corTênis,anoTênis) " +
                    "VALUES('" + tbMarca.Text + "', '" + tbModelo.Text + "','" + tbCor.Text + "', " + Convert.ToInt16(tbAno.Text) + ")";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso!");
                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaconexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaconexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaconexaoBD.CreateCommand(); //Crio um comando SQL

                comandoMySql.CommandText = "UPDATE tênis   SET marcaTênis= '" + tbMarca + "', " +
                    "modeloTênis = '" + tbModelo.Text + "', " +
                    "corTênis = '" + tbCor.Text + "', " +
                    "anoTênis = " + Convert.ToInt16(tbAno.Text) +
                    " WHERE   tênis.   idTênis = " + tbID.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaconexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaconexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaconexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaconexaoBD.CreateCommand(); //Crio um comando SQL

                comandoMySql.CommandText = "UPDATE tênis SET ativoTênis = 0 WHERE idTênis = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaconexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dgTenis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgTenis.CurrentRow.Selected = true;
            //preenche os textbox com as células da linha selecionada
            tbMarca.Text = dgTenis.Rows[e.RowIndex].Cells["colunaMarca"].FormattedValue.ToString();
            tbModelo.Text = dgTenis.Rows[e.RowIndex].Cells["colunaModelo"].FormattedValue.ToString();
            tbCor.Text = dgTenis.Rows[e.RowIndex].Cells["colunaCor"].FormattedValue.ToString();
            tbAno.Text = dgTenis.Rows[e.RowIndex].Cells["colunaAno"].FormattedValue.ToString();
            tbID.Text = dgTenis.Rows[e.RowIndex].Cells["colunaID"].FormattedValue.ToString();
        }
    }
} 
