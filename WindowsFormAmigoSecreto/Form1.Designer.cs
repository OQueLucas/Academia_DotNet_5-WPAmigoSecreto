namespace WindowsFormAmigoSecreto
{
    partial class Form_Principal
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
            label_NomeCompleto = new Label();
            textBox_NomeCompleto = new TextBox();
            label_Email = new Label();
            textBox_Email = new TextBox();
            listView_pessoas = new ListView();
            Nome = new ColumnHeader();
            Email = new ColumnHeader();
            button_limpar = new Button();
            button_cadastrar = new Button();
            menuStrip_Principal = new MenuStrip();
            GerarAmigoSecretoToolStripMenuItem = new ToolStripMenuItem();
            excluirPessoaToolStripMenuItem = new ToolStripMenuItem();
            formAmigoSecretoToolStripMenuItem = new ToolStripMenuItem();
            panel_ExcluirPessoa = new Panel();
            label_Excluir = new Label();
            textBox_ExcluirPessoa = new TextBox();
            button_Excluir = new Button();
            button_Sair = new Button();
            menuStrip_Principal.SuspendLayout();
            panel_ExcluirPessoa.SuspendLayout();
            SuspendLayout();
            // 
            // label_NomeCompleto
            // 
            label_NomeCompleto.AutoSize = true;
            label_NomeCompleto.Location = new Point(12, 35);
            label_NomeCompleto.Name = "label_NomeCompleto";
            label_NomeCompleto.Size = new Size(99, 15);
            label_NomeCompleto.TabIndex = 0;
            label_NomeCompleto.Text = "Nome Completo:";
            // 
            // textBox_NomeCompleto
            // 
            textBox_NomeCompleto.Location = new Point(117, 32);
            textBox_NomeCompleto.Name = "textBox_NomeCompleto";
            textBox_NomeCompleto.Size = new Size(398, 23);
            textBox_NomeCompleto.TabIndex = 1;
            textBox_NomeCompleto.KeyPress += textBox_NomeCompleto_KeyPress;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(72, 70);
            label_Email.Name = "label_Email";
            label_Email.RightToLeft = RightToLeft.No;
            label_Email.Size = new Size(39, 15);
            label_Email.TabIndex = 2;
            label_Email.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(117, 67);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(398, 23);
            textBox_Email.TabIndex = 3;
            textBox_Email.KeyPress += textBox_Email_KeyPress;
            // 
            // listView_pessoas
            // 
            listView_pessoas.Columns.AddRange(new ColumnHeader[] { Nome, Email });
            listView_pessoas.Location = new Point(12, 116);
            listView_pessoas.Name = "listView_pessoas";
            listView_pessoas.Size = new Size(776, 322);
            listView_pessoas.TabIndex = 6;
            listView_pessoas.UseCompatibleStateImageBehavior = false;
            listView_pessoas.View = View.Details;
            // 
            // Nome
            // 
            Nome.Tag = "Nome";
            Nome.Text = "Nome";
            Nome.Width = 250;
            // 
            // Email
            // 
            Email.Tag = "Email";
            Email.Text = "Email";
            Email.Width = 400;
            // 
            // button_limpar
            // 
            button_limpar.BackColor = Color.Red;
            button_limpar.FlatStyle = FlatStyle.Flat;
            button_limpar.ForeColor = SystemColors.Control;
            button_limpar.Location = new Point(678, 32);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(75, 23);
            button_limpar.TabIndex = 5;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = false;
            // 
            // button_cadastrar
            // 
            button_cadastrar.BackColor = Color.LimeGreen;
            button_cadastrar.FlatAppearance.BorderColor = SystemColors.Control;
            button_cadastrar.FlatStyle = FlatStyle.Flat;
            button_cadastrar.ForeColor = SystemColors.Control;
            button_cadastrar.Location = new Point(678, 67);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(75, 23);
            button_cadastrar.TabIndex = 4;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = false;
            // 
            // menuStrip_Principal
            // 
            menuStrip_Principal.Items.AddRange(new ToolStripItem[] { GerarAmigoSecretoToolStripMenuItem, excluirPessoaToolStripMenuItem, formAmigoSecretoToolStripMenuItem });
            menuStrip_Principal.Location = new Point(0, 0);
            menuStrip_Principal.Name = "menuStrip_Principal";
            menuStrip_Principal.Size = new Size(800, 24);
            menuStrip_Principal.TabIndex = 7;
            menuStrip_Principal.TabStop = true;
            menuStrip_Principal.Text = "menuStrip2";
            // 
            // GerarAmigoSecretoToolStripMenuItem
            // 
            GerarAmigoSecretoToolStripMenuItem.Name = "GerarAmigoSecretoToolStripMenuItem";
            GerarAmigoSecretoToolStripMenuItem.Size = new Size(128, 20);
            GerarAmigoSecretoToolStripMenuItem.Text = "Gerar Amigo Secreto";
            // 
            // excluirPessoaToolStripMenuItem
            // 
            excluirPessoaToolStripMenuItem.Name = "excluirPessoaToolStripMenuItem";
            excluirPessoaToolStripMenuItem.Size = new Size(93, 20);
            excluirPessoaToolStripMenuItem.Text = "Excluir Pessoa";
            excluirPessoaToolStripMenuItem.Click += excluirPessoaToolStripMenuItem_Click;
            // 
            // formAmigoSecretoToolStripMenuItem
            // 
            formAmigoSecretoToolStripMenuItem.Name = "formAmigoSecretoToolStripMenuItem";
            formAmigoSecretoToolStripMenuItem.Size = new Size(128, 20);
            formAmigoSecretoToolStripMenuItem.Text = "Form Amigo Secreto";
            formAmigoSecretoToolStripMenuItem.Click += formAmigoSecretoToolStripMenuItem_Click;
            // 
            // panel_ExcluirPessoa
            // 
            panel_ExcluirPessoa.Controls.Add(label_Excluir);
            panel_ExcluirPessoa.Controls.Add(textBox_ExcluirPessoa);
            panel_ExcluirPessoa.Controls.Add(button_Excluir);
            panel_ExcluirPessoa.Controls.Add(button_Sair);
            panel_ExcluirPessoa.Location = new Point(278, 169);
            panel_ExcluirPessoa.Name = "panel_ExcluirPessoa";
            panel_ExcluirPessoa.Size = new Size(295, 135);
            panel_ExcluirPessoa.TabIndex = 20;
            panel_ExcluirPessoa.Visible = false;
            // 
            // label_Excluir
            // 
            label_Excluir.AutoSize = true;
            label_Excluir.FlatStyle = FlatStyle.Flat;
            label_Excluir.Location = new Point(18, 21);
            label_Excluir.Name = "label_Excluir";
            label_Excluir.Size = new Size(258, 15);
            label_Excluir.TabIndex = 21;
            label_Excluir.Text = "Digite o nome ou email de quem deseja excluir:";
            // 
            // textBox_ExcluirPessoa
            // 
            textBox_ExcluirPessoa.Location = new Point(18, 50);
            textBox_ExcluirPessoa.Name = "textBox_ExcluirPessoa";
            textBox_ExcluirPessoa.Size = new Size(258, 23);
            textBox_ExcluirPessoa.TabIndex = 22;
            textBox_ExcluirPessoa.KeyPress += textBox_ExcluirPessoa_KeyPress;
            // 
            // button_Excluir
            // 
            button_Excluir.BackColor = Color.Red;
            button_Excluir.FlatAppearance.BorderColor = SystemColors.Control;
            button_Excluir.FlatStyle = FlatStyle.Flat;
            button_Excluir.ForeColor = SystemColors.Control;
            button_Excluir.Location = new Point(54, 90);
            button_Excluir.Name = "button_Excluir";
            button_Excluir.Size = new Size(75, 23);
            button_Excluir.TabIndex = 23;
            button_Excluir.Text = "Excluir";
            button_Excluir.UseVisualStyleBackColor = false;
            // 
            // button_Sair
            // 
            button_Sair.BackColor = SystemColors.ControlLight;
            button_Sair.FlatAppearance.BorderColor = SystemColors.Control;
            button_Sair.FlatStyle = FlatStyle.Flat;
            button_Sair.ForeColor = Color.Black;
            button_Sair.Location = new Point(162, 90);
            button_Sair.Name = "button_Sair";
            button_Sair.Size = new Size(75, 23);
            button_Sair.TabIndex = 24;
            button_Sair.Text = "Sair";
            button_Sair.UseVisualStyleBackColor = false;
            button_Sair.Click += button_Sair_Click;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_NomeCompleto);
            Controls.Add(textBox_NomeCompleto);
            Controls.Add(label_Email);
            Controls.Add(textBox_Email);
            Controls.Add(button_cadastrar);
            Controls.Add(button_limpar);
            Controls.Add(panel_ExcluirPessoa);
            Controls.Add(menuStrip_Principal);
            Controls.Add(listView_pessoas);
            MainMenuStrip = menuStrip_Principal;
            Name = "Form_Principal";
            Text = "Amigo Secreto";
            menuStrip_Principal.ResumeLayout(false);
            menuStrip_Principal.PerformLayout();
            panel_ExcluirPessoa.ResumeLayout(false);
            panel_ExcluirPessoa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_NomeCompleto;
        private TextBox textBox_NomeCompleto;
        private Label label_Email;
        private TextBox textBox_Email;
        private ListView listView_pessoas;
        private ColumnHeader Nome;
        private ColumnHeader Email;
        private Button button_limpar;
        private Button button_cadastrar;
        private MenuStrip menuStrip_Principal;
        private ToolStripMenuItem GerarAmigoSecretoToolStripMenuItem;
        private Panel panel_ExcluirPessoa;
        private Button button_Excluir;
        private TextBox textBox_ExcluirPessoa;
        private Label label_Excluir;
        private ToolStripMenuItem excluirPessoaToolStripMenuItem;
        private Button button_Sair;
        private ToolStripMenuItem formAmigoSecretoToolStripMenuItem;
    }
}