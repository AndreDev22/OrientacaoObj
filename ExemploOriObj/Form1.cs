using ExemploOriObj.Controller;
using ExemploOriObj.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ExemploOriObj
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private string con = "server=localhost;port=3306;User Id=root;database=biblioteca;password=12345";
        MySqlConnection connection = null;
        MySqlCommand cmd;

        //Metodo para fechar conexoes em catchs
        public void Fechacatch()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int data = int.Parse(DateTime.Now.Hour.ToString());


            if (data < 12)
            {
                lblMsg.Text = "Bom Dia!";
            }
            else if (data < 18)
            {
                lblMsg.Text = "Boa Tarde!";
            }
            else
            {
                lblMsg.Text = "Boa Noite!";
            }
            ListarAlunos();

        }
        private void ListarAlunos()
        {
            //chamando controlador e listando no data grid view
            AlunoController alunoController = new AlunoController();
            dgvAlunos.DataSource = alunoController.Listar();

            //definindo tamanho da coluna de acordo com o conteúdo
            dgvAlunos.AutoResizeColumns();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            int rm;

            if (txbRM.Text != "" && txbNome.Text != "" && txbEmail.Text != "")
            {
                if (int.TryParse(txbRM.Text, out rm))
                {
                    try
                    {
                        connection = new MySqlConnection(con);

                        connection.Open();

                        //comando de query mysql
                        cmd = new MySqlCommand("select RM from aluno where RM= @RM;", connection);
                        cmd.Parameters.AddWithValue("@RM", rm);
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.Text;
                        MySqlDataReader dr = cmd.ExecuteReader();
                        //objeto de leitura
                        dr.Read();
                        //pego posições e atribuo a variável
                        MessageBox.Show("O aluno de RM = " + dr.GetInt32(0) + " já foi cadastrado", "Aluno cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                        connection.Close();


                    }
                    catch (Exception/* erro*/)
                    {
                        //MessageBox.Show(erro.Message);
                        //MessageBox.Show("Erro "+erro);
                        Fechacatch();
                        CadastroAluno();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o RM apenas com números", "RM inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados para cadastrar o aluno!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CadastroAluno()
        {
            try
            {
                connection = new MySqlConnection(con);

                connection.Open();
                cmd = new MySqlCommand("insert into aluno (RM, Nome, Email, NEmprestimo) values(?, ?, ?, 0);", connection);
                cmd.Parameters.AddWithValue("@RM", txbRM.Text);
                cmd.Parameters.AddWithValue("@Nome", txbNome.Text);
                cmd.Parameters.AddWithValue("@Email", txbEmail.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Aluno cadastrado com sucesso!!!");
                Limpar();
                ListarAlunos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            txbNome.Clear();
            txbRM.Clear();
            txbEmail.Clear();
        }


        //chamada de orientação
        private void BuscarAluno(AlunoModel alunoModel)
        {
            alunoModel.Nome = txbBusca.text.Trim();

            AlunoController alunoController = new AlunoController();
            dgvAlunos.DataSource = alunoController.PesquisarNome(alunoModel);
        }
        private void txbBusca_OnTextChange(object sender, EventArgs e)
        {
            //condição para caso o texto esteja nulo, apresentar o padrão
            if (txbBusca.text == "")
            {
                AlunoController alunoController = new AlunoController();

                dgvAlunos.DataSource = alunoController.Listar();
            }
            else
            {
                AlunoModel alunoModel = new AlunoModel();
                BuscarAluno(alunoModel);
            }
        }
    }
}
