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
            ((System.ComponentModel.ISupportInitialize)chartStatistics).BeginInit();
            SuspendLayout();
            // 
            // buttonHelp_BGO
            // 
            buttonHelp_BGO.BackColor = Color.White;
            buttonHelp_BGO.BackgroundImage = (Image)resources.GetObject("buttonHelp_BGO.BackgroundImage");
            buttonHelp_BGO.Location = new Point(1738, 11);
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
            listBoxResult_BGO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxResult_BGO.ForeColor = SystemColors.InactiveCaptionText;
            listBoxResult_BGO.FormattingEnabled = true;
            listBoxResult_BGO.ItemHeight = 28;
            listBoxResult_BGO.Location = new Point(11, 307);
            listBoxResult_BGO.Name = "listBoxResult_BGO";
            listBoxResult_BGO.Size = new Size(1806, 56);
            listBoxResult_BGO.TabIndex = 3;
            listBoxResult_BGO.SelectedIndexChanged += listBoxResult_BGO_SelectedIndexChanged;
            // 
            // buttonSearch_BGO
            // 
            buttonSearch_BGO.BackgroundImage = (Image)resources.GetObject("buttonSearch_BGO.BackgroundImage");
            buttonSearch_BGO.Location = new Point(674, 192);
            buttonSearch_BGO.Name = "buttonSearch_BGO";
            buttonSearch_BGO.Size = new Size(86, 82);
            buttonSearch_BGO.TabIndex = 4;
            buttonSearch_BGO.UseVisualStyleBackColor = true;
            buttonSearch_BGO.Click += buttonSearch_BGO_Click;
            // 
            // textBoxInput_BGO
            // 
            textBoxInput_BGO.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInput_BGO.Location = new Point(11, 192);
            textBoxInput_BGO.Multiline = true;
            textBoxInput_BGO.Name = "textBoxInput_BGO";
            textBoxInput_BGO.Size = new Size(541, 47);
            textBoxInput_BGO.TabIndex = 5;
            // 
            // textBoxNameProject_BGO
            // 
            textBoxNameProject_BGO.BackColor = SystemColors.InactiveBorder;
            textBoxNameProject_BGO.BorderStyle = BorderStyle.FixedSingle;
            textBoxNameProject_BGO.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNameProject_BGO.ForeColor = Color.DarkSlateGray;
            textBoxNameProject_BGO.Location = new Point(11, 12);
            textBoxNameProject_BGO.Multiline = true;
            textBoxNameProject_BGO.Name = "textBoxNameProject_BGO";
            textBoxNameProject_BGO.Size = new Size(1720, 78);
            textBoxNameProject_BGO.TabIndex = 6;
            textBoxNameProject_BGO.Text = "Университет";
            // 
            // chartStatistics
            // 
            chartStatistics.Location = new Point(11, 369);
            chartStatistics.Margin = new Padding(3, 4, 3, 4);
            chartStatistics.Name = "chartStatistics";
            chartStatistics.Size = new Size(922, 404);
            chartStatistics.TabIndex = 7;
            chartStatistics.Text = "chart1";
            // 
            // FormMain_BGO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1842, 933);
            Controls.Add(chartStatistics);
            Controls.Add(textBoxNameProject_BGO);
            Controls.Add(textBoxInput_BGO);
            Controls.Add(buttonSearch_BGO);
            Controls.Add(listBoxResult_BGO);
            Controls.Add(buttonHelp_BGO);
            Name = "FormMain_BGO";
            Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)chartStatistics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
