using Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataObject
{
    public class User_data
    {
        Model_Context db = null;
        public User_data()
        {
            db = new Model_Context();
        }
        public tbl_User getItem(string username)
        {
            return db.tbl_User.FirstOrDefault(x => x.UserName == username);
        }
        public List<tbl_User> getList()
        {
            return db.tbl_User.ToList();
        }
        public tbl_User Add(tbl_User user)
        {
            db.tbl_User.Add(user);
            db.SaveChanges();
            return user;
        }
        public tbl_User Update(tbl_User user)
        {
            var data = db.tbl_User.FirstOrDefault(x => x.ID == user.ID);
            data.Password = user.Password;
            data.FullName = user.FullName;
            data.Email = user.Email;
            data.Phone = user.Phone;
            data.Address = user.Address;
            data.UpdatedBy = user.UpdatedBy;
            data.UpdatedDate = user.UpdatedDate;
            db.SaveChanges();
            return user;
        }
        public int Login(string username, string password)
        {
            var user = db.tbl_User.FirstOrDefault(x => x.UserName == username );
            if(user == null)
            {
                return -1; //Sai tên đăng nhập
            }
            else
            {
                if(user.Status == false)
                {
                    return 0;//Tài khoản bị khoá
                }
                else
                {
                    if(user.Password == password)
                    {
                        return 1;//Đăng nhâp thành công
                    }
                    else
                    {
                        return -2;//Sai mật khẩu
                    }
                }
            }
        }
         
    }
}
