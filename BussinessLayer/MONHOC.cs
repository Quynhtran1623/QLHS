using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLayer
{
    public class MONHOC
    {
        QUANLYHOCSINHEntities db = null;
        public MONHOC()
        {
            db = new QUANLYHOCSINHEntities();
        }    
        public MonHoc getItem(int mamh)
        {
            return db.MonHocs.FirstOrDefault(x=>x.MAMH == mamh);
        }
        public List< MonHoc> getList()
        {
            return db.MonHocs.ToList();
        }
        public MonHoc Add(MonHoc mh)
        {
            try
            {
                db.MonHocs.Add(mh);
                db.SaveChanges();
                return mh;

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public MonHoc Update(MonHoc mh)
        {
            try
            {
                var _mh = db.MonHocs.FirstOrDefault(x => x.MAMH == mh.MAMH);
                _mh.TENMH = mh.TENMH;
                _mh.SOTIET = mh.SOTIET;
                _mh.HESO = mh.HESO;
                _mh.UPDATED_BY = mh.UPDATED_BY;
                _mh.UPDATED_DATE = mh.UPDATED_DATE;
                db.SaveChanges();
                return mh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int mamh, int MAUSER)
        {
            try
            {
                var _mh = db.MonHocs.FirstOrDefault(x => x.MAMH == mamh);
                _mh.DELETED_BY = MAUSER;
                _mh.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

            
        
    }
}
