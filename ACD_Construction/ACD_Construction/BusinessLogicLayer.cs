using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACD_Construction.ORM.Entities;

namespace ACD_Construction
{
    internal class BusinessLogicLayer
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public int Login(string userName, string password)
        {
            User user = DAL.Login(userName);

            if (user.userName == userName && user.password == password)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public bool Save(string docOrginator, string docType,
            string docDisipline, string locationArea, string documentNumber,
            string documentTitle, string revision, string sendingReason,
            string documentStatus, string transNoTo, string transNoFrom, string serviceOrderNo,int personnel)
        {
            Document doc = new Document();
            doc.docOrginator = docOrginator;
            doc.docType = docType;
            doc.docDisipline = docDisipline;
            doc.locationArea = locationArea;
            doc.documentNumber = documentNumber;
            doc.documentTitle = documentTitle;
            doc.revision = revision;
            doc.sendingReason = sendingReason;
            doc.AddDate = DateTime.Now;
            doc.documentStatus = documentStatus;
            doc.transNoTo = transNoTo;
            doc.transNoFrom = transNoFrom;
            doc.serviceOrderNo = serviceOrderNo;
            doc.userID = personnel;
            return DAL.Save(doc);
        }
        public bool Update(Document updated)
        {
            return DAL.Update(updated);
        }
        public bool Delete(int ıd)
        {
            return DAL.Delete(ıd);
        }
        public List<Document> List()
        {
            
            return DAL.List();
        }
        public List<User> PersonnelList()
        {
            return DAL.PersonnelList();
        }
        public Document ListDoubleClick(int ıd)
        {
            return DAL.ListDoubleClick(ıd);
        }
        public List<Document> Search(Document search)
        {
            return DAL.Search(search);
        }
    }
}
