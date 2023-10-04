using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace site
{
    public partial class Form1 : Form
    {
        private int Id;

        public Form1()
        {
            InitializeComponent();
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateListView()
        {
            Listao.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM FIEL";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string nome = (string)dr["Nome"];
                    string email = (string)dr["Email"];
                    string telefone = (string)dr["Telefone"];
                    string senha = (string)dr["Senha"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(nome);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(telefone);
                    lv.SubItems.Add(senha);
                    Listao.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtentrar_Click(object sender, EventArgs e)
        {
            string nome = textnome.Text, email = textemail.Text, telefone = texttele.Text, senha = textsenha.Text;

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            {
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"INSERT INTO FIEL VALUES (@Nome, @Email, @Telefone, @Senha)";

                sqlCommand.Parameters.AddWithValue("@Nome", textnome.Text);
                sqlCommand.Parameters.AddWithValue("@Email", textemail.Text);
                sqlCommand.Parameters.AddWithValue("@Telefone", texttele.Text);
                sqlCommand.Parameters.AddWithValue("@Senha", textsenha.Text);
                sqlCommand.ExecuteNonQuery();
            };


            MessageBox.Show("Cadastro realizado com sucesso!");
        }

        private void txtedit_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE FIEL SET

            Nome       = @nome, 
            Email      = @email,
            Telefone   = @telefone, 
            Senha      = @senha
            where 
            ID = @ID";

            sqlCommand.Parameters.AddWithValue("@nome", textnome.Text);
            sqlCommand.Parameters.AddWithValue("@email", textemail.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", texttele.Text);
            sqlCommand.Parameters.AddWithValue("@senha", textsenha.Text);
            sqlCommand.Parameters.AddWithValue("@id", Id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Editado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            textnome.Clear();
            texttele.Clear();
            textemail.Clear();
            textsenha.Clear();


            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void txtexcluir_Click(object sender, EventArgs e)
        {
            //Código para excluir
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM FIEL WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void Tele_Click(object sender, EventArgs e)
        {

        }

        private void senha_Click(object sender, EventArgs e)
        {

        }

        private void texttele_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
