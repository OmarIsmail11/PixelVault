using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        
        // TODO: ADD your functions here

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
