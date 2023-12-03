
namespace Tyuiu.KhramovNA.Sprint6.Task3.V6
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
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SAA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_SAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SAA = new System.Windows.Forms.DataGridView();
            this.labelRes_SAA = new System.Windows.Forms.Label();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.groupBoxTask_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAA)).BeginInit();
            this.groupBoxOutPutData_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.dataGridViewMatrix_SAA);
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(16, 15);
            this.groupBoxTask_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(495, 257);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // dataGridViewMatrix_SAA
            // 
            this.dataGridViewMatrix_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SAA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SAA.Location = new System.Drawing.Point(280, 20);
            this.dataGridViewMatrix_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMatrix_SAA.Name = "dataGridViewMatrix_SAA";
            this.dataGridViewMatrix_SAA.RowHeadersVisible = false;
            this.dataGridViewMatrix_SAA.RowHeadersWidth = 51;
            this.dataGridViewMatrix_SAA.Size = new System.Drawing.Size(207, 230);
            this.dataGridViewMatrix_SAA.TabIndex = 1;
            this.dataGridViewMatrix_SAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_SAA_CellContentClick);
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(8, 23);
            this.textBoxTask_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(264, 156);
            this.textBoxTask_SAA.TabIndex = 0;
            // 
            // groupBoxOutPutData_SAA
            // 
            this.groupBoxOutPutData_SAA.Controls.Add(this.dataGridViewResult_SAA);
            this.groupBoxOutPutData_SAA.Controls.Add(this.labelRes_SAA);
            this.groupBoxOutPutData_SAA.Location = new System.Drawing.Point(519, 15);
            this.groupBoxOutPutData_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOutPutData_SAA.Name = "groupBoxOutPutData_SAA";
            this.groupBoxOutPutData_SAA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOutPutData_SAA.Size = new System.Drawing.Size(267, 223);
            this.groupBoxOutPutData_SAA.TabIndex = 1;
            this.groupBoxOutPutData_SAA.TabStop = false;
            this.groupBoxOutPutData_SAA.Text = "Вывод данных";
            // 
            // dataGridViewResult_SAA
            // 
            this.dataGridViewResult_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SAA.Location = new System.Drawing.Point(22, 39);
            this.dataGridViewResult_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewResult_SAA.Name = "dataGridViewResult_SAA";
            this.dataGridViewResult_SAA.RowHeadersVisible = false;
            this.dataGridViewResult_SAA.RowHeadersWidth = 51;
            this.dataGridViewResult_SAA.Size = new System.Drawing.Size(247, 176);
            this.dataGridViewResult_SAA.TabIndex = 2;
            // 
            // labelRes_SAA
            // 
            this.labelRes_SAA.AutoSize = true;
            this.labelRes_SAA.Location = new System.Drawing.Point(8, 20);
            this.labelRes_SAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRes_SAA.Name = "labelRes_SAA";
            this.labelRes_SAA.Size = new System.Drawing.Size(80, 17);
            this.labelRes_SAA.TabIndex = 1;
            this.labelRes_SAA.Text = "Результат:";
            this.labelRes_SAA.Click += new System.EventHandler(this.labelRes_SAA_Click);
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Location = new System.Drawing.Point(633, 245);
            this.buttonHelp_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(36, 28);
            this.buttonHelp_SAA.TabIndex = 2;
            this.buttonHelp_SAA.Text = "?";
            this.buttonHelp_SAA.UseVisualStyleBackColor = true;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Location = new System.Drawing.Point(677, 245);
            this.buttonDone_SAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(100, 28);
            this.buttonDone_SAA.TabIndex = 3;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 288);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.groupBoxOutPutData_SAA);
            this.Controls.Add(this.groupBoxTask_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 6 | Храмов Н. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAA)).EndInit();
            this.groupBoxOutPutData_SAA.ResumeLayout(false);
            this.groupBoxOutPutData_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SAA;
        private System.Windows.Forms.Label labelRes_SAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAA;
    }
}
