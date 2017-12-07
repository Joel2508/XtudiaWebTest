using Domain.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
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
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    var message = string.Empty;
                    foreach (var eve in e.EntityValidationErrors)
                    {

                        message = string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            message += string.Format("\n- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                }
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
            using (var db = new BdXtudiaWebEntities())
            {
                db.Entry(cHE_Usuario).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<SelectAllUser_Result> SelectUser()
        {
            using (var db = new BdXtudiaWebEntities())
            {
                var qry = from user in db.SelectAllUser()
                          select user;
                return qry.ToList();
            }
        }
    }
}
