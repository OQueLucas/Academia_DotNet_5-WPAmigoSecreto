namespace WindowsFormAmigoSecreto
{
    internal static class FileLocation
    {
        /// <summary>
        /// Exibe uma message box com o campo para adicionar e capturar um texto;
        /// </summary>
        /// <param name="input">Texto que será capturado</param>
        /// <param name="prompt">Texto do prompt</param>
        /// <param name="title">Titulo do prompt</param>
        /// <returns>Um dos resultados do DialogResult</returns>
        public static DialogResult ShowDialog(ref string input, string prompt, string title)
        {
            Size size = new(400, 100);

            Form inputBox = new()
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = title,
                StartPosition = FormStartPosition.CenterParent
            };

            Label label = new()
            {
                Text = prompt,
                Location = new Point(5, 5),
                Width = size.Width - 10
            };
            inputBox.Controls.Add(label);

            TextBox textBox = new()
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, label.Location.Y + 20),
                Text = input
            };
            inputBox.Controls.Add(textBox);

            Button okButton = new()
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = "&OK",
                Location = new Point(size.Width - 80 - 80, size.Height - 30)
            };
            inputBox.Controls.Add(okButton);
            
            Button cancelButton = new()
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new Size(75, 23),
                Text = "&Cancelar",
                Location = new Point(size.Width - 80, size.Height - 30)
            };
            inputBox.Controls.Add(cancelButton);

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;

            return result;
        }
    }
}
