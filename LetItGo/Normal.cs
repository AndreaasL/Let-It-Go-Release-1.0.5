/*
 * Created by SharpDevelop.
 * User: andreas.leja
 * Date: 12.3.2018.
 * Time: 11:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace LetItGo
{
	/// <summary>
	/// Description of Normal.
	/// </summary>
	public partial class Normal : Form
	{
		string prepath = Directory.GetCurrentDirectory();
		public Normal()
		{
			InitializeComponent();
		}
        Random rnd = new Random();
        int br_zivota = 20;
        void NormalLoad(object sender, EventArgs e)
		{
			timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Start();
            timer2.Start();
				
				Button btn = new Button();
				
					btn.Size = new Size (40, 40);
					btn.BackColor = Color.FromArgb(rnd.Next(0,255), rnd.Next(0,255), rnd.Next(0,255));
					btn.Location = new Point(rnd.Next(0, 800), rnd.Next(60, 500));
					btn.FlatStyle = FlatStyle.Flat;
                    btn.Text = br_zivota.ToString();
                    btn.ForeColor = Color.Black;
                    btn.Font = new Font(Font.FontFamily, 9);
                    this.Controls.Add(btn);
					
					btn.Click += new EventHandler(this.GreetingBtn_Click);
					myPanel.Controls.Add(btn);
		}
		
		int duration_sek = 0;
		
		void Timer1Tick(object sender, EventArgs e)
		{
			duration_sek++;
			textBox1.Text = duration_sek.ToString();
		}
		int duration_ms=0;
		void Timer2Tick(object sender, EventArgs e)
		{
			duration_ms++;
			if(duration_ms<100)
			{
				textBox2.Text = duration_ms.ToString();
				duration_ms++;
			}
			else
			{
				duration_ms=0;
			}
		}
			void GreetingBtn_Click(Object sender,EventArgs e)
    		{
       			 Button clickedButton = (Button)sender;
        		clickedButton.Dispose();
                 br_zivota--;
                if (br_zivota == 0)
                    {
                        string path_score = Path.GetFullPath(Path.Combine(prepath, @"..\..\resursi\baza.txt"));
                        TextWriter tsw = new StreamWriter(path_score, true);

                        timer1.Stop();
                        timer2.Stop();
                        MainForm MF = new MainForm();
                        MessageBox.Show(MF.Ime + " uspjesno ste uklonili sve kvadratiće u " + textBox1.Text + "." + textBox2.Text + " sekundi");

                        string ime = MF.Ime;
                        string zapis = ime + " Normalno " + textBox1.Text + "." + textBox2.Text;
                        tsw.WriteLine(zapis);
                        tsw.Close();
                        this.Hide();

                        MF.Show();
                    }
                else
                    {
                        Button btn = new Button();

                        btn.Size = new Size(40, 40);
                        btn.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                        btn.Location = new Point(rnd.Next(0, 800), rnd.Next(60, 500));
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Text = br_zivota.ToString();
                        btn.ForeColor = Color.Black;
                        btn.Font = new Font(Font.FontFamily, 9);
                        btn.Click += new EventHandler(this.GreetingBtn_Click);
                        myPanel.Controls.Add(btn);
                    }
        }
			void BtnGiveUpClick(object sender, EventArgs e)
		{
			timer1.Stop();
            timer2.Stop();
			MessageBox.Show("Odustali ste");
			this.Hide();
			MainForm MF = new MainForm();
			MF.Show();
		}
		void MyPanelClick(object sender, EventArgs e)
		    {
			    duration_sek++;
		    }
		}
	}
