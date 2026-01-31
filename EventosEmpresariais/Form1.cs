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
            CarregarParticipantes();

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


        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection ligacao = new SqlConnection(Db.StringLigacao);
                using SqlCommand comando = new SqlCommand("spInserirEvento", ligacao);

                comando.CommandType = CommandType.StoredProcedure;

                // Parâmetros do SQL (confirmados na tua SP)
                comando.Parameters.AddWithValue("@Nome", txtNomeEvento.Text.Trim());
                comando.Parameters.AddWithValue("@Data", dtpDataEvento.Value.Date);
                comando.Parameters.AddWithValue("@Local", txtLocal.Text.Trim());

                ligacao.Open();
                comando.ExecuteNonQuery();

                CarregarEventos();
                MessageBox.Show("Evento inserido com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir evento: " + ex.Message);
            }
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita erro quando clicas no cabeçalho
            if (e.RowIndex < 0) return;

            DataGridViewRow linha = dgvEventos.Rows[e.RowIndex];

            // Ajusta os nomes conforme as colunas que tens no SELECT (IdEvento, Nome, Data, Local)
            txtIdEvento.Text = linha.Cells["IdEvento"].Value?.ToString();
            txtNomeEvento.Text = linha.Cells["Nome"].Value?.ToString();
            dtpDataEvento.Value = Convert.ToDateTime(linha.Cells["Data"].Value);
            txtLocal.Text = linha.Cells["Local"].Value?.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            // [Variáveis]
            int idEvento;

            // [Validação]
            if (!int.TryParse(txtIdEvento.Text, out idEvento))
            {
                MessageBox.Show("Selecione um evento na grelha.");
                return;
            }

            try
            {
                using SqlConnection ligacao = new SqlConnection(Db.StringLigacao);
                using SqlCommand comando = new SqlCommand("spAtualizarEvento", ligacao);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdEvento", idEvento);
                comando.Parameters.AddWithValue("@Nome", txtNomeEvento.Text.Trim());
                comando.Parameters.AddWithValue("@Data", dtpDataEvento.Value.Date);
                comando.Parameters.AddWithValue("@Local", txtLocal.Text.Trim());

                ligacao.Open();
                comando.ExecuteNonQuery();

                CarregarEventos();
                MessageBox.Show("Evento atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar evento: " + ex.Message);
            }

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {


            int idEvento;

            if (!int.TryParse(txtIdEvento.Text, out idEvento))
            {
                MessageBox.Show("Selecione um evento na grelha.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem a certeza que pretende eliminar este evento?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta != DialogResult.Yes) return;

            try
            {
                using SqlConnection ligacao = new SqlConnection(Db.StringLigacao);
                using SqlCommand comando = new SqlCommand("spEliminarEvento", ligacao);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEvento", idEvento);

                ligacao.Open();
                comando.ExecuteNonQuery();

                CarregarEventos();
                MessageBox.Show("Evento eliminado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar evento: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdEvento.Clear();
            txtNomeEvento.Clear();
            txtLocal.Clear();
            txtDescricao.Clear(); // se existir no teu projeto
            dtpDataEvento.Value = DateTime.Today;

            // Tirar seleção da grelha (se houver)
            dgvEventos.ClearSelection();
        }

        // =====================================================
        // PARTICIPANTES - Métodos e Eventos (CRUD)
        // =====================================================

        private void CarregarParticipantes()
        {
            try
            {
                using SqlConnection ligacao = new SqlConnection(Db.StringLigacao);
                using SqlCommand comando = new SqlCommand("spListarParticipantes", ligacao);

                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvParticipantes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar participantes: " + ex.Message);
            }
        }

        private void LimparParticipantes()
        {
            txtIdParticipante.Clear();
            txtNomeParticipante.Clear();
            txtEmail.Clear();

            dgvParticipantes.ClearSelection();
            txtNomeParticipante.Focus();
        }

        private void btnAdicionarParticipante_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection ligacao = new SqlConnection(Db.StringLigacao);
                using SqlCommand comando = new SqlCommand("spAdicionarParticipante", ligacao);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NomeParticipante", txtNomeParticipante.Text);
                comando.Parameters.AddWithValue("@Email", txtEmail.Text);

                ligacao.Open();
                comando.ExecuteNonQuery();

                CarregarParticipantes();
                MessageBox.Show("Participante inserido com sucesso.");
                LimparParticipantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir participante: " + ex.Message);
            }
        }

        private void btnAtualizarParticipante_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdParticipante.Text, out int idParticipante))
            {
                MessageBox.Show("Seleciona um participante primeiro.");
                return;
            }

            try
            {
                using SqlConnection ligacao = new SqlConnection(Db.StringLigacao);
                using SqlCommand comando = new SqlCommand("spAtualizarParticipante", ligacao);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdParticipante", idParticipante);
                comando.Parameters.AddWithValue("@NomeParticipante", txtNomeParticipante.Text);
                comando.Parameters.AddWithValue("@Email", txtEmail.Text);

                ligacao.Open();
                comando.ExecuteNonQuery();

                CarregarParticipantes();
                MessageBox.Show("Participante atualizado com sucesso.");
                LimparParticipantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar participante: " + ex.Message);
            }
        }

        private void btnEliminarParticipante_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdParticipante.Text, out int idParticipante))
            {
                MessageBox.Show("Seleciona um participante primeiro.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tens a certeza que queres eliminar este participante?",
                "Confirmar eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes) return;

            try
            {
                using SqlConnection ligacao = new SqlConnection(Db.StringLigacao);
                using SqlCommand comando = new SqlCommand("spEliminarParticipante", ligacao);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdParticipante", idParticipante);

                ligacao.Open();
                comando.ExecuteNonQuery();

                CarregarParticipantes();
                MessageBox.Show("Participante eliminado com sucesso.");
                LimparParticipantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar participante: " + ex.Message);
            }
        }

        private void btnLimparParticipante_Click(object sender, EventArgs e)
        {
            LimparParticipantes();
        }

        private void dgvParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtIdParticipante.Text = dgvParticipantes.Rows[e.RowIndex].Cells["IdParticipante"].Value.ToString();
            txtNomeParticipante.Text = dgvParticipantes.Rows[e.RowIndex].Cells["NomeParticipante"].Value.ToString();
            txtEmail.Text = dgvParticipantes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
        }

      
    }



}

