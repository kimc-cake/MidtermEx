﻿using MySql.Data.MySqlClient;
using System;


namespace ConsoleApp1
{
    class view
    {
        public static void ViewJobPostings()
        {
            Connection conn = new Connection();
            conn.ViewJobPostings();
        }
    }
}
