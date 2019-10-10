using System;
using BLS.model;
using BLS.dao;
using System.Data;

namespace BLS.service {
    class UserServiceImpl : UserService {
        private UserDao userDao = new UserDaoImpl();

        public DataTable getUser() {
            return userDao.getUser();
        }

        public DataTable getUserByKeyWord(string keyWord) {
            return userDao.getUserByKeyWord(keyWord);
        }

        public void addUser(User user) {
            userDao.addUser(user);
        }

        public void deleteUser(int id) {
            userDao.deleteUser(id);
        }

        public User getUserById(int id) {
            return userDao.getUserById(id);
        }

        public User getUserByUserName(String userName) {
            return userDao.getUserByUserName(userName);
        }

        public void updateUser(User user) {
            userDao.updateUser(user);
        }

        public User login(User user) {
            return userDao.login(user);
        }
    }
}
