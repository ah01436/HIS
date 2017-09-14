using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS
{
    class cls_employee
    {
        Connection con;
        DataTable dt;
        SqlParameter[] param;
        //public DataTable select_emp()
        //{
        //    con = new Connection();
        //    dt = new DataTable();
        //    dt = con.ReadData("sp_select_emp");
        //    return dt;
        //}
        public DataTable select_employee()
        {
            con = new Connection();
            dt = new DataTable();
            param = new SqlParameter[27];
            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
            param[0].Value = "select";
            param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[1].Value = "";
            param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[2].Value = "";
            param[3] = new SqlParameter("@addreess", SqlDbType.NVarChar, 100);
            param[3].Value = "";
            param[4] = new SqlParameter("@phone", SqlDbType.NVarChar, 14);
            param[4].Value = DBNull.Value; ;
            param[5] = new SqlParameter("@status", SqlDbType.NVarChar, 14);
            param[5].Value = DBNull.Value; ;
            param[6] = new SqlParameter("@email", SqlDbType.NVarChar,100);
            param[6].Value = 10;
            param[7] = new SqlParameter("@gender", SqlDbType.NVarChar, 14);
            param[7].Value = "";
            param[8] = new SqlParameter("@birth_date", SqlDbType.Date);
            param[8].Value = DBNull.Value; ;
            param[9] = new SqlParameter("@religion", SqlDbType.NVarChar, 14);
            param[9].Value = DBNull.Value; ;
            param[10] = new SqlParameter("@birth_place", SqlDbType.NVarChar,100);
            param[10].Value = DBNull.Value; ;
            param[11] = new SqlParameter("@nationality", SqlDbType.NVarChar, 14);
            param[11].Value = DBNull.Value; ;
            param[12] = new SqlParameter("@card_id", SqlDbType.NVarChar,14);
            param[12].Value = 10;
            param[13] = new SqlParameter("@card_realease_place", SqlDbType.NVarChar, 14);
            param[13].Value = DBNull.Value; ;
            param[14] = new SqlParameter("@card_realease_date", SqlDbType.Date);
            param[14].Value = DBNull.Value; ;
            param[15] = new SqlParameter("@qualification", SqlDbType.NVarChar, 100);
            param[15].Value = DBNull.Value; ;
            param[16] = new SqlParameter("@qualification_date", SqlDbType.Date);
            param[16].Value = DBNull.Value; ;
            param[17] = new SqlParameter("@years_of_experience", SqlDbType.Int);
            param[17].Value = DBNull.Value; ;
            param[18] = new SqlParameter("@experience", SqlDbType.NVarChar, 100);
            param[18].Value = DBNull.Value; ;
            param[19] = new SqlParameter("@prevoius_jobs", SqlDbType.NVarChar, 100);
            param[19].Value = DBNull.Value; 
            param[20] = new SqlParameter("@hiring_date", SqlDbType.Date);
            param[20].Value = DBNull.Value; ;
            param[21] = new SqlParameter("@total_salary", SqlDbType.Float);
            param[21].Value = DBNull.Value;
            param[22] = new SqlParameter("@career_level", SqlDbType.NVarChar, 50);
            param[22].Value = DBNull.Value;
            param[23] = new SqlParameter("@career_name", SqlDbType.NVarChar, 50);
            param[23].Value = DBNull.Value;
            param[24] = new SqlParameter("@dep_code", SqlDbType.NVarChar, 25);
            param[24].Value = DBNull.Value;
            param[25] = new SqlParameter("@Emp_Type", SqlDbType.NVarChar, 25);
            param[25].Value = DBNull.Value;
            param[26] = new SqlParameter("@blood_type", SqlDbType.NVarChar, 25);
            param[26].Value = DBNull.Value;
            dt = con.ReadData("sp_employee", param);
            return dt;
        }

        public bool insertdata
            (string type, string id, string name, string address, string phone,
            string status, string email, string gender, string birth_date,
            string religion, string birth_place, string nationality,
            string card_id, string card_realease_place, string card_realease_date,
            string qualification, string qualification_date,
            string years_of_experience, string experience,
            string prevoius_jobs, string hiring_date,
            string total_salary, string career_level
          ,string career_name, string dep_code, string Emp_Type, string blood_type)
        {
            try
            {

            con = new Connection();
                param = new SqlParameter[27];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = id;
                param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
                param[2].Value = name;
                param[3] = new SqlParameter("@addreess", SqlDbType.NVarChar, 100);
                param[3].Value = address;
                param[4] = new SqlParameter("@phone", SqlDbType.NVarChar, 14);
                param[4].Value =phone; 
                param[5] = new SqlParameter("@status", SqlDbType.NVarChar, 14);
                param[5].Value = status; 
                param[6] = new SqlParameter("@email", SqlDbType.NVarChar, 100);
                param[6].Value = email;
                param[7] = new SqlParameter("@gender", SqlDbType.NVarChar, 14);
                param[7].Value = gender;
                param[8] = new SqlParameter("@birth_date", SqlDbType.Date);
                param[8].Value = birth_date; 
                param[9] = new SqlParameter("@religion", SqlDbType.NVarChar, 14);
                param[9].Value = religion; ;
                param[10] = new SqlParameter("@birth_place", SqlDbType.NVarChar, 100);
                param[10].Value = birth_place; 
                param[11] = new SqlParameter("@nationality", SqlDbType.NVarChar, 14);
                param[11].Value = nationality; 
                param[12] = new SqlParameter("@card_id", SqlDbType.NVarChar, 14);
                param[12].Value = card_id;
                param[13] = new SqlParameter("@card_realease_place", SqlDbType.NVarChar, 14);
                param[13].Value = card_realease_place; ;
                param[14] = new SqlParameter("@card_realease_date", SqlDbType.Date);
                param[14].Value = card_realease_date; ;
                param[15] = new SqlParameter("@qualification", SqlDbType.NVarChar, 100);
                param[15].Value = qualification; ;
                param[16] = new SqlParameter("@qualification_date", SqlDbType.Date);
                param[16].Value = qualification_date; ;
                param[17] = new SqlParameter("@years_of_experience", SqlDbType.Int);
                param[17].Value = years_of_experience; ;
                param[18] = new SqlParameter("@experience", SqlDbType.NVarChar, 100);
                param[18].Value = experience; ;
                param[19] = new SqlParameter("@prevoius_jobs", SqlDbType.NVarChar, 100);
                param[19].Value = prevoius_jobs;
                param[20] = new SqlParameter("@hiring_date", SqlDbType.Date);
                param[20].Value = hiring_date; ;
                param[21] = new SqlParameter("@total_salary", SqlDbType.Float);
                param[21].Value = float.Parse(total_salary);
                param[22] = new SqlParameter("@career_level", SqlDbType.NVarChar, 50);
                param[22].Value = career_level;
                param[23] = new SqlParameter("@career_name", SqlDbType.NVarChar, 50);
                param[23].Value = career_name;
                param[24] = new SqlParameter("@dep_code", SqlDbType.NVarChar, 25);
                param[24].Value = dep_code;
                param[25] = new SqlParameter("@Emp_Type", SqlDbType.NVarChar, 25);
                param[25].Value = Emp_Type;
                param[26] = new SqlParameter("@blood_type", SqlDbType.NVarChar, 25);
                param[26].Value = blood_type;
                /////////////////////////////////////
                con.Exacute_procdure("sp_employee", param);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool updatedata
            (string type, string id, string name, string address, string phone,
            string status, string email, string gender, string birth_date,
            string religion, string birth_place, string nationality,
            string card_id, string card_realease_place, string card_realease_date,
            string qualification, string qualification_date,
            string years_of_experience, string experience,
            string prevoius_jobs, string hiring_date,
            string total_salary, string career_level
          , string career_name, string dep_code, string Emp_Type, string blood_type)
        {
            try
            {

                con = new Connection();
                param = new SqlParameter[27];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = id;
                param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
                param[2].Value = name;
                param[3] = new SqlParameter("@addreess", SqlDbType.NVarChar, 100);
                param[3].Value = address;
                param[4] = new SqlParameter("@phone", SqlDbType.NVarChar, 14);
                param[4].Value = phone; ;
                param[5] = new SqlParameter("@status", SqlDbType.NVarChar, 14);
                param[5].Value = status; ;
                param[6] = new SqlParameter("@email", SqlDbType.NVarChar, 100);
                param[6].Value = email;
                param[7] = new SqlParameter("@gender", SqlDbType.NVarChar, 14);
                param[7].Value = gender;
                param[8] = new SqlParameter("@birth_date", SqlDbType.Date);
                param[8].Value = birth_date; ;
                param[9] = new SqlParameter("@religion", SqlDbType.NVarChar, 14);
                param[9].Value = religion; ;
                param[10] = new SqlParameter("@birth_place", SqlDbType.NVarChar, 100);
                param[10].Value = birth_place; ;
                param[11] = new SqlParameter("@nationality", SqlDbType.NVarChar, 14);
                param[11].Value = nationality; ;
                param[12] = new SqlParameter("@card_id", SqlDbType.NVarChar, 14);
                param[12].Value = card_id;
                param[13] = new SqlParameter("@card_realease_place", SqlDbType.NVarChar, 14);
                param[13].Value = card_realease_place; ;
                param[14] = new SqlParameter("@card_realease_date", SqlDbType.Date);
                param[14].Value = card_realease_date; ;
                param[15] = new SqlParameter("@qualification", SqlDbType.NVarChar, 100);
                param[15].Value = qualification; ;
                param[16] = new SqlParameter("@qualification_date", SqlDbType.Date);
                param[16].Value = qualification_date; ;
                param[17] = new SqlParameter("@years_of_experience", SqlDbType.Int);
                param[17].Value = years_of_experience; ;
                param[18] = new SqlParameter("@experience", SqlDbType.NVarChar, 100);
                param[18].Value = experience; ;
                param[19] = new SqlParameter("@prevoius_jobs", SqlDbType.NVarChar, 100);
                param[19].Value = prevoius_jobs;
                param[20] = new SqlParameter("@hiring_date", SqlDbType.Date);
                param[20].Value = hiring_date; ;
                param[21] = new SqlParameter("@total_salary", SqlDbType.Float);
                param[21].Value =float.Parse(total_salary);
                param[22] = new SqlParameter("@career_level", SqlDbType.NVarChar, 50);
                param[22].Value = career_level;
                param[23] = new SqlParameter("@career_name", SqlDbType.NVarChar, 50);
                param[23].Value = career_name;
                param[24] = new SqlParameter("@dep_code", SqlDbType.NVarChar, 25);
                param[24].Value = dep_code;
                param[25] = new SqlParameter("@Emp_Type", SqlDbType.NVarChar, 25);
                param[25].Value = Emp_Type;
                param[26] = new SqlParameter("@blood_type", SqlDbType.NVarChar, 25);
                param[26].Value = blood_type;
                /////////////////////////////////////
                con.Exacute_procdure("sp_employee", param);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool deletedata
            (string type, string id)
        {
            try
            {

                con = new Connection();
                param = new SqlParameter[27];
                param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 25);
                param[0].Value = type;
                param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
                param[1].Value = id;
                param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
                param[2].Value = DBNull.Value;
                param[3] = new SqlParameter("@addreess", SqlDbType.NVarChar, 100);
                param[3].Value = DBNull.Value;
                param[4] = new SqlParameter("@phone", SqlDbType.NVarChar, 14);
                param[4].Value = DBNull.Value; ;
                param[5] = new SqlParameter("@status", SqlDbType.NVarChar, 14);
                param[5].Value = DBNull.Value; ;
                param[6] = new SqlParameter("@email", SqlDbType.NVarChar, 100);
                param[6].Value = DBNull.Value;
                param[7] = new SqlParameter("@gender", SqlDbType.NVarChar, 14);
                param[7].Value = DBNull.Value;
                param[8] = new SqlParameter("@birth_date", SqlDbType.Date);
                param[8].Value = DBNull.Value; ;
                param[9] = new SqlParameter("@religion", SqlDbType.NVarChar, 14);
                param[9].Value = DBNull.Value; ;
                param[10] = new SqlParameter("@birth_place", SqlDbType.NVarChar, 100);
                param[10].Value = DBNull.Value; ;
                param[11] = new SqlParameter("@nationality", SqlDbType.NVarChar, 14);
                param[11].Value = DBNull.Value; ;
                param[12] = new SqlParameter("@card_id", SqlDbType.NVarChar, 14);
                param[12].Value = DBNull.Value;
                param[13] = new SqlParameter("@card_realease_place", SqlDbType.NVarChar, 14);
                param[13].Value = DBNull.Value; ;
                param[14] = new SqlParameter("@card_realease_date", SqlDbType.Date);
                param[14].Value = DBNull.Value; ;
                param[15] = new SqlParameter("@qualification", SqlDbType.NVarChar, 100);
                param[15].Value = DBNull.Value; ;
                param[16] = new SqlParameter("@qualification_date", SqlDbType.Date);
                param[16].Value = DBNull.Value; ;
                param[17] = new SqlParameter("@years_of_experience", SqlDbType.Int);
                param[17].Value = DBNull.Value; ;
                param[18] = new SqlParameter("@experience", SqlDbType.NVarChar, 100);
                param[18].Value = DBNull.Value; ;
                param[19] = new SqlParameter("@prevoius_jobs", SqlDbType.NVarChar, 100);
                param[19].Value = DBNull.Value;
                param[20] = new SqlParameter("@hiring_date", SqlDbType.Date);
                param[20].Value = DBNull.Value; ;
                param[21] = new SqlParameter("@total_salary", SqlDbType.Float);
                param[21].Value = DBNull.Value;
                param[22] = new SqlParameter("@career_level", SqlDbType.NVarChar, 50);
                param[22].Value = DBNull.Value;
                param[23] = new SqlParameter("@career_name", SqlDbType.NVarChar, 50);
                param[23].Value = DBNull.Value;
                param[24] = new SqlParameter("@dep_code", SqlDbType.NVarChar, 25);
                param[24].Value = DBNull.Value;
                param[25] = new SqlParameter("@Emp_Type", SqlDbType.NVarChar, 25);
                param[25].Value = DBNull.Value;
                param[26] = new SqlParameter("@blood_type", SqlDbType.NVarChar, 25);
                param[26].Value = DBNull.Value;
                /////////////////////////////////////
                con.Exacute_procdure("sp_employee", param);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
       
    }
}
