using System;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        private readonly string[] outcomes = { "Камень", "Ножницы", "Бумага" };
        private string GetComputerOutcome()
        {
            Random rand = new Random();
            return outcomes[rand.Next(0, 3)];
        }
        public string UserOutcome { get; private set; }
        public string ComputerOutcome { get; private set; }
        public int Wins { get; private set; }
        public int Loses { get; private set; }
        public int Draws { get; private set; }
        public Form1()
        {
            InitializeComponent();
            labelCompOutcome.Hide();
            labelGameResult.Hide();
        }

        private void bRock_Click(object sender, EventArgs e)
        {
            UserOutcome = outcomes[0];
            ComputerOutcome = GetComputerOutcome();
            labelCompOutcome.Text = $"Компьютер выбрал:\n{ComputerOutcome}";
            labelCompOutcome.Show();
            if (ComputerOutcome == outcomes[0]) { Draws++; labelGameResult.Text = "Ничья!"; labelGameResult.ForeColor = Color.Black; }
            if (ComputerOutcome == outcomes[1]) { Wins++; labelGameResult.Text = "Вы победили!"; labelGameResult.ForeColor = Color.Green; }
            if (ComputerOutcome == outcomes[2]) { Loses++; labelGameResult.Text = "Вы проиграли!"; labelGameResult.ForeColor = Color.Red; }
            labelGameResult.Show();
            labelStats.Text = $"Побед: {Wins} Поражений: {Loses} Ничьих: {Draws}";
        }

        private void bScissors_Click(object sender, EventArgs e)
        {
            UserOutcome = outcomes[1];
            ComputerOutcome = GetComputerOutcome();
            labelCompOutcome.Text = $"Компьютер выбрал:\n{ComputerOutcome}";
            labelCompOutcome.Show();
            if (ComputerOutcome == outcomes[1]) { Draws++; labelGameResult.Text = "Ничья!"; labelGameResult.ForeColor = Color.Black; }
            if (ComputerOutcome == outcomes[2]) { Wins++; labelGameResult.Text = "Вы победили!"; labelGameResult.ForeColor = Color.Green; }
            if (ComputerOutcome == outcomes[0]) { Loses++; labelGameResult.Text = "Вы проиграли!"; labelGameResult.ForeColor = Color.Red; }
            labelGameResult.Show();
            labelStats.Text = $"Побед: {Wins} Поражений: {Loses} Ничьих: {Draws}";
        }

        private void bPaper_Click(object sender, EventArgs e)
        {
            UserOutcome = outcomes[2];
            ComputerOutcome = GetComputerOutcome();
            labelCompOutcome.Text = $"Компьютер выбрал:\n{ComputerOutcome}";
            labelCompOutcome.Show();
            if (ComputerOutcome == outcomes[2]) { Draws++; labelGameResult.Text = "Ничья!"; labelGameResult.ForeColor = Color.Black; }
            if (ComputerOutcome == outcomes[0]) { Wins++; labelGameResult.Text = "Вы победили!"; labelGameResult.ForeColor = Color.Green; }
            if (ComputerOutcome == outcomes[1]) { Loses++; labelGameResult.Text = "Вы проиграли!"; labelGameResult.ForeColor = Color.Red; }
            labelGameResult.Show();
            labelStats.Text = $"Побед: {Wins} Поражений: {Loses} Ничьих: {Draws}";
        }
    }
}
