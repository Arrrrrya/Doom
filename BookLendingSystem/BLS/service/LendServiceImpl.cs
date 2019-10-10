using BLS.dao;
using BLS.model;
using System.Data;

namespace BLS.service {
    class LendServiceImpl  : LendService{
        private LendDao lendDao = new LendDaoImpl();

        public DataTable getLend() {
            return lendDao.getLend();
        }

        public DataTable getLendByKeyWord(string keyWord) {
            return lendDao.getLendByKeyWord(keyWord);
        }

        public void addLend(Lend lend) {
            lendDao.addLend(lend);
        }
    }
}
