using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.BerezovskayaGO.Sprint7.Project.V3
{
    partial class FormMain_BGO
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonHelp_BGO;
        private ToolTip toolTipHelp;
        private ListBox listBoxResult_BGO;
        private Button buttonSearch_BGO;
        private TextBox textBoxInput_BGO;
        private TextBox textBoxNameProject_BGO;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Chart chartStatistics; // Добавлен элемент Chart

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BGO));
            buttonHelp_BGO = new Button();
            toolTipHelp = new ToolTip(components);
            listBoxResult_BGO = new ListBox();
            buttonSearch_BGO = new Button();
            textBoxInput_BGO = new TextBox();
            textBoxNameProject_BGO = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chartStatistics = new Chart();
            groupBoxTeacher_BGO = new GroupBox();
            groupBoxResult_BGO = new GroupBox();
            textBoxInfo_BGO = new TextBox();
            pictureBoxFIO_BGO = new PictureBox();
            pictureBoxChartBar_BGO = new PictureBox();
            pictureBoxMail_BGO = new PictureBox();
            pictureBoxBuilding_BGO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)chartStatistics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFIO_BGO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChartBar_BGO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMail_BGO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBuilding_BGO).BeginInit();
            SuspendLayout();
            // 
            // buttonHelp_BGO
            // 
            buttonHelp_BGO.BackColor = Color.White;
            buttonHelp_BGO.BackgroundImage = (Image)resources.GetObject("buttonHelp_BGO.BackgroundImage");
            buttonHelp_BGO.Location = new Point(1737, 20);
            buttonHelp_BGO.Name = "buttonHelp_BGO";
            buttonHelp_BGO.Size = new Size(80, 79);
            buttonHelp_BGO.TabIndex = 0;
            buttonHelp_BGO.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonHelp_BGO.UseVisualStyleBackColor = false;
            buttonHelp_BGO.Click += buttonMain_BGO_Click;
            // 
            // toolTipHelp
            // 
            toolTipHelp.ToolTipIcon = ToolTipIcon.Info;
            toolTipHelp.ToolTipTitle = "Сведение о программе";
            // 
            // listBoxResult_BGO
            // 
            listBoxResult_BGO.BorderStyle = BorderStyle.None;
            listBoxResult_BGO.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxResult_BGO.ForeColor = SystemColors.InactiveCaptionText;
            listBoxResult_BGO.FormattingEnabled = true;
            listBoxResult_BGO.ItemHeight = 45;
            listBoxResult_BGO.Location = new Point(60, 397);
            listBoxResult_BGO.Name = "listBoxResult_BGO";
            listBoxResult_BGO.Size = new Size(1276, 45);
            listBoxResult_BGO.TabIndex = 3;
            listBoxResult_BGO.SelectedIndexChanged += listBoxResult_BGO_SelectedIndexChanged;
            // 
            // buttonSearch_BGO
            // 
            buttonSearch_BGO.BackgroundImage = (Image)resources.GetObject("buttonSearch_BGO.BackgroundImage");
            buttonSearch_BGO.Location = new Point(657, 213);
            buttonSearch_BGO.Name = "buttonSearch_BGO";
            buttonSearch_BGO.Size = new Size(86, 82);
            buttonSearch_BGO.TabIndex = 4;
            buttonSearch_BGO.UseVisualStyleBackColor = true;
            buttonSearch_BGO.Click += buttonSearch_BGO_Click;
            // 
            // textBoxInput_BGO
            // 
            textBoxInput_BGO.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInput_BGO.Location = new Point(60, 236);
            textBoxInput_BGO.Multiline = true;
            textBoxInput_BGO.Name = "textBoxInput_BGO";
            textBoxInput_BGO.Size = new Size(541, 47);
            textBoxInput_BGO.TabIndex = 5;
            textBoxInput_BGO.TextChanged += textBoxInput_BGO_TextChanged;
            // 
            // textBoxNameProject_BGO
            // 
            textBoxNameProject_BGO.BackColor = SystemColors.InactiveBorder;
            textBoxNameProject_BGO.BorderStyle = BorderStyle.FixedSingle;
            textBoxNameProject_BGO.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNameProject_BGO.ForeColor = Color.DarkSlateGray;
            textBoxNameProject_BGO.Location = new Point(11, 12);
            textBoxNameProject_BGO.Multiline = true;
            textBoxNameProject_BGO.Name = "textBoxNameProject_BGO";
            textBoxNameProject_BGO.Size = new Size(1720, 101);
            textBoxNameProject_BGO.TabIndex = 6;
            textBoxNameProject_BGO.Text = "Университет";
            // 
            // chartStatistics
            // 
            chartStatistics.Location = new Point(60, 504);
            chartStatistics.Margin = new Padding(3, 4, 3, 4);
            chartStatistics.Name = "chartStatistics";
            chartStatistics.Palette = ChartColorPalette.Berry;
            chartStatistics.Size = new Size(842, 368);
            chartStatistics.TabIndex = 7;
            chartStatistics.Text = "chart1";
            // 
            // groupBoxTeacher_BGO
            // 
            groupBoxTeacher_BGO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxTeacher_BGO.Location = new Point(49, 181);
            groupBoxTeacher_BGO.Name = "groupBoxTeacher_BGO";
            groupBoxTeacher_BGO.RightToLeft = RightToLeft.No;
            groupBoxTeacher_BGO.Size = new Size(585, 122);
            groupBoxTeacher_BGO.TabIndex = 8;
            groupBoxTeacher_BGO.TabStop = false;
            groupBoxTeacher_BGO.Text = "Введите фамилию преподавателя";
            groupBoxTeacher_BGO.Enter += groupBoxTeacher_BGO_Enter;
            // 
            // groupBoxResult_BGO
            // 
            groupBoxResult_BGO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxResult_BGO.Location = new Point(49, 347);
            groupBoxResult_BGO.Name = "groupBoxResult_BGO";
            groupBoxResult_BGO.Size = new Size(1311, 113);
            groupBoxResult_BGO.TabIndex = 9;
            groupBoxResult_BGO.TabStop = false;
            groupBoxResult_BGO.Text = "Информация по данному преподавателю";
            groupBoxResult_BGO.Enter += groupBoxResult_BGO_Enter;
            // 
            // textBoxInfo_BGO
            // 
            textBoxInfo_BGO.BackColor = Color.AliceBlue;
            textBoxInfo_BGO.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxInfo_BGO.Location = new Point(1088, 521);
            textBoxInfo_BGO.Multiline = true;
            textBoxInfo_BGO.Name = "textBoxInfo_BGO";
            textBoxInfo_BGO.Size = new Size(700, 330);
            textBoxInfo_BGO.TabIndex = 10;
            textBoxInfo_BGO.Text = "Данная программа помогает найти информацию про преподавателей, \r\nа именно:\r\n\r\nФИО\r\n\r\nСтаж работы в университете \r\n\r\nЭлектронная почта\r\n\r\nКафедра\r\n\r\n";
            // 
            // pictureBoxFIO_BGO
            // 
            pictureBoxFIO_BGO.BackgroundImage = (Image)resources.GetObject("pictureBoxFIO_BGO.BackgroundImage");
            pictureBoxFIO_BGO.Location = new Point(1048, 604);
            pictureBoxFIO_BGO.Name = "pictureBoxFIO_BGO";
            pictureBoxFIO_BGO.Size = new Size(34, 32);
            pictureBoxFIO_BGO.TabIndex = 11;
            pictureBoxFIO_BGO.TabStop = false;
            pictureBoxFIO_BGO.Click += pictureBoxFIO_BGO_Click;
            // 
            // pictureBoxChartBar_BGO
            // 
            pictureBoxChartBar_BGO.BackgroundImage = (Image)resources.GetObject("pictureBoxChartBar_BGO.BackgroundImage");
            pictureBoxChartBar_BGO.Location = new Point(1048, 664);
            pictureBoxChartBar_BGO.Name = "pictureBoxChartBar_BGO";
            pictureBoxChartBar_BGO.Size = new Size(34, 31);
            pictureBoxChartBar_BGO.TabIndex = 12;
            pictureBoxChartBar_BGO.TabStop = false;
            pictureBoxChartBar_BGO.Click += pictureBoxChartBar_BGO_Click;
            // 
            // pictureBoxMail_BGO
            // 
            pictureBoxMail_BGO.BackgroundImage = (Image)resources.GetObject("pictureBoxMail_BGO.BackgroundImage");
            pictureBoxMail_BGO.Location = new Point(1048, 720);
            pictureBoxMail_BGO.Name = "pictureBoxMail_BGO";
            pictureBoxMail_BGO.Size = new Size(34, 30);
            pictureBoxMail_BGO.TabIndex = 13;
            pictureBoxMail_BGO.TabStop = false;
            pictureBoxMail_BGO.Click += pictureBoxMail_BGO_Click;
            // 
            // pictureBoxBuilding_BGO
            // 
            pictureBoxBuilding_BGO.BackgroundImage = (Image)resources.GetObject("pictureBoxBuilding_BGO.BackgroundImage");
            pictureBoxBuilding_BGO.Location = new Point(1048, 775);
            pictureBoxBuilding_BGO.Name = "pictureBoxBuilding_BGO";
            pictureBoxBuilding_BGO.Size = new Size(34, 32);
            pictureBoxBuilding_BGO.TabIndex = 14;
            pictureBoxBuilding_BGO.TabStop = false;
            pictureBoxBuilding_BGO.Click += pictureBoxBuilding_BGO_Click;
            // 
            // FormMain_BGO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1842, 933);
            Controls.Add(pictureBoxBuilding_BGO);
            Controls.Add(pictureBoxMail_BGO);
            Controls.Add(pictureBoxChartBar_BGO);
            Controls.Add(pictureBoxFIO_BGO);
            Controls.Add(textBoxInfo_BGO);
            Controls.Add(chartStatistics);
            Controls.Add(textBoxNameProject_BGO);
            Controls.Add(textBoxInput_BGO);
            Controls.Add(buttonSearch_BGO);
            Controls.Add(listBoxResult_BGO);
            Controls.Add(buttonHelp_BGO);
            Controls.Add(groupBoxTeacher_BGO);
            Controls.Add(groupBoxResult_BGO);
            Name = "FormMain_BGO";
            Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)chartStatistics).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFIO_BGO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChartBar_BGO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMail_BGO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBuilding_BGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox groupBoxTeacher_BGO;
        private GroupBox groupBoxResult_BGO;
        private TextBox textBoxInfo_BGO;
        private PictureBox pictureBoxFIO_BGO;
        private PictureBox pictureBoxChartBar_BGO;
        private PictureBox pictureBoxMail_BGO;
        private PictureBox pictureBoxBuilding_BGO;
    }
}
