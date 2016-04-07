using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Web;
namespace UpdateConFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtData = new DataTable();
        private string[] separetor = { ";" };
        
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshControls();
            dtData.Columns.Add("sno");
            dtData.Columns.Add("FolderPath");
            dtData.Columns.Add("FileName");
            dtData.Columns.Add("OnePlaceCon");
            dtData.Columns.Add("MozartCon");

            dtData.Columns.Add("DbServer");
            dtData.Columns.Add("Database");
            dtData.Columns.Add("UserID");
            dtData.Columns.Add("Password");
            dtData.Columns.Add("IntegratedSecurity");

            dtData.Columns.Add("Error");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtMasterFolder.Text = fbd.SelectedPath;
           
        }

        private void ReadChildFolders(string vrMasterFolderPath)
        {
            string[] chileFolders = Directory.GetDirectories(vrMasterFolderPath);
            foreach (string vrFolder in chileFolders)
            {
                ReadFolderFiles(vrFolder);
                if (chkReadOnlyTopFolder.Checked == false)
                    ReadChildFolders(vrFolder);
            }
        }

        private void ReadFolderFiles(string vrFolderPath)
        {
            string vrFileName = "";
            try
            {
                string[] files = Directory.GetFiles(vrFolderPath);
                foreach (string strFileName in files)
                {
                    vrFileName = Path.GetFileName(strFileName);
                    if (vrFileName == txtFileToSearch.Text.Trim())
                    {

                        XDocument doc = XDocument.Load(strFileName);
                        XElement ConnectionStrings = null;
                        try
                        {
                            ConnectionStrings = doc.Descendants("connectionStrings").First();
                        }
                        catch(Exception ex)
                        {
                            AddDataRow(vrFolderPath, vrFileName, "", "", "", "", "", "", "", "Error 1: " + ex.Message);
                            continue;
                        }
                        if (ConnectionStrings.Elements().Count() == 0)
                        {
                            AddDataRow(vrFolderPath, vrFileName, "", "", "", "", "", "", "", "connection string tag missing");
                            continue;
                        }
                        else
                        {
                            ReadConFile(vrFolderPath, vrFileName, ConnectionStrings);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AddDataRow(vrFolderPath, vrFileName, "", "", "", "", "", "", "", ex.Message);
            }
        }

        private void ReadConFile(string vrFolderPath, string vrFileName, XElement ConnectionStrings)
        {
            try
            {
                string vrOneplaceCon = "";
                string vrMozrtCon = "";

                string vrConServerName = "";
                string vrConDatabaseName = "";
                string vrUserName = "";
                string vrPassword = "";
                string IntegratedSecurity = "";

                foreach (XElement element in ConnectionStrings.Elements())
                {
                    if (element.Name.LocalName.ToLower() == "add")
                    {
                        if (element.Attribute("name").Value == "PhxDbConnectionString")
                        {
                            vrOneplaceCon = element.Attribute("connectionString").Value;

                            List<string> lstConParameters = vrOneplaceCon.Split(separetor, StringSplitOptions.RemoveEmptyEntries).ToList();
                            foreach(string conParameter in lstConParameters)
                            {
                                if(conParameter.Contains("Data Source="))
                                {
                                    vrConServerName = conParameter.Replace("Data Source=",string.Empty).Trim();
                                }
                                else if (conParameter.Contains("Server="))
                                {
                                    vrConServerName = conParameter.Replace("Server=", string.Empty).Trim();
                                }

                                else if (conParameter.Contains("Initial Catalog="))
                                {
                                    vrConDatabaseName = conParameter.Replace("Initial Catalog=", string.Empty).Trim();
                                }
                                else if (conParameter.Contains("Database="))
                                {
                                    vrConDatabaseName = conParameter.Replace("Database=", string.Empty).Trim();
                                }

                                else if (conParameter.Contains("User ID="))
                                {
                                    vrUserName = conParameter.Replace("User ID=", string.Empty).Trim();
                                }
                                else if (conParameter.Contains("user="))
                                {
                                    vrUserName = conParameter.Replace("user=", string.Empty).Trim();
                                }

                                else if (conParameter.Contains("Password="))
                                {
                                    vrPassword = conParameter.Replace("Password=", string.Empty).Trim();
                                }
                                else if (conParameter.Contains("password="))
                                {
                                    vrPassword = conParameter.Replace("password=", string.Empty).Trim();
                                }

                                else if (conParameter.Contains("Integrated Security="))
                                {
                                    IntegratedSecurity = conParameter.Replace("Integrated Security=", string.Empty).Trim();
                                }
                                else if (conParameter.Contains("Integrated Security = "))
                                {
                                    IntegratedSecurity = conParameter.Replace("Integrated Security = ", string.Empty).Trim();
                                }
                            }
                        }
                        else if (element.Attribute("name").Value == "MozartOnePlaceEntities")
                        {
                            vrMozrtCon = element.Attribute("connectionString").Value;
                        }
                    }
                }
                AddDataRow(vrFolderPath, vrFileName, vrOneplaceCon, vrMozrtCon,vrConServerName,vrConDatabaseName,vrUserName,vrPassword,IntegratedSecurity, "");
            }
            catch(Exception ex)
            {
                AddDataRow(vrFolderPath, vrFileName, "", "", "", "", "", "", "", "Error ReadConFile" + ex.Message);
            }
        }

        private void RefreshControls()
        {
            lblError.Text = "";
            dtData.Clear();
            dgResults.DataSource = null;
            dgResults.Rows.Clear();
            dgResults.Refresh();
        }

        private void btnReadFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMasterFolder.Text.Trim()))
            {
                RefreshControls();
                string vrMasterFolderPath = txtMasterFolder.Text.Trim();
                ReadFolderFiles(vrMasterFolderPath);
                ReadChildFolders(vrMasterFolderPath);

                if (dtData.Rows.Count > 0)
                {
                    dgResults.DataSource = dtData;
                    dgResults.Refresh();
                }
                else
                {
                    lblError.Text = "No DbConnection.config file found";
                }
            }
        }

        private void AddDataRow(string vrFolerPath,string vrFileName,string vrOneplaceCon,string vrMozartCon, string DbServer,string Database,string UserID,string Password,string IntegratedSecurity, string vrError)
        {
            int vrSerialNum = 1;
            vrSerialNum = vrSerialNum + dtData.Rows.Count;
            dtData.Rows.Add(vrSerialNum.ToString(), vrFolerPath, vrFileName, vrOneplaceCon, vrMozartCon,DbServer,Database,UserID,Password,IntegratedSecurity, vrError);
        }

        private void dgResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    string vrFolderPath = senderGrid["FolderPath", e.RowIndex].Value.ToString();
                    string vrFileName = senderGrid["FileName", e.RowIndex].Value.ToString();
                    string vrCompletePath = vrFolderPath + "\\" + vrFileName;
                    string vrMozartConStr = string.Empty;
                    bool IntegratedSecurity = false;

                    #region Create file backup
                    string vrNewFileName = Path.GetFileNameWithoutExtension(vrFileName) + "_orig" + Path.GetExtension(vrFileName);
                    string vrNewFileCompletePath = vrFolderPath + "\\" + vrNewFileName;
                    if (!File.Exists(vrNewFileCompletePath))
                        File.Copy(vrCompletePath, vrNewFileCompletePath, true);
                    #endregion

                    #region GET database settings
                    IntegratedSecurity = (Convert.ToString(senderGrid["IntegratedSecurity", e.RowIndex].Value) == string.Empty) ? false : true;
                    if(IntegratedSecurity == false)
                    {
                        vrMozartConStr = MozartTampleteWUser.Text.Trim();
                        vrMozartConStr = vrMozartConStr.Replace("@@server", senderGrid["DbServer", e.RowIndex].Value.ToString())
                            .Replace("@@database", senderGrid["Database", e.RowIndex].Value.ToString())
                            .Replace("@@user", senderGrid["UserID", e.RowIndex].Value.ToString())
                            .Replace("@@password", senderGrid["Password", e.RowIndex].Value.ToString());
                    }
                    else
                    {
                        vrMozartConStr = MozartTampleteIntegrated.Text.Trim();
                        vrMozartConStr = vrMozartConStr.Replace("@@server", senderGrid["DbServer", e.RowIndex].Value.ToString())
                           .Replace("@@database", senderGrid["Database", e.RowIndex].Value.ToString());
                    }
                    #endregion

                    #region UPDATE CONNECTION FILE
                    if (!string.IsNullOrEmpty(vrMozartConStr))
                    {
                        XDocument doc = XDocument.Load(vrCompletePath);

                        XElement ConnectionStrings = doc.Descendants("connectionStrings").First();
                        IEnumerable<XElement> lst = doc.Element("connectionStrings").Elements("MozartOnePlaceEntities");
                        doc.Element("connectionStrings").Elements().Where(el => el.Attribute("name").Value == "MozartOnePlaceEntities").Remove();
                        XElement root = new XElement("add");
                        root.Add(new XAttribute("name", "MozartOnePlaceEntities"));
                        root.Add(new XAttribute("connectionString", HttpUtility.HtmlDecode(vrMozartConStr)));
                        root.Add(new XAttribute("providerName", "System.Data.EntityClient"));
                        doc.Element("connectionStrings").Add(root); 
                        doc.Save(vrCompletePath);
                    }
                    #endregion

                    senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
            catch(Exception ex)
            {
                senderGrid.Rows[e.RowIndex].Cells["Error"].Value = ex.Message;   
            }
        }
    }
}
