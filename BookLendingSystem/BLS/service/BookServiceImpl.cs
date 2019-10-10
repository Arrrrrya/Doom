using BLS.dao;
using BLS.model;
using System;
using System.Data;

namespace BLS.service {
    class BookServiceImpl : BookService {
        private BookDao bookDao = new BookDaoImpl();

        public DataTable getBook() {
            return bookDao.getBook();
        }

        public DataTable getBookByKeyWord(string keyWord) {
            return bookDao.getBookByKeyWord(keyWord);
        }

        public void addBook(Book book) {
            bookDao.addBook(book);
        }

        public void deleteBook(string id) {
            bookDao.deleteBook(id);
        }

        public Book getBookByBookName(String bookName) {
            return bookDao.getBookByBookName(bookName);
        }

        public void updateBook(Book book) {
            bookDao.updateBook(book);
        }

        public void updateBookStatusOut(string book_id, string book_out_date, string book_in_date) {
            bookDao.updateBookStatusOut(book_id, book_out_date, book_in_date);
        }

        public void updateBookStatusIn(string book_id, string date) {
            bookDao.updateBookStatusIn(book_id, date);
        }
    }
}
