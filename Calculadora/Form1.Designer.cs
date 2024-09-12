namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.zero = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.allClear = new System.Windows.Forms.Button();
            this.mainDisplay = new System.Windows.Forms.Label();
            this.secondDisplay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.historial = new System.Windows.Forms.TextBox();
            this.absoluteSum = new System.Windows.Forms.TextBox();
            this.saveHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Consolas", 16F);
            this.zero.Location = new System.Drawing.Point(12, 382);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(100, 75);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Consolas", 16F);
            this.two.Location = new System.Drawing.Point(118, 301);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(100, 75);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Consolas", 16F);
            this.one.Location = new System.Drawing.Point(12, 301);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(100, 75);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Consolas", 16F);
            this.three.Location = new System.Drawing.Point(224, 301);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(100, 75);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Consolas", 16F);
            this.four.Location = new System.Drawing.Point(12, 220);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(100, 75);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Consolas", 16F);
            this.five.Location = new System.Drawing.Point(118, 220);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(100, 75);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Consolas", 16F);
            this.six.Location = new System.Drawing.Point(224, 220);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(100, 75);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Consolas", 16F);
            this.seven.Location = new System.Drawing.Point(12, 139);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(100, 75);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Consolas", 16F);
            this.eight.Location = new System.Drawing.Point(118, 139);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(100, 75);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Consolas", 16F);
            this.nine.Location = new System.Drawing.Point(224, 139);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(100, 75);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(118, 382);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(206, 75);
            this.equal.TabIndex = 10;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Consolas", 16F);
            this.divide.Location = new System.Drawing.Point(330, 139);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(100, 75);
            this.divide.TabIndex = 11;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // times
            // 
            this.times.Font = new System.Drawing.Font("Consolas", 16F);
            this.times.Location = new System.Drawing.Point(330, 220);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(100, 75);
            this.times.TabIndex = 12;
            this.times.Text = "×";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Consolas", 16F);
            this.minus.Location = new System.Drawing.Point(330, 301);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(100, 75);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Consolas", 16F);
            this.plus.Location = new System.Drawing.Point(330, 382);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(100, 75);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // allClear
            // 
            this.allClear.Font = new System.Drawing.Font("Consolas", 16F);
            this.allClear.Location = new System.Drawing.Point(330, 50);
            this.allClear.Name = "allClear";
            this.allClear.Size = new System.Drawing.Size(100, 75);
            this.allClear.TabIndex = 15;
            this.allClear.Text = "AC";
            this.allClear.UseVisualStyleBackColor = true;
            this.allClear.Click += new System.EventHandler(this.allClear_Click);
            // 
            // mainDisplay
            // 
            this.mainDisplay.AutoSize = true;
            this.mainDisplay.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Bold);
            this.mainDisplay.Location = new System.Drawing.Point(12, 61);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainDisplay.Size = new System.Drawing.Size(57, 64);
            this.mainDisplay.TabIndex = 18;
            this.mainDisplay.Text = "0";
            this.mainDisplay.TextChanged += new System.EventHandler(this.mainDisplay_TextChanged);
            // 
            // secondDisplay
            // 
            this.secondDisplay.AutoSize = true;
            this.secondDisplay.Font = new System.Drawing.Font("Consolas", 12F);
            this.secondDisplay.Location = new System.Drawing.Point(19, 28);
            this.secondDisplay.Name = "secondDisplay";
            this.secondDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secondDisplay.Size = new System.Drawing.Size(0, 23);
            this.secondDisplay.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 75);
            this.button1.TabIndex = 20;
            this.button1.Text = "Historial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // historial
            // 
            this.historial.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial.Location = new System.Drawing.Point(440, 50);
            this.historial.Multiline = true;
            this.historial.Name = "historial";
            this.historial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historial.Size = new System.Drawing.Size(418, 407);
            this.historial.TabIndex = 21;
            // 
            // absoluteSum
            // 
            this.absoluteSum.Enabled = false;
            this.absoluteSum.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absoluteSum.Location = new System.Drawing.Point(440, 470);
            this.absoluteSum.Multiline = true;
            this.absoluteSum.Name = "absoluteSum";
            this.absoluteSum.Size = new System.Drawing.Size(418, 68);
            this.absoluteSum.TabIndex = 22;
            this.absoluteSum.Visible = false;
            // 
            // saveHistorial
            // 
            this.saveHistorial.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveHistorial.Location = new System.Drawing.Point(12, 463);
            this.saveHistorial.Name = "saveHistorial";
            this.saveHistorial.Size = new System.Drawing.Size(206, 75);
            this.saveHistorial.TabIndex = 23;
            this.saveHistorial.Text = "Guardar";
            this.saveHistorial.UseVisualStyleBackColor = true;
            this.saveHistorial.Click += new System.EventHandler(this.saveHistorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 600);
            this.Controls.Add(this.saveHistorial);
            this.Controls.Add(this.absoluteSum);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondDisplay);
            this.Controls.Add(this.mainDisplay);
            this.Controls.Add(this.allClear);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.times);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.zero);
            this.Name = "Form1";
            this.Text = "Calculadora HOD-001";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button allClear;
        private System.Windows.Forms.Label mainDisplay;
        private System.Windows.Forms.Label secondDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox historial;
        private System.Windows.Forms.TextBox absoluteSum;
        private System.Windows.Forms.Button saveHistorial;
    }
}

