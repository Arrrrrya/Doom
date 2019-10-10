using System;
using BLS.model;
using System.Data.SqlClient;
using System.Data;
using MySDK;

namespace BLS.dao {
    class UserDaoImpl : UserDao {
        private string sql = "";

        // 获取所有用户列表
        public DataTable getUser() {
            sql = "select * from TB_user order by user_type, user_id";
            DataTable dt = new DataTable();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sc);
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        
        // 通过名字检索用户
        public DataTable getUserByKeyWord(string keyWord) {
            sql = "select * from TB_user where user_name = '" + keyWord + "'";
            DataTable dt = new DataTable();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sc);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public void addUser(User user) {
            // 获取当前数据库中最大的id
            sql = "select max(user_id) from TB_user";
            SqlCommand sc = DBTools.getSqlCommand(sql);
            // 新用户user_id为当前库中最大id + 1
            int user_id = Convert.ToInt32(sc.ExecuteScalar()) + 1;

            // 新增数据
            sql = "insert into TB_user values ('" + user_id 
                + "', '" + user.user_type 
                + "', '" + user.user_name
                + "', '" + user.user_password
                + "', '" + user.user_age
                + "', '" + user.user_gender
                + "', '" + user.user_info
                + "', '" + user.user_phone
                + "')";

            sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }

        public void deleteUser(int id) {
            sql = "delete from TB_user where user_id = '" + id + "'";
            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }

        public User getUserById(int id) {
            sql = "select * from TB_user where user_id = '" + id + "'";

            User user = new User();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataReader sdr = sc.ExecuteReader();

            user.user_id = Convert.ToInt32(sdr["user_id"]);
            user.user_type = Convert.ToInt32(sdr["user_type"]);
            user.user_name = sdr["user_name"].ToString().Trim();
            user.user_password = sdr["user_password"].ToString().Trim();
            user.user_age = sdr["user_age"].ToString().Trim();
            user.user_gender = sdr["user_gender"].ToString().Trim();
            user.user_info = sdr["user_info"].ToString().Trim();
            user.user_phone = sdr["user_phone"].ToString().Trim();

            return user;
        }

        public User getUserByUserName(string userName) {
            sql = "select * from TB_user where user_name = '" + userName + "'";

            User user = new User();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataReader sdr = sc.ExecuteReader();

            user.user_id = Convert.ToInt32(sdr["user_id"]);
            user.user_type = Convert.ToInt32(sdr["user_type"]);
            user.user_name = sdr["user_name"].ToString().Trim();
            user.user_password = sdr["user_password"].ToString().Trim();
            user.user_age = sdr["user_age"].ToString().Trim();
            user.user_gender = sdr["user_gender"].ToString().Trim();
            user.user_info = sdr["user_info"].ToString().Trim();
            user.user_phone = sdr["user_phone"].ToString().Trim();

            return user;
        }

        // 通过user_id 编辑用户
        public void updateUser(User user) {
            string sql = "update TB_user set user_name = '" + user.user_name +
                "', user_password = '" + user.user_password +
                "', user_age = '" + user.user_age +
                "', user_gender = '" + user.user_gender +
                "', user_info = '" + user.user_info +
                "', user_phone = '" + user.user_phone +
                "' where user_id = '" + user.user_id + "'";

            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }

        public User login(User user) {
            sql = "select * from TB_user where user_name = '" + user.user_name + "'";
            
            User loginUser = null;

            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataReader sdr = sc.ExecuteReader();

            if(!sdr.Read()) {
                //MessageBox.Show("用户不存在！");
            } else if(sdr["user_password"].ToString().Trim() == user.user_password &&
                Convert.ToInt32(sdr["user_type"]) == user.user_type) {

                loginUser = new User();
                loginUser.user_id = Convert.ToInt32(sdr["user_id"]);
                loginUser.user_type = Convert.ToInt32(sdr["user_type"]);
                loginUser.user_name = sdr["user_name"].ToString().Trim();
                loginUser.user_password = sdr["user_password"].ToString().Trim();
                loginUser.user_age = sdr["user_age"].ToString().Trim();
                loginUser.user_gender = sdr["user_gender"].ToString().Trim();
                loginUser.user_info = sdr["user_info"].ToString().Trim();
                loginUser.user_phone = sdr["user_phone"].ToString().Trim();
            } else {
                //MessageBox.Show("密码错误或用户类型错误");
            }

            return loginUser;
        }
    }
}
