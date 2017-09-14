using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS
{
    class cls_visit
    {
         Connection con = new Connection();
        SqlParameter[] param;
       
   /*     public DataTable select_visit()
        {
            dt = new DataTable();
            param = new SqlParameter[16];
            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
            param[0].Value = "select";
            param[1] = new SqlParameter("@visit_id", SqlDbType.NVarChar, 25);
            param[1].Value = "";
            param[2] = new SqlParameter("@entry_date", SqlDbType.DateTime);
            param[2].Value = "";
            param[3] = new SqlParameter("@entry_time", SqlDbType.DateTime);
            param[3].Value ="";
            param[4] = new SqlParameter("@entry_state", SqlDbType.NVarChar,100);
            param[4].Value = "patient";
            param[5] = new SqlParameter("@exit_date", SqlDbType.DateTime);
            param[5].Value = "patient";
            param[6] = new SqlParameter("@exit_Status", SqlDbType.NVarChar, 100);
            param[6].Value = 10;
            param[7] = new SqlParameter("@Initial_diagnosis", SqlDbType.NVarChar, 100);
            param[7].Value = "";
            param[8] = new SqlParameter("@Final_diagnosis", SqlDbType.NVarChar,100);
            param[8].Value = "patient";
            param[9] = new SqlParameter("@recommendation", SqlDbType.NVarChar, 1000);
            param[9].Value = "patient";
            param[10] = new SqlParameter("@send_side_name", SqlDbType.NVarChar, 50);
            param[10].Value = "patient";
            param[11] = new SqlParameter("@Visit_type", SqlDbType.NVarChar, 50);
            param[11].Value = "patient";
            param[12] = new SqlParameter("@Visit_state", SqlDbType.Bit);
            param[12].Value = 10;
            param[13] = new SqlParameter("@entry_doc_id", SqlDbType.NVarChar, 25);
            param[13].Value = "patient";
            param[14] = new SqlParameter("@entry_emp_id", SqlDbType.NVarChar, 25);
            param[14].Value = "patient";
            param[15] = new SqlParameter("@pat_id", SqlDbType.NVarChar, 25);
            param[15].Value = "patient";
           
            dt = con.ReadData("sp_visit", param);
            return dt;
        }
        */
        // add new visit
        #region add_visit

        public bool insertdata
            (string visit_id, string entry_date, string entry_time,
                string Initial_diagnos, string send_side_name, string Visit_type
            , string entry_doc_name, string entry_empUser_id, string pat_id,string pat_name)
        {
            try
            {
                param = new SqlParameter[10];
               
                param[0] = new SqlParameter("@visit_id", SqlDbType.NVarChar, 25);
                param[0].Value = visit_id;
                param[1] = new SqlParameter("@entry_date", SqlDbType.Date);
                // entry_date = entry_date.ToString("yyyy-MM-dd");
                param[1].Value = entry_date;
                param[2] = new SqlParameter("@entry_time", SqlDbType.NVarChar, 20);
                param[2].Value = entry_time;
                param[3] = new SqlParameter("@Initial_diagnosis", SqlDbType.NVarChar, 100);
                param[3].Value = Initial_diagnos;
                param[4] = new SqlParameter("@send_side_name", SqlDbType.NVarChar, 50);
                param[4].Value = send_side_name;
                param[5] = new SqlParameter("@Visit_type", SqlDbType.NVarChar, 50);
                param[5].Value = Visit_type;
                param[6] = new SqlParameter("@entry_empUser_id", SqlDbType.NVarChar, 25);
                param[6].Value = entry_empUser_id;
                param[7] = new SqlParameter("@pat_id", SqlDbType.NVarChar, 25);
                param[7].Value = pat_id;
                param[8] = new SqlParameter("@pat_name", SqlDbType.NVarChar, 100);
                param[8].Value = pat_name;
                param[9] = new SqlParameter("@entry_doc_name", SqlDbType.NVarChar,50);
                param[9].Value = entry_doc_name;
                //////////////////////////////////
                int exp_num;
                exp_num = con.Exacute_procdure("insert_visit", param);
                if ((exp_num == 1))
                {
                    return true;
                    
                }
                   
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
        #region add_visit

        public bool updatedata
            (string type, string visit_id, string name, DateTime entry_date,DateTime entry_time,
            string entry_state, DateTime exit_date, string exit_Status, string Initial_diagnos,string Final_diagnosis,
            string recommendation, string send_side_name, string Visit_type, 
            bool Visit_state,string entry_doc_id,string entry_emp_id,
            string pat_id)
        {
         try
            {
                param = new SqlParameter[16];
            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
            param[0].Value = "update";
            param[1] = new SqlParameter("@visit_id", SqlDbType.NVarChar, 25);
            param[1].Value = visit_id;
            param[2] = new SqlParameter("@entry_date", SqlDbType.DateTime);
            param[2].Value = entry_date;
            param[3] = new SqlParameter("@entry_time", SqlDbType.DateTime);
            param[3].Value =entry_time;
            param[4] = new SqlParameter("@entry_state", SqlDbType.NVarChar,100);
            param[4].Value = entry_state;
            param[5] = new SqlParameter("@exit_date", SqlDbType.DateTime);
            param[5].Value = exit_date;
            param[6] = new SqlParameter("@exit_Status", SqlDbType.NVarChar, 100);
            param[6].Value = exit_Status;
            param[7] = new SqlParameter("@Initial_diagnosis", SqlDbType.NVarChar, 100);
            param[7].Value =Initial_diagnos ;
            param[8] = new SqlParameter("@Final_diagnosis", SqlDbType.NVarChar,100);
            param[8].Value = Final_diagnosis;
            param[9] = new SqlParameter("@recommendation", SqlDbType.NVarChar, 1000);
            param[9].Value = recommendation;
            param[10] = new SqlParameter("@send_side_name", SqlDbType.NVarChar, 50);
            param[10].Value =send_side_name;
            param[11] = new SqlParameter("@Visit_type", SqlDbType.NVarChar, 50);
            param[11].Value = Visit_type;
            param[12] = new SqlParameter("@Visit_state", SqlDbType.Bit);
            param[12].Value = false;
            param[13] = new SqlParameter("@entry_doc_id", SqlDbType.NVarChar, 25);
            param[13].Value = entry_doc_id;
            param[14] = new SqlParameter("@entry_emp_id", SqlDbType.NVarChar, 25);
            param[14].Value = entry_emp_id;
            param[15] = new SqlParameter("@pat_id", SqlDbType.NVarChar, 25);
            param[15].Value = pat_id;
           //////////////////////////////////
               con.Exacute_procdure("sp_visit", param);
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
        public bool deletedata
           (string type, string visit_id, string name, DateTime entry_date,DateTime entry_time,
            string entry_state, DateTime exit_date, string exit_Status, string Initial_diagnos,string Final_diagnosis,
            string recommendation, string send_side_name, string Visit_type, 
            string Visit_state,string entry_doc_id,string entry_emp_id,
            string pat_id)
        {
         try
            {
                param = new SqlParameter[16];
            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
            param[0].Value = "delete";
            param[1] = new SqlParameter("@visit_id", SqlDbType.NVarChar, 25);
            param[1].Value = visit_id;
            param[2] = new SqlParameter("@entry_date", SqlDbType.DateTime);
            param[2].Value = entry_date;
            param[3] = new SqlParameter("@entry_time", SqlDbType.DateTime);
            param[3].Value =entry_time;
            param[4] = new SqlParameter("@entry_state", SqlDbType.NVarChar,100);
            param[4].Value = entry_state;
            param[5] = new SqlParameter("@exit_date", SqlDbType.DateTime);
            param[5].Value = exit_date;
            param[6] = new SqlParameter("@exit_Status", SqlDbType.NVarChar, 100);
            param[6].Value = exit_Status;
            param[7] = new SqlParameter("@Initial_diagnosis", SqlDbType.NVarChar, 100);
            param[7].Value =Initial_diagnos ;
            param[8] = new SqlParameter("@Final_diagnosis", SqlDbType.NVarChar,100);
            param[8].Value = Final_diagnosis;
            param[9] = new SqlParameter("@recommendation", SqlDbType.NVarChar, 1000);
            param[9].Value = recommendation;
            param[10] = new SqlParameter("@send_side_name", SqlDbType.NVarChar, 50);
            param[10].Value =send_side_name;
            param[11] = new SqlParameter("@Visit_type", SqlDbType.NVarChar, 50);
            param[11].Value = Visit_type;
            param[12] = new SqlParameter("@Visit_state", SqlDbType.Bit);
            param[12].Value = false;
            param[13] = new SqlParameter("@entry_doc_id", SqlDbType.NVarChar, 25);
            param[13].Value = entry_doc_id;
            param[14] = new SqlParameter("@entry_emp_id", SqlDbType.NVarChar, 25);
            param[14].Value = entry_emp_id;
            param[15] = new SqlParameter("@pat_id", SqlDbType.NVarChar, 25);
            param[15].Value = pat_id;
           //////////////////////////////////
               con.Exacute_procdure("sp_visit", param);
               return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public string increasekey(string id)
        {
            string new_id="v_";
           new_id+= (Convert.ToInt64(id.Substring(2, id.Length-2))+1).ToString();
           MessageBox.Show(new_id);
            return new_id;
        }
    }
    }
    