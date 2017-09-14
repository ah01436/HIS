using System.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HIS
{
    class Patient
    {

        Connection con = new Connection();
        SqlParameter[] param;
        public DataTable select_patient()
        {
            DataTable dt = new DataTable();
            param = new SqlParameter[22];
            param[0] = new SqlParameter("type", SqlDbType.VarChar, 20);
            param[0].Value = "select";
            param[1] = new SqlParameter("patient_id", SqlDbType.VarChar, 20);
            param[1].Value = "patient";
            param[2] = new SqlParameter("patient_name", SqlDbType.VarChar, 70);
            param[2].Value = "patient";
            param[3] = new SqlParameter("age", SqlDbType.Int);
            param[3].Value =25;
            param[4] = new SqlParameter("identity_type", SqlDbType.VarChar, 14);
            param[4].Value = "patient";
            param[5] = new SqlParameter("identity_side", SqlDbType.VarChar, 20);
            param[5].Value = "patient";
            param[6] = new SqlParameter("nationality", SqlDbType.VarChar, 40);
            param[6].Value = "patient";
            param[7] = new SqlParameter("marital_status", SqlDbType.VarChar, 40);
            param[7].Value = "patient";
            param[8] = new SqlParameter("job", SqlDbType.VarChar, 40);
            param[8].Value = "patient";
            param[9] = new SqlParameter("phone", SqlDbType.VarChar, 11);
            param[9].Value = "patient";
            param[10] = new SqlParameter("address_of_patient", SqlDbType.VarChar, 40);
            param[10].Value = "patient";
            param[11] = new SqlParameter("address_working", SqlDbType.VarChar, 40);
            param[11].Value = "patient";
            param[12] = new SqlParameter("husband_name", SqlDbType.VarChar, 50);
            param[12].Value = "patient";
            param[13] = new SqlParameter("husband_identity", SqlDbType.VarChar, 14);
            param[13].Value = "patient";
            param[14] = new SqlParameter("married_duration", SqlDbType.VarChar, 40);
            param[14].Value = "patient";
            param[15] = new SqlParameter("patient_Relative_name", SqlDbType.VarChar, 50);
            param[15].Value = "patient";
            param[16] = new SqlParameter("patient_Relative_state", SqlDbType.VarChar, 14);
            param[16].Value = "patient";
            param[17] = new SqlParameter("patient_Relative_job", SqlDbType.VarChar, 40);
            param[17].Value = "patient";
            param[18] = new SqlParameter("patient_Relative_address", SqlDbType.VarChar, 70);
            param[18].Value = "patient";
            param[19] = new SqlParameter("patient_Relative_identity", SqlDbType.VarChar, 14);
            param[19].Value = "patient";
            param[20] = new SqlParameter("patient_Relative_phone", SqlDbType.VarChar, 11);
            param[20].Value = "patient";
            param[21] = new SqlParameter("date_Regist", SqlDbType.VarChar, 225);
            param[21].Value = "patient";
            dt = con.ReadData("sp_patient", param);
            return dt;
        }

        // add new patient
        #region add_patient

        public bool insertdata
            (string type, string patient_id, string patient_name, string age,
            string identity_type, string identity_side, string nationality, string marital_status,
            string job, string phone, string address_of_patient, string address_working, string husband_name,
            string husband_identity, string married_duration, string patient_Relative_name, string patient_Relative_state, string patient_Relative_job,
            string patient_Relative_address, string patient_Relative_identity, string patient_Relative_phone, string date_Regist)
        {
         try
            {
                param = new SqlParameter[22];
                param[0] = new SqlParameter("type", SqlDbType.VarChar, 20);
                param[0].Value = type;
                param[1] = new SqlParameter("patient_id", SqlDbType.VarChar, 20);
                param[1].Value =patient_id;
                param[2] = new SqlParameter("patient_name", SqlDbType.VarChar, 70);
                param[2].Value = patient_name;
                param[3] = new SqlParameter("age", SqlDbType.Int);
                param[3].Value = age;
                param[4] = new SqlParameter("identity_type", SqlDbType.VarChar, 14);
                param[4].Value = identity_type;
                param[5] = new SqlParameter("identity_side", SqlDbType.VarChar, 20);
                param[5].Value = identity_side;
                param[6] = new SqlParameter("nationality", SqlDbType.VarChar, 40);
                param[6].Value = nationality;
                param[7] = new SqlParameter("marital_status", SqlDbType.VarChar, 40);
                param[7].Value = marital_status;
                param[8] = new SqlParameter("job", SqlDbType.VarChar, 40);
                param[8].Value = job;
                param[9] = new SqlParameter("phone", SqlDbType.VarChar, 11);
                param[9].Value = phone;
                param[10] = new SqlParameter("address_of_patient", SqlDbType.VarChar, 40);
                param[10].Value = address_of_patient;
                param[11] = new SqlParameter("address_working", SqlDbType.VarChar, 40);
                param[11].Value = address_working;
                param[12] = new SqlParameter("husband_name", SqlDbType.VarChar, 50);
                param[12].Value = husband_name;
                param[13] = new SqlParameter("husband_identity", SqlDbType.VarChar, 14);
                param[13].Value = husband_identity;
                param[14] = new SqlParameter("married_duration", SqlDbType.VarChar, 40);
                param[14].Value = married_duration;
                param[15] = new SqlParameter("patient_Relative_name", SqlDbType.VarChar, 50);
                param[15].Value = patient_Relative_name;
                param[16] = new SqlParameter("patient_Relative_state", SqlDbType.VarChar, 14);
                param[16].Value = patient_Relative_state;
                param[17] = new SqlParameter("patient_Relative_job", SqlDbType.VarChar, 40);
                param[17].Value = patient_Relative_job;
                param[18] = new SqlParameter("patient_Relative_address", SqlDbType.VarChar, 70);
                param[18].Value = patient_Relative_address;
                param[19] = new SqlParameter("patient_Relative_identity", SqlDbType.VarChar, 14);
                param[19].Value = patient_Relative_identity;
                param[20] = new SqlParameter("patient_Relative_phone", SqlDbType.VarChar, 11);
                param[20].Value = patient_Relative_phone;
                param[21] = new SqlParameter("date_Regist", SqlDbType.VarChar, 225);
                param[21].Value = date_Regist;
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
        // add new patient
        #region update_patient

        public bool update_patient
            (string type, string patient_id, string patient_name, string age,
            string identity_type, string identity_side, string nationality, string marital_status,
            string job, string phone, string address_of_patient, string address_working, string husband_name,
            string husband_identity, string married_duration, string patient_Relative_name, string patient_Relative_state, string patient_Relative_job,
            string patient_Relative_address, string patient_Relative_identity, string patient_Relative_phone, string date_Regist)
        {
            try
            {
                param = new SqlParameter[22];
                param[0] = new SqlParameter("type", SqlDbType.VarChar, 20);
                param[0].Value = type;
                param[1] = new SqlParameter("patient_id", SqlDbType.VarChar, 20);
                param[1].Value = patient_id;
                param[2] = new SqlParameter("patient_name", SqlDbType.VarChar, 70);
                param[2].Value = patient_name;
                param[3] = new SqlParameter("age", SqlDbType.Int);
                param[3].Value = age;
                param[4] = new SqlParameter("identity_type", SqlDbType.VarChar, 14);
                param[4].Value = identity_type;
                param[5] = new SqlParameter("identity_side", SqlDbType.VarChar, 20);
                param[5].Value = identity_side;
                param[6] = new SqlParameter("nationality", SqlDbType.VarChar, 40);
                param[6].Value = nationality;
                param[7] = new SqlParameter("marital_status", SqlDbType.VarChar, 40);
                param[7].Value = marital_status;
                param[8] = new SqlParameter("job", SqlDbType.VarChar, 40);
                param[8].Value = job;
                param[9] = new SqlParameter("phone", SqlDbType.VarChar, 11);
                param[9].Value = phone;
                param[10] = new SqlParameter("address_of_patient", SqlDbType.VarChar, 40);
                param[10].Value = address_of_patient;
                param[11] = new SqlParameter("address_working", SqlDbType.VarChar, 40);
                param[11].Value = address_working;
                param[12] = new SqlParameter("husband_name", SqlDbType.VarChar, 50);
                param[12].Value = husband_name;
                param[13] = new SqlParameter("husband_identity", SqlDbType.VarChar, 14);
                param[13].Value = husband_identity;
                param[14] = new SqlParameter("married_duration", SqlDbType.VarChar, 40);
                param[14].Value = married_duration;
                param[15] = new SqlParameter("patient_Relative_name", SqlDbType.VarChar, 50);
                param[15].Value = patient_Relative_name;
                param[16] = new SqlParameter("patient_Relative_state", SqlDbType.VarChar, 14);
                param[16].Value = patient_Relative_state;
                param[17] = new SqlParameter("patient_Relative_job", SqlDbType.VarChar, 40);
                param[17].Value = patient_Relative_job;
                param[18] = new SqlParameter("patient_Relative_address", SqlDbType.VarChar, 70);
                param[18].Value = patient_Relative_address;
                param[19] = new SqlParameter("patient_Relative_identity", SqlDbType.VarChar, 14);
                param[19].Value = patient_Relative_identity;
                param[20] = new SqlParameter("patient_Relative_phone", SqlDbType.VarChar, 11);
                param[20].Value = patient_Relative_phone;
                param[21] = new SqlParameter("date_Regist", SqlDbType.VarChar, 225);
                param[21].Value = date_Regist;
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

        //delete patient
        public bool delete_patient(string type, string patient_id, string patient_name, string age,
            string identity_type, string identity_side, string nationality, string marital_status,
            string job, string phone, string address_of_patient, string address_working, string husband_name,
            string husband_identity, string married_duration, string patient_Relative_name, string patient_Relative_state, string patient_Relative_job,
            string patient_Relative_address, string patient_Relative_identity, string patient_Relative_phone, string date_Regist)
        {
            try
            {
                param = new SqlParameter[22];
                param[0] = new SqlParameter("type", SqlDbType.VarChar, 20);
                param[0].Value = type;
                param[1] = new SqlParameter("patient_id", SqlDbType.VarChar, 20);
                param[1].Value = patient_id;
                param[2] = new SqlParameter("patient_name", SqlDbType.VarChar, 70);
                param[2].Value = patient_name;
                param[3] = new SqlParameter("age", SqlDbType.Int);
                param[3].Value =age;
                param[4] = new SqlParameter("identity_type", SqlDbType.VarChar, 14);
                param[4].Value = identity_type;
                param[5] = new SqlParameter("identity_side", SqlDbType.VarChar, 20);
                param[5].Value = identity_side;
                param[6] = new SqlParameter("nationality", SqlDbType.VarChar, 40);
                param[6].Value = nationality;
                param[7] = new SqlParameter("marital_status", SqlDbType.VarChar, 40);
                param[7].Value = marital_status;
                param[8] = new SqlParameter("job", SqlDbType.VarChar, 40);
                param[8].Value = job;
                param[9] = new SqlParameter("phone", SqlDbType.VarChar, 11);
                param[9].Value = phone;
                param[10] = new SqlParameter("address_of_patient", SqlDbType.VarChar, 40);
                param[10].Value = address_of_patient;
                param[11] = new SqlParameter("address_working", SqlDbType.VarChar, 40);
                param[11].Value = address_working;
                param[12] = new SqlParameter("husband_name", SqlDbType.VarChar, 50);
                param[12].Value = husband_name;
                param[13] = new SqlParameter("husband_identity", SqlDbType.VarChar, 14);
                param[13].Value = husband_identity;
                param[14] = new SqlParameter("married_duration", SqlDbType.VarChar, 40);
                param[14].Value = married_duration;
                param[15] = new SqlParameter("patient_Relative_name", SqlDbType.VarChar, 50);
                param[15].Value = patient_Relative_name;
                param[16] = new SqlParameter("patient_Relative_state", SqlDbType.VarChar, 14);
                param[16].Value = patient_Relative_state;
                param[17] = new SqlParameter("patient_Relative_job", SqlDbType.VarChar, 40);
                param[17].Value = patient_Relative_job;
                param[18] = new SqlParameter("patient_Relative_address", SqlDbType.VarChar, 70);
                param[18].Value = patient_Relative_address;
                param[19] = new SqlParameter("patient_Relative_identity", SqlDbType.VarChar, 14);
                param[19].Value = patient_Relative_identity;
                param[20] = new SqlParameter("patient_Relative_phone", SqlDbType.VarChar, 11);
                param[20].Value = patient_Relative_phone;
                param[21] = new SqlParameter("date_Regist", SqlDbType.VarChar, 225);
                param[21].Value = date_Regist;
                con.Exacute_procdure("sp_patient", param);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
