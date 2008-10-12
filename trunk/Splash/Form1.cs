using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using Hassanally.Net.BPMonitor;

namespace Hassanally
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	
	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Timer timer1;
		//private Splash sp=null;

        

		public Form1()
		{
			InitializeComponent();

            //DoSplash();
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
            th.Join();
            Thread.Sleep(1000);
            th.Abort();
            Thread.Sleep(1000);
			
			

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void DoSplash()
		{
			
			Splash sp = new Splash();
			sp.ShowDialog();

		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
		//	sp.Close();
		}
	}
}
