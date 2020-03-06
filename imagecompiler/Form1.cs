using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace imagecompiler
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }



        public void Form1_Load(object sender, EventArgs e)
        {
            
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
           





        }

        
        public void isle()
        {

            if (textBox2.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Please fill the required areas.");
            }
            else
            {

            var target = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(target);
            graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            graphics.DrawImage(pictureBox1.Image, 0, 0);
            graphics.DrawImage(pictureBox2.Image, 0, 0);



                target.Save(textBox2.Text + "\\" + textBox1.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                pictureBox3.Image = Image.FromFile(textBox2.Text + "\\" + textBox1.Text + ".png");
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            




        }
        
  

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
         
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data!=null)
            {

                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    pictureBox1.Image = Image.FromFile(fileNames[0]);

            }
        }

        private void PictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {

                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    pictureBox2.Image = Image.FromFile(fileNames[0]);

            }
        }

        private void PictureBox3_DragEnter(object sender, DragEventArgs e)
        {
       
           
        }

        private void PictureBox3_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            isle();
        }
    }
}
