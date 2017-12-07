using Domain.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CrudModel
{
    public class UserCrud
    {
        public void InsertUser(CHE_Usuario cHE_Usuario)
        {
            using (var db = new BdXtudiaWebEntities())
            {
                db.CHE_Usuario.Add(cHE_Usuario);
                db.SaveChanges();
            }
        }

        public void UpDateUser(CHE_Usuario cHE_Usuario)
        {
            using (var db = new BdXtudiaWebEntities())
            {
                db.Entry(cHE_Usuario).State = EntityState.Modified;
                db.Entry(cHE_Usuario).CurrentValues.SetValues(cHE_Usuario);
                db.SaveChanges();
            }
        }

        public void DelelteUser(CHE_Usuario cHE_Usuario)
        {
            using(var db = new BdXtudiaWebEntities())
            {
                db.Entry(cHE_Usuario).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<SelectAllUser_Result>  SelectUser()
        {
            var db = new BdXtudiaWebEntities();
            var qry = from user in db.SelectAllUser()
                      select user;
            return qry.ToList(); 
        }
    }
}
