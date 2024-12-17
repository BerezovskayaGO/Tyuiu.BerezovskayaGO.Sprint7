using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BerezovskayaGO.Sprint7.Project.V3
{
    public partial class FormAbout_BGO : Form
    {
        public FormAbout_BGO()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAbout_BGO));
            textBoxAboutMe_BGO = new TextBox();
            buttonAboutMe_BGO = new Button();
            pictureBoxAboutMe_BGO = new PictureBox();
            ((ISupportInitialize)pictureBoxAboutMe_BGO).BeginInit();
            SuspendLayout();
            // 
            // textBoxAboutMe_BGO
            // 
            textBoxAboutMe_BGO.BackColor = SystemColors.GradientInactiveCaption;
            textBoxAboutMe_BGO.Location = new Point(245, 26);
            textBoxAboutMe_BGO.Multiline = true;
            textBoxAboutMe_BGO.Name = "textBoxAboutMe_BGO";
            textBoxAboutMe_BGO.Size = new Size(399, 283);
            textBoxAboutMe_BGO.TabIndex = 0;
            textBoxAboutMe_BGO.Text = resources.GetString("textBoxAboutMe_BGO.Text");
            // 
            // buttonAboutMe_BGO
            // 
            buttonAboutMe_BGO.BackColor = SystemColors.GradientActiveCaption;
            buttonAboutMe_BGO.Location = new Point(563, 327);
            buttonAboutMe_BGO.Name = "buttonAboutMe_BGO";
            buttonAboutMe_BGO.Size = new Size(81, 34);
            buttonAboutMe_BGO.TabIndex = 1;
            buttonAboutMe_BGO.Text = "О К";
            buttonAboutMe_BGO.UseVisualStyleBackColor = false;
            buttonAboutMe_BGO.Click += buttonAboutMe_BGO_Click;
            // 
            // pictureBoxAboutMe_BGO
            // 
            pictureBoxAboutMe_BGO.Image = (Image)resources.GetObject("pictureBoxAboutMe_BGO.Image");
            pictureBoxAboutMe_BGO.Location = new Point(25, 36);
            pictureBoxAboutMe_BGO.Name = "pictureBoxAboutMe_BGO";
            pictureBoxAboutMe_BGO.Size = new Size(196, 257);
            pictureBoxAboutMe_BGO.TabIndex = 2;
            pictureBoxAboutMe_BGO.TabStop = false;
            pictureBoxAboutMe_BGO.Click += pictureBox1_Click;
            // 
            // FormAbout_BGO
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(667, 373);
            Controls.Add(pictureBoxAboutMe_BGO);
            Controls.Add(buttonAboutMe_BGO);
            Controls.Add(textBoxAboutMe_BGO);
            Name = "FormAbout_BGO";
            Text = "О программе";
            ((ISupportInitialize)pictureBoxAboutMe_BGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonAboutMe_BGO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
