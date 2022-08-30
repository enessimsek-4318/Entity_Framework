using ACD_Construction.ORM.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ACD_Construction
{
    public partial class DocumentOperations : Form
    {
        public DocumentOperations()
        {
            InitializeComponent();
        }
        BusinessLogicLayer BLL = new BusinessLogicLayer();
        private void DocumentOperations_Load(object sender, EventArgs e)
        {
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            //----------------------------------------------
            string[] sendingReason = { "IRF", "RIRF" };
            string[] documentStatus = { "Approved", "Approved With Comment", "Rejected With Comment", "Rejected" };
            foreach (var item in sendingReason)
            {
                cmbx_sendingReason.Items.Add(item);
            }
            foreach (var item in documentStatus)
            {
                cmbx_docStatus.Items.Add(item);
            }
            //----------------------------------------------
            cmbx_personnel.DataSource = BLL.PersonnelList();
            cmbx_personnel.DisplayMember = "name";
            cmbx_personnel.ValueMember = "ID";
            cmbx_personnel.SelectedIndex = -1;
            //----------------------------------------------
            List();
            //----------------------------------------------
            string api = "eb75f36ef570276212929529f10ada36";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=ankara&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument weather = XDocument.Load(connection);
            txt_temp.Text = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            txt_feelTemp.Text = weather.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            txt_precipitation.Text = weather.Descendants("precipitation").ElementAt(0).Attribute("mode").Value;
            txt_sunrise.Text = weather.Descendants("sun").ElementAt(0).Attribute("rise").Value;
            txt_sunset.Text = weather.Descendants("sun").ElementAt(0).Attribute("set").Value;
            //----------------------------------------------
        }
        private void btn_DocSave_Click(object sender, EventArgs e)
        {
            if (txt_docnumber.Text.Length > 15)
            {
                string docOrginator = txt_docnumber.Text.Remove(3);
                string docType = txt_docnumber.Text.Remove(7);
                docType = docType.Substring(4);
                string docDisipline = txt_docnumber.Text.Remove(11);
                docDisipline = docDisipline.Substring(8);
                string locationArea = txt_docnumber.Text.Remove(15);
                locationArea = locationArea.Substring(12);
                BLL.Save(docOrginator, docType, docDisipline, locationArea, txt_docnumber.Text, txt_title.Text, txt_revision.Text, cmbx_sendingReason.Text, cmbx_docStatus.Text, txt_transmittalNoTo.Text, txt_transmittalNoFrom.Text, txt_serviceOrder.Text, (int)cmbx_personnel.SelectedValue);
                List();
            }
            else
            {
                MessageBox.Show("Dokuman Numarası 15 Karakterden Az Olamaz");
            }

        }
        public void List()
        {
            lst_List.Items.Clear();
            List<Document> list = BLL.List();
            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.documentNumber);
                lvi.SubItems.Add(item.documentTitle);
                lvi.SubItems.Add(item.sendingReason);
                lvi.SubItems.Add(item.revision);
                lvi.SubItems.Add(item.serviceOrderNo);
                lvi.SubItems.Add(item.transNoTo);
                lvi.SubItems.Add(item.transNoFrom);
                lvi.SubItems.Add(item.documentStatus);
                lvi.SubItems.Add(item.AddDate.ToString());
                lvi.SubItems.Add(item.UpdateDate.ToString());
                lvi.Tag = item.ID;
                lst_List.Items.Add(lvi);
            }
        }
        Document updated;
        public object ACD { get; private set; }

        private void lst_List_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickInformation();
        }
        public void DoubleClickInformation()
        {
            updated = BLL.ListDoubleClick((int)lst_List.SelectedItems[0].Tag);
            txt_docnumber.Text = updated.documentNumber;
            txt_title.Text = updated.documentTitle;
            cmbx_sendingReason.Text = updated.sendingReason;
            txt_revision.Text = updated.revision;
            txt_serviceOrder.Text = updated.serviceOrderNo;
            txt_transmittalNoTo.Text = updated.transNoTo;
            txt_transmittalNoFrom.Text = updated.transNoFrom;
            cmbx_docStatus.Text = updated.documentStatus;
            cmbx_personnel.Text = updated.userID.ToString();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)lst_List.SelectedItems[0].Tag <= 0)
                {
                    MessageBox.Show("Lütfen Güncellemek istediğiniz bilgileri liste içerisinden seçiniz.");
                }
                else
                {
                    updated.docOrginator = txt_docnumber.Text.Remove(3);
                    updated.docType = txt_docnumber.Text.Remove(7);
                    updated.docType = updated.docType.Substring(4);
                    updated.docDisipline = txt_docnumber.Text.Remove(11);
                    updated.docDisipline = updated.docDisipline.Substring(8);
                    updated.locationArea = txt_docnumber.Text.Remove(15);
                    updated.locationArea = updated.locationArea.Substring(12);
                    updated.documentNumber = txt_docnumber.Text;
                    updated.documentTitle = txt_title.Text;
                    updated.sendingReason = cmbx_sendingReason.Text;
                    updated.revision = txt_revision.Text;
                    updated.serviceOrderNo = txt_serviceOrder.Text;
                    updated.transNoTo = txt_transmittalNoTo.Text;
                    updated.transNoFrom = txt_transmittalNoFrom.Text;
                    updated.documentStatus = cmbx_docStatus.Text;
                    updated.UpdateDate = DateTime.Now;
                    //updated.userID = (int)cmbx_personnel.SelectedValue;
                    BLL.Update(updated);
                    List();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen seçim yapınız");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_docnumber.Text = "";
            txt_title.Text = "";
            cmbx_sendingReason.Text = "";
            txt_revision.Text = "";
            txt_serviceOrder.Text = "";
            txt_transmittalNoTo.Text = "";
            txt_transmittalNoFrom.Text = "";
            cmbx_docStatus.Text = "";
            cmbx_personnel.Text = "";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)lst_List.SelectedItems[0].Tag <= 0)
                {
                    MessageBox.Show("Lütfen Silmek istediğiniz bilgileri liste içerisinden seçiniz.");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        BLL.Delete((int)lst_List.SelectedItems[0].Tag);
                        List();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Seçim yapınız");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Document search = new Document();
            search.documentNumber = txt_docnumber.Text;
            search.documentTitle = txt_title.Text;
            search.sendingReason = cmbx_sendingReason.Text;
            search.revision=txt_revision.Text;
            search.serviceOrderNo = txt_serviceOrder.Text;
            search.transNoTo = txt_transmittalNoTo.Text;
            search.transNoFrom=txt_transmittalNoFrom.Text;
            search.documentStatus = cmbx_docStatus.Text;
            searchList(search);
        }
        private void searchList(Document request)
        {
            lst_List.Items.Clear();
            List<Document> list = BLL.Search(request);
            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.documentNumber);
                lvi.SubItems.Add(item.documentTitle);
                lvi.SubItems.Add(item.sendingReason);
                lvi.SubItems.Add(item.revision);
                lvi.SubItems.Add(item.serviceOrderNo);
                lvi.SubItems.Add(item.transNoTo);
                lvi.SubItems.Add(item.transNoFrom);
                lvi.SubItems.Add(item.documentStatus);
                lvi.SubItems.Add(item.AddDate.ToString());
                lvi.SubItems.Add(item.UpdateDate.ToString());
                lvi.Tag = item.ID;
                lst_List.Items.Add(lvi);
            }
        }
    }
}
