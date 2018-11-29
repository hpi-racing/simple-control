using System.Drawing;
using System.Windows.Forms;

namespace WindowsApplication
{
	public partial class ReglerControl : UserControl
	{
		public ReglerControl()
		{
			InitializeComponent();
		}

		public override string Text
		{
			get { return this.groupBox1.Text; }
			set { this.groupBox1.Text = value; }
		}

		public int Speed
		{
			set { this.label2.Text = value.ToString(); }
		}

		public bool Pressed
		{
			set { this.label2.ForeColor = (value) ? Color.Red : Color.Black; }
		}
	}
}
