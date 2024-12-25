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
            buttonAboutMe_BGO = new Button();
            labelAbouMe_BGO = new Label();
            pictureBoxAboutMe_BGO = new PictureBox();
            ((ISupportInitialize)pictureBoxAboutMe_BGO).BeginInit();
            SuspendLayout();
            // 
            // buttonAboutMe_BGO
            // 
            buttonAboutMe_BGO.BackColor = SystemColors.GradientActiveCaption;
            buttonAboutMe_BGO.Location = new Point(606, 371);
            buttonAboutMe_BGO.Name = "buttonAboutMe_BGO";
            buttonAboutMe_BGO.Size = new Size(81, 34);
            buttonAboutMe_BGO.TabIndex = 1;
            buttonAboutMe_BGO.Text = "ОК";
            buttonAboutMe_BGO.UseVisualStyleBackColor = false;
            buttonAboutMe_BGO.Click += buttonAboutMe_BGO_Click;
            // 
            // labelAbouMe_BGO
            // 
            labelAbouMe_BGO.AutoSize = true;
            labelAbouMe_BGO.BorderStyle = BorderStyle.Fixed3D;
            labelAbouMe_BGO.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAbouMe_BGO.Location = new Point(257, 25);
            labelAbouMe_BGO.Name = "labelAbouMe_BGO";
            labelAbouMe_BGO.Size = new Size(430, 327);
            labelAbouMe_BGO.TabIndex = 3;
            labelAbouMe_BGO.Text = resources.GetString("labelAbouMe_BGO.Text");
            labelAbouMe_BGO.Click += label1_Click;
            // 
            // pictureBoxAboutMe_BGO
            // 
            pictureBoxAboutMe_BGO.BackgroundImage = (Image)resources.GetObject("pictureBoxAboutMe_BGO.BackgroundImage");
            pictureBoxAboutMe_BGO.Location = new Point(27, 56);
            pictureBoxAboutMe_BGO.Name = "pictureBoxAboutMe_BGO";
            pictureBoxAboutMe_BGO.Size = new Size(200, 268);
            pictureBoxAboutMe_BGO.TabIndex = 2;
            pictureBoxAboutMe_BGO.TabStop = false;
            pictureBoxAboutMe_BGO.Click += pictureBox1_Click;
            // 
            // FormAbout_BGO
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(718, 417);
            Controls.Add(labelAbouMe_BGO);
            Controls.Add(pictureBoxAboutMe_BGO);
            Controls.Add(buttonAboutMe_BGO);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}