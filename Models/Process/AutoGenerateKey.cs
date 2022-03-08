using System;
using System.Text.RegularExpressions;

namespace MaNguonMo.Models.Process{
    public class AutoGenerateKey{
       
        public string SinhMaTuDong(string id) { // truyen vao ID vd: "PS001"
            string newKey = ""; // ID moi
            string numPart = "", strPart = "", strPhanso = "";

            numPart = Regex.Match(id, @"\d+").Value; // lay ra phan so cua key "001"
            strPart = Regex.Match(id, @"\D+").Value; // lay ra phan chu cua key = "PS"

            int Phanso = Convert.ToInt32(numPart) + 1; // 2

            for(int i = 0; i < numPart.Length - Phanso.ToString().Length; i++) //(3 -1)
            {
                strPhanso += "0";
            }
            // strPhanso = "00"
            strPhanso += Phanso; // "00" + "2" = "002"
            newKey = strPart + strPhanso;  // "PS" + "002" = "PS002"
           
            return newKey;
        }
        //xay dung phuong thuc xu ly so lieu
    }
}