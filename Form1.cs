using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace WindowsApplication
{
	public partial class Form1 : Form
	{
		private bool isRunning = true;

		private SerialPort serialPortSensors = new SerialPort("/dev/ttyUSB0");
		private SerialPort serialPortActuators = new SerialPort("/dev/ttyUSB1");

		private long counter = 0;

		ReglerControl[] reglerControlSet;
		int[] speedSet = new int[8];
		bool[] pressedSet = new bool[8];

		
		public Form1()
		{
			InitializeComponent();

			Random random = new Random();
			serialPortActuators.Open();

			//new Thread((ThreadStart)delegate
			//{
				//while (isRunning)
				//{
					//byte speed = (byte)random.Next(16);
					//byte taster = (byte)random.Next(2);

					//byte sendByte = (byte)(speed | (taster << 4) | (1 << 6));
					//serialPortActuators.Write(new[] { sendByte },0,1);

					//Thread.Sleep(500);
				//}
			//}) { IsBackground = true }.Start();
					

			this.reglerControlSet = new []
			{
				this.reglerControl1,
				this.reglerControl2,
				this.reglerControl3,
				this.reglerControl4,
				this.reglerControl5,
				this.reglerControl6,
			};
			for (int i=0;i<6;i++)
				reglerControlSet[i].Text = "Controller "+i;

				
			serialPortSensors.Open();

			new Thread((ThreadStart)delegate
			{
				while (isRunning)
				{
					int one;
					do one = serialPortSensors.ReadByte();
					while ((one & (1<<7))==0);					

					int count = one & ~(1<<7);
					int value = serialPortSensors.ReadByte() | (serialPortSensors.ReadByte()<<7);

					if (count==9)
					{
						int adress = new[] { value.Bit(0),value.Bit(1),value.Bit(2) }.ToInt();
						bool spur = value.Bit(3);
						int speed = new[] { value.Bit(4),value.Bit(5),value.Bit(6),value.Bit(7) }.ToInt();

						speedSet[adress] = speed;
						pressedSet[adress] = !spur;
					}

					counter++;
				}
			}) { IsBackground = true }.Start();
		}

		private void button1_Click(object sender,EventArgs e)
		{
			this.isRunning = false;
		}



		private void timer1_Tick(object sender,EventArgs e)
		{
			this.label1.Text = "";
			this.label2.Text = "";

			this.label3.Text = this.counter.ToString("N0");

			for (int i=0;i<this.reglerControlSet.Length;i++)
			{
				ReglerControl control = this.reglerControlSet[i];
				control.Speed = speedSet[i];
				control.Pressed = pressedSet[i];
			}
		}
	}
}
