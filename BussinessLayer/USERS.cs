using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BussinessLayer.DTO;

namespace BussinessLayer
{
    public class USERS
    {
        QUANLYHOCSINHEntities db;
        public USERS()
        {
            db = new QUANLYHOCSINHEntities();
        }
        public User getItem(string username)
        {
            return db.Users.FirstOrDefault(x => x.UserName == username);
            
        }

        public int Login( string username, string pass)
        {
            var us = db.Users.FirstOrDefault(x => x.UserName == username && x.Pass == pass);
            if (us != null)
                return 1;
            else
                return 0;
        }


    }
}
