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
            listView_pessoas = new ListView();
            Nome = new ColumnHeader();
            Email = new ColumnHeader();
            button_limpar = new Button();
            button_cadastrar = new Button();
            menuStrip_Principal = new MenuStrip();
            GerarAmigoSecretoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // label_NomeCompleto
            // 
            label_NomeCompleto.AutoSize = true;
            label_NomeCompleto.Location = new Point(38, 45);
            label_NomeCompleto.Name = "label_NomeCompleto";
            label_NomeCompleto.Size = new Size(99, 15);
            label_NomeCompleto.TabIndex = 0;
            label_NomeCompleto.Text = "Nome Completo:";
            // 
            // textBox_NomeCompleto
            // 
            textBox_NomeCompleto.Location = new Point(143, 42);
            textBox_NomeCompleto.Name = "textBox_NomeCompleto";
            textBox_NomeCompleto.Size = new Size(413, 23);
            textBox_NomeCompleto.TabIndex = 1;
            textBox_NomeCompleto.KeyPress += textBox_NomeCompleto_KeyPress;
            // 
            // listView_pessoas
            // 
            listView_pessoas.Columns.AddRange(new ColumnHeader[] { Nome, Email });
            listView_pessoas.Location = new Point(38, 93);
            listView_pessoas.Name = "listView_pessoas";
            listView_pessoas.Size = new Size(696, 322);
            listView_pessoas.TabIndex = 8;
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
            button_limpar.Location = new Point(578, 41);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(75, 24);
            button_limpar.TabIndex = 7;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = false;
            // 
            // button_cadastrar
            // 
            button_cadastrar.Location = new Point(659, 41);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(75, 24);
            button_cadastrar.TabIndex = 2;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = true;
            button_cadastrar.Click += button_cadastrar_Click;
            // 
            // menuStrip_Principal
            // 
            menuStrip_Principal.Items.AddRange(new ToolStripItem[] { GerarAmigoSecretoToolStripMenuItem });
            menuStrip_Principal.Location = new Point(0, 0);
            menuStrip_Principal.Name = "menuStrip_Principal";
            menuStrip_Principal.Size = new Size(800, 24);
            menuStrip_Principal.TabIndex = 6;
            menuStrip_Principal.Text = "menuStrip2";
            // 
            // GerarAmigoSecretoToolStripMenuItem
            // 
            GerarAmigoSecretoToolStripMenuItem.Name = "GerarAmigoSecretoToolStripMenuItem";
            GerarAmigoSecretoToolStripMenuItem.Size = new Size(128, 20);
            GerarAmigoSecretoToolStripMenuItem.Text = "Gerar Amigo Secreto";
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip_Principal);
            Controls.Add(button_cadastrar);
            Controls.Add(button_limpar);
            Controls.Add(listView_pessoas);
            Controls.Add(textBox_NomeCompleto);
            Controls.Add(label_NomeCompleto);
            MainMenuStrip = menuStrip_Principal;
            Name = "Form_Principal";
            Text = "Amigo Secreto";
            menuStrip_Principal.ResumeLayout(false);
            menuStrip_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_NomeCompleto;
        private TextBox textBox_NomeCompleto;
        private ListView listView_pessoas;
        private ColumnHeader Nome;
        private ColumnHeader Email;
        private Button button_limpar;
        private Button button_cadastrar;
        private MenuStrip menuStrip_Principal;
        private ToolStripMenuItem GerarAmigoSecretoToolStripMenuItem;
    }
}