using BLS.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLS.service {
    interface ApplyService {
        DataTable getApply();

        DataTable getApplyByKeyWord(string keyWord);

        void addApply(Apply apply);
    }
}
