
namespace Tyuiu.KhramovNA.Sprint6.Task0.V24
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
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxVar_SIA = new System.Windows.Forms.GroupBox();
            this.labelVarX_SIA = new System.Windows.Forms.Label();
            this.textBoxVarX_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SIA = new System.Windows.Forms.GroupBox();
            this.labelResult_SIA = new System.Windows.Forms.Label();
            this.textBoxResult_SIA = new System.Windows.Forms.TextBox();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.buttonInfo_SIA = new System.Windows.Forms.Button();
            this.groupBoxTask_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxVar_SIA.SuspendLayout();
            this.groupBoxResult_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(16, 33);
            this.groupBoxTask_SIA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(939, 258);
            this.groupBoxTask_SIA.TabIndex = 0;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(692, 108);
            this.pictureBoxFormula.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(217, 66);
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            this.pictureBoxFormula.Click += new System.EventHandler(this.pictureBoxFormula_SIA_Click);
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.Location = new System.Drawing.Point(20, 23);
            this.textBoxTask_SIA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(613, 218);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxVar_SIA
            // 
            this.groupBoxVar_SIA.Controls.Add(this.labelVarX_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.textBoxVarX_SIA);
            this.groupBoxVar_SIA.Location = new System.Drawing.Point(16, 299);
            this.groupBoxVar_SIA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxVar_SIA.Name = "groupBoxVar_SIA";
            this.groupBoxVar_SIA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxVar_SIA.Size = new System.Drawing.Size(588, 181);
            this.groupBoxVar_SIA.TabIndex = 2;
            this.groupBoxVar_SIA.TabStop = false;
            this.groupBoxVar_SIA.Text = "Ввод данных";
            // 
            // labelVarX_SIA
            // 
            this.labelVarX_SIA.AutoSize = true;
            this.labelVarX_SIA.Location = new System.Drawing.Point(159, 55);
            this.labelVarX_SIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVarX_SIA.Name = "labelVarX_SIA";
            this.labelVarX_SIA.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_SIA.TabIndex = 1;
            this.labelVarX_SIA.Text = "Переменная X:";
            // 
            // textBoxVarX_SIA
            // 
            this.textBoxVarX_SIA.Location = new System.Drawing.Point(159, 79);
            this.textBoxVarX_SIA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVarX_SIA.Name = "textBoxVarX_SIA";
            this.textBoxVarX_SIA.Size = new System.Drawing.Size(228, 22);
            this.textBoxVarX_SIA.TabIndex = 0;
            this.textBoxVarX_SIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_SIA_KeyPress);
            // 
            // groupBoxResult_SIA
            // 
            this.groupBoxResult_SIA.Controls.Add(this.labelResult_SIA);
            this.groupBoxResult_SIA.Controls.Add(this.textBoxResult_SIA);
            this.groupBoxResult_SIA.Location = new System.Drawing.Point(612, 299);
            this.groupBoxResult_SIA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxResult_SIA.Name = "groupBoxResult_SIA";
            this.groupBoxResult_SIA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxResult_SIA.Size = new System.Drawing.Size(343, 181);
            this.groupBoxResult_SIA.TabIndex = 3;
            this.groupBoxResult_SIA.TabStop = false;
            this.groupBoxResult_SIA.Text = "Вывод данных";
            // 
            // labelResult_SIA
            // 
            this.labelResult_SIA.AutoSize = true;
            this.labelResult_SIA.Location = new System.Drawing.Point(8, 55);
            this.labelResult_SIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult_SIA.Name = "labelResult_SIA";
            this.labelResult_SIA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SIA.TabIndex = 1;
            this.labelResult_SIA.Text = "Результат:";
            // 
            // textBoxResult_SIA
            // 
            this.textBoxResult_SIA.AccessibleName = "";
            this.textBoxResult_SIA.Location = new System.Drawing.Point(8, 79);
            this.textBoxResult_SIA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult_SIA.Name = "textBoxResult_SIA";
            this.textBoxResult_SIA.ReadOnly = true;
            this.textBoxResult_SIA.Size = new System.Drawing.Size(325, 22);
            this.textBoxResult_SIA.TabIndex = 0;
            this.textBoxResult_SIA.Tag = "";
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.Location = new System.Drawing.Point(612, 487);
            this.buttonDone_SIA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(343, 52);
            this.buttonDone_SIA.TabIndex = 4;
            this.buttonDone_SIA.Text = "Выполнить";
            this.buttonDone_SIA.UseVisualStyleBackColor = true;
            this.buttonDone_SIA.Click += new System.EventHandler(this.buttonDone_SIA_Click);
            // 
            // buttonInfo_SIA
            // 
            this.buttonInfo_SIA.Location = new System.Drawing.Point(544, 487);
            this.buttonInfo_SIA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInfo_SIA.Name = "buttonInfo_SIA";
            this.buttonInfo_SIA.Size = new System.Drawing.Size(60, 50);
            this.buttonInfo_SIA.TabIndex = 5;
            this.buttonInfo_SIA.Text = "?";
            this.buttonInfo_SIA.UseVisualStyleBackColor = true;
            this.buttonInfo_SIA.Click += new System.EventHandler(this.buttonInfo_SIA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 554);
            this.Controls.Add(this.buttonInfo_SIA);
            this.Controls.Add(this.buttonDone_SIA);
            this.Controls.Add(this.groupBoxResult_SIA);
            this.Controls.Add(this.groupBoxVar_SIA);
            this.Controls.Add(this.groupBoxTask_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 24 | Храмов Н. А.";
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxVar_SIA.ResumeLayout(false);
            this.groupBoxVar_SIA.PerformLayout();
            this.groupBoxResult_SIA.ResumeLayout(false);
            this.groupBoxResult_SIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.GroupBox groupBoxVar_SIA;
        private System.Windows.Forms.TextBox textBoxVarX_SIA;
        private System.Windows.Forms.GroupBox groupBoxResult_SIA;
        private System.Windows.Forms.TextBox textBoxResult_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.Label labelVarX_SIA;
        private System.Windows.Forms.Label labelResult_SIA;
        private System.Windows.Forms.Button buttonInfo_SIA;
    }
}
