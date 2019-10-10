namespace BLS.model {
    class Book {
        public string book_id {
            get;
            set;
        }

        public string book_name {
            get;
            set;
        }

        public string book_author {
            get;
            set;
        }

        public string book_type {
            get;
            set;
        }

        public string book_status {
            get;
            set;
        }

        public string book_out_date {
            get;
            set;
        }

        public string book_in_date {
            get;
            set;
        }

        public Book() {
        }

        public Book(string book_id, string book_name) {
            this.book_id = book_id;
            this.book_name = book_name;
        }

        public Book(string book_id, string book_name, string book_author, string book_type, string book_status, string book_out_date, string book_in_date) {
            this.book_id = book_id;
            this.book_name = book_name;
            this.book_author = book_author;
            this.book_type = book_type;
            this.book_status = book_status;
            this.book_out_date = book_out_date;
            this.book_in_date = book_in_date;
        }
    }
}
