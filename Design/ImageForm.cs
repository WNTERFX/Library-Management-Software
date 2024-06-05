﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace InputImage
{
    public partial class Form1 : Form
    {
        public string Filter { get; private set; }
        public bool Multiselect { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        public void Insert(String fileName, byte[] image)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["InputImage.Properties.Settings.DatabaseConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using(SqlCommand cmd=new SqlCommand("insert into pictures(filename, image) values(@filename, @image)", cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@filename", txtFileName.Text);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void  LoadData()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["InputImage.Properties.Settings.DatabaseConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
               using(DataTable dt = new DataTable("Pictures")) 
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select *from pictures", cn);
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }
            }
        }

         byte[] ConvertImageToBytes(System.Drawing.Image img)
        {
            using(MemoryStream ms=new MemoryStream())
            {
                img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public System.Drawing.Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter="Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    txtFileName.Text = ofd.FileName;
                    Insert(txtFileName.Text,ConvertImageToBytes(pictureBox.Image));
                    LoadData();
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dataGridView.DataSource as DataTable;
            if (dt != null )
            {
                DataRow row = dt.Rows[e.RowIndex];
                pictureBox.Image = ConvertByteArrayToImage((byte[])row["Image"]);
            }
        }
    }
}

