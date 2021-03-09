using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemo
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=E440\SQLEXPRESS;Initial Catalog=DBUsers;Integrated Security=True";
        SqlConnection con;
        DataSet dsUsers;
        DataTable dtUsers;
        SqlDataAdapter adptr;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            dsUsers = new DataSet();
            ShowUsersInGV();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ShowUsersInGV();
        }

        private void ShowUsersInGV()
        {
            adptr = new SqlDataAdapter(
                " SELECT * " +
                " FROM TBUsers " +
                " ORDER BY Name"
                , con);

            dsUsers.Clear();
            adptr.Fill(dsUsers, "users");
            dtUsers = dsUsers.Tables["users"];
            //MessageBox.Show(dtUsers.Rows[0][1].ToString());

            dataGridView1.DataSource = dtUsers;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = dtUsers.NewRow();
            dr["Name"] = txtName.Text;
            dr["Family"] = txtFamily.Text;
            dr["ID"] = 777;

            dtUsers.Rows.Add(dr);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dtUsers.Rows)
            {
                if (row.RowState != DataRowState.Deleted && row["ID"].ToString() == txtID.Text)
                {
                    row["Name"] = txtName.Text;
                    row["Family"] = txtFamily.Text;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dtUsers.Rows)
            {
                if (row.RowState != DataRowState.Deleted && row["ID"].ToString() == txtID.Text)
                {
                    row.Delete();
                }
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(adptr);
            adptr.Update(dtUsers);
            //adptr.Update(dsUsers, "users");
        }

        private void btnIWP_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand(
                //" INSERT INTO TBUsers(Name, Family) VALUES('" + txtName.Text + "','" + txtFamily.Text + "')"
                //$" INSERT INTO TBUsers(Name, Family) VALUES('{txtName.Text}','{txtFamily.Text}')"
                " INSERT INTO TBUsers(Name, Family) VALUES(@parName , @parFamily)"
                , con);

            SqlParameter pName = new SqlParameter("parName", txtName.Text);
            comm.Parameters.Add(pName);

            comm.Parameters.Add(new SqlParameter("parFamily", txtFamily.Text));

            comm.Connection.Open();
            int res = comm.ExecuteNonQuery();
            comm.Connection.Close();

            MessageBox.Show(res == 1 ? " SUCCESS" : "WORNG");
        }

        private void btnSPRV_Click(object sender, EventArgs e)
        {
            SqlCommand commSP = new SqlCommand("SearchUser", con);
            commSP.CommandType = CommandType.StoredProcedure;

            SqlParameter parID = new SqlParameter("MyID", txtID.Text);
            parID.Direction = ParameterDirection.Input;
            commSP.Parameters.Add(parID);

            SqlParameter parFamily = new SqlParameter("FamilyName", SqlDbType.VarChar, 20);
            parFamily.Direction = ParameterDirection.Output;
            commSP.Parameters.Add(parFamily);

            SqlParameter returnV = new SqlParameter();
            returnV.Direction = ParameterDirection.ReturnValue;
            commSP.Parameters.Add(returnV);

            commSP.Connection.Open();
            commSP.ExecuteNonQuery();
            commSP.Connection.Close();

            if ((int)returnV.Value == 0)
            {
                MessageBox.Show(parFamily.Value.ToString());
            }
            else
            {
                MessageBox.Show("mashu lo histader li!");
            }

        }

        private void btnSPRT_Click(object sender, EventArgs e)
        {
            SqlCommand commSP = new SqlCommand("SearchUserTable", con);
            commSP.CommandType = CommandType.StoredProcedure;

            SqlParameter parID = new SqlParameter("MyID", txtID.Text);
            parID.Direction = ParameterDirection.Input;
            commSP.Parameters.Add(parID);

            DataSet dsSP = new DataSet();
            SqlDataAdapter adptrSP = new SqlDataAdapter(commSP);
            adptrSP.Fill(dsSP, "T1");

            dataGridView1.DataSource = dsSP.Tables["T1"];
        }
    }
}
