namespace WinForms_Calculator
{
    public partial class Form1 : Form
    {
        private string currentInput = "0";
        private string currentInputValue = "0";
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
            // Obs�uga przycisku backspace
            if (lbl_display.Text.Length > 0)
            {
                lbl_display.Text = lbl_display.Text.Substring(0, lbl_display.Text.Length - 1);

                // Je�eli etykieta jest pusta, ustaw warto�� domy�ln�
                if (string.IsNullOrEmpty(lbl_display.Text))
                {
                    lbl_display.Text = "0";
                }
            }
        }

        private void NumericButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string buttonText = button.Text;

                if (buttonText == ",")
                {
                    if (!currentInputValue.Contains(","))
                    {
                        currentInputValue += buttonText;
                    }
                }
                else
                {
                    if (currentInputValue == "0")
                    {
                        currentInputValue = buttonText;
                    }
                    else
                    {
                        currentInputValue += buttonText;
                    }
                }

                lbl_display.Text = currentInputValue;
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
                        ApplyPercentage();
                        break;
                    case "btn_ce":
                        currentInputValue = "0";
                        lbl_display.Text = currentInputValue;
                        break;
                    case "btn_c":
                        currentInput = "0";
                        currentInputValue = "0";
                        currentOperation = null;
                        lastValue = null;
                        lbl_display.Text = "0";
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
                            currentInput = resultSqrt.ToString();
                            currentInputValue = currentInput;
                            lbl_display.Text = currentInput;
                        }
                        else
                        {
                            MessageBox.Show("Nie mo�na uzyska� pierwiastka!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ApplyPercentage()
        {
            if (double.TryParse(currentInputValue, out double currentValue) && lastValue.HasValue && currentOperation.HasValue)
            {
                double percentage = lastValue.Value * (currentValue / 100);

                switch (currentOperation)
                {
                    case '+':
                        lastValue += percentage;
                        break;
                    case '-':
                        lastValue -= percentage;
                        break;
                    case '*':
                        lastValue = percentage;
                        break;
                    default:
                        break;
                }

                currentInputValue = lastValue.ToString();
                lbl_display.Text = currentInputValue;
            }
        }

        private void HandleArithmeticOperation(char operation)
        {
            if (double.TryParse(currentInputValue, out double currentValue))
            {
                if (currentOperation.HasValue && lastValue.HasValue)
                {
                    double result = PerformArithmeticOperation(lastValue.Value, currentValue, currentOperation.Value);
                    lastValue = result;
                    currentInputValue = result.ToString();
                    lbl_display.Text = currentInputValue;
                }
                else
                {
                    lastValue = currentValue;
                }

                currentOperation = operation;
                currentInputValue = "0";
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
                        MessageBox.Show("Nie mo�na dzieli� przez zero!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return operand1;
                    }
                default:
                    throw new InvalidOperationException("Nieobs�ugiwana operacja");
            }
        }

        private void PerformCalculation()
        {
            if (currentOperation.HasValue && lastValue.HasValue)
            {
                double currentValue = double.Parse(currentInputValue);
                double result = PerformArithmeticOperation(lastValue.Value, currentValue, currentOperation.Value);
                currentInputValue = result.ToString();
                lbl_display.Text = currentInputValue;
                currentOperation = null;
                lastValue = null;
            }
        }
    }
}