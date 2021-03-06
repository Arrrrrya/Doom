﻿using BLS.model;
using System;
using System.Data;

namespace BLS.dao {
    interface UserDao {
        DataTable getUser();

        DataTable getUserByKeyWord(string keyWord);

        void addUser(User user);

        void deleteUser(int id);

        User getUserById(int id);

        User getUserByUserName(String userName);

        void updateUser(User user);

        User login(User user);
    }
}
