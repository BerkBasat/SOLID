using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface;
using DataAccess.Model.Entity;
using DataAccess.Model.Context;

namespace BLL.Service
{
    public class AdminService<T> : IAdmin<T> where T : BaseEntity
    {
        IMDBContext db =  new IMDBContext();

        public string Create(T model)
        {
            try
            {
                db.Set(typeof(T)).Add(model);
                db.SaveChanges();
                return "Veri Kaydedildi!";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                var deleted = db.Set(typeof(T)).Find(id);
                db.Set(typeof(T)).Remove(deleted);
                db.SaveChanges();
                return "Veri Silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public string Update(T model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Veri Güncellendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
