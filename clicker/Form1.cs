namespace clicker
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonLevel;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonLevel = 1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(10, buttonLevel - 1);
            siano.Text = "Kremówki: $" + cash.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if (cash >= upgradeCost)
            {
                buttonLevel++;
                ButtonLevelTextBox.Text = buttonLevel.ToString();
                cash -= upgradeCost;
                siano.Text = "Kremówki: $" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                button2.Text = "Ulepsz\n" + nextUpgradeCost;
            }
        }

        private void button3_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
