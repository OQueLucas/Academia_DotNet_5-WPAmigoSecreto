namespace WindowsFormAmigoSecreto
{
    partial class FormAmigoSecreto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAmigoSecreto));


            listView_AmigoSecreto = new ListView();
            columnHeader_Nome = new ColumnHeader();
            columnHeader_Email = new ColumnHeader();
            columnHeader_NomeAmigo = new ColumnHeader();
            columnHeader_EmailAmigo = new ColumnHeader();
            SuspendLayout();
            // 
            // listView_AmigoSecreto
            // 
            listView_AmigoSecreto.Columns.AddRange(new ColumnHeader[] { columnHeader_Nome, columnHeader_Email, columnHeader_NomeAmigo, columnHeader_EmailAmigo });
            listView_AmigoSecreto.Dock = DockStyle.Fill;
            listView_AmigoSecreto.Location = new Point(0, 0);
            listView_AmigoSecreto.Name = "listView_AmigoSecreto";
            listView_AmigoSecreto.Size = new Size(800, 450);
            listView_AmigoSecreto.TabIndex = 1;
            listView_AmigoSecreto.UseCompatibleStateImageBehavior = false;
            listView_AmigoSecreto.View = View.Details;
            // 
            // columnHeader_Nome
            // 
            columnHeader_Nome.Text = "Nome";
            columnHeader_Nome.Width = 180;
            // 
            // columnHeader_Email
            // 
            columnHeader_Email.Text = "Email";
            columnHeader_Email.Width = 200;
            // 
            // columnHeader_NomeAmigo
            // 
            columnHeader_NomeAmigo.Text = "Nome Amigo";
            columnHeader_NomeAmigo.Width = 180;
            // 
            // columnHeader_EmailAmigo
            // 
            columnHeader_EmailAmigo.Text = "Email Amigo";
            columnHeader_EmailAmigo.Width = 200;
            // 
            // FormAmigoSecreto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView_AmigoSecreto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAmigoSecreto";
            Text = "Amigo Secreto - Pares";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView_AmigoSecreto;
        private ColumnHeader columnHeader_Nome;
        private ColumnHeader columnHeader_Email;
        private ColumnHeader columnHeader_NomeAmigo;
        private ColumnHeader columnHeader_EmailAmigo;
    }
}