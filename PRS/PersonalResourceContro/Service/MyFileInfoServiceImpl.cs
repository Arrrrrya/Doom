using PersonalResourceContro.Dao;
using PersonalResourceContro.Model;

namespace PersonalResourceContro.Service {
    class MyFileInfoServiceImpl : MyFileInfoService {
        private MyFileInfoDao myFileInfoDao = new MyFileInfoDaoImpl();
        public void addMyFileInfo(MyFileInfo myFileInfo) {
            myFileInfoDao.addMyFileInfo(myFileInfo);
        }
    }
}
