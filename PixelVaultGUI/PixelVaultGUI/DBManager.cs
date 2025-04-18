﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class DBManager
    {
        // TOOD: ADD your connection string here
        static string DB_Connection_String = @"Data Source=OMAR-REDA\SQLEXPRESS;Initial Catalog=PixelVault;Integrated Security=True;Encrypt=False";
        // Reda   static string DB_Connection_String = @"Data Source=OMAR-REDA\SQLEXPRESS;Initial Catalog=PixelVault;Integrated Security=True;Encrypt=False";
        // Mickoo static string DB_Connection_String = @"Data Source=MICKOO\SQLEXPRESS;Initial Catalog=PixelVault;Integrated Security=True;Encrypt=False";
        // DOKSH Data Source=LAPTOP-CSMG40TJ\SQLEXPRESS;Initial Catalog=PixelVault;Integrated Security=True;Encrypt=False;Trust Server Certificate=True
        // Tifa   static string DB_Connection_String = @"Data Source=MOSTAFA-PC\SQLEXPRESS03;Initial Catalog=PixelVault;Integrated Security=True;Encrypt=False";

        SqlConnection myConnection;

        public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open(); //Open a connection with the DB

                // just for illustration when the database is opened, 
                // this should NOT be shown in GUI to the user in the final application
                // but we show it here only to make sure that the database is working

                //MessageBox.Show("Successfully connected to the database!");
            }
            catch (Exception e)
            {
                // this message should not appear to user in the final application
                MessageBox.Show("An error occurred while connecting to the database!");
            }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // this message should not appear to user in the final application
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                // this message should not appear to user in the final application
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // this message should not appear to user in the final application
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                // this message should not appear to user in the final application
                MessageBox.Show(e.Message);
            }
        }


    }
}
;
