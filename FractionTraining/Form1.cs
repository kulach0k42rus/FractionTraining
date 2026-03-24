using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FractionTraining
{
    public partial class Form1 : Form
    {
        private readonly FractionService _fractionService;
        private int _correctAnswersCount;
        private Fraction _currentFraction;
        public Form1()
        {
            InitializeComponent();
            _fractionService = new FractionService();
            ConfigureForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           LoadNewTask();
        }

        private void ConfigureForm()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = this.Size;
            MaximumSize = this.Size;
        }

        private void LoadNewTask()
        {
            _currentFraction = _fractionService.GenerateFraction();
            DisplayFraction(_currentFraction);
            UpdateScoreDisplay();
        }

        private void DisplayFraction(Fraction fraction)
        {
            task_rtb.Text = $"{fraction.Numerator.ToString()}\n──\n{fraction.Denomerator.ToString()}";
        }

        private void UpdateScoreDisplay()
        {
            count_lbl.Text = $"Решено: {_correctAnswersCount}";
        }

        private bool VerifyAnswer()
        {
            var userNumerator = num_tb.Text;
            var userDenomerator = denom_tb.Text;

            if (userDenomerator == "1")
            {
                return userNumerator == _currentFraction.SimplifiedNumerator.ToString() && string.IsNullOrEmpty(userDenomerator);
            }
            else 
            {
                return userNumerator == _currentFraction.SimplifiedNumerator.ToString() && userDenomerator == _currentFraction.SimplifiedDenomerator.ToString();
            }
        }

        private void ShowSuccessMessage()
        {
            result_lbl.Text = "Правильно!";
            result_lbl.ForeColor = Color.Green;
        }

        private void ShowErrorMessage()
        {
            result_lbl.Text = "Неправильно!";
            result_lbl.ForeColor = Color.Red;
        }

        private void ClearInputFields()
        {
            num_tb.Clear();
            denom_tb.Clear();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (VerifyAnswer())
            {
                ShowSuccessMessage();
                ClearInputFields();
                _correctAnswersCount++;
                LoadNewTask();
            }
            else
            {
                ShowErrorMessage();
            }

        }

        private void num_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void num_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                string cleanText = new string(tb.Text.Where(char.IsDigit).ToArray());

                if (tb.Text != cleanText)
                {
                    int cursorPosition = tb.SelectionStart;
                    tb.Text = cleanText;
                    tb.SelectionStart = Math.Min(cursorPosition, cleanText.Length);
                }
            }
        }
    }
}
