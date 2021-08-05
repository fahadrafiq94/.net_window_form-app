using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Covid_patient_tracking_system
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;

        string ConString, sql;
        int paging = 0;
        int pagingsize = 10;

        SqlConnection Sqlcon;
        SqlCommandBuilder sqlbuilder;

        private void openbutton_Click(object sender, EventArgs e)
        {
            ConString = "Data Source=DESKTOP-KP57APH ; Initial Catalog  = corona; User ID= sa ; Password=Badbaby1";

            sql = "select * from P_Detail ; "; 

            Sqlcon = new SqlConnection(ConString);

            adapter = new SqlDataAdapter(sql, Sqlcon);

            ds = new DataSet();
            paging = 0;
            try
            {
                Sqlcon.Open();
                sqlbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(ds,paging , pagingsize, "mytable");
                Sqlcon.Close();
                dt = ds.Tables["mytable"];
                dataGridView1.DataSource = dt;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                savebutton.Enabled = false;
                nextbutton.Enabled = true;
                previousbutton.Enabled = true;
                cleargridbutton.Enabled = true;
                updatebutton.Enabled = true;
                deletebutton.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("error " + ex.ToString());
            }
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            nextbutton.Enabled = false;
            previousbutton.Enabled = false;
            cleargridbutton.Enabled = false;
            updatebutton.Enabled = false;
            savebutton.Enabled = false;
            deletebutton.Enabled = false;
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            if (paging <= 0)
            {
                MessageBox.Show("NO Previous Page");
            }
            paging = paging - 10;
            try
            {
                ds.Clear();
                adapter.Fill(ds, paging, pagingsize, "mytable");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if(paging >=40)
            {
                MessageBox.Show("Maximum Record Reached ");
            }
            paging = paging + 10;
            try
            {
                ds.Clear();
                adapter.Fill(ds, paging, pagingsize, "mytable");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            savebutton.Enabled = false;
            openbutton.Enabled = true;
            updatebutton.Enabled = true;
            if (adapter.Update(dt) > 0)
            {
                MessageBox.Show("Changes Saved");
            }

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            updatebutton.Enabled = false;
            savebutton.Enabled = true;
            openbutton.Enabled = false;
            dataGridView1.ReadOnly = false;
        }

        private void namesearchbutton_Click(object sender, EventArgs e)
        {
           
            try
            {
                ConString = "Data Source=DESKTOP-KP57APH ; Initial Catalog  = corona; User ID= sa ; Password=Badbaby1";

                sql = "select * from P_Detail where P_Name = @val and P_Id = P_Id  or P_Mobile = @val and P_Id = P_Id; ";

                Sqlcon = new SqlConnection(ConString);

                adapter = new SqlDataAdapter(sql, Sqlcon);

                adapter.SelectCommand.Parameters.AddWithValue("@val ", namesearchtextBox.Text.Trim());
                
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                namesearchtextBox.Clear();
                cleargridbutton.Enabled = true;
                nextbutton.Enabled = true;
                previousbutton.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void patientmedicalhistoryaddbutton_Click(object sender, EventArgs e)
        {
            ConString = "Data Source=DESKTOP-KP57APH ; Initial Catalog  = corona; User ID= sa ; Password=Badbaby1";

            sql = "select * from P_Mhistory; ";

            Sqlcon = new SqlConnection(ConString);

            adapter = new SqlDataAdapter(sql, Sqlcon);

            ds = new DataSet();
            paging = 0;
            try
            {
                Sqlcon.Open();
                sqlbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, paging, pagingsize, "mytable");
                Sqlcon.Close();
                dt = ds.Tables["mytable"];
                dataGridView1.DataSource = dt;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                savebutton.Enabled = false;
                openbutton.Enabled = true; 
                nextbutton.Enabled = true;
                previousbutton.Enabled = true;
                cleargridbutton.Enabled = true;
                updatebutton.Enabled = true;
                deletebutton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.ToString());
            }
        }

        private void patienttreatmentbutton_Click(object sender, EventArgs e)
        {
            ConString = "Data Source=DESKTOP-KP57APH ; Initial Catalog  = corona; User ID= sa ; Password=Badbaby1";

            sql = "select * from P_TDetail; ";

            Sqlcon = new SqlConnection(ConString);

            adapter = new SqlDataAdapter(sql, Sqlcon);

            ds = new DataSet();
            paging = 0;
            try
            {
                Sqlcon.Open();
                sqlbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, paging, pagingsize, "mytable");
                Sqlcon.Close();
                dt = ds.Tables["mytable"];
                dataGridView1.DataSource = dt;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                savebutton.Enabled = false;
                nextbutton.Enabled = true;
                previousbutton.Enabled = true;
                cleargridbutton.Enabled = true;
                updatebutton.Enabled = true;
                deletebutton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.ToString());
            }
        }

        private void medicalstaffbutton_Click(object sender, EventArgs e)
        {
            ConString = "Data Source=DESKTOP-KP57APH ; Initial Catalog  = corona; User ID= sa ; Password=Badbaby1";

            sql = "select * from P_MDetail; ";

            Sqlcon = new SqlConnection(ConString);

            adapter = new SqlDataAdapter(sql, Sqlcon);

            ds = new DataSet();
            paging = 0;
            try
            {
                Sqlcon.Open();
                sqlbuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, paging, pagingsize, "mytable");
                Sqlcon.Close();
                dt = ds.Tables["mytable"];
                dataGridView1.DataSource = dt;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                savebutton.Enabled = false;
                nextbutton.Enabled = true;
                previousbutton.Enabled = true;
                cleargridbutton.Enabled = true;
                updatebutton.Enabled = true;
                deletebutton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure to Delete Record", "Confirmation Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int rowid = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(rowid);

                if(adapter.Update(dt)>0)
                {
                    MessageBox.Show("Succecfully Delted");
                }
            }
        }

        private void cleargridbutton_Click(object sender, EventArgs e)
        {
            openbutton.Enabled = true;
            dataGridView1.DataSource = null;
            cleargridbutton.Enabled = false;
            nextbutton.Enabled = false;
            previousbutton.Enabled = false;
            updatebutton.Enabled = false;
            deletebutton.Enabled = false;
            savebutton.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }
    
    }
}
