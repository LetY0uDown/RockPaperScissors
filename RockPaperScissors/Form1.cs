using System;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelCompOutcome.Hide();
            labelGameResult.Hide();
        }
        private string GetComputerOutcome()
        {
            return outcomes[rand.Next(0, 3)];
        }
        private readonly string[] outcomes = { "Камень", "Ножницы", "Бумага" };
        
        private string userOutcome;
        private string computerOutcome;
        private int wins;
        private int loses;
        private int draws;

        private Random rand = new Random();

        private void bRock_Click(object sender, EventArgs e)
        {
            userOutcome = outcomes[0];
            computerOutcome = GetComputerOutcome();
            labelCompOutcome.Text = $"Компьютер выбрал:\n{computerOutcome}";
            labelCompOutcome.Show();
            if (computerOutcome == outcomes[0]) { draws++; labelGameResult.Text = "Ничья!"; labelGameResult.ForeColor = Color.Black; }
            if (computerOutcome == outcomes[1]) { wins++; labelGameResult.Text = "Вы победили!"; labelGameResult.ForeColor = Color.Green; }
            if (computerOutcome == outcomes[2]) { loses++; labelGameResult.Text = "Вы проиграли!"; labelGameResult.ForeColor = Color.Red; }
            labelGameResult.Show();
            labelStats.Text = $"Побед: {wins} Поражений: {loses} Ничьих: {draws}";
        }

        private void bScissors_Click(object sender, EventArgs e)
        {
            userOutcome = outcomes[1];
            computerOutcome = GetComputerOutcome();
            labelCompOutcome.Text = $"Компьютер выбрал:\n{computerOutcome}";
            labelCompOutcome.Show();
            if (computerOutcome == outcomes[1]) { draws++; labelGameResult.Text = "Ничья!"; labelGameResult.ForeColor = Color.Black; }
            if (computerOutcome == outcomes[2]) { wins++; labelGameResult.Text = "Вы победили!"; labelGameResult.ForeColor = Color.Green; }
            if (computerOutcome == outcomes[0]) { loses++; labelGameResult.Text = "Вы проиграли!"; labelGameResult.ForeColor = Color.Red; }
            labelGameResult.Show();
            labelStats.Text = $"Побед: {wins} Поражений: {loses} Ничьих: {draws}";
        }

        private void bPaper_Click(object sender, EventArgs e)
        {
            userOutcome = outcomes[2];
            computerOutcome = GetComputerOutcome();
            labelCompOutcome.Text = $"Компьютер выбрал:\n{computerOutcome}";
            labelCompOutcome.Show();
            if (computerOutcome == outcomes[2]) { draws++; labelGameResult.Text = "Ничья!"; labelGameResult.ForeColor = Color.Black; }
            if (computerOutcome == outcomes[0]) { wins++; labelGameResult.Text = "Вы победили!"; labelGameResult.ForeColor = Color.Green; }
            if (computerOutcome == outcomes[1]) { loses++; labelGameResult.Text = "Вы проиграли!"; labelGameResult.ForeColor = Color.Red; }
            labelGameResult.Show();
            labelStats.Text = $"Побед: {wins} Поражений: {loses} Ничьих: {draws}";
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
