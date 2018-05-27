/*
 * Created by SharpDevelop.
 * User: andreas.leja
 * Date: 19.2.2018.
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LetItGo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnPravila;
		private System.Windows.Forms.Button btnIzlaz;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPravila = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(163, 233);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(287, 71);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Nova igra";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // btnPravila
            // 
            this.btnPravila.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPravila.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnPravila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPravila.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPravila.Location = new System.Drawing.Point(163, 342);
            this.btnPravila.Name = "btnPravila";
            this.btnPravila.Size = new System.Drawing.Size(287, 71);
            this.btnPravila.TabIndex = 1;
            this.btnPravila.Text = "Pravila";
            this.btnPravila.UseVisualStyleBackColor = false;
            this.btnPravila.Click += new System.EventHandler(this.BtnPravilaClick);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzlaz.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(163, 455);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(287, 71);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.BtnIzlazClick);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(244, 176);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 30);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(176, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "IME:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(0, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Let It Go 1.0.5";
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnScore.ForeColor = System.Drawing.Color.Transparent;
            this.btnScore.Location = new System.Drawing.Point(319, 546);
            this.btnScore.Margin = new System.Windows.Forms.Padding(0);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(131, 30);
            this.btnScore.TabIndex = 6;
            this.btnScore.Text = "Score board";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.BtnScoreClick);
            this.btnScore.MouseLeave += new System.EventHandler(this.BtnScoreMouseLeave);
            this.btnScore.MouseHover += new System.EventHandler(this.BtnScoreMouseHover);
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlScore.Controls.Add(this.BtnReturn);
            this.pnlScore.Controls.Add(this.BtnClear);
            this.pnlScore.Controls.Add(this.listBox1);
            this.pnlScore.Location = new System.Drawing.Point(12, 163);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(444, 441);
            this.pnlScore.TabIndex = 7;
            this.pnlScore.Visible = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Location = new System.Drawing.Point(296, 411);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 2;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturnClick);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Location = new System.Drawing.Point(52, 411);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClearClick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(433, 390);
            this.listBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 627);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPravila);
            this.Controls.Add(this.btnStart);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Let It Go";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.pnlScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnReturn;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Panel pnlScore;
		private System.Windows.Forms.Button btnScore;
		private System.Windows.Forms.Label label2;
	}
}
