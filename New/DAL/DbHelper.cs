﻿using System;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DbHelper
    {
        private static MySqlConnection connection;
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection
                {
                    ConnectionString = "server=localhost;username=vtca;password=vtcacademy;port=3306;database=LoginDB;"
                };
            }
            return connection;
        }
        private DbHelper(){}
    }
}

