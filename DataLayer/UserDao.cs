﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKT_Team.DataLayer
{
    public class UserDao
    {
        private List<User> listUser;
        public List<User> ListUser { get { return listUser; } set { listUser = value; } }

          DocGhiFile docGhi;

        public UserDao()
        {
            listUser = new List<User>()
            {
                new User(){ID=1, TaiKhoan="admin",MatKhau="admin",HoVaTen="tinluu",LoaiUser="admin",NhoMatKhau=true},
                 new User(){ID=2, TaiKhoan="member",MatKhau="member",HoVaTen="tinluu",LoaiUser="member",NhoMatKhau=true },
                };
        }
        public UserDao(string path)
        {
            listUser = new List<User>();
            docGhi = new DocGhiFile(path);
            listUser = docGhi.DocUser();
        }

       
        //Lấy danh sách User 
        public List<User> GetUsers()
        {
            return docGhi.DocUser();
        }
        //Ghi file

        public bool GhiUser(string path, List<User> users)
        {
            return docGhi.GhiFile(path, users);
        }

    }
}
