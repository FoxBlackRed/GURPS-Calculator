namespace GURPSCalculator
{
    public partial class GURPScalc : Form
    {
        public GURPScalc()
        {
            InitializeComponent();
        }

        private void CaliberText_Click(object sender, EventArgs e)
        {
            CaliberText.Text = String.Empty;
            CaliberText.ForeColor = Color.Black;
        }

        private void CaliberText_Leave(object sender, EventArgs e)
        {
            if (CaliberText.Text == String.Empty)
            {
                CaliberText.Text = "Caliber";
                CaliberText.ForeColor = Color.Gray;
            }
        }
        private void CaliberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SpeedText_Click(object sender, EventArgs e)
        {
            SpeedText.Text = String.Empty;
            SpeedText.ForeColor = Color.Black;
        }

        private void SpeedText_Leave(object sender, EventArgs e)
        {
            if (SpeedText.Text == String.Empty)
            {
                SpeedText.Text = "Speed";
                SpeedText.ForeColor = Color.Gray;
            }
        }
        private void SpeedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void WeightText_Click(object sender, EventArgs e)
        {
            WeightText.Text = String.Empty;
            WeightText.ForeColor = Color.Black;
        }

        private void WeightText_Leave(object sender, EventArgs e)
        {
            if (WeightText.Text == String.Empty)
            {
                WeightText.Text = "Weight";
                WeightText.ForeColor = Color.Gray;
            }
        }
        private void WeightText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void DamPointButton_Click(object sender, EventArgs e)
        {
            double materMod = 0;
            if (CaliberText.Text == "Caliber" && SpeedText.Text == "Speed" && WeightText.Text == "Weight") { }
            else
            {
                if (radioButton1.Checked)
                {
                    materMod = 1.25;
                }
                else if (radioButton2.Checked)
                {
                    materMod = 1.9;
                }
                else if (radioButton3.Checked)
                {
                    materMod = 2.4;
                }
                else if (radioButton4.Checked)
                {
                    materMod = 1.5;
                }
                else if (radioButton5.Checked)
                {
                    materMod = 1.3;
                }

                DamagePoints dp = new DamagePoints(Convert.ToDouble(CaliberText.Text), Convert.ToDouble(SpeedText.Text), Convert.ToDouble(WeightText.Text), Convert.ToDouble(materMod));
                AnswerBox.Text = "6dx" + dp.DamageCalc();
            }

        }
    }
}
