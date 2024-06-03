using SpokenGlovesDataAccess1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpokenGlovesBussiness1
{
    public class clsSignData
    {
        public int SignID { get; set; } 
        public string Flex1Read { get; set; }
        public string Flex2Read { get; set; }
        public string Flex3Read { get; set; }
        public string Flex4Read { get; set; }
        public string Flex5Read { get; set; }

        public int Angle { get; set; }
        public int SignInfoID { get; set; }
        public clsSignInfo SignInfo { get; set; }
        public enum enMode { AddNew=1,Update=2}
        public enMode Mode;
        public clsSignData(int SignID,string Flex1Read, string Flex2Read, string Flex3Read, string Flex4Read, string Flex5Read, int Angle,int SignInfoID)
        {
            this.SignID = SignID;
            this.Flex1Read = Flex1Read;
            this.Flex2Read = Flex2Read;
            this.Flex3Read = Flex3Read;
            this.Flex4Read = Flex4Read;
            this.Flex5Read = Flex5Read;
            this.Angle = Angle;
            this.SignInfoID = SignInfoID;
            this.SignInfo = clsSignInfo.Find(SignInfoID);
            Mode = enMode.Update;
        }
        public clsSignData()
        {
            this.SignID = -1;
            this.Flex1Read = "";
            this.Flex2Read = "";
            this.Flex3Read = "";
            this.Flex4Read = "";
            this.Flex5Read = "";
            this.Angle = -1;
            this.SignInfoID = -1;
            Mode = enMode.AddNew;
        }
        private bool _AddNewSign()
        {
            this.SignID = clsSignDataAccsess.AddNewSign(this.Flex1Read, this.Flex2Read, this.Flex3Read, this.Flex4Read, this.Flex5Read, this.Angle, this.SignInfoID);
            return (this.SignID != -1);
        }
        private bool _UpdateSign()
        {
            return clsSignDataAccsess.UpdateSign(this.SignID, this.Flex1Read, this.Flex2Read, this.Flex3Read, this.Flex4Read, this.Flex5Read, this.Angle, this.SignInfoID);
        }
        public bool Delete()
        {
            return clsSignDataAccsess.DeleteSign(this.SignID);
        }
        public static bool Delete(int SignID)
        {
            return clsSignDataAccsess.DeleteSign(SignID);
        }
        public static bool DeleteAllSignData(int SignInfoID)
        {
            return clsSignDataAccsess.DeleteAllSignData(SignInfoID);
        }
        public static clsSignData FindSign(int SignID)
        {
            int Angle = -1, SignInfoID = -1;
            string Flex1Read = "", Flex2Read="", Flex3Read = "", Flex4Read = "", Flex5Read = "";
            string Text = "",ImagePath="";
            if(clsSignDataAccsess.FindSignByID(SignID,ref Flex1Read,ref Flex2Read,ref Flex3Read,ref Flex4Read,ref Flex5Read,ref Angle,ref SignInfoID))
                return new clsSignData(SignID,Flex1Read,Flex2Read,Flex3Read,Flex4Read,Flex5Read,Angle,SignInfoID);
            else 
                return null;
        }
        public static DataTable GetAllSignsData()
        {
            return clsSignDataAccsess.GetAllSignsData();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSign())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateSign();

            }

            return false;
        }

    }
}
