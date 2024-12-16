namespace Tyuiu.BerezovskayaGO.Sprint7.Project.V3
{
    partial class FormMain_BGO
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BGO));
            buttonHelp_BGO = new Button();
            toolTipHelp = new ToolTip(components);
            SuspendLayout();
            // 
            // buttonHelp_BGO
            // 
            buttonHelp_BGO.BackColor = Color.White;
            buttonHelp_BGO.BackgroundImage = (Image)resources.GetObject("buttonHelp_BGO.BackgroundImage");
            buttonHelp_BGO.Location = new Point(720, 12);
            buttonHelp_BGO.Name = "buttonHelp_BGO";
            buttonHelp_BGO.Size = new Size(68, 55);
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
            // FormMain_BGO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_BGO);
            Name = "FormMain_BGO";
            Text = "Главная";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_BGO;
        private ToolTip toolTipHelp;
    }
}
