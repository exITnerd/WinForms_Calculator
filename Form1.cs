namespace WinForms_Calculator
{
    public partial class Form1 : Form
    {
        private string displayText = "0"; // Represents the text displayed on the calculator screen
        private string displayTextValue = "0"; // Represents the current input value being entered
        private char? selectedOperation; // Represents the currently selected arithmetic operation
        private double? storedValue; // Represents the last stored numeric value

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        // "0-9" and ","
        private void NumericButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string buttonText = button.Text;

                if (buttonText == ",")
                {
                    if (!displayTextValue.Contains(","))
                    {
                        displayTextValue += buttonText;
                    }
                }
                else
                {
                    if (displayTextValue == "0")
                    {
                        displayTextValue = buttonText;
                    }
                    else
                    {
                        displayTextValue += buttonText;
                    }
                }
                lbl_display.Text = displayTextValue;
            }
        }

        // All logic functions (+, -, *, /, %, CE, C, backspace, 1/x, x^2, sqrt(x), =, +-)
        private void OperationButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string buttonName = button.Name;

                switch (buttonName)
                {
                    case "btn_percent":
                        if (double.TryParse(displayTextValue, out double currentValue) && storedValue.HasValue && selectedOperation.HasValue)
                        {
                            double percentage = storedValue.Value * (currentValue / 100);

                            switch (selectedOperation)
                            {
                                case '+':
                                    storedValue += percentage;
                                    break;
                                case '-':
                                    storedValue -= percentage;
                                    break;
                                case '*':
                                    storedValue = percentage;
                                    break;
                                default:
                                    break;
                            }

                            displayTextValue = storedValue.ToString();
                            lbl_display.Text = displayTextValue;
                        }
                        break;
                    case "btn_ce":
                        // Delete whole operation
                        int index = displayTextValue.Length - 1;
                        while (index >= 0 && (char.IsDigit(displayTextValue[index]) || displayTextValue[index] == '.'))
                        {
                            index--;
                        }

                        // delete "+" or "-" operator
                        if (index >= 0 && (displayTextValue[index] == '+' || displayTextValue[index] == '-'))
                        {
                            index--;
                        }

                        if (index < 0)
                        {
                            displayTextValue = "0";
                        }
                        else
                        {
                            displayTextValue = displayTextValue.Substring(0, index + 1);
                        }

                        lbl_display.Text = displayTextValue;
                        break;
                    case "btn_c":
                        displayText = "0";
                        displayTextValue = "0";
                        selectedOperation = null;
                        storedValue = null;
                        lbl_display.Text = "0";
                        break;
                    case "btn_backspace":
                        if (lbl_display.Text.Length > 0)
                        {
                            lbl_display.Text = lbl_display.Text.Substring(0, lbl_display.Text.Length - 1);

                            if (string.IsNullOrEmpty(lbl_display.Text))
                            {
                                lbl_display.Text = "0";
                                displayTextValue = "0";
                            }
                            else
                            {
                                displayTextValue = lbl_display.Text;
                            }
                        }
                        break;
                    case "btn_1divbyX":
                        if (double.TryParse(lbl_display.Text, out double value1DivByX))
                        {
                            double result = 1 / value1DivByX;
                            lbl_display.Text = result.ToString();
                        }
                        break;
                    case "btn_xpow2":
                        if (double.TryParse(lbl_display.Text, out double valueXpow2))
                        {
                            double resultX2 = Math.Pow(valueXpow2, 2);
                            lbl_display.Text = resultX2.ToString();
                        }
                        break;
                    case "btn_sqrtx":
                        if (double.TryParse(lbl_display.Text, out double valueSqrt) && valueSqrt >= 0)
                        {
                            double resultSqrt = Math.Sqrt(valueSqrt);
                            displayText = resultSqrt.ToString();
                            displayTextValue = displayText;
                            lbl_display.Text = displayText;
                        }
                        else
                        {
                            MessageBox.Show("Nie mo¿na uzyskaæ pierwiastka!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (double.TryParse(lbl_display.Text, out double currentValue2))
                        {
                            currentValue2 = (-1 * currentValue2);
                            displayTextValue = currentValue2.ToString();
                            lbl_display.Text = displayTextValue;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void HandleArithmeticOperation(char operation)
        {
            if (double.TryParse(displayTextValue, out double currentValue))
            {
                if (selectedOperation.HasValue && storedValue.HasValue)
                {
                    double result = PerformArithmeticOperation(storedValue.Value, currentValue, selectedOperation.Value);
                    storedValue = result;
                    displayTextValue = result.ToString();
                    lbl_display.Text = displayTextValue;
                }
                else
                {
                    storedValue = currentValue;
                }
                selectedOperation = operation;
                displayTextValue = "0";
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
            if (selectedOperation.HasValue && storedValue.HasValue)
            {
                double currentValue = double.Parse(displayTextValue);
                double result = PerformArithmeticOperation(storedValue.Value, currentValue, selectedOperation.Value);
                displayTextValue = result.ToString();
                lbl_display.Text = displayTextValue;
                selectedOperation = null;
                storedValue = null;
            }
        }
    }
}