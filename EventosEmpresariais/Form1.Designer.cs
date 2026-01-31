namespace EventosEmpresariais
{
    partial class FrmEventos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDadosEveto = new GroupBox();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtLocal = new TextBox();
            lblLocal = new Label();
            dtpDataEvento = new DateTimePicker();
            lblDataEvento = new Label();
            txtNomeEvento = new TextBox();
            LblNomeEvento = new Label();
            txtIdEvento = new TextBox();
            lblIdEvento = new Label();
            btnInserir = new Button();
            btnAtualizar = new Button();
            btEliminar = new Button();
            btnLimpar = new Button();
            btnListar = new Button();
            btnSair = new Button();
            dgvEventos = new DataGridView();
            grpParticipantes = new GroupBox();
            btnLimparParticipante = new Button();
            btnEliminarParticipante = new Button();
            btnAtualizarParticipante = new Button();
            btnAdicionarParticipante = new Button();
            txtEmail = new TextBox();
            label4 = new Label();
            txtNomeParticipante = new TextBox();
            txtIdParticipante = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvParticipantes = new DataGridView();
            grpDadosEveto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            grpParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            SuspendLayout();
            // 
            // grpDadosEveto
            // 
            grpDadosEveto.Controls.Add(txtDescricao);
            grpDadosEveto.Controls.Add(lblDescricao);
            grpDadosEveto.Controls.Add(txtLocal);
            grpDadosEveto.Controls.Add(lblLocal);
            grpDadosEveto.Controls.Add(dtpDataEvento);
            grpDadosEveto.Controls.Add(lblDataEvento);
            grpDadosEveto.Controls.Add(txtNomeEvento);
            grpDadosEveto.Controls.Add(LblNomeEvento);
            grpDadosEveto.Controls.Add(txtIdEvento);
            grpDadosEveto.Controls.Add(lblIdEvento);
            grpDadosEveto.Location = new Point(27, 19);
            grpDadosEveto.Name = "grpDadosEveto";
            grpDadosEveto.Size = new Size(525, 317);
            grpDadosEveto.TabIndex = 0;
            grpDadosEveto.TabStop = false;
            grpDadosEveto.Text = "Dados do Evento";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(163, 252);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtDescricao.Size = new Size(192, 59);
            txtDescricao.TabIndex = 10;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(15, 268);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 9;
            lblDescricao.Text = "Descrição:";
            lblDescricao.Click += lblDescricao_Click;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(197, 193);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(100, 23);
            txtLocal.TabIndex = 8;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Location = new Point(15, 196);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(38, 15);
            lblLocal.TabIndex = 7;
            lblLocal.Text = "Local:";
            // 
            // dtpDataEvento
            // 
            dtpDataEvento.Format = DateTimePickerFormat.Short;
            dtpDataEvento.Location = new Point(197, 133);
            dtpDataEvento.Name = "dtpDataEvento";
            dtpDataEvento.Size = new Size(100, 23);
            dtpDataEvento.TabIndex = 6;
            // 
            // lblDataEvento
            // 
            lblDataEvento.AutoSize = true;
            lblDataEvento.Location = new Point(15, 139);
            lblDataEvento.Name = "lblDataEvento";
            lblDataEvento.Size = new Size(89, 15);
            lblDataEvento.TabIndex = 5;
            lblDataEvento.Text = "Data de Evento:";
            // 
            // txtNomeEvento
            // 
            txtNomeEvento.Location = new Point(197, 91);
            txtNomeEvento.Name = "txtNomeEvento";
            txtNomeEvento.Size = new Size(100, 23);
            txtNomeEvento.TabIndex = 4;
            // 
            // LblNomeEvento
            // 
            LblNomeEvento.AutoSize = true;
            LblNomeEvento.Location = new Point(15, 94);
            LblNomeEvento.Name = "LblNomeEvento";
            LblNomeEvento.Size = new Size(99, 15);
            LblNomeEvento.TabIndex = 3;
            LblNomeEvento.Text = "Nome do Evento:";
            // 
            // txtIdEvento
            // 
            txtIdEvento.Location = new Point(197, 40);
            txtIdEvento.Name = "txtIdEvento";
            txtIdEvento.ReadOnly = true;
            txtIdEvento.Size = new Size(100, 23);
            txtIdEvento.TabIndex = 2;
            // 
            // lblIdEvento
            // 
            lblIdEvento.AutoSize = true;
            lblIdEvento.Location = new Point(15, 43);
            lblIdEvento.Name = "lblIdEvento";
            lblIdEvento.Size = new Size(21, 15);
            lblIdEvento.TabIndex = 1;
            lblIdEvento.Text = "ID:";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(30, 362);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(181, 362);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(332, 362);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(75, 23);
            btEliminar.TabIndex = 3;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(477, 362);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(105, 411);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 5;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(400, 411);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // dgvEventos
            // 
            dgvEventos.AllowUserToAddRows = false;
            dgvEventos.AllowUserToDeleteRows = false;
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(27, 454);
            dgvEventos.MultiSelect = false;
            dgvEventos.Name = "dgvEventos";
            dgvEventos.ReadOnly = true;
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.Size = new Size(525, 133);
            dgvEventos.TabIndex = 7;
            dgvEventos.CellClick += dgvEventos_CellClick;
            // 
            // grpParticipantes
            // 
            grpParticipantes.Controls.Add(btnLimparParticipante);
            grpParticipantes.Controls.Add(btnEliminarParticipante);
            grpParticipantes.Controls.Add(btnAtualizarParticipante);
            grpParticipantes.Controls.Add(btnAdicionarParticipante);
            grpParticipantes.Controls.Add(txtEmail);
            grpParticipantes.Controls.Add(label4);
            grpParticipantes.Controls.Add(txtNomeParticipante);
            grpParticipantes.Controls.Add(txtIdParticipante);
            grpParticipantes.Controls.Add(label3);
            grpParticipantes.Controls.Add(label2);
            grpParticipantes.Controls.Add(label1);
            grpParticipantes.Location = new Point(27, 593);
            grpParticipantes.Name = "grpParticipantes";
            grpParticipantes.Size = new Size(525, 201);
            grpParticipantes.TabIndex = 8;
            grpParticipantes.TabStop = false;
            grpParticipantes.Text = "Dados do Participante";
            // 
            // btnLimparParticipante
            // 
            btnLimparParticipante.Location = new Point(440, 164);
            btnLimparParticipante.Name = "btnLimparParticipante";
            btnLimparParticipante.Size = new Size(75, 23);
            btnLimparParticipante.TabIndex = 18;
            btnLimparParticipante.Text = "Limpar";
            btnLimparParticipante.UseVisualStyleBackColor = true;
            btnLimparParticipante.Click += btnLimparParticipante_Click;
            // 
            // btnEliminarParticipante
            // 
            btnEliminarParticipante.Location = new Point(440, 117);
            btnEliminarParticipante.Name = "btnEliminarParticipante";
            btnEliminarParticipante.Size = new Size(75, 23);
            btnEliminarParticipante.TabIndex = 17;
            btnEliminarParticipante.Text = "Eliminar";
            btnEliminarParticipante.UseVisualStyleBackColor = true;
            btnEliminarParticipante.Click += btnEliminarParticipante_Click;
            // 
            // btnAtualizarParticipante
            // 
            btnAtualizarParticipante.Location = new Point(440, 76);
            btnAtualizarParticipante.Name = "btnAtualizarParticipante";
            btnAtualizarParticipante.Size = new Size(75, 23);
            btnAtualizarParticipante.TabIndex = 16;
            btnAtualizarParticipante.Text = "Atualizar";
            btnAtualizarParticipante.UseVisualStyleBackColor = true;
            btnAtualizarParticipante.Click += btnAtualizarParticipante_Click;
            // 
            // btnAdicionarParticipante
            // 
            btnAdicionarParticipante.Location = new Point(440, 26);
            btnAdicionarParticipante.Name = "btnAdicionarParticipante";
            btnAdicionarParticipante.Size = new Size(75, 23);
            btnAdicionarParticipante.TabIndex = 15;
            btnAdicionarParticipante.Text = "Inserir";
            btnAdicionarParticipante.UseVisualStyleBackColor = true;
            btnAdicionarParticipante.Click += btnAdicionarParticipante_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(176, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 172);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "Email:";
            // 
            // txtNomeParticipante
            // 
            txtNomeParticipante.Location = new Point(176, 105);
            txtNomeParticipante.Name = "txtNomeParticipante";
            txtNomeParticipante.Size = new Size(193, 23);
            txtNomeParticipante.TabIndex = 12;
            // 
            // txtIdParticipante
            // 
            txtIdParticipante.Location = new Point(174, 34);
            txtIdParticipante.Name = "txtIdParticipante";
            txtIdParticipante.ReadOnly = true;
            txtIdParticipante.Size = new Size(193, 23);
            txtIdParticipante.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 105);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 11;
            label3.Text = "Nome do Participante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 34);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 9;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.AllowUserToAddRows = false;
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Location = new Point(576, 240);
            dgvParticipantes.MultiSelect = false;
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.ReadOnly = true;
            dgvParticipantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParticipantes.Size = new Size(346, 220);
            dgvParticipantes.TabIndex = 9;
            dgvParticipantes.CellClick += dgvParticipantes_CellClick;
            // 
            // FrmEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 835);
            Controls.Add(dgvParticipantes);
            Controls.Add(grpParticipantes);
            Controls.Add(dgvEventos);
            Controls.Add(btnSair);
            Controls.Add(btnListar);
            Controls.Add(btnLimpar);
            Controls.Add(btEliminar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(grpDadosEveto);
            MinimizeBox = false;
            Name = "FrmEventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Eventos";
            Load += Form1_Load;
            grpDadosEveto.ResumeLayout(false);
            grpDadosEveto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            grpParticipantes.ResumeLayout(false);
            grpParticipantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDadosEveto;
        private Label lblIdEvento;
        private TextBox txtIdEvento;
        private TextBox txtNomeEvento;
        private Label LblNomeEvento;
        private TextBox txtLocal;
        private Label lblLocal;
        private DateTimePicker dtpDataEvento;
        private Label lblDataEvento;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private Button btnInserir;
        private Button btnAtualizar;
        private Button btEliminar;
        private Button btnLimpar;
        private Button btnListar;
        private Button btnSair;
        private DataGridView dgvEventos;
        private GroupBox grpParticipantes;
        private Label label1;
        private Label label2;
        private TextBox txtIdParticipante;
        private TextBox txtNomeParticipante;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Button btnLimparParticipante;
        private Button btnEliminarParticipante;
        private Button btnAtualizarParticipante;
        private Button btnAdicionarParticipante;
        private DataGridView dgvParticipantes;
    }
}
