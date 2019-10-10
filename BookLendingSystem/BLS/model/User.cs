namespace BLS.model {
    class User {
        public int user_id {
            get;
            set;
        }

        public int user_type {
            get;
            set;
        }
        public string user_name {
            get;
            set;
        }
        public string user_password {
            get;
            set;
        }
        public string user_age {
            get;
            set;
        }
        public string user_gender {
            get;
            set;
        }
        public string user_info {
            get;
            set;
        }
        public string user_phone {
            get;
            set;
        }

        public User() {
        }

        public User(int user_id, int user_type, string user_name, string user_password) {
            this.user_id = user_id;
            this.user_type = user_type;
            this.user_name = user_name;
            this.user_password = user_password;
        }

        public User(int user_type, string user_name, string user_password) {
            this.user_type = user_type;
            this.user_name = user_name;
            this.user_password = user_password;
        }

        public User(int user_id, int user_type, string user_name, string user_password, string user_age, string user_gender, string user_info, string user_phone) {
            this.user_id = user_id;
            this.user_type = user_type;
            this.user_name = user_name;
            this.user_password = user_password;
            this.user_age = user_age;
            this.user_gender = user_gender;
            this.user_info = user_info;
            this.user_phone = user_phone;
        }
    }
}
