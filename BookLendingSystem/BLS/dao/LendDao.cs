using BLS.model;
using System.Data;

namespace BLS.dao {
    interface LendDao {
        DataTable getLend();

        DataTable getLendByKeyWord(string keyWord);

        void addLend(Lend lend);
    }
}
