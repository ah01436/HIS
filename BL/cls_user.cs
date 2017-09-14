using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HIS
{
    class cls_user
    {

        Connection con;
        DataTable dt;
        SqlParameter[] param;
        public DataTable select()
        {
            con = new Connection();
            dt = new DataTable();
            param = new SqlParameter[5];
            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
            param[0].Value = "select";
            param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[1].Value = "select";
            param[2] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            param[2].Value = "select";
            param[3] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            param[3].Value = "select";
            param[4] = new SqlParameter("@emp_id", SqlDbType.NVarChar, 25);
            param[4].Value = "select";
            dt = con.ReadData("sp_users", param);
            return dt;
        }

        public bool insertdata
            (string type, string id, string user_name, string password, string emp_id)
        {
        asd: try
            {
                int exp_num;
                con = new Connection();
                param = new SqlParameter[5];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = id;
                param[2] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
                param[2].Value = user_name;
                param[3] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
                param[3].Value = password;
                param[4] = new SqlParameter("@emp_id", SqlDbType.NVarChar, 25);
                param[4].Value = emp_id;
                exp_num = con.Exacute_procdure("sp_users", param);
                if (exp_num == 1)
                {
                    return true;
                }
                else
                {
                    if (exp_num == 1062)
                    {
                        id = cls_validate.increasekey(id, 5);
                        goto asd;
                    }
                    else if (exp_num == 2627)
                    {
                        MessageBox.Show("اسم المستخدم موجود مسبقا الرجاءادخال اسم مستخدم جديد");
                    }
                    //MessageBox.Show(exp_num.ToString());
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public bool updatedata(string type, string id, string user_name, string password, string emp_id)
        {
            try 
            {	        
            int exp_num;
                con = new Connection();
                param = new SqlParameter[5];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = id;
                param[2] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
                param[2].Value = user_name;
                param[3] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
                param[3].Value = password;
                param[4] = new SqlParameter("@emp_id", SqlDbType.NVarChar, 25);
                param[4].Value = emp_id;
                exp_num = con.Exacute_procdure("sp_users", param);
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


        public bool delete(string type, string id)
        {
            try
            {
                int exp_num;
                con = new Connection();
                param = new SqlParameter[5];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = id;
                param[2] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
                param[2].Value = "";
                param[3] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
                param[3].Value = "";
                param[4] = new SqlParameter("@emp_id", SqlDbType.NVarChar, 25);
                param[4].Value = "";
                exp_num = con.Exacute_procdure("sp_users", param);
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

