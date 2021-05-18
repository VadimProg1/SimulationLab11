
namespace Simulation9Lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_experiments = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_prob1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_prob2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_prob3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_prob4 = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label_validation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_average = new System.Windows.Forms.Label();
            this.label_var = new System.Windows.Forms.Label();
            this.label_averageD = new System.Windows.Forms.Label();
            this.label_varD = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_chi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_isTrue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_experiments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(172, 12);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(600, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prob1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prob2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prob3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prob4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prob5";
            // 
            // numericUpDown_experiments
            // 
            this.numericUpDown_experiments.Location = new System.Drawing.Point(29, 334);
            this.numericUpDown_experiments.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_experiments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_experiments.Name = "numericUpDown_experiments";
            this.numericUpDown_experiments.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_experiments.TabIndex = 7;
            this.numericUpDown_experiments.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number of experiments";
            // 
            // numericUpDown_prob1
            // 
            this.numericUpDown_prob1.DecimalPlaces = 2;
            this.numericUpDown_prob1.Location = new System.Drawing.Point(82, 72);
            this.numericUpDown_prob1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob1.Name = "numericUpDown_prob1";
            this.numericUpDown_prob1.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob1.TabIndex = 14;
            this.numericUpDown_prob1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown_prob2
            // 
            this.numericUpDown_prob2.DecimalPlaces = 2;
            this.numericUpDown_prob2.Location = new System.Drawing.Point(82, 118);
            this.numericUpDown_prob2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob2.Name = "numericUpDown_prob2";
            this.numericUpDown_prob2.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob2.TabIndex = 15;
            this.numericUpDown_prob2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numericUpDown_prob3
            // 
            this.numericUpDown_prob3.DecimalPlaces = 2;
            this.numericUpDown_prob3.Location = new System.Drawing.Point(82, 166);
            this.numericUpDown_prob3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob3.Name = "numericUpDown_prob3";
            this.numericUpDown_prob3.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob3.TabIndex = 16;
            this.numericUpDown_prob3.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // numericUpDown_prob4
            // 
            this.numericUpDown_prob4.DecimalPlaces = 2;
            this.numericUpDown_prob4.Location = new System.Drawing.Point(82, 215);
            this.numericUpDown_prob4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prob4.Name = "numericUpDown_prob4";
            this.numericUpDown_prob4.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown_prob4.TabIndex = 17;
            this.numericUpDown_prob4.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(82, 262);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(67, 22);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "auto";
            // 
            // label_validation
            // 
            this.label_validation.AutoSize = true;
            this.label_validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_validation.ForeColor = System.Drawing.Color.Red;
            this.label_validation.Location = new System.Drawing.Point(12, 368);
            this.label_validation.Name = "label_validation";
            this.label_validation.Size = new System.Drawing.Size(0, 25);
            this.label_validation.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Average:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Variance:";
            // 
            // label_average
            // 
            this.label_average.AutoSize = true;
            this.label_average.Location = new System.Drawing.Point(326, 450);
            this.label_average.Name = "label_average";
            this.label_average.Size = new System.Drawing.Size(44, 17);
            this.label_average.TabIndex = 21;
            this.label_average.Text = "2.192";
            // 
            // label_var
            // 
            this.label_var.AutoSize = true;
            this.label_var.Location = new System.Drawing.Point(326, 478);
            this.label_var.Name = "label_var";
            this.label_var.Size = new System.Drawing.Size(44, 17);
            this.label_var.TabIndex = 22;
            this.label_var.Text = "2.074";
            // 
            // label_averageD
            // 
            this.label_averageD.AutoSize = true;
            this.label_averageD.Location = new System.Drawing.Point(387, 450);
            this.label_averageD.Name = "label_averageD";
            this.label_averageD.Size = new System.Drawing.Size(85, 17);
            this.label_averageD.TabIndex = 23;
            this.label_averageD.Text = "(error = 8%)";
            // 
            // label_varD
            // 
            this.label_varD.AutoSize = true;
            this.label_varD.Location = new System.Drawing.Point(387, 478);
            this.label_varD.Name = "label_varD";
            this.label_varD.Size = new System.Drawing.Size(85, 17);
            this.label_varD.TabIndex = 24;
            this.label_varD.Text = "(error = 9%)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(387, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "< 11.07";
            // 
            // label_chi
            // 
            this.label_chi.AutoSize = true;
            this.label_chi.Location = new System.Drawing.Point(347, 513);
            this.label_chi.Name = "label_chi";
            this.label_chi.Size = new System.Drawing.Size(44, 17);
            this.label_chi.TabIndex = 26;
            this.label_chi.Text = "13.54";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(252, 513);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Chi-squared:";
            // 
            // label_isTrue
            // 
            this.label_isTrue.AutoSize = true;
            this.label_isTrue.Location = new System.Drawing.Point(449, 513);
            this.label_isTrue.Name = "label_isTrue";
            this.label_isTrue.Size = new System.Drawing.Size(47, 17);
            this.label_isTrue.TabIndex = 28;
            this.label_isTrue.Text = "is true";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 539);
            this.Controls.Add(this.label_isTrue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_chi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label_varD);
            this.Controls.Add(this.label_averageD);
            this.Controls.Add(this.label_var);
            this.Controls.Add(this.label_average);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_validation);
            this.Controls.Add(this.numericUpDown_prob4);
            this.Controls.Add(this.numericUpDown_prob3);
            this.Controls.Add(this.numericUpDown_prob2);
            this.Controls.Add(this.numericUpDown_prob1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_experiments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Lab9";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_experiments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prob4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_experiments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob1;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob2;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob3;
        private System.Windows.Forms.NumericUpDown numericUpDown_prob4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label_validation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_average;
        private System.Windows.Forms.Label label_var;
        private System.Windows.Forms.Label label_averageD;
        private System.Windows.Forms.Label label_varD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_chi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_isTrue;
    }
}

