using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Atlas
{
	public partial class Form1 : Form
	{
		public Image img; 


		public Form1()
		{
			InitializeComponent();
		}



		private void button2_Click(object sender, EventArgs e)
		{
			
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pictureBox1.Load(openFileDialog1.FileName);
					img = pictureBox1.Image; //stores a reference image aswell for getting a smaller version out on selection
					pictureBox1.Width = img.Width;
					pictureBox1.Height = img.Height;
				}
				catch (Exception eer)
				{
					MessageBox.Show("blip blop, error /n" + eer.Message);
				}
			}
		}

		//use this to select the grid size area. gotta do some math here to find the right grid though :)
		private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
		{
			if (pictureBox1.Image != null && img != null)
			{
			}
		}

		//this is the update botton, feel free to rename the buttons to appropriate things
		//one can remove the need for this button if you add events to the textboxes,
		//but they trigger for every change, and can be laggy
		private void button1_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image != null)
			{
				int.TryParse(textBox1.Text, out var x);
				int.TryParse(textBox2.Text, out var y);

				Graphics grap;
				grap = pictureBox1.CreateGraphics();
				ControlPaint.DrawGrid(grap, new Rectangle(0, 0, img.Width, img.Height), new Size(x,y), Color.Black);
				
				//you can alternatively do a for loop to draw x and y lines. but this is fine.
			}

		}
	}
}
