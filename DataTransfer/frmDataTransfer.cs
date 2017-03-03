using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataTransfer
{
    public partial class frmDataTransfer : Form
    {
        public frmDataTransfer()
        {
            InitializeComponent();
        }

        public SqlConnection conSrc = new SqlConnection();
        public string strSrc = "";

        public SqlConnection conDst = new SqlConnection();
        public string strDst = "";

        private void frmDataTransfer_Load(object sender, EventArgs e)
        {
            
        }

        public void BuildConnectionString()
        {
            if (chkSAuthentication.Checked)
            {
                strSrc = "Data Source=" + txtSServerName.Text + ";Initial Catalog=" + txtSDatabase.Text + ";User Id=" + txtSLogin.Text + ";Password=" + txtSPassword.Text;
            }
            else
            {
                strSrc = "Data Source=" + txtSServerName.Text + ";Initial Catalog=" + txtSDatabase.Text + ";Integrated Security=True";
            }

            if (chkDAuthentication.Checked)
            {
                strDst = "Data Source=" + txtDServerName.Text + ";Initial Catalog=" + txtDDatabase.Text + ";User Id=" + txtDLogin.Text + ";Password=" + txtDPassword.Text;
            }
            else
            {
                strDst = "Data Source=" + txtDServerName.Text + ";Initial Catalog=" + txtDDatabase.Text + ";Integrated Security=True";
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            BuildConnectionString();

            try
            {
                if (rbtnTable.Checked)
                {
                    if (chkWithTable.Checked)
                    {
                        TransferDataWithTableScript();
                    }
                    else
                    {
                        TransferData();
                    }
                }
                else if (rbtnSP.Checked)
                {
                    TransferSP();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtnTable_Click(object sender, EventArgs e)
        {
            if (rbtnTable.Checked)
            {
                lblTableName.Text = "Table Name";

                chkWithTable.Enabled = true;
            }
        }

        private void rbtnSP_Click(object sender, EventArgs e)
        {
            if (rbtnSP.Checked)
            {
                lblTableName.Text = "SP Name";

                chkWithTable.Enabled = false;
            }
        }

        void TransferData()
        {
            try
            {
                DataTable dataTable = new Utility().GetTableData("Select * From " + txtTableName.Text, strSrc);

                SqlBulkCopy bulkCopy = new SqlBulkCopy(strDst, SqlBulkCopyOptions.TableLock)
                {
                    DestinationTableName = txtTableName.Text,
                    BatchSize = 100000,
                    BulkCopyTimeout = 360
                };
                bulkCopy.WriteToServer(dataTable);

                MessageBox.Show("Data Transfer Succesfull.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void TransferDataWithTableScript()
        {
            try
            {
                try
                {
                    string Script = new Utility().GetTableScript(txtTableName.Text, strSrc);
                    new Utility().ExecuteQuery(Script, strDst);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
                DataTable dataTable = new Utility().GetTableData("Select * From " + txtTableName.Text, strSrc);

                if (!string.IsNullOrEmpty(new Utility().GetIdentityColumn(txtTableName.Text, strSrc)))
                {
                    string InsertSQL = "";
                    InsertSQL += "SET IDENTITY_INSERT [" + txtTableName.Text + "] ON " + Environment.NewLine;

                    string ColumnSQL = "";
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        ColumnSQL += column.ColumnName + ",";
                    }
                    ColumnSQL = ColumnSQL.Substring(0, ColumnSQL.Length - 1);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string ColumnValueL = "";
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            ColumnValueL += "'" + row[column.ColumnName].ToString().Replace("''", "'") + "',";
                        }
                        ColumnValueL = ColumnValueL.Substring(0, ColumnValueL.Length - 1);

                        InsertSQL += "Insert Into " + txtTableName.Text + " (" + ColumnSQL + ") Values(" + ColumnValueL + ")" + Environment.NewLine;
                    }

                    InsertSQL += "SET IDENTITY_INSERT [" + txtTableName.Text + "] OFF " + Environment.NewLine;

                    new Utility().ExecuteQuery(InsertSQL, strDst);
                }
                else
                {
                    SqlBulkCopy bulkCopy = new SqlBulkCopy(strDst, SqlBulkCopyOptions.TableLock)
                    {
                        DestinationTableName = txtTableName.Text,
                        BatchSize = 100000,
                        BulkCopyTimeout = 360
                    };
                    bulkCopy.WriteToServer(dataTable);
                }

                MessageBox.Show("Table Script and Data Transfer Succesfull.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void TransferSP()
        {
            try
            {
                string Script = new Utility().GetSPScript(txtTableName.Text, strSrc);
                new Utility().ExecuteQuery(Script, strDst);

                MessageBox.Show("SP Transfer Succesfull.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
