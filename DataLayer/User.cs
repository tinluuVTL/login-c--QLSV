﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKT_Team.DataLayer
{
    public class User
    {
       
        private int iD;
        private string taiKhoan;
        private string matKhau;
        private string hoVaTen;
        private bool nhoMatKhau;
        private string loaiUser;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string TaiKhoan { get { return taiKhoan; } set { taiKhoan = value; } }
        public string MatKhau { get { return matKhau; } set { matKhau = value; } }
        public string HoVaTen { get { return hoVaTen; } set { hoVaTen = value; } }
        public bool NhoMatKhau { get { return nhoMatKhau; } set { nhoMatKhau = value; } }
        public string LoaiUser { get { return loaiUser; } set { loaiUser = value; } }

        public User DocUser(string line)
        {
            User user = new User();//khoi tao mot user
            string[] mang = line.Split(',');
            user.ID = Convert.ToInt32(mang[0]);
         
            user.TaiKhoan = mang[1];
            user.MatKhau = mang[2];
            user.HoVaTen = mang[3];
            user.LoaiUser = mang[4];
            user.NhoMatKhau = Convert.ToBoolean(mang[5]);


            return user;
        }
        public void GhiUser(StreamWriter streamWriter)
        {
            streamWriter.WriteLine(string.Format("{0},{1},{2},{3},{4},{5}", ID, TaiKhoan, MatKhau, HoVaTen, LoaiUser, NhoMatKhau));
        }
    }
}
