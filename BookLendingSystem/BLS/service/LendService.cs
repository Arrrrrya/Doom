using BLS.model;
using System.Data;

namespace BLS.service {
    interface LendService {
        DataTable getLend();

        DataTable getLendByKeyWord(string keyWord);

        void addLend(Lend lend);
    }
}
