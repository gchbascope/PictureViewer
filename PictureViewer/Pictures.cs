﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Pictures : Form
    {
        /// <summary>
        /// Constructor de la clase Pictures, inicializa componentes.
        /// </summary>
        public Pictures()
        {
            int number;
            number = 10;
            number = number - 5;
            number = number * 3;
            
            InitializeComponent();
            //this.Text = number.ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showImagen_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Carga la imagen al picture box
                pictureBox1.Load(openFileDialog1.FileName);
            }

        }

        private void deletteImagen_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void setColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajustar_CheckedChanged(object sender, EventArgs e)
        {
            if (Ajustar.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void Pictures_Load(object sender, EventArgs e)
        {

        }

      
    }
}
