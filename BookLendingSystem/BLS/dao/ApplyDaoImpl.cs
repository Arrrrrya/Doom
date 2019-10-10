using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLS.model;
using System.Data.SqlClient;
using MySDK;

namespace BLS.dao {
    class ApplyDaoImpl : ApplyDao {
        private string sql = "";

        public DataTable getApply() {
            sql = "select * from TB_apply order by apply_id desc";
            DataTable dt = new DataTable();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sc);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public DataTable getApplyByKeyWord(string keyWord) {
            sql = "select * from TB_apply where apply_create_date = '" + keyWord + "'";
            DataTable dt = new DataTable();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sc);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public void addApply(Apply apply) {
            // 新增数据的sql
            sql = "insert into TB_apply values ('" + apply.apply_id
                + "', '" + apply.apply_title
                + "', '" + apply.apply_info
                + "', '" + apply.apply_create_date
                + "')";

            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }
    }
}
