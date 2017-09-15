using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Text;
using System.Data;
namespace HIS
{
    class cls_validate
    {
        
        // this funcation use to in crease the key 
        public static string increasekey(string id,int length)
        {
            string new_id = id.Substring(0,length);
            new_id += (Convert.ToInt64(id.Substring(length, id.Length - length)) + 1).ToString();
            return new_id;
        }
        // check if the email is valide or no  
        public  bool IsValidEmail(string email)
        {
            if(!Regex.IsMatch(email,@"/^[\x20-\x7E]+$/"))
            { 
            if (Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                return true;
            else
                return false;
            }
            MessageBox.Show("يجب ادخال الايميل باللغة الانجليزية فقط");
            return false;
        }
        public bool IsValidNationalID(string id)
        {
            //Regex phoneNumpattern = new Regex(@"(2|3)[1-9][0-9] [0-1][0-2] [0-3][0-9] [1-2][0-9][0-9][0-9][0-9][0-9][0-9]");
            Regex phoneNumpattern = new Regex(@"(2|3)[0-9][1-9][0-1][1-9][0-3][0-9](01|02|03|04|11|12|13|14|15|16|17|18|19|21|22|23|24|25|26|27|28|29|31|32|33)\d\d\d\d\d");
          //  Regex phoneNumpattern = new Regex(@"(2|3)[1-9][0-9][0-1][1-9][0-3][1-9](01|02|03|04|11|12|13|14|15|16|17|18|19|21|22|23|24|25|26|27|28|29|31|32|33)\d\d\d\d\d");

            if (phoneNumpattern.IsMatch(id))
            {
               return true;
            }
            else
            {
                return false;
            }

        }
        public bool IsvalidPhone(string phone)
        {
        Regex phoneNumpattern = new Regex(@"^01[0-2][0-9]{8}$");
            if (phoneNumpattern.IsMatch(phone))
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public void stringvalidation(TextBox txt, String name)
        {
            var regexItem = new Regex("^[a-zA-Z]*$");
            if (!(regexItem.IsMatch(txt.Text)))
            {
                int VisibleTime = 1000;  //in milliseconds
                ToolTip tt = new ToolTip();

                tt.ForeColor = Color.Red;
                tt.Show(name + " يجب ان يحتوى على حروف فقط", txt, 0, 0, VisibleTime);
                txt.Focus();
                
            }
        }
        public bool letterValidation(string txt)
        {
            if (txt.All(c=>Char.IsLetter(c) || c==' '))

                return true;
            else
                return false;

        
        }
        internal bool HasArabicCharacters(string text)
        {

            Regex regex = new Regex(

                "[\u0600-\u06ff]|[\u0750-\u077f]|[\ufb50-\ufc3f]|[\ufe70-\ufefc]");

            return regex.IsMatch(text);
        }
       
       


        }
    }