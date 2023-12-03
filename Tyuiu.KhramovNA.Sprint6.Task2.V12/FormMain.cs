using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KhramovNA.Sprint6.Task2.V12.Lib;

namespace Tyuiu.KhramovNA.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonStartCode_KUE_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxInputStartStep_KUE.Text);
                int stopValue = Convert.ToInt32(textBoxInputStopStep_KUE.Text);


                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                this.chartFunction_KUE.Titles.Add("График функции");

                this.chartFunction_KUE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KUE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KUE.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction_KUE.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_KUE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-3 Храмов Николай Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStartCode_KUE_MouseEnter(object sender, EventArgs e)
        {
            buttonStartCode_KUE.BackColor = Color.Red;
        }

        private void buttonStartCode_KUE_MouseLeave(object sender, EventArgs e)
        {
            buttonStartCode_KUE.BackColor = Color.Green;
        }

        private void buttonStartCode_KUE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStartCode_KUE.BackColor = Color.Blue;
        }
    }
}