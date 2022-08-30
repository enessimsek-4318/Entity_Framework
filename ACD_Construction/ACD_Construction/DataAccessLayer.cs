using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACD_Construction.ORM.Entities;
using ACD_Construction.ORM.Context;

namespace ACD_Construction
{
    internal class DataAccessLayer
    {
        public User Login(string userName)
        {
            try
            {
                using (var ACD = new ProjectContext())
                {
                    User user = new User();
                    var dbUser = ACD.User.Where(login => login.userName == userName).ToList();

                    foreach (var item in dbUser)
                    {
                        user.userName = item.userName;
                        user.password = item.password;
                    }
                    return user;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Save(Document doc)
        {
            try
            {
                using (var ACD = new ProjectContext())
                {
                    ACD.Document.Add(doc);
                    ACD.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Update(Document updated)
        {
            try
            {
                using (var ACD = new ProjectContext())
                {
                    ACD.Entry(ACD.Document.Find(updated.ID)).CurrentValues.SetValues(updated);
                    ACD.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                using (var ACD = new ProjectContext())
                {
                    Document deleted;
                    deleted = ACD.Document.Find(id);
                    ACD.Document.Remove(deleted);
                    ACD.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Document> List()
        {
            try
            {
                using (var ACD = new ProjectContext())
                {
                    return new List<Document>(ACD.Document.ToList());
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<User> PersonnelList()
        {
            try
            {
                using (var ACD = new ProjectContext())
                {
                    return new List<User>(ACD.User.ToList());
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Document ListDoubleClick(int ıd)
        {
            try
            {
                using (var ACD =new ProjectContext())
                {
                    return ACD.Document.Find(ıd);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Document> Search(Document search)
        {
            List<Document> searchResultList=new List<Document>();
            try
            {
                using (var ACD = new ProjectContext())
                {
                    var searchResult=ACD.Document.Where(result => result.documentNumber.Contains(search.documentNumber)&&result.documentTitle.Contains(search.documentTitle)
                    &&result.sendingReason.Contains(search.sendingReason)&&result.revision.Contains(search.revision)&&result.serviceOrderNo.Contains(search.serviceOrderNo)
                    &&result.transNoTo.Contains(search.transNoTo)&&result.transNoFrom.Contains(search.transNoFrom)&&result.documentStatus.Contains(search.documentStatus)
                    );
                    foreach (var item in searchResult)
                    {
                        searchResultList.Add(item);
                    }    
                    return searchResultList;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
