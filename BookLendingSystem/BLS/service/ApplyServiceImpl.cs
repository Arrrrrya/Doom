using BLS.dao;
using BLS.model;
using System.Data;

namespace BLS.service {
    class ApplyServiceImpl : ApplyService{
        private ApplyDao applyDao = new ApplyDaoImpl();

        public DataTable getApply() {
            return applyDao.getApply();
        }

        public DataTable getApplyByKeyWord(string keyWord) {
            return applyDao.getApplyByKeyWord(keyWord);
        }

        public void addApply(Apply apply) {
            applyDao.addApply(apply);
        }
    }
}
