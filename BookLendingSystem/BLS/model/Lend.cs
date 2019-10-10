namespace BLS.model {
    class Lend {
        public string lend_id {
            get; set;
        }

        public string lend_book_id {
            get; set;
        }

        public string lend_book_name {
            get; set;
        }

        public int lend_user_id {
            get; set;
        }

        public string lend_user_name {
            get; set;
        }

        public string lend_create_date {
            get; set;
        }

        public string lend_update_date {
            get; set;
        }

        public string lend_status {
            get; set;
        }

        public Lend() {
        }

        public Lend(string lend_id) {
        }

        public Lend(string lend_id, string lend_book_id, string lend_book_name, int lend_user_id, string lend_user_name) {
            this.lend_id = lend_id;
            this.lend_book_id = lend_book_id;
            this.lend_book_name = lend_book_name;
            this.lend_user_id = lend_user_id;
            this.lend_user_name = lend_user_name;
        }

        public Lend(string lend_id, string lend_book_id, string lend_book_name, int lend_user_id, string lend_user_name, string lend_create_date, string lend_update_date, string lend_status) {
            this.lend_id = lend_id;
            this.lend_book_id = lend_book_id;
            this.lend_book_name = lend_book_name;
            this.lend_user_id = lend_user_id;
            this.lend_user_name = lend_user_name;
            this.lend_create_date = lend_create_date;
            this.lend_update_date = lend_update_date;
            this.lend_status = lend_status;
        }
    }
}
