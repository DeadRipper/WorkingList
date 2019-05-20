using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TestTask
{
	public partial class Form1 : Form
	{
		static string ConnectionString = ConfigurationManager.ConnectionStrings["TestTask.Properties.Settings.Параметр"].ConnectionString;
		static SqlConnection conn = new SqlConnection(ConnectionString);
		static SqlCommand cmd = new SqlCommand("SELECT [Date] " +
			",[Organization]" + 
			",[City]" +
			",[Country]" +
			",[Manager]" +
			",[Quantity]" +
			",[Summary]" +
			"FROM[TaskDB].[dbo].[Table1]", conn);
		static SqlDataAdapter adapter = new SqlDataAdapter();

		public Form1()
		{
			InitializeComponent();
			Filling();
		}

		public void Filling()
		{
			try
			{
				conn.Open();
				DataTable dt = new DataTable();
				adapter.SelectCommand = cmd;
				adapter.Fill(dt);
				BindingSource binding = new BindingSource();

				binding.DataSource = dt;
				dataGridView1.DataSource = binding;
				adapter.Update(dt);
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}


		/// <summary>
		/// Эти чекбоксы регулируют отображение данных в гриде
		/// Задание было вывести при необходимости 1 колонку + обязательных 2 колонки Количество и Сумма
		/// Я решил немного сделать по другому и решил дать конечному пользывателю функционал
		/// в котором он сам захочет сортировать данные по тем критериям которые ему нужны.
		/// </summary>
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked == true)
				dataGridView1.Columns[0].Visible = false;
			else
				dataGridView1.Columns[0].Visible = true;
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked == true)
				dataGridView1.Columns[1].Visible = false;
			else
				dataGridView1.Columns[1].Visible = true;
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked == true)
				dataGridView1.Columns[2].Visible = false;
			else
				dataGridView1.Columns[2].Visible = true;
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox4.Checked == true)
				dataGridView1.Columns[3].Visible = false;
			else
				dataGridView1.Columns[3].Visible = true;
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox5.Checked == true)
				dataGridView1.Columns[4].Visible = false;
			else
				dataGridView1.Columns[4].Visible = true;
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox6.Checked == true)
				dataGridView1.Columns[5].Visible = false;
			else
				dataGridView1.Columns[5].Visible = true;
		}

		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox7.Checked == true)
				dataGridView1.Columns[6].Visible = false;
			else
				dataGridView1.Columns[6].Visible = true;
		}
	}
}
