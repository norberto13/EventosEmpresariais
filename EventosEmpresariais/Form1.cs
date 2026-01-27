using System.Data;
using Microsoft.Data.SqlClient;


namespace EventosEmpresariais
{
    public partial class FrmEventos : Form
    {
        public FrmEventos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarEventos();
        }

        private void CarregarEventos()
        {
            
                try
                {
                    using SqlConnection ligacao = new SqlConnection(Db.StringLigacao);
                    using SqlCommand comando = new SqlCommand("spListarEventos", ligacao);

                    comando.CommandType = CommandType.StoredProcedure;

                    DataTable tabela = new DataTable();

                    ligacao.Open();
                    using SqlDataReader leitor = comando.ExecuteReader();
                    tabela.Load(leitor);

                    dgvEventos.DataSource = tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar eventos: " + ex.Message);
                }
            

        }



        private void lblDescricao_Click(object sender, EventArgs e)
        {

        }
    }
}
