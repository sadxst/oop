using System.Windows.Forms;

namespace ООП_ПР4_приклад
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string age = textBoxAge.Text;
            string profession = textBoxProfession.Text;

            string info = $"Ім'я: {name}; Вік: {age}; Професія: {profession}";
            listBoxResult.Items.Add(info);
        }
    }
}
