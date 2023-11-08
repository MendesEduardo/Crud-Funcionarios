namespace CRUD_Funcionarios
{
    partial class Form1
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
            tabControl1 = new TabControl();
            PageConsulta = new TabPage();
            btnListar = new Button();
            listView1 = new ListView();
            Nome = new ColumnHeader();
            Equipe = new ColumnHeader();
            Cargo = new ColumnHeader();
            Salario = new ColumnHeader();
            Horario = new ColumnHeader();
            RG = new ColumnHeader();
            Nascimento = new ColumnHeader();
            CTPS = new ColumnHeader();
            CPF = new ColumnHeader();
            email = new ColumnHeader();
            ID = new ColumnHeader();
            tabPage2 = new TabPage();
            label9 = new Label();
            txtNascimento = new TextBox();
            label7 = new Label();
            txtCtps = new TextBox();
            label2 = new Label();
            txtRg = new TextBox();
            label11 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            txtCpf = new TextBox();
            label8 = new Label();
            txtHorario = new TextBox();
            txt = new Label();
            txtSalario = new TextBox();
            label3 = new Label();
            txtCargo = new TextBox();
            labe = new Label();
            txtEquipe = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            tabPage3 = new TabPage();
            label4 = new Label();
            txtUpdateNascimento = new TextBox();
            label5 = new Label();
            txtUpdateCtps = new TextBox();
            label6 = new Label();
            txtUpdateRg = new TextBox();
            label12 = new Label();
            txtUpdateEmail = new TextBox();
            label13 = new Label();
            txtUpdateCpf = new TextBox();
            label14 = new Label();
            txtUpdateHorario = new TextBox();
            label15 = new Label();
            txtUpdateSalario = new TextBox();
            label16 = new Label();
            txtUpdateCargo = new TextBox();
            label17 = new Label();
            txtUpdateEquipe = new TextBox();
            label18 = new Label();
            txtUpdateNome = new TextBox();
            btnAtualizar = new Button();
            btnBuscar = new Button();
            txtbuscarId = new TextBox();
            tabPage4 = new TabPage();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            btnDeletar = new Button();
            btnBusca = new Button();
            BuscarPeloId = new TextBox();
            tabControl1.SuspendLayout();
            PageConsulta.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PageConsulta);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 369);
            tabControl1.TabIndex = 0;
            // 
            // PageConsulta
            // 
            PageConsulta.Controls.Add(btnListar);
            PageConsulta.Controls.Add(listView1);
            PageConsulta.Location = new Point(4, 24);
            PageConsulta.Name = "PageConsulta";
            PageConsulta.Padding = new Padding(3);
            PageConsulta.Size = new Size(768, 341);
            PageConsulta.TabIndex = 0;
            PageConsulta.Text = "Consultar";
            PageConsulta.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(603, 21);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.AutoArrange = false;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Columns.AddRange(new ColumnHeader[] { Nome, Equipe, Cargo, Salario, Horario, RG, Nascimento, CTPS, CPF, email, ID });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 101);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(756, 186);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 90;
            // 
            // Equipe
            // 
            Equipe.Text = "Equipe";
            // 
            // Cargo
            // 
            Cargo.Text = "Cargo";
            Cargo.Width = 150;
            // 
            // Salario
            // 
            Salario.Text = "Salario";
            Salario.Width = 75;
            // 
            // Horario
            // 
            Horario.Text = "Horario";
            // 
            // RG
            // 
            RG.Text = "RG";
            RG.Width = 70;
            // 
            // Nascimento
            // 
            Nascimento.Text = "Nascimento";
            Nascimento.Width = 90;
            // 
            // CTPS
            // 
            CTPS.Text = "CTPS";
            CTPS.Width = 75;
            // 
            // CPF
            // 
            CPF.Text = "CPF";
            CPF.Width = 95;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 170;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 30;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtNascimento);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtCtps);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtRg);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txtCpf);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtHorario);
            tabPage2.Controls.Add(txt);
            tabPage2.Controls.Add(txtSalario);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtCargo);
            tabPage2.Controls.Add(labe);
            tabPage2.Controls.Add(txtEquipe);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtNome);
            tabPage2.Controls.Add(btnAdicionar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 341);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Adicionar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Location = new Point(593, 118);
            label9.Name = "label9";
            label9.Size = new Size(78, 23);
            label9.TabIndex = 21;
            label9.Text = "Nascimento";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNascimento
            // 
            txtNascimento.Location = new Point(593, 144);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(148, 23);
            txtNascimento.TabIndex = 22;
            // 
            // label7
            // 
            label7.Location = new Point(398, 118);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 19;
            label7.Text = "CTPS";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCtps
            // 
            txtCtps.Location = new Point(398, 144);
            txtCtps.Name = "txtCtps";
            txtCtps.Size = new Size(148, 23);
            txtCtps.TabIndex = 20;
            // 
            // label2
            // 
            label2.Location = new Point(197, 118);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 17;
            label2.Text = "RG";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRg
            // 
            txtRg.Location = new Point(197, 144);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(148, 23);
            txtRg.TabIndex = 18;
            // 
            // label11
            // 
            label11.Location = new Point(382, 180);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 15;
            label11.Text = "e-mail";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(382, 206);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(380, 23);
            txtEmail.TabIndex = 16;
            // 
            // label10
            // 
            label10.Location = new Point(3, 180);
            label10.Name = "label10";
            label10.Size = new Size(78, 23);
            label10.TabIndex = 13;
            label10.Text = "CPF";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(3, 206);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(358, 23);
            txtCpf.TabIndex = 14;
            // 
            // label8
            // 
            label8.Location = new Point(3, 118);
            label8.Name = "label8";
            label8.Size = new Size(78, 23);
            label8.TabIndex = 9;
            label8.Text = "Horario";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(3, 144);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(148, 23);
            txtHorario.TabIndex = 10;
            // 
            // txt
            // 
            txt.Location = new Point(382, 57);
            txt.Name = "txt";
            txt.Size = new Size(100, 23);
            txt.TabIndex = 7;
            txt.Text = "Salario";
            txt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(382, 83);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(380, 23);
            txtSalario.TabIndex = 8;
            // 
            // label3
            // 
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Cargo";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(3, 83);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(358, 23);
            txtCargo.TabIndex = 5;
            // 
            // labe
            // 
            labe.Location = new Point(382, 3);
            labe.Name = "labe";
            labe.Size = new Size(100, 17);
            labe.TabIndex = 2;
            labe.Text = "Equipe";
            labe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEquipe
            // 
            txtEquipe.Location = new Point(382, 23);
            txtEquipe.Name = "txtEquipe";
            txtEquipe.Size = new Size(380, 23);
            txtEquipe.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(100, 16);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(358, 23);
            txtNome.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(335, 300);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(txtUpdateNascimento);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(txtUpdateCtps);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(txtUpdateRg);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(txtUpdateEmail);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(txtUpdateCpf);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(txtUpdateHorario);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(txtUpdateSalario);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(txtUpdateCargo);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(txtUpdateEquipe);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(txtUpdateNome);
            tabPage3.Controls.Add(btnAtualizar);
            tabPage3.Controls.Add(btnBuscar);
            tabPage3.Controls.Add(txtbuscarId);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 341);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Atualizar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(595, 167);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 41;
            label4.Text = "Nascimento";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateNascimento
            // 
            txtUpdateNascimento.Location = new Point(595, 193);
            txtUpdateNascimento.Name = "txtUpdateNascimento";
            txtUpdateNascimento.Size = new Size(148, 23);
            txtUpdateNascimento.TabIndex = 42;
            // 
            // label5
            // 
            label5.Location = new Point(400, 167);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 39;
            label5.Text = "CTPS";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateCtps
            // 
            txtUpdateCtps.Location = new Point(400, 193);
            txtUpdateCtps.Name = "txtUpdateCtps";
            txtUpdateCtps.Size = new Size(148, 23);
            txtUpdateCtps.TabIndex = 40;
            // 
            // label6
            // 
            label6.Location = new Point(199, 167);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 37;
            label6.Text = "RG";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateRg
            // 
            txtUpdateRg.Location = new Point(199, 193);
            txtUpdateRg.Name = "txtUpdateRg";
            txtUpdateRg.Size = new Size(148, 23);
            txtUpdateRg.TabIndex = 38;
            // 
            // label12
            // 
            label12.Location = new Point(384, 229);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 35;
            label12.Text = "e-mail";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(384, 255);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(380, 23);
            txtUpdateEmail.TabIndex = 36;
            // 
            // label13
            // 
            label13.Location = new Point(5, 229);
            label13.Name = "label13";
            label13.Size = new Size(78, 23);
            label13.TabIndex = 33;
            label13.Text = "CPF";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateCpf
            // 
            txtUpdateCpf.Location = new Point(5, 255);
            txtUpdateCpf.Name = "txtUpdateCpf";
            txtUpdateCpf.Size = new Size(358, 23);
            txtUpdateCpf.TabIndex = 34;
            // 
            // label14
            // 
            label14.Location = new Point(5, 167);
            label14.Name = "label14";
            label14.Size = new Size(78, 23);
            label14.TabIndex = 31;
            label14.Text = "Horario";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateHorario
            // 
            txtUpdateHorario.Location = new Point(5, 193);
            txtUpdateHorario.Name = "txtUpdateHorario";
            txtUpdateHorario.Size = new Size(148, 23);
            txtUpdateHorario.TabIndex = 32;
            // 
            // label15
            // 
            label15.Location = new Point(384, 106);
            label15.Name = "label15";
            label15.Size = new Size(100, 23);
            label15.TabIndex = 29;
            label15.Text = "Salario";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateSalario
            // 
            txtUpdateSalario.Location = new Point(384, 132);
            txtUpdateSalario.Name = "txtUpdateSalario";
            txtUpdateSalario.Size = new Size(380, 23);
            txtUpdateSalario.TabIndex = 30;
            // 
            // label16
            // 
            label16.Location = new Point(5, 106);
            label16.Name = "label16";
            label16.Size = new Size(100, 23);
            label16.TabIndex = 26;
            label16.Text = "Cargo";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateCargo
            // 
            txtUpdateCargo.Location = new Point(5, 132);
            txtUpdateCargo.Name = "txtUpdateCargo";
            txtUpdateCargo.Size = new Size(358, 23);
            txtUpdateCargo.TabIndex = 27;
            // 
            // label17
            // 
            label17.Location = new Point(384, 52);
            label17.Name = "label17";
            label17.Size = new Size(100, 17);
            label17.TabIndex = 25;
            label17.Text = "Equipe";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateEquipe
            // 
            txtUpdateEquipe.Location = new Point(384, 72);
            txtUpdateEquipe.Name = "txtUpdateEquipe";
            txtUpdateEquipe.Size = new Size(380, 23);
            txtUpdateEquipe.TabIndex = 28;
            // 
            // label18
            // 
            label18.Location = new Point(5, 53);
            label18.Name = "label18";
            label18.Size = new Size(100, 16);
            label18.TabIndex = 23;
            label18.Text = "Nome";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateNome
            // 
            txtUpdateNome.Location = new Point(5, 72);
            txtUpdateNome.Name = "txtUpdateNome";
            txtUpdateNome.Size = new Size(358, 23);
            txtUpdateNome.TabIndex = 24;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(632, 6);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 34);
            btnAtualizar.TabIndex = 0;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(523, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 34);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar por ID";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtbuscarId
            // 
            txtbuscarId.AccessibleDescription = "";
            txtbuscarId.Location = new Point(159, 12);
            txtbuscarId.Name = "txtbuscarId";
            txtbuscarId.Size = new Size(358, 23);
            txtbuscarId.TabIndex = 14;
            txtbuscarId.Tag = "";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listView2);
            tabPage4.Controls.Add(btnDeletar);
            tabPage4.Controls.Add(btnBusca);
            tabPage4.Controls.Add(BuscarPeloId);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 341);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Deletar";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.None;
            listView2.AutoArrange = false;
            listView2.BorderStyle = BorderStyle.FixedSingle;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(7, 78);
            listView2.Margin = new Padding(4);
            listView2.Name = "listView2";
            listView2.Size = new Size(756, 186);
            listView2.TabIndex = 24;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nome";
            columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Equipe";
            columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Cargo";
            columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Salario";
            columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Horario";
            columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "RG";
            columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "CTPS";
            columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Nascimento";
            columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "CPF";
            columnHeader12.Width = 75;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Email";
            columnHeader13.Width = 75;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(506, 312);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 16;
            btnDeletar.Text = "Deletar";
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(523, 20);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(92, 34);
            btnBusca.TabIndex = 22;
            btnBusca.Text = "Buscar por ID";
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click;
            // 
            // BuscarPeloId
            // 
            BuscarPeloId.Location = new Point(159, 27);
            BuscarPeloId.Name = "BuscarPeloId";
            BuscarPeloId.Size = new Size(358, 23);
            BuscarPeloId.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 393);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "CRUD Funcionarios";
            tabControl1.ResumeLayout(false);
            PageConsulta.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage PageConsulta;
        private TabPage tabPage2;
        private ListView listView1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnListar;
        private Button btnAdicionar;
        private ColumnHeader Nome;
        private ColumnHeader Equipe;
        private ColumnHeader Cargo;
        private TextBox txtNome;
        private Label label1;
        private Label labe;
        private TextBox txtEquipe;
        private Label label3;
        private TextBox txtCargo;
        private TextBox txtbuscarId;
        private Button btnAtualizar;
        private Button btnBuscar;
        private Button btnDeletar;
        private Button btnBusca;
        private TextBox BuscarPeloId;
        private Label label8;
        private TextBox txtHorario;
        private Label txt;
        private TextBox txtSalario;
        private Label label10;
        private TextBox txtCpf;
        private Label label11;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtNascimento;
        private Label label7;
        private TextBox txtCtps;
        private Label label2;
        private TextBox txtRg;
        private Label label4;
        private TextBox txtUpdateNascimento;
        private Label label5;
        private TextBox txtUpdateCtps;
        private Label label6;
        private TextBox txtUpdateRg;
        private Label label12;
        private TextBox txtUpdateEmail;
        private Label label13;
        private TextBox txtUpdateCpf;
        private Label label14;
        private TextBox txtUpdateHorario;
        private Label label15;
        private TextBox txtUpdateSalario;
        private Label label16;
        private TextBox txtUpdateCargo;
        private Label label17;
        private TextBox txtUpdateEquipe;
        private Label label18;
        private TextBox txtUpdateNome;
        private ColumnHeader Salario;
        private ColumnHeader Horario;
        private ColumnHeader RG;
        private ColumnHeader Nascimento;
        private ColumnHeader CTPS;
        private ColumnHeader CPF;
        private ColumnHeader email;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader ID;
    }
}