using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model.Entity;
using BLL.Interface;
using DataAccess.Model.Context;

namespace BLL.Service
{
    public class UserService<T> : IUser<T> where T : BaseEntity
    {
        IMDBContext db = new IMDBContext();

        public string AddComment(Comment comment)
        {
            try
            {
                db.Comments.Add(comment);
                db.SaveChanges();
                return $"Yorum Kaydedildi!";
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
    }
}
