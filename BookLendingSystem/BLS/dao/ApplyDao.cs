using BLS.model;
using System.Data;

namespace BLS.dao {
    interface ApplyDao {
        DataTable getApply();

        DataTable getApplyByKeyWord(string keyWord);

        void addApply(Apply apply);
    }
}
