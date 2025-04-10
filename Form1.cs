namespace ООП_ПР4_завдання
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string country = textBoxCountry.Text;
            int athletesCount = int.Parse(textBoxAthletesCount.Text);
            int medalsCount = int.Parse(textBoxMedalsCount.Text);
            CountryMedal countryMedal = new CountryMedal(country, athletesCount, medalsCount);
            listBox1.Items.Add(countryMedal);
        }

        private void textBoxMedalsCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}