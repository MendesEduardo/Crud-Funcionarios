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
            Sobrenome = new ColumnHeader();
            Cargo = new ColumnHeader();
            tabPage2 = new TabPage();
            label3 = new Label();
            txtCargo = new TextBox();
            label2 = new Label();
            txtSobrenome = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            tabPage3 = new TabPage();
            btnAtualizar = new Button();
            btnBuscar = new Button();
            txtbuscarId = new TextBox();
            label4 = new Label();
            txtUpdateCargo = new TextBox();
            label5 = new Label();
            txtUpdateSobrenome = new TextBox();
            label6 = new Label();
            txtUpdateNome = new TextBox();
            tabPage4 = new TabPage();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
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
            tabControl1.Size = new Size(776, 321);
            tabControl1.TabIndex = 0;
            // 
            // PageConsulta
            // 
            PageConsulta.Controls.Add(btnListar);
            PageConsulta.Controls.Add(listView1);
            PageConsulta.Location = new Point(4, 24);
            PageConsulta.Name = "PageConsulta";
            PageConsulta.Padding = new Padding(3);
            PageConsulta.Size = new Size(768, 293);
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
            listView1.Columns.AddRange(new ColumnHeader[] { Nome, Sobrenome, Cargo });
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
            Nome.Width = 252;
            // 
            // Sobrenome
            // 
            Sobrenome.Text = "Sobrenome";
            Sobrenome.Width = 252;
            // 
            // Cargo
            // 
            Cargo.Text = "Cargo";
            Cargo.Width = 252;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtCargo);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtSobrenome);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtNome);
            tabPage2.Controls.Add(btnAdicionar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 293);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Adicionar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Cargo";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(6, 120);
            txtCargo.Multiline = true;
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(358, 34);
            txtCargo.TabIndex = 5;
            // 
            // label2
            // 
            label2.Location = new Point(382, 20);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Sobrenome";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(382, 46);
            txtSobrenome.Multiline = true;
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(380, 34);
            txtSobrenome.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 46);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(358, 34);
            txtNome.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(665, 249);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnAtualizar);
            tabPage3.Controls.Add(btnBuscar);
            tabPage3.Controls.Add(txtbuscarId);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(txtUpdateCargo);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(txtUpdateSobrenome);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(txtUpdateNome);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 293);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Atualizar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(523, 221);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 0;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(523, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 34);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtbuscarId
            // 
            txtbuscarId.Location = new Point(159, 6);
            txtbuscarId.Multiline = true;
            txtbuscarId.Name = "txtbuscarId";
            txtbuscarId.Size = new Size(358, 34);
            txtbuscarId.TabIndex = 14;
            // 
            // label4
            // 
            label4.Location = new Point(6, 155);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 10;
            label4.Text = "Cargo";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateCargo
            // 
            txtUpdateCargo.Location = new Point(6, 181);
            txtUpdateCargo.Multiline = true;
            txtUpdateCargo.Name = "txtUpdateCargo";
            txtUpdateCargo.Size = new Size(358, 34);
            txtUpdateCargo.TabIndex = 11;
            // 
            // label5
            // 
            label5.Location = new Point(382, 81);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 9;
            label5.Text = "Sobrenome";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateSobrenome
            // 
            txtUpdateSobrenome.Location = new Point(382, 107);
            txtUpdateSobrenome.Multiline = true;
            txtUpdateSobrenome.Name = "txtUpdateSobrenome";
            txtUpdateSobrenome.Size = new Size(380, 34);
            txtUpdateSobrenome.TabIndex = 12;
            // 
            // label6
            // 
            label6.Location = new Point(6, 81);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 7;
            label6.Text = "Nome";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUpdateNome
            // 
            txtUpdateNome.Location = new Point(6, 107);
            txtUpdateNome.Multiline = true;
            txtUpdateNome.Name = "txtUpdateNome";
            txtUpdateNome.Size = new Size(358, 34);
            txtUpdateNome.TabIndex = 8;
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
            tabPage4.Size = new Size(768, 293);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Deletar";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.None;
            listView2.AutoArrange = false;
            listView2.BorderStyle = BorderStyle.FixedSingle;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(6, 95);
            listView2.Margin = new Padding(4);
            listView2.Name = "listView2";
            listView2.Size = new Size(756, 104);
            listView2.TabIndex = 23;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 252;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Sobrenome";
            columnHeader2.Width = 252;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cargo";
            columnHeader3.Width = 252;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(523, 242);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 16;
            btnDeletar.Text = "Deletar";
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(523, 27);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(75, 34);
            btnBusca.TabIndex = 22;
            btnBusca.Text = "Buscar";
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click;
            // 
            // BuscarPeloId
            // 
            BuscarPeloId.Location = new Point(159, 27);
            BuscarPeloId.Multiline = true;
            BuscarPeloId.Name = "BuscarPeloId";
            BuscarPeloId.Size = new Size(358, 34);
            BuscarPeloId.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 345);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
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
        private ColumnHeader Sobrenome;
        private ColumnHeader Cargo;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtSobrenome;
        private Label label3;
        private TextBox txtCargo;
        private TextBox txtbuscarId;
        private Label label4;
        private TextBox txtUpdateCargo;
        private Label label5;
        private TextBox txtUpdateSobrenome;
        private Label label6;
        private TextBox txtUpdateNome;
        private Button btnAtualizar;
        private Button btnBuscar;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnDeletar;
        private Button btnBusca;
        private TextBox BuscarPeloId;
    }
}