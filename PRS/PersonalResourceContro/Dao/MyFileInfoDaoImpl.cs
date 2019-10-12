using PersonalResourceContro.Model;
using System.Data.SqlClient;
using MySDK;

namespace PersonalResourceContro.Dao {
    class MyFileInfoDaoImpl : MyFileInfoDao {
        private string sql = "";

        public void addMyFileInfo(MyFileInfo myFileInfo) {
            // 新增数据的sql
            sql = "insert into TB_files values ('" + myFileInfo.seq
                + "', '" + myFileInfo.file_name
                + "', '" + myFileInfo.file_parent_name
                + "', '" + myFileInfo.create_date
                + "')";

            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }
    }
}
