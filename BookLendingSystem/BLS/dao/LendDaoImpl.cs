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
    class LendDaoImpl : LendDao {
        private string sql = "";

        public void addLend(Lend lend) {
            // 新增数据的sql
            sql = "insert into TB_lend values ('" + lend.lend_id
                + "', '" + lend.lend_book_id
                + "', '" + lend.lend_book_name
                + "', '" + lend.lend_user_id
                + "', '" + lend.lend_user_name
                + "', '" + lend.lend_create_date
                + "', '', '')";

            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }

        public DataTable getLend() {
            sql = "select * from TB_lend order by lend_id";
            DataTable dt = new DataTable();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sc);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public DataTable getLendByKeyWord(string keyWord) {
            sql = "select * from TB_lend where lend_user_name = '" + keyWord + "'";
            DataTable dt = new DataTable();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sc);
            sqlDataAdapter.Fill(dt);
            return dt;
        }
    }
}
