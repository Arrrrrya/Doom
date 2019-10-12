namespace PersonalResourceContro.Model {
    class MyFileInfo {
        public string seq {
            get;
            set;
        }
        public string file_name {
            get;
            set;
        }
        public string file_parent_name {
            get;
            set;
        }
        public string create_date {
            get;
            set;
        }
        public MyFileInfo() {
        }
        public MyFileInfo(string seq) {
            this.seq = seq;
        }
        public MyFileInfo(string seq, string file_name, string file_parent_name, string create_date) {
            this.seq = seq;
            this.file_name = file_name;
            this.file_parent_name = file_parent_name;
            this.create_date = create_date;
        }
    }
}
