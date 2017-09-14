using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS
{
    class cls_department
    {
        Connection con;
        DataTable dt;
        SqlParameter[] param;
        public DataTable selct_department()
        {
            con = new Connection();
            dt = new DataTable();
            param = new SqlParameter[5];
            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
            param[0].Value = "select";
            param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[1].Value = "select";
            param[2] = new SqlParameter("@name", SqlDbType.NVarChar, 25);
            param[2].Value = "select";
            param[3] = new SqlParameter("@location", SqlDbType.NVarChar, 25);
            param[3].Value = "select";
            param[4] = new SqlParameter("@note", SqlDbType.NVarChar, 25);
            param[4].Value = "select";
            dt = con.ReadData("sp_department", param);
            return dt;
        }





        // add new department
        // #region add_department

        public bool insertdata
            (string type, string dep_id, string dep_name, string dep_location, string notes)
        {
        asd: try
            {
                int exp_num;
                con = new Connection();
                param = new SqlParameter[5];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = dep_id;
                param[2] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
                param[2].Value = dep_name;
                param[3] = new SqlParameter("@location", SqlDbType.NVarChar, 100);
                param[3].Value = dep_location;
                param[4] = new SqlParameter("note", SqlDbType.NVarChar, 255);
                param[4].Value = notes;
                exp_num = con.Exacute_procdure("sp_department", param);
                if (exp_num == 1)
                {
                    return true;
                }
                else
                {
                    if (exp_num == 1062)
                    {
                        dep_id = cls_validate.increasekey(dep_id, 4);
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
        public bool updatedata
            (string type, string dep_id, string dep_name, string dep_location, string notes)
        {
            try
            {
                int exp_num;
                con = new Connection();
                param = new SqlParameter[5];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = dep_id;
                param[2] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
                param[2].Value = dep_name;
                param[3] = new SqlParameter("@location", SqlDbType.NVarChar, 100);
                param[3].Value = dep_location;
                param[4] = new SqlParameter("note", SqlDbType.NVarChar, 255);
                param[4].Value = notes;
                exp_num = con.Exacute_procdure("sp_department", param);
                if (exp_num == 1)
                {
                    return true;
                }
                else
                {
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


        public bool delete_patient(string type, string dep_id)
        {
            try
            {
                int exp_num;
                con = new Connection();
                param = new SqlParameter[5];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = dep_id;
                param[2] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
                param[2].Value = "";
                param[3] = new SqlParameter("@location", SqlDbType.NVarChar, 100);
                param[3].Value = "";
                param[4] = new SqlParameter("note", SqlDbType.NVarChar, 255);
                param[4].Value = "";
                exp_num = con.Exacute_procdure("sp_department", param);
                if (exp_num == 1)
                {
                    return true;
                }
                else
                {
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
    }
}