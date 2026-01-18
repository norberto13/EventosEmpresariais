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
            lblIdEvento = new Label();
            txtIdEvento = new TextBox();
            LblNomeEvento = new Label();
            txtNomeEvento = new TextBox();
            lblDataEvento = new Label();
            dtpDataEvento = new DateTimePicker();
            lblLocal = new Label();
            txtLocal = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            btnInserir = new Button();
            btnAtualizar = new Button();
            btEliminar = new Button();
            btnLimpar = new Button();
            btnListar = new Button();
            btnSair = new Button();
            dgvEventos = new DataGridView();
            grpDadosEveto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
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
            grpDadosEveto.Location = new Point(174, 19);
            grpDadosEveto.Name = "grpDadosEveto";
            grpDadosEveto.Size = new Size(378, 317);
            grpDadosEveto.TabIndex = 0;
            grpDadosEveto.TabStop = false;
            grpDadosEveto.Text = "Dados do Evento";
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
            // txtIdEvento
            // 
            txtIdEvento.Location = new Point(197, 40);
            txtIdEvento.Name = "txtIdEvento";
            txtIdEvento.ReadOnly = true;
            txtIdEvento.Size = new Size(100, 23);
            txtIdEvento.TabIndex = 2;
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
            // txtNomeEvento
            // 
            txtNomeEvento.Location = new Point(197, 91);
            txtNomeEvento.Name = "txtNomeEvento";
            txtNomeEvento.Size = new Size(100, 23);
            txtNomeEvento.TabIndex = 4;
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
            // dtpDataEvento
            // 
            dtpDataEvento.Format = DateTimePickerFormat.Short;
            dtpDataEvento.Location = new Point(197, 133);
            dtpDataEvento.Name = "dtpDataEvento";
            dtpDataEvento.Size = new Size(100, 23);
            dtpDataEvento.TabIndex = 6;
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
            // txtLocal
            // 
            txtLocal.Location = new Point(197, 193);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(100, 23);
            txtLocal.TabIndex = 8;
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
            // txtDescricao
            // 
            txtDescricao.Location = new Point(163, 252);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtDescricao.Size = new Size(192, 59);
            txtDescricao.TabIndex = 10;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(152, 396);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(281, 396);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(405, 396);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(75, 23);
            btEliminar.TabIndex = 3;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(531, 396);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(224, 475);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 5;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(477, 475);
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
            dgvEventos.Location = new Point(263, 567);
            dgvEventos.MultiSelect = false;
            dgvEventos.Name = "dgvEventos";
            dgvEventos.ReadOnly = true;
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.Size = new Size(240, 150);
            dgvEventos.TabIndex = 7;
            // 
            // FrmEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 835);
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
    }
}
