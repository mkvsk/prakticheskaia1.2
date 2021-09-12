using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakticheskaia1._2_byNeshik
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public float swimmingDistance = 1500;
		public float bikeDistance = 40;
		public float runningDistance = 10;

		public float totalTime1;
		public float totalTime2;
		public float totalTime3;

		public float minTotalTime = 999999999999;

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void buttonTotalTime_Click(object sender, EventArgs e)
		{
			float sportsman1SwimmingSpeed = int.Parse(textBoxSwimming1.Text);
			float sportsman2SwimmingSpeed = int.Parse(textBoxSwimming2.Text);
			float sportsman3SwimmingSpeed = int.Parse(textBoxSwimming3.Text);

			float sportsman1BikeSpeed = int.Parse(textBoxBike1.Text);
			float sportsman2BikeSpeed = int.Parse(textBoxBike2.Text);
			float sportsman3BikeSpeed = int.Parse(textBoxBike3.Text);

			float sportsman1RunningSpeed = int.Parse(textBoxRunning1.Text);
			float sportsman2RunningSpeed = int.Parse(textBoxRunning2.Text);
			float sportsman3RunningSpeed = int.Parse(textBoxRunning3.Text);

			totalTime1 = (swimmingDistance / sportsman1SwimmingSpeed) 
				+ (bikeDistance / sportsman1BikeSpeed) 
				+ (runningDistance / sportsman1RunningSpeed);

			totalTime2 = (swimmingDistance / sportsman2SwimmingSpeed)
				+ (bikeDistance / sportsman2BikeSpeed)
				+ (runningDistance / sportsman2RunningSpeed);

			totalTime3 = (swimmingDistance / sportsman3SwimmingSpeed)
				+ (bikeDistance / sportsman3BikeSpeed)
				+ (runningDistance / sportsman3RunningSpeed);

			textBoxTotalTime1.Text = totalTime1.ToString();
			textBoxTotalTime2.Text = totalTime2.ToString();
			textBoxTotalTime3.Text = totalTime3.ToString();
		}

		private void buttonShowChampion_Click(object sender, EventArgs e)
		{
			bestResult(totalTime1, totalTime2, totalTime3);
		}

		void bestResult(float totalTime1, float totalTime2, float totalTime3)
		{
			string name1 = textBoxSportsman1.Text;
			string name2 = textBoxSportsman2.Text;
			string name3 = textBoxSportsman3.Text;

			float[] arr = { totalTime1, totalTime2, totalTime3 };
			minTotalTime = arr.Min();

			if (minTotalTime == totalTime1)
			{
				textBoxChampionName.Text = name1.ToString();
			}
			if (minTotalTime == totalTime2)
			{
				textBoxChampionName.Text = name2.ToString();
			}
			if (minTotalTime == totalTime3)
			{
				textBoxChampionName.Text = name3.ToString();
			}
		}
	}
}
