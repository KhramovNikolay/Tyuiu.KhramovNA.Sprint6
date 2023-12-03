
namespace Tyuiu.KhramovNA.Sprint6.Task2.V12
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KUE = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_KUE = new System.Windows.Forms.GroupBox();
            this.labelInputStopStep_KUE = new System.Windows.Forms.Label();
            this.labelInputStartStep_KUE = new System.Windows.Forms.Label();
            this.textBoxInputStopStep_KUE = new System.Windows.Forms.TextBox();
            this.textBoxInputStartStep_KUE = new System.Windows.Forms.TextBox();
            this.buttonSpravka_KUE = new System.Windows.Forms.Button();
            this.buttonStartCode_KUE = new System.Windows.Forms.Button();
            this.groupBoxOutputData_KUE = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_KUE = new System.Windows.Forms.DataGridView();
            this.chartFunction_KUE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_KUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxInputData_KUE.SuspendLayout();
            this.groupBoxOutputData_KUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KUE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KUE
            // 
            this.groupBoxTask_KUE.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask_KUE.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_KUE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KUE.Name = "groupBoxTask_KUE";
            this.groupBoxTask_KUE.Size = new System.Drawing.Size(509, 338);
            this.groupBoxTask_KUE.TabIndex = 1;
            this.groupBoxTask_KUE.TabStop = false;
            this.groupBoxTask_KUE.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(9, 40);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(191, 46);
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(497, 282);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = "Протабулироавать функцию:\r\n\r\n\r\n\r\n\r\nна заданном диапазоне. Результат вывести в Dat" +
    "aGridView и построить график функции.";
            // 
            // groupBoxInputData_KUE
            // 
            this.groupBoxInputData_KUE.Controls.Add(this.labelInputStopStep_KUE);
            this.groupBoxInputData_KUE.Controls.Add(this.labelInputStartStep_KUE);
            this.groupBoxInputData_KUE.Controls.Add(this.textBoxInputStopStep_KUE);
            this.groupBoxInputData_KUE.Controls.Add(this.textBoxInputStartStep_KUE);
            this.groupBoxInputData_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_KUE.Location = new System.Drawing.Point(12, 357);
            this.groupBoxInputData_KUE.Name = "groupBoxInputData_KUE";
            this.groupBoxInputData_KUE.Size = new System.Drawing.Size(240, 81);
            this.groupBoxInputData_KUE.TabIndex = 3;
            this.groupBoxInputData_KUE.TabStop = false;
            this.groupBoxInputData_KUE.Text = "Ввод данных";
            // 
            // labelInputStopStep_KUE
            // 
            this.labelInputStopStep_KUE.AutoSize = true;
            this.labelInputStopStep_KUE.Location = new System.Drawing.Point(131, 35);
            this.labelInputStopStep_KUE.Name = "labelInputStopStep_KUE";
            this.labelInputStopStep_KUE.Size = new System.Drawing.Size(76, 15);
            this.labelInputStopStep_KUE.TabIndex = 3;
            this.labelInputStopStep_KUE.Text = "Конец шага:";
            // 
            // labelInputStartStep_KUE
            // 
            this.labelInputStartStep_KUE.AutoSize = true;
            this.labelInputStartStep_KUE.Location = new System.Drawing.Point(6, 35);
            this.labelInputStartStep_KUE.Name = "labelInputStartStep_KUE";
            this.labelInputStartStep_KUE.Size = new System.Drawing.Size(75, 15);
            this.labelInputStartStep_KUE.TabIndex = 2;
            this.labelInputStartStep_KUE.Text = "Старт шага:";
            // 
            // textBoxInputStopStep_KUE
            // 
            this.textBoxInputStopStep_KUE.Location = new System.Drawing.Point(134, 53);
            this.textBoxInputStopStep_KUE.Name = "textBoxInputStopStep_KUE";
            this.textBoxInputStopStep_KUE.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputStopStep_KUE.TabIndex = 1;
            // 
            // textBoxInputStartStep_KUE
            // 
            this.textBoxInputStartStep_KUE.Location = new System.Drawing.Point(6, 53);
            this.textBoxInputStartStep_KUE.Name = "textBoxInputStartStep_KUE";
            this.textBoxInputStartStep_KUE.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputStartStep_KUE.TabIndex = 0;
            // 
            // buttonSpravka_KUE
            // 
            this.buttonSpravka_KUE.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSpravka_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka_KUE.Location = new System.Drawing.Point(268, 368);
            this.buttonSpravka_KUE.Name = "buttonSpravka_KUE";
            this.buttonSpravka_KUE.Size = new System.Drawing.Size(87, 62);
            this.buttonSpravka_KUE.TabIndex = 4;
            this.buttonSpravka_KUE.Text = "Справка";
            this.buttonSpravka_KUE.UseVisualStyleBackColor = false;
            this.buttonSpravka_KUE.Click += new System.EventHandler(this.buttonSpravka_KUE_Click);
            // 
            // buttonStartCode_KUE
            // 
            this.buttonStartCode_KUE.BackColor = System.Drawing.Color.Green;
            this.buttonStartCode_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartCode_KUE.Location = new System.Drawing.Point(366, 368);
            this.buttonStartCode_KUE.Name = "buttonStartCode_KUE";
            this.buttonStartCode_KUE.Size = new System.Drawing.Size(149, 62);
            this.buttonStartCode_KUE.TabIndex = 5;
            this.buttonStartCode_KUE.Text = "Выполнить";
            this.buttonStartCode_KUE.UseVisualStyleBackColor = false;
            this.buttonStartCode_KUE.Click += new System.EventHandler(this.buttonStartCode_KUE_Click);
            this.buttonStartCode_KUE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStartCode_KUE_MouseDown);
            this.buttonStartCode_KUE.MouseEnter += new System.EventHandler(this.buttonStartCode_KUE_MouseEnter);
            this.buttonStartCode_KUE.MouseLeave += new System.EventHandler(this.buttonStartCode_KUE_MouseLeave);
            // 
            // groupBoxOutputData_KUE
            // 
            this.groupBoxOutputData_KUE.Controls.Add(this.chartFunction_KUE);
            this.groupBoxOutputData_KUE.Controls.Add(this.dataGridViewFunction_KUE);
            this.groupBoxOutputData_KUE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_KUE.Location = new System.Drawing.Point(528, 13);
            this.groupBoxOutputData_KUE.Name = "groupBoxOutputData_KUE";
            this.groupBoxOutputData_KUE.Size = new System.Drawing.Size(718, 425);
            this.groupBoxOutputData_KUE.TabIndex = 6;
            this.groupBoxOutputData_KUE.TabStop = false;
            this.groupBoxOutputData_KUE.Text = "Вывод данных";
            // 
            // dataGridViewFunction_KUE
            // 
            this.dataGridViewFunction_KUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KUE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_KUE.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewFunction_KUE.Name = "dataGridViewFunction_KUE";
            this.dataGridViewFunction_KUE.RowHeadersVisible = false;
            this.dataGridViewFunction_KUE.Size = new System.Drawing.Size(156, 397);
            this.dataGridViewFunction_KUE.TabIndex = 0;
            // 
            // chartFunction_KUE
            // 
            chartArea9.Name = "ChartArea1";
            this.chartFunction_KUE.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartFunction_KUE.Legends.Add(legend9);
            this.chartFunction_KUE.Location = new System.Drawing.Point(168, 22);
            this.chartFunction_KUE.Name = "chartFunction_KUE";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartFunction_KUE.Series.Add(series9);
            this.chartFunction_KUE.Size = new System.Drawing.Size(550, 397);
            this.chartFunction_KUE.TabIndex = 1;
            this.chartFunction_KUE.Text = "chart1";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 75;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 75;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 450);
            this.Controls.Add(this.groupBoxOutputData_KUE);
            this.Controls.Add(this.buttonStartCode_KUE);
            this.Controls.Add(this.buttonSpravka_KUE);
            this.Controls.Add(this.groupBoxInputData_KUE);
            this.Controls.Add(this.groupBoxTask_KUE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 12 | Храмов Н.А. ";
            this.groupBoxTask_KUE.ResumeLayout(false);
            this.groupBoxTask_KUE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxInputData_KUE.ResumeLayout(false);
            this.groupBoxInputData_KUE.PerformLayout();
            this.groupBoxOutputData_KUE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KUE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KUE;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.GroupBox groupBoxInputData_KUE;
        private System.Windows.Forms.Label labelInputStopStep_KUE;
        private System.Windows.Forms.Label labelInputStartStep_KUE;
        private System.Windows.Forms.TextBox textBoxInputStopStep_KUE;
        private System.Windows.Forms.TextBox textBoxInputStartStep_KUE;
        private System.Windows.Forms.Button buttonSpravka_KUE;
        private System.Windows.Forms.Button buttonStartCode_KUE;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KUE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KUE;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}
