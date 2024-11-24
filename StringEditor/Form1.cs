using RavenDataTypes;
using System.Security.Cryptography.X509Certificates;

namespace StringEditor
{
    public partial class Form1 : Form
    {
        RavenDataTypes.Language l = new RavenDataTypes.Language();
        public Form1()
        {
            InitializeComponent();
        }

        Language language;

        private void id_ValueChanged(object sender, EventArgs e)
        {
            str.Text = language.getString((int)id.Value);
            strUse.Text = "Usage: " + language.getStringUse((int)id.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);

            FileInfo file = new FileInfo(openFileDialog1.FileName);
            fileName.Text = openFileDialog1.FileName;

            if (file.Exists == true)
            {
                language = new Language(openFileDialog1.FileName);
            }
            else
            {
                language = new Language();
            }

            id.Value = 0;
            id.Maximum = language.getNoStrings() - 1;
            id.Minimum = 0;

            str.Text = language.getString((int)id.Value);
            strUse.Text = "Usage: " + l.getStringUse((int)id.Value);
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            language.writeStringsToFile(fileName.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            language.addString("Hello World");
            id.Maximum = language.getNoStrings() - 1;
            id.Value = id.Maximum;

            str.Text = language.getString((int)id.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            language.removeString((int)id.Value);
            id.Maximum = language.getNoStrings() - 1;
            id.Value = 0;

            str.Text = language.getString((int)id.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            language.updateString((int)id.Value, str.Text);
        }
    }
}
