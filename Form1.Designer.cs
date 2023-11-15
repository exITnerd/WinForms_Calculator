namespace WinForms_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_point = new Button();
            btn_0 = new Button();
            btn_plus_minus = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_multipier = new Button();
            btn_divide = new Button();
            btn_sqrtx = new Button();
            btn_xpow2 = new Button();
            btn_1divbyX = new Button();
            btn_backspace = new Button();
            btn_c = new Button();
            btn_ce = new Button();
            btn_minus = new Button();
            btn_plus = new Button();
            btn_equals = new Button();
            btn_percent = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbl_display = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = SystemColors.AppWorkspace;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn_point, 2, 5);
            tableLayoutPanel1.Controls.Add(btn_0, 1, 5);
            tableLayoutPanel1.Controls.Add(btn_plus_minus, 0, 5);
            tableLayoutPanel1.Controls.Add(btn_3, 2, 4);
            tableLayoutPanel1.Controls.Add(btn_2, 1, 4);
            tableLayoutPanel1.Controls.Add(btn_1, 0, 4);
            tableLayoutPanel1.Controls.Add(btn_6, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_5, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_4, 0, 3);
            tableLayoutPanel1.Controls.Add(btn_9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_7, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_multipier, 3, 2);
            tableLayoutPanel1.Controls.Add(btn_divide, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_sqrtx, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_xpow2, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_1divbyX, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_backspace, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_c, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_ce, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_minus, 3, 3);
            tableLayoutPanel1.Controls.Add(btn_plus, 3, 4);
            tableLayoutPanel1.Controls.Add(btn_equals, 3, 5);
            tableLayoutPanel1.Controls.Add(btn_percent, 0, 0);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.MinimumSize = new Size(584, 600);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(584, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_point
            // 
            btn_point.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_point.Location = new Point(295, 503);
            btn_point.Name = "btn_point";
            btn_point.Size = new Size(140, 91);
            btn_point.TabIndex = 20;
            btn_point.Text = ",";
            btn_point.UseVisualStyleBackColor = true;
            btn_point.Click += NumericButtonClick;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_0.Location = new Point(149, 503);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(140, 91);
            btn_0.TabIndex = 19;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += NumericButtonClick;
            // 
            // btn_plus_minus
            // 
            btn_plus_minus.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_plus_minus.Location = new Point(3, 503);
            btn_plus_minus.Name = "btn_plus_minus";
            btn_plus_minus.Size = new Size(140, 91);
            btn_plus_minus.TabIndex = 18;
            btn_plus_minus.Text = "+/-";
            btn_plus_minus.UseVisualStyleBackColor = true;
            btn_plus_minus.Click += OperationButtonClick;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_3.Location = new Point(295, 403);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(140, 91);
            btn_3.TabIndex = 17;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += NumericButtonClick;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_2.Location = new Point(149, 403);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(140, 91);
            btn_2.TabIndex = 16;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += NumericButtonClick;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_1.Location = new Point(3, 403);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(140, 91);
            btn_1.TabIndex = 15;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += NumericButtonClick;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_6.Location = new Point(295, 303);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(140, 91);
            btn_6.TabIndex = 14;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += NumericButtonClick;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_5.Location = new Point(149, 303);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(140, 91);
            btn_5.TabIndex = 13;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += NumericButtonClick;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_4.Location = new Point(3, 303);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(140, 91);
            btn_4.TabIndex = 12;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += NumericButtonClick;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_9.Location = new Point(295, 203);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(140, 91);
            btn_9.TabIndex = 11;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += NumericButtonClick;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_8.Location = new Point(149, 203);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(140, 91);
            btn_8.TabIndex = 10;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += NumericButtonClick;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_7.Location = new Point(3, 203);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(140, 91);
            btn_7.TabIndex = 2;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += NumericButtonClick;
            // 
            // btn_multipier
            // 
            btn_multipier.BackColor = SystemColors.ControlLight;
            btn_multipier.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_multipier.Location = new Point(441, 203);
            btn_multipier.Name = "btn_multipier";
            btn_multipier.Size = new Size(140, 91);
            btn_multipier.TabIndex = 6;
            btn_multipier.Text = "×";
            btn_multipier.UseVisualStyleBackColor = false;
            btn_multipier.Click += OperationButtonClick;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = SystemColors.ControlLight;
            btn_divide.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_divide.Location = new Point(441, 103);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(140, 91);
            btn_divide.TabIndex = 5;
            btn_divide.Text = "÷";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += OperationButtonClick;
            // 
            // btn_sqrtx
            // 
            btn_sqrtx.BackColor = SystemColors.ControlLight;
            btn_sqrtx.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sqrtx.Location = new Point(295, 103);
            btn_sqrtx.Name = "btn_sqrtx";
            btn_sqrtx.Size = new Size(140, 91);
            btn_sqrtx.TabIndex = 4;
            btn_sqrtx.Text = "√x";
            btn_sqrtx.UseVisualStyleBackColor = false;
            btn_sqrtx.Click += OperationButtonClick;
            // 
            // btn_xpow2
            // 
            btn_xpow2.BackColor = SystemColors.ControlLight;
            btn_xpow2.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xpow2.Location = new Point(149, 103);
            btn_xpow2.Name = "btn_xpow2";
            btn_xpow2.Size = new Size(140, 91);
            btn_xpow2.TabIndex = 3;
            btn_xpow2.Text = "x^2";
            btn_xpow2.UseVisualStyleBackColor = false;
            btn_xpow2.Click += OperationButtonClick;
            // 
            // btn_1divbyX
            // 
            btn_1divbyX.BackColor = SystemColors.ControlLight;
            btn_1divbyX.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_1divbyX.Location = new Point(3, 103);
            btn_1divbyX.Name = "btn_1divbyX";
            btn_1divbyX.Size = new Size(140, 91);
            btn_1divbyX.TabIndex = 2;
            btn_1divbyX.Text = "1/x";
            btn_1divbyX.UseVisualStyleBackColor = false;
            btn_1divbyX.Click += OperationButtonClick;
            // 
            // btn_backspace
            // 
            btn_backspace.BackColor = SystemColors.ControlLight;
            btn_backspace.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_backspace.Location = new Point(441, 3);
            btn_backspace.Name = "btn_backspace";
            btn_backspace.Size = new Size(140, 91);
            btn_backspace.TabIndex = 2;
            btn_backspace.Text = "⌫";
            btn_backspace.UseVisualStyleBackColor = false;
            btn_backspace.Click += OperationButtonClick;
            // 
            // btn_c
            // 
            btn_c.BackColor = SystemColors.ControlLight;
            btn_c.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_c.Location = new Point(295, 3);
            btn_c.Name = "btn_c";
            btn_c.Size = new Size(140, 91);
            btn_c.TabIndex = 1;
            btn_c.Text = "C";
            btn_c.UseVisualStyleBackColor = false;
            btn_c.Click += OperationButtonClick;
            // 
            // btn_ce
            // 
            btn_ce.BackColor = SystemColors.ControlLight;
            btn_ce.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ce.Location = new Point(149, 3);
            btn_ce.Name = "btn_ce";
            btn_ce.Size = new Size(140, 91);
            btn_ce.TabIndex = 1;
            btn_ce.Text = "CE";
            btn_ce.UseVisualStyleBackColor = false;
            btn_ce.Click += OperationButtonClick;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = SystemColors.ControlLight;
            btn_minus.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_minus.Location = new Point(441, 303);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(140, 91);
            btn_minus.TabIndex = 7;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += OperationButtonClick;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = SystemColors.ControlLight;
            btn_plus.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_plus.Location = new Point(441, 403);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(140, 91);
            btn_plus.TabIndex = 8;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += OperationButtonClick;
            // 
            // btn_equals
            // 
            btn_equals.BackColor = Color.FromArgb(255, 255, 192);
            btn_equals.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_equals.Location = new Point(441, 503);
            btn_equals.Name = "btn_equals";
            btn_equals.Size = new Size(140, 91);
            btn_equals.TabIndex = 9;
            btn_equals.Text = "=";
            btn_equals.UseVisualStyleBackColor = false;
            btn_equals.Click += OperationButtonClick;
            // 
            // btn_percent
            // 
            btn_percent.BackColor = SystemColors.ControlLight;
            btn_percent.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_percent.Location = new Point(3, 3);
            btn_percent.Name = "btn_percent";
            btn_percent.Size = new Size(140, 91);
            btn_percent.TabIndex = 0;
            btn_percent.Text = "%";
            btn_percent.UseVisualStyleBackColor = false;
            btn_percent.Click += OperationButtonClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = SystemColors.AppWorkspace;
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Location = new Point(0, 156);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(584, 606);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lbl_display
            // 
            lbl_display.AutoEllipsis = true;
            lbl_display.BackColor = SystemColors.AppWorkspace;
            lbl_display.Dock = DockStyle.Top;
            lbl_display.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_display.Location = new Point(0, 0);
            lbl_display.Name = "lbl_display";
            lbl_display.RightToLeft = RightToLeft.No;
            lbl_display.Size = new Size(584, 159);
            lbl_display.TabIndex = 2;
            lbl_display.Text = "0";
            lbl_display.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 761);
            Controls.Add(lbl_display);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_percent;
        private Button btn_backspace;
        private Button btn_ce;
        private Button btn_c;
        private Button btn_1divbyX;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_divide;
        private Button btn_sqrtx;
        private Button btn_xpow2;
        private Button btn_multipier;
        private Button btn_minus;
        private Button btn_plus;
        private Button btn_equals;
        private Button btn_point;
        private Button btn_0;
        private Button btn_plus_minus;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Label lbl_display;
    }
}