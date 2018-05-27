/*
 * Created by SharpDevelop.
 * User: andreas.leja
 * Date: 19.2.2018.
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace LetItGo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private static string ime;
		
		string prepath = Directory.GetCurrentDirectory();
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		void BtnStartClick(object sender, EventArgs e)
		{		
			if(txtName.Text != "")
			{
				ime = txtName.Text;
				Random rnd = new Random();
				
				btnIzlaz.Hide();
				btnPravila.Hide();
				btnStart.Hide();
				txtName.Hide();
				label1.Hide();
				btnScore.Hide();
				
				
				string path_main = Path.GetFullPath(Path.Combine(prepath, @"..\..\resursi\Wall.jpg"));
				
				
				Image myimage = new Bitmap(path_main);
    			this.BackgroundImage = myimage;
				
    			this.FormBorderStyle = FormBorderStyle.None;
    			
				Button Lako = new Button();
				Button Osrednji = new Button();
				Button Teski = new Button();
			
				Label lbl1 = new Label();
			
				lbl1.Size = new Size(500,60);
				lbl1.Location = new Point(150, 60);
				lbl1.Font = new Font("Comic Sans MS", 30);
				lbl1.ForeColor = Color.Transparent;
				lbl1.Text = "Odaberite težinu:";
				lbl1.BackColor = Color.Transparent;
				this.Controls.Add(lbl1);
				
				label2.ForeColor = Color.Black;
			
				Lako.Size = new Size(300, 80);
				Lako.BackColor = Color.Cyan;
				Lako.Location = new Point(173, 187);
				Lako.Text = "Lagano";
				Lako.Font = new Font("Comic Sans MS", 23);
				Lako.FlatStyle = FlatStyle.Flat;
				this.Controls.Add(Lako);
			
				Osrednji.Size = new Size(300, 80);
				Osrednji.BackColor = Color.Cyan;
				Osrednji.Location = new Point(173, 305);
				Osrednji.Text="Napredno";
				Osrednji.Font = new Font("Comic Sans MS", 23);
				Osrednji.FlatStyle = FlatStyle.Flat;
				this.Controls.Add(Osrednji);
			
			
				Teski.Size = new Size(300, 80);
				Teski.BackColor = Color.Cyan;
				Teski.Location = new Point(173, 421);
				Teski.Text = "Teško";
				Teski.Font = new Font("Comic Sans MS", 23);
				Teski.FlatStyle = FlatStyle.Flat;
				this.Controls.Add(Teski);

			
				Lako.Click += new EventHandler(Easy_Click);
				Osrednji.Click += new EventHandler(Normal_Click);
				Teski.Click += new EventHandler(Hard_Click);
			}
			else
			{
				txtName.BackColor = Color.MistyRose;
				MessageBox.Show("Unesite svoje ime");
				txtName.Focus();
			}
		}
		void BtnIzlazClick(object sender, EventArgs e)
		{
			
			List<Form> openForms = new List<Form>();
			foreach (Form f in Application.OpenForms)
   			 openForms.Add(f);
			foreach (Form f in openForms)
			{
			    if (f.Name != "Menu")
			        f.Dispose();
			}
			this.Dispose();
		}
		void BtnPravilaClick(object sender, EventArgs e)
		{
			string s = "Na zaslonu će ti se pojaviti kvadrat u boji koji moraš pratiti klikom. Za svaki promašaj igra će te kazniti jednom dodatnom sekundom. Sretno!";
			MessageBox.Show(s, "Pravila");
		}
		void Easy_Click(object sender, EventArgs e)
		{
			Easy ES = new Easy();
			ES.Show();
    		this.Hide();
		}
		void Normal_Click(object sender, EventArgs e)
		{
			this.Hide();
			Normal NM = new Normal();
			NM.Show();
		}
		void Hard_Click(object sender, EventArgs e)
		{
			this.Hide();
			Hard HD = new Hard();
			HD.Show();
		}	
		void MainFormLoad(object sender, EventArgs e)
		{
			txtName.Focus();
		}
		
		void BtnScoreMouseHover(object sender, EventArgs e)
		{
			btnScore.ForeColor = Color.Gray;
		}
		
		void BtnScoreMouseLeave(object sender, EventArgs e)
		{
			btnScore.ForeColor = Color.Transparent;
		}
		
		void BtnScoreClick(object sender, EventArgs e)
		{
			string path_score = Path.GetFullPath(Path.Combine(prepath, @"..\..\resursi\baza.txt"));
			pnlScore.Visible = true;

            listBox1.DataSource = File.ReadAllLines(path_score);
        }
		
		void BtnReturnClick(object sender, EventArgs e)
		{
			pnlScore.Visible = false;			
		}
		
		public string Ime {
			get { return ime;}
			set { ime = value;}
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
            MessageBox.Show("This list will be cleared");
            string path_score = Path.GetFullPath(Path.Combine(prepath, @"..\..\resursi\baza.txt"));
            StreamWriter file = new StreamWriter(path_score);
            file.Flush();
            file.Close();
            listBox1.DataSource = File.ReadAllLines(path_score);
        }
	}
}
