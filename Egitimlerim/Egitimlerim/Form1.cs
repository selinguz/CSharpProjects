﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egitimlerim
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEgitimOlustur_Click(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			frm.Show();
			this.Hide();
		}

		private void btnEgitimlerimeGit_Click(object sender, EventArgs e)
		{
			Form3 frm = new Form3();
			frm.Show();
			this.Hide();
		}
	}
}
