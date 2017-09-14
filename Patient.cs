using System.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HIS
{
    class Patient
    {
        Connection con = new Connection();
        int exp_num;// execption number 
        public DataTable selct_patient()
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("p_type", SqlDbType.VarChar, 20);
            param[0].Value = "patient";
            dt = con.ReadData("sp_select", param);
            return dt;
        }
        // add new patient
        #region add_patient

        public bool insertdata
            (string id,string name,string gender,string birth_date,
            string status,string reg_date,string address,string phone1,
            string phone2,string email)
        {
        asd: try
            {
                SqlParameter[] param = new SqlParameter[13];
                param[0] = new SqlParameter("stype", SqlDbType.VarChar, 20);
                param[0].Value = "patient";
                param[1] = new SqlParameter("sid", SqlDbType.VarChar, 20);
                param[1].Value = id;
                param[2] = new SqlParameter("sname", SqlDbType.VarChar, 50);
                param[2].Value = name;
                param[3] = new SqlParameter("sgender", SqlDbType.VarChar, 10);
                param[3].Value = gender;
                param[4] = new SqlParameter("sbirth_date", SqlDbType.Date);
                param[4].Value = birth_date;
                param[5] = new SqlParameter("sstatus", SqlDbType.VarChar, 10);
                param[5].Value = status;
                param[6] = new SqlParameter("sreg_date", SqlDbType.Date);
                param[6].Value = reg_date;
                param[7] = new SqlParameter("saddress", SqlDbType.VarChar, 100);
                param[7].Value = address;
                param[8] = new SqlParameter("sphone1", SqlDbType.VarChar, 20);
                param[8].Value = phone1;
                param[9] = new SqlParameter("sphone2", SqlDbType.VarChar, 20);
                param[9].Value = phone2;
                param[10] = new SqlParameter("semail", SqlDbType.VarChar, 20);
                param[10].Value = email;

                param[11] = new SqlParameter("sposition", SqlDbType.VarChar, 10);
                param[11].Value = DBNull.Value;
                param[12] = new SqlParameter("snat_id", SqlDbType.VarChar, 14);
                param[12].Value = DBNull.Value;
                exp_num = con.Exacute_procdure("sp_add", param);
                if (exp_num == 1)
                {
                    return true;
                }
                else
                {
                    if (exp_num == 1062)
                    {
                        id = increasekey(id);
                        goto asd;
                    }
                    MessageBox.Show(exp_num.ToString());
                    return false;
                }
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
            (string id, string name, string gender, string birth_date,
            string status, string reg_date, string address, string phone1,
            string phone2, string email)
        {
        asd: try
            {
                SqlParameter[] param = new SqlParameter[10];
                param[0] = new SqlParameter("id", SqlDbType.VarChar, 20);
                param[0].Value = id;
                param[1] = new SqlParameter("name", SqlDbType.VarChar, 50);
                param[1].Value = name;
                param[2] = new SqlParameter("gender", SqlDbType.VarChar, 10);
                param[2].Value = gender;
                param[3] = new SqlParameter("birth_date", SqlDbType.Date);
                param[3].Value = birth_date;
                param[4] = new SqlParameter("status", SqlDbType.VarChar, 10);
                param[4].Value = status;
                param[5] = new SqlParameter("reg_date", SqlDbType.Date);
                param[5].Value = reg_date;
                param[6] = new SqlParameter("address", SqlDbType.VarChar, 100);
                param[6].Value = address;
                param[7] = new SqlParameter("phone1", SqlDbType.VarChar, 20);
                param[7].Value = phone1;
                param[8] = new SqlParameter("phone2", SqlDbType.VarChar, 20);
                param[8].Value = phone2;
                param[9] = new SqlParameter("email", SqlDbType.VarChar, 45);
                param[9].Value = email;
                exp_num = con.Exacute_procdure("update_patient", param);
                if (exp_num == 1)
                {
                    return true;
                }
                else
                {
                    if (exp_num == 1062)
                    {
                        id = increasekey(id);
                        goto asd;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion

        //delete patient
        public bool delete_patient(string id)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("stype", SqlDbType.VarChar, 20);
                param[0].Value = "patient";
                param[1] = new SqlParameter("sid", SqlDbType.VarChar, 20);
                param[1].Value = id;
                con.Exacute_procdure("sp_delete",param);
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
