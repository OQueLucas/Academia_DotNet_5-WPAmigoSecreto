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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            label_NomeCompleto = new Label();
            textBox_NomeCompleto = new TextBox();
            label_Email = new Label();
            textBox_Email = new TextBox();
            listView_pessoas = new ListView();
            Nome = new ColumnHeader();
            Email = new ColumnHeader();
            button_LimparCampos = new Button();
            button_CadastrarPessoa = new Button();
            button_ExcluirPessoa = new Button();
            button_CarregarLista = new Button();
            button_SalvarLista = new Button();
            button_LimparLista = new Button();
            button_GerarPares = new Button();
            button_FormAmigoSecreto = new Button();
            panel_Header = new Panel();
            panel_Bottom = new Panel();
            panel_Header.SuspendLayout();
            panel_Bottom.SuspendLayout();
            SuspendLayout();
            // 
            // label_NomeCompleto
            // 
            label_NomeCompleto.AutoSize = true;
            label_NomeCompleto.Location = new Point(21, 20);
            label_NomeCompleto.Name = "label_NomeCompleto";
            label_NomeCompleto.Size = new Size(99, 15);
            label_NomeCompleto.TabIndex = 0;
            label_NomeCompleto.Text = "Nome Completo:";
            // 
            // textBox_NomeCompleto
            // 
            textBox_NomeCompleto.Location = new Point(126, 17);
            textBox_NomeCompleto.Name = "textBox_NomeCompleto";
            textBox_NomeCompleto.Size = new Size(413, 23);
            textBox_NomeCompleto.TabIndex = 1;
            textBox_NomeCompleto.KeyPress += textBox_NomeCompleto_KeyPress;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(81, 65);
            label_Email.Name = "label_Email";
            label_Email.RightToLeft = RightToLeft.No;
            label_Email.Size = new Size(39, 15);
            label_Email.TabIndex = 2;
            label_Email.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(126, 60);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(413, 23);
            textBox_Email.TabIndex = 3;
            textBox_Email.KeyPress += textBox_Email_KeyPress;
            // 
            // listView_pessoas
            // 
            listView_pessoas.Columns.AddRange(new ColumnHeader[] { Nome, Email });
            listView_pessoas.Dock = DockStyle.Fill;
            listView_pessoas.Location = new Point(0, 100);
            listView_pessoas.Margin = new Padding(20);
            listView_pessoas.Name = "listView_pessoas";
            listView_pessoas.Size = new Size(784, 361);
            listView_pessoas.TabIndex = 7;
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
            // button_LimparCampos
            // 
            button_LimparCampos.BackColor = Color.Transparent;
            button_LimparCampos.BackgroundImageLayout = ImageLayout.None;
            button_LimparCampos.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_LimparCampos.ForeColor = SystemColors.ControlLightLight;
            button_LimparCampos.Image = Properties.Resources.broom_gray;
            button_LimparCampos.Location = new Point(561, 20);
            button_LimparCampos.Name = "button_LimparCampos";
            button_LimparCampos.Size = new Size(55, 55);
            button_LimparCampos.TabIndex = 5;
            button_LimparCampos.TextAlign = ContentAlignment.BottomCenter;
            button_LimparCampos.TextImageRelation = TextImageRelation.ImageAboveText;
            button_LimparCampos.UseVisualStyleBackColor = false;
            // 
            // button_CadastrarPessoa
            // 
            button_CadastrarPessoa.BackColor = Color.Transparent;
            button_CadastrarPessoa.BackgroundImageLayout = ImageLayout.None;
            button_CadastrarPessoa.FlatAppearance.BorderColor = SystemColors.Control;
            button_CadastrarPessoa.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_CadastrarPessoa.ForeColor = SystemColors.ControlLightLight;
            button_CadastrarPessoa.Image = Properties.Resources.user_add_green;
            button_CadastrarPessoa.Location = new Point(634, 20);
            button_CadastrarPessoa.Name = "button_CadastrarPessoa";
            button_CadastrarPessoa.RightToLeft = RightToLeft.No;
            button_CadastrarPessoa.Size = new Size(55, 55);
            button_CadastrarPessoa.TabIndex = 4;
            button_CadastrarPessoa.TextAlign = ContentAlignment.BottomCenter;
            button_CadastrarPessoa.TextImageRelation = TextImageRelation.ImageAboveText;
            button_CadastrarPessoa.UseVisualStyleBackColor = false;
            // 
            // button_ExcluirPessoa
            // 
            button_ExcluirPessoa.BackColor = Color.Transparent;
            button_ExcluirPessoa.BackgroundImageLayout = ImageLayout.None;
            button_ExcluirPessoa.FlatAppearance.BorderColor = SystemColors.Control;
            button_ExcluirPessoa.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_ExcluirPessoa.ForeColor = Color.Red;
            button_ExcluirPessoa.Image = Properties.Resources.user_remove_red;
            button_ExcluirPessoa.Location = new Point(706, 20);
            button_ExcluirPessoa.Name = "button_ExcluirPessoa";
            button_ExcluirPessoa.Size = new Size(55, 55);
            button_ExcluirPessoa.TabIndex = 6;
            button_ExcluirPessoa.TextAlign = ContentAlignment.BottomCenter;
            button_ExcluirPessoa.TextImageRelation = TextImageRelation.ImageAboveText;
            button_ExcluirPessoa.UseVisualStyleBackColor = false;
            // 
            // button_CarregarLista
            // 
            button_CarregarLista.BackColor = SystemColors.ControlLightLight;
            button_CarregarLista.FlatAppearance.BorderColor = SystemColors.Control;
            button_CarregarLista.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_CarregarLista.ForeColor = SystemColors.ActiveCaptionText;
            button_CarregarLista.Image = Properties.Resources.upload_black;
            button_CarregarLista.Location = new Point(21, 13);
            button_CarregarLista.Name = "button_CarregarLista";
            button_CarregarLista.RightToLeft = RightToLeft.No;
            button_CarregarLista.Size = new Size(70, 70);
            button_CarregarLista.TabIndex = 21;
            button_CarregarLista.Text = "Carregar Lista";
            button_CarregarLista.TextAlign = ContentAlignment.BottomCenter;
            button_CarregarLista.TextImageRelation = TextImageRelation.ImageAboveText;
            button_CarregarLista.UseVisualStyleBackColor = false;
            // 
            // button_SalvarLista
            // 
            button_SalvarLista.BackColor = SystemColors.ControlLightLight;
            button_SalvarLista.FlatAppearance.BorderColor = SystemColors.Control;
            button_SalvarLista.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_SalvarLista.ForeColor = SystemColors.ActiveCaptionText;
            button_SalvarLista.Image = Properties.Resources.floppy_disk_black;
            button_SalvarLista.Location = new Point(205, 15);
            button_SalvarLista.Name = "button_SalvarLista";
            button_SalvarLista.RightToLeft = RightToLeft.No;
            button_SalvarLista.Size = new Size(70, 70);
            button_SalvarLista.TabIndex = 22;
            button_SalvarLista.Text = "Salvar Lista";
            button_SalvarLista.TextAlign = ContentAlignment.BottomCenter;
            button_SalvarLista.TextImageRelation = TextImageRelation.ImageAboveText;
            button_SalvarLista.UseVisualStyleBackColor = false;
            // 
            // button_LimparLista
            // 
            button_LimparLista.BackColor = SystemColors.ControlLightLight;
            button_LimparLista.FlatAppearance.BorderColor = SystemColors.Control;
            button_LimparLista.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_LimparLista.ForeColor = SystemColors.ActiveCaptionText;
            button_LimparLista.Image = Properties.Resources.broom_black;
            button_LimparLista.Location = new Point(112, 15);
            button_LimparLista.Name = "button_LimparLista";
            button_LimparLista.RightToLeft = RightToLeft.No;
            button_LimparLista.Size = new Size(70, 70);
            button_LimparLista.TabIndex = 23;
            button_LimparLista.Text = "Limpar Lista";
            button_LimparLista.TextAlign = ContentAlignment.BottomCenter;
            button_LimparLista.TextImageRelation = TextImageRelation.ImageAboveText;
            button_LimparLista.UseVisualStyleBackColor = false;
            // 
            // button_GerarPares
            // 
            button_GerarPares.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_GerarPares.BackColor = SystemColors.ControlLightLight;
            button_GerarPares.FlatAppearance.BorderColor = SystemColors.Control;
            button_GerarPares.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_GerarPares.ForeColor = SystemColors.ActiveCaptionText;
            button_GerarPares.Image = Properties.Resources.user_group_plus_black;
            button_GerarPares.Location = new Point(599, 13);
            button_GerarPares.Name = "button_GerarPares";
            button_GerarPares.RightToLeft = RightToLeft.No;
            button_GerarPares.Size = new Size(70, 70);
            button_GerarPares.TabIndex = 24;
            button_GerarPares.Text = "Gerar Pares";
            button_GerarPares.TextAlign = ContentAlignment.BottomCenter;
            button_GerarPares.TextImageRelation = TextImageRelation.ImageAboveText;
            button_GerarPares.UseVisualStyleBackColor = false;
            // 
            // button_FormAmigoSecreto
            // 
            button_FormAmigoSecreto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_FormAmigoSecreto.BackColor = SystemColors.ControlLightLight;
            button_FormAmigoSecreto.FlatAppearance.BorderColor = SystemColors.Control;
            button_FormAmigoSecreto.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_FormAmigoSecreto.ForeColor = SystemColors.ActiveCaptionText;
            button_FormAmigoSecreto.Image = Properties.Resources.user_group_talking_black;
            button_FormAmigoSecreto.Location = new Point(691, 13);
            button_FormAmigoSecreto.Name = "button_FormAmigoSecreto";
            button_FormAmigoSecreto.RightToLeft = RightToLeft.No;
            button_FormAmigoSecreto.Size = new Size(70, 70);
            button_FormAmigoSecreto.TabIndex = 25;
            button_FormAmigoSecreto.Text = "Espiar";
            button_FormAmigoSecreto.TextAlign = ContentAlignment.BottomCenter;
            button_FormAmigoSecreto.TextImageRelation = TextImageRelation.ImageAboveText;
            button_FormAmigoSecreto.UseVisualStyleBackColor = false;
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.WhiteSmoke;
            panel_Header.Controls.Add(label_NomeCompleto);
            panel_Header.Controls.Add(textBox_NomeCompleto);
            panel_Header.Controls.Add(label_Email);
            panel_Header.Controls.Add(textBox_Email);
            panel_Header.Controls.Add(button_LimparCampos);
            panel_Header.Controls.Add(button_CadastrarPessoa);
            panel_Header.Controls.Add(button_ExcluirPessoa);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Margin = new Padding(0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(784, 100);
            panel_Header.TabIndex = 26;
            // 
            // panel_Bottom
            // 
            panel_Bottom.BackColor = Color.WhiteSmoke;
            panel_Bottom.Controls.Add(button_GerarPares);
            panel_Bottom.Controls.Add(button_FormAmigoSecreto);
            panel_Bottom.Controls.Add(button_CarregarLista);
            panel_Bottom.Controls.Add(button_SalvarLista);
            panel_Bottom.Controls.Add(button_LimparLista);
            panel_Bottom.Dock = DockStyle.Bottom;
            panel_Bottom.Location = new Point(0, 461);
            panel_Bottom.Name = "panel_Bottom";
            panel_Bottom.Size = new Size(784, 100);
            panel_Bottom.TabIndex = 29;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(784, 561);
            Controls.Add(listView_pessoas);
            Controls.Add(panel_Bottom);
            Controls.Add(panel_Header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amigo Secreto";
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            panel_Bottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label_NomeCompleto;
        private TextBox textBox_NomeCompleto;
        private Label label_Email;
        private TextBox textBox_Email;
        private ListView listView_pessoas;
        private ColumnHeader Nome;
        private ColumnHeader Email;
        private Button button_LimparCampos;
        private Button button_CadastrarPessoa;
        private Button button_ExcluirPessoa;
        private Button button_CarregarLista;
        private Button button_SalvarLista;
        private Button button_LimparLista;
        private Button button_GerarPares;
        private Button button_FormAmigoSecreto;
        private Panel panel_Header;
        private Panel panel_Bottom;
    }
}