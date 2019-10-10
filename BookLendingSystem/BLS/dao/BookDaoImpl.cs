using System;
using System.Data;
using BLS.model;
using System.Data.SqlClient;
using MySDK;

namespace BLS.dao {
    class BookDaoImpl : BookDao {
        private string sql = "";

        public DataTable getBook() {
            sql = "select * from TB_book order by book_name, book_id";
            DataTable dt = new DataTable();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sc);
            sqlDataAdapter.Fill(dt);
            return dt;
        }
 
        public DataTable getBookByKeyWord(string keyWord) {
            sql = "select * from TB_book where book_name = '" + keyWord + "'";
            DataTable dt = new DataTable();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sc);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public void addBook(Book book) {
            // 新增数据的sql
            sql = "insert into TB_book values ('" + book.book_id
                + "', '" + book.book_name
                + "', '" + book.book_author
                + "', '" + book.book_type
                + "', '" + book.book_status
                + "', '" + book.book_out_date
                + "', '" + book.book_in_date
                + "')";

            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }

        public void deleteBook(string id) {
            sql = "delete from TB_book where book_id = '" + id + "'";
            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }

        public Book getBookByBookName(String bookName) {
            sql = "select * from TB_book where book_name = '" + bookName + "'";

            Book book = new Book();
            SqlCommand sc = DBTools.getSqlCommand(sql);
            SqlDataReader sdr = sc.ExecuteReader();
            book.book_id = sdr["book_id"].ToString().Trim();
            book.book_name = sdr["book_name"].ToString().Trim();
            book.book_author = sdr["book_author"].ToString().Trim();
            book.book_type = sdr["book_type"].ToString().Trim();
            book.book_status = sdr["book_status"].ToString().Trim();
            book.book_out_date = sdr["book_out_date"].ToString().Trim();
            book.book_in_date = sdr["book_in_date"].ToString().Trim();

            return book;
        }

        public void updateBook(Book book) {
            string sql = "update TB_book set book_author = '" + book.book_author +
                "', book_type = '" + book.book_type +
                "', book_status = '" + book.book_status +
                "', book_out_date = '" + book.book_out_date +
                "', book_in_date = '" + book.book_in_date +
                "' where book_id = '" + book.book_id + "'";
            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }

        public void updateBookStatusOut(string book_id, string book_out_date, string book_in_date) {
            string sql = "update TB_book set book_status = '" + Common.bookStatus_2 +
                "', book_out_date = '" + book_out_date +
                "', book_in_date = '" + book_in_date +
                "' where book_id = '" + book_id + "'";
            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }

        public void updateBookStatusIn(string book_id, string date) {
            string sql = "update TB_book set book_status = '" + Common.bookStatus_1 +
                "', book_in_date = '" + date +
                "' where book_id = '" + book_id + "'";
            SqlCommand sc = DBTools.getSqlCommand(sql);
            sc.ExecuteNonQuery();
        }
    }
}
