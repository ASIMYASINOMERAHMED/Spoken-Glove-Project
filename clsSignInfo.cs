using SpokenGlovesDataAccess1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpokenGlovesBussiness1.clsSignData;
using static System.Net.Mime.MediaTypeNames;

namespace SpokenGlovesBussiness1
{
    public class clsSignInfo
    {
        public int SignInfoID { get; set; }
        public string Text { get; set; }
        public string ImagePath { get; set; }
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode;
        public clsSignInfo(int signInfoID, string text, string imagePath)
        {
            SignInfoID = signInfoID;
            Text = text;
            ImagePath = imagePath;
            Mode = enMode.Update;
        }
        public clsSignInfo()
        {
            SignInfoID = -1;
            Text = "";
            ImagePath = "";
            Mode = enMode.AddNew;
        }

        private bool _AddNewSignInfo()
        {
            this.SignInfoID = clsSignInfoDataAccess.AddNewSignInfo(this.Text, this.ImagePath);
            return (this.SignInfoID!=-1);
        }
        private bool _UpdateSignInfo()
        {
            return clsSignInfoDataAccess.UpdateSignInfo(this.SignInfoID,this.Text, this.ImagePath);
        }
        public bool Delete()
        {
            return clsSignInfoDataAccess.DeleteSignInfo(this.SignInfoID);
        }
        public static bool Delete(int SignInfoID)
        {
            bool SignDataDeleted = clsSignData.DeleteAllSignData(SignInfoID);
            if(!SignDataDeleted)
                return false;
            bool SignInfoDeleted = clsSignInfoDataAccess.DeleteSignInfo(SignInfoID);
            return SignInfoDeleted;
        }
        public static clsSignInfo Find(int SignInfoID)
        {
            string Text = "", ImagePath = "";
            if(clsSignInfoDataAccess.FindSignInfoByID(SignInfoID,ref Text,ref ImagePath))
                return new clsSignInfo(SignInfoID,Text,ImagePath);
            else
                return null;
        }
        public static bool IsSignExist(string SignText)
        {
            return clsSignInfoDataAccess.IsSignExist(SignText);
        }
        public static DataTable GetAllSigns()
        {
            return clsSignInfoDataAccess.GetAllSigns();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSignInfo())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateSignInfo();

            }

            return false;
        }

    }
}
