namespace WinForms_Calculator
{
    public partial class Form1 : Form
    {
        private string currentInput = "0";
        private char? currentOperation;
        private double? lastValue;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            // Obs³uga przycisku backspace (<<<)
            if (lbl_display.Text.Length > 0)
            {
                lbl_display.Text = lbl_display.Text.Substring(0, lbl_display.Text.Length - 1);

                // Je¿eli etykieta jest pusta, ustaw wartoœæ domyœln¹
                if (string.IsNullOrEmpty(lbl_display.Text))
                {
                    lbl_display.Text = "0";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumericButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string buttonText = button.Text;

                if (buttonText == ",")
                {
                    if (!lbl_display.Text.Contains(","))
                    {
                        lbl_display.Text += buttonText;
                    }
                }
                else
                {
                    if (lbl_display.Text == "0")
                    {
                        lbl_display.Text = buttonText;
                    }
                    else
                    {
                        lbl_display.Text += buttonText;
                    }
                }
            }
        }

        private void OperationButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string buttonName = button.Name;

                switch (buttonName)
                {
                    case "btn_percent":
                        break;
                    case "btn_ce":
                        lbl_display.Text = "0";
                        break;
                    case "btn_c":
                        lbl_display.Text = "0";
                        currentOperation = null;
                        lastValue = null;
                        break;
                    case "btn_backspace":
                        btn_backspace_Click(sender, e);
                        break;
                    case "btn_1divbyX":
                        if (double.TryParse(lbl_display.Text, out double value))
                        {
                            double result = 1 / value;
                            lbl_display.Text = result.ToString();
                        }
                        break;
                    case "btn_xpow2":
                        if (double.TryParse(lbl_display.Text, out double valueX2))
                        {
                            double resultX2 = Math.Pow(valueX2, 2);
                            lbl_display.Text = resultX2.ToString();
                        }
                        break;
                    case "btn_sqrtx":
                        if (double.TryParse(lbl_display.Text, out double valueSqrt) && valueSqrt >= 0)
                        {
                            double resultSqrt = Math.Sqrt(valueSqrt);
                            lbl_display.Text = resultSqrt.ToString();
                        }
                        else
                        {
                            lbl_display.Text = "B³¹d";
                        }
                        break;
                    case "btn_divide":
                        HandleArithmeticOperation('/');
                        break;
                    case "btn_multipier":
                        HandleArithmeticOperation('*');
                        break;
                    case "btn_minus":
                        HandleArithmeticOperation('-');
                        break;
                    case "btn_plus":
                        HandleArithmeticOperation('+');
                        break;
                    case "btn_equals":
                        PerformCalculation();
                        break;
                    case "btn_plus_minus":
                        if (double.TryParse(lbl_display.Text, out double currentValue))
                        {
                            lbl_display.Text = (-currentValue).ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void HandleArithmeticOperation(char operation)
        {
            if (double.TryParse(lbl_display.Text, out double currentValue))
            {
                if (currentOperation.HasValue && lastValue.HasValue)
                {
                    double result = PerformArithmeticOperation(lastValue.Value, currentValue, currentOperation.Value);
                    lastValue = result;
                    lbl_display.Text = result.ToString();
                }
                else
                {
                    lastValue = currentValue;
                }

                currentOperation = operation;
                lbl_display.Text = "0";
            }
        }

        private double PerformArithmeticOperation(double operand1, double operand2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    if (operand2 != 0)
                    {
                        return operand1 / operand2;
                    }
                    else
                    {
                        MessageBox.Show("Nie mo¿na dzieliæ przez zero!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return operand1;
                    }
                default:
                    throw new InvalidOperationException("Nieobs³ugiwana operacja");
            }
        }

        private void PerformCalculation()
        {
            if (currentOperation.HasValue && lastValue.HasValue)
            {
                double currentValue = double.Parse(lbl_display.Text);
                double result = PerformArithmeticOperation(lastValue.Value, currentValue, currentOperation.Value);
                lbl_display.Text = result.ToString();
                currentOperation = null;
                lastValue = null;
            }
        }
    }

}