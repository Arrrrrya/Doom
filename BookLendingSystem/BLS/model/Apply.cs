namespace BLS.model {
    class Apply {
        public string apply_id {
            get; set;
        }

        public string apply_title {
            get; set;
        }

        public string apply_info {
            get; set;
        }

        public string apply_create_date {
            get; set;
        }

        public Apply() {
        }

        public Apply(string apply_id, string apply_title, string apply_info, string apply_create_date) {
            this.apply_id = apply_id;
            this.apply_title = apply_title;
            this.apply_info = apply_info;
            this.apply_create_date = apply_create_date;
        }
    }
}
