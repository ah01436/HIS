using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS
{
    class cls_patient
    {
        Connection con = new Connection();
        SqlParameter[] param;
        DataTable dt;
        public DataTable select_patient()
        {
            dt = new DataTable();
            param = new SqlParameter[23];
            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
            param[0].Value = "select";
            param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[1].Value = "";
            param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[2].Value = "";
            param[3] = new SqlParameter("@address", SqlDbType.NVarChar,100);
            param[3].Value ="";
            param[4] = new SqlParameter("@phone", SqlDbType.NVarChar, 14);
            param[4].Value = "patient";
            param[5] = new SqlParameter("@status", SqlDbType.NVarChar, 14);
            param[5].Value = "patient";
            param[6] = new SqlParameter("@age", SqlDbType.Int);
            param[6].Value = 10;
            param[7] = new SqlParameter("@job", SqlDbType.NVarChar, 50);
            param[7].Value = "";
            param[8] = new SqlParameter("@nationality", SqlDbType.NVarChar, 14);
            param[8].Value = "patient";
            param[9] = new SqlParameter("@address_working", SqlDbType.NVarChar, 100);
            param[9].Value = "patient";
            param[10] = new SqlParameter("@card_id", SqlDbType.NVarChar, 14);
            param[10].Value = "patient";
            param[11] = new SqlParameter("@card_realease_place", SqlDbType.NVarChar, 14);
            param[11].Value = "patient";
            param[12] = new SqlParameter("@married_duration", SqlDbType.Int);
            param[12].Value = 10;
            param[13] = new SqlParameter("@husband_name", SqlDbType.NVarChar, 100);
            param[13].Value = "patient";
            param[14] = new SqlParameter("@husband_identity", SqlDbType.NVarChar, 14);
            param[14].Value = "patient";
            param[15] = new SqlParameter("@patient_Relative_name", SqlDbType.NVarChar, 100);
            param[15].Value = "patient";
            param[16] = new SqlParameter("@patient_Relative_identity", SqlDbType.NVarChar, 14);
            param[16].Value = "patient";
            param[17] = new SqlParameter("@patient_Relative_state", SqlDbType.NVarChar, 50);
            param[17].Value = "patient";
            param[18] = new SqlParameter("@patient_Relative_phone", SqlDbType.NVarChar, 14);
            param[18].Value = "patient";
            param[19] = new SqlParameter("@patient_Relative_address", SqlDbType.NVarChar, 100);
            param[19].Value = "patient";
            param[20] = new SqlParameter("@patient_Relative_job", SqlDbType.NVarChar, 50);
            param[20].Value = "patient";
            param[21] = new SqlParameter("@reg_date", SqlDbType.Date);
            param[21].Value = DBNull.Value;
            param[22] = new SqlParameter("@user_id", SqlDbType.NVarChar,50);
            param[22].Value = "patient";
            dt = con.ReadData("sp_patient", param);
            return dt;
        }

        // add new patient
        #region add_patient

        public bool insertdata
            (string type, string id, string name, string address,string phone,
            string status, string age, string job, string nationality,
            string address_woking, string card_id, string card_realease_place, 
            string married_duration,string husband_name,string husband_identity,
            string patient_Relative_name,string patient_Relative_state,
            string patient_Relative_job,string patient_Relative_address, 
            string patient_Relative_identity,string patient_Relative_phone, 
            string date_Regist,string user_id)
        {
         try
            {
                param = new SqlParameter[23];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = id;
                param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
                param[2].Value = name;
                param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
                param[3].Value = address;
                param[4] = new SqlParameter("@phone", SqlDbType.NVarChar, 14);
                param[4].Value = phone;
                param[5] = new SqlParameter("@status", SqlDbType.NVarChar, 14);
                param[5].Value = status;
                param[6] = new SqlParameter("@age", SqlDbType.Int);
                param[6].Value =int.Parse(age);
                param[7] = new SqlParameter("@job", SqlDbType.NVarChar, 50);
                param[7].Value = job;
                param[8] = new SqlParameter("@nationality", SqlDbType.NVarChar, 14);
                param[8].Value = nationality;
                param[9] = new SqlParameter("@address_working", SqlDbType.NVarChar, 100);
                param[9].Value = address_woking;
                param[10] = new SqlParameter("@card_id", SqlDbType.NVarChar, 14);
                param[10].Value = card_id;
                param[11] = new SqlParameter("@card_realease_place", SqlDbType.NVarChar, 14);
                param[11].Value = card_realease_place;
                param[12] = new SqlParameter("@married_duration", SqlDbType.Int);
                param[12].Value = int.Parse(married_duration);
                param[13] = new SqlParameter("@husband_name", SqlDbType.NVarChar, 100);
                param[13].Value = husband_name;
                param[14] = new SqlParameter("@husband_identity", SqlDbType.NVarChar, 14);
                param[14].Value = husband_identity;
                param[15] = new SqlParameter("@patient_Relative_name", SqlDbType.NVarChar, 100);
                param[15].Value = patient_Relative_name;
                param[16] = new SqlParameter("@patient_Relative_identity", SqlDbType.NVarChar, 14);
                param[16].Value = patient_Relative_identity;
                param[17] = new SqlParameter("@patient_Relative_state", SqlDbType.NVarChar, 50);
                param[17].Value = patient_Relative_state;
                param[18] = new SqlParameter("@patient_Relative_phone", SqlDbType.NVarChar, 14);
                param[18].Value = patient_Relative_phone;
                param[19] = new SqlParameter("@patient_Relative_address", SqlDbType.NVarChar, 100);
                param[19].Value = patient_Relative_address;
                param[20] = new SqlParameter("@patient_Relative_job", SqlDbType.NVarChar, 50);
                param[20].Value = patient_Relative_job;
                param[21] = new SqlParameter("@reg_date", SqlDbType.Date);
                param[21].Value = date_Regist;
                param[22] = new SqlParameter("@user_id", SqlDbType.NVarChar, 50);
                param[22].Value = user_id;
            /////////////////////////////////////
               con.Exacute_procdure("sp_patient", param);
               return true;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
#endregion
        #region add_patient

        public bool updatedata
            (string type, string id, string name, string address, string phone,
            string status, string age, string job, string nationality,
            string address_woking, string card_id, string card_realease_place,
            string married_duration, string husband_name, string husband_identity,
            string patient_Relative_name, string patient_Relative_state,
            string patient_Relative_job, string patient_Relative_address,
            string patient_Relative_identity, string patient_Relative_phone,
            string date_Regist, string user_id)
        {
            try
            {
                param = new SqlParameter[23];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = id;
                param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
                param[2].Value = name;
                param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
                param[3].Value = address;
                param[4] = new SqlParameter("@phone", SqlDbType.NVarChar, 14);
                param[4].Value = phone;
                param[5] = new SqlParameter("@status", SqlDbType.NVarChar, 14);
                param[5].Value = status;
                param[6] = new SqlParameter("@age", SqlDbType.Int);
                param[6].Value = int.Parse(age);
                param[7] = new SqlParameter("@job", SqlDbType.NVarChar, 50);
                param[7].Value = job;
                param[8] = new SqlParameter("@nationality", SqlDbType.NVarChar, 14);
                param[8].Value = nationality;
                param[9] = new SqlParameter("@address_working", SqlDbType.NVarChar, 100);
                param[9].Value = address_woking;
                param[10] = new SqlParameter("@card_id", SqlDbType.NVarChar, 14);
                param[10].Value = card_id;
                param[11] = new SqlParameter("@card_realease_place", SqlDbType.NVarChar, 14);
                param[11].Value = card_realease_place;
                param[12] = new SqlParameter("@married_duration", SqlDbType.Int);
                param[12].Value = int.Parse(married_duration);
                param[13] = new SqlParameter("@husband_name", SqlDbType.NVarChar, 100);
                param[13].Value = husband_name;
                param[14] = new SqlParameter("@husband_identity", SqlDbType.NVarChar, 14);
                param[14].Value = husband_identity;
                param[15] = new SqlParameter("@patient_Relative_name", SqlDbType.NVarChar, 100);
                param[15].Value = patient_Relative_name;
                param[16] = new SqlParameter("@patient_Relative_identity", SqlDbType.NVarChar, 14);
                param[16].Value = patient_Relative_identity;
                param[17] = new SqlParameter("@patient_Relative_state", SqlDbType.NVarChar, 50);
                param[17].Value = patient_Relative_state;
                param[18] = new SqlParameter("@patient_Relative_phone", SqlDbType.NVarChar, 14);
                param[18].Value = patient_Relative_phone;
                param[19] = new SqlParameter("@patient_Relative_address", SqlDbType.NVarChar, 100);
                param[19].Value = patient_Relative_address;
                param[20] = new SqlParameter("@patient_Relative_job", SqlDbType.NVarChar, 50);
                param[20].Value = patient_Relative_job;
                param[21] = new SqlParameter("@reg_date", SqlDbType.Date);
                param[21].Value = date_Regist;
                param[22] = new SqlParameter("@user_id", SqlDbType.NVarChar, 25);
                param[22].Value = user_id;
                /////////////////////////////////////
                if (con.Exacute_procdure("sp_patient", param) == 1)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
#endregion
        //delete patient
        public bool deletedata
           (string type, string id, string name, string address, string phone,
           string status, string age, string job, string nationality,
           string address_woking, string card_id, string card_realease_place,
           string married_duration, string husband_name, string husband_identity,
           string patient_Relative_name, string patient_Relative_state,
           string patient_Relative_job, string patient_Relative_address,
           string patient_Relative_identity, string patient_Relative_phone,
           string date_Regist, string user_id)
        {
            try
            {
                param = new SqlParameter[23];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = id;
                param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
                param[2].Value = name;
                param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
                param[3].Value = address;
                param[4] = new SqlParameter("@phone", SqlDbType.NVarChar, 14);
                param[4].Value = phone;
                param[5] = new SqlParameter("@status", SqlDbType.NVarChar, 14);
                param[5].Value = status;
                param[6] = new SqlParameter("@age", SqlDbType.Int);
                param[6].Value = int.Parse(age);
                param[7] = new SqlParameter("@job", SqlDbType.NVarChar, 50);
                param[7].Value = job;
                param[8] = new SqlParameter("@nationality", SqlDbType.NVarChar, 14);
                param[8].Value = nationality;
                param[9] = new SqlParameter("@address_working", SqlDbType.NVarChar, 100);
                param[9].Value = address_woking;
                param[10] = new SqlParameter("@card_id", SqlDbType.NVarChar, 14);
                param[10].Value = card_id;
                param[11] = new SqlParameter("@card_realease_place", SqlDbType.NVarChar, 14);
                param[11].Value = card_realease_place;
                param[12] = new SqlParameter("@married_duration", SqlDbType.Int);
                param[12].Value = int.Parse(married_duration);
                param[13] = new SqlParameter("@husband_name", SqlDbType.NVarChar, 100);
                param[13].Value = husband_name;
                param[14] = new SqlParameter("@husband_identity", SqlDbType.NVarChar, 14);
                param[14].Value = husband_identity;
                param[15] = new SqlParameter("@patient_Relative_name", SqlDbType.NVarChar, 100);
                param[15].Value = patient_Relative_name;
                param[16] = new SqlParameter("@patient_Relative_identity", SqlDbType.NVarChar, 14);
                param[16].Value = patient_Relative_identity;
                param[17] = new SqlParameter("@patient_Relative_state", SqlDbType.NVarChar, 50);
                param[17].Value = patient_Relative_state;
                param[18] = new SqlParameter("@patient_Relative_phone", SqlDbType.NVarChar, 14);
                param[18].Value = patient_Relative_phone;
                param[19] = new SqlParameter("@patient_Relative_address", SqlDbType.NVarChar, 100);
                param[19].Value = patient_Relative_address;
                param[20] = new SqlParameter("@patient_Relative_job", SqlDbType.NVarChar, 50);
                param[20].Value = patient_Relative_job;
                param[21] = new SqlParameter("@reg_date", SqlDbType.Date);
                param[21].Value = date_Regist;
                param[22] = new SqlParameter("@user_id", SqlDbType.NVarChar, 50);
                param[22].Value = user_id;
                /////////////////////////////////////
                if (con.Exacute_procdure("sp_patient", param) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public string increasekey(string id)
        {
            string new_id="P_";
           new_id+= (Convert.ToInt64(id.Substring(2, id.Length-2))+1).ToString();
           MessageBox.Show(new_id);
            return new_id;
        }
    }
    }

