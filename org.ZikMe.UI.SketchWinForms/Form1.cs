using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using org.ZikMe.UI.Presenter;

namespace org.ZikMe.UI.SketchWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Library _lib = null;

        private void btAction1_Click(object sender, EventArgs e)
        {
            _lib = new Library();
            LogMessage("Presenter connection" + (_lib != null ? " SUCCESSFULL" : "FAILED"));
        }

        private void LogMessage(string aMessage)
        {
            lbDebug.Items.Add(aMessage);
        }

        private void btAction2_Click(object sender, EventArgs e)
        {
            if (_lib == null)
            {
                LogMessage("Presenter NOT connected :/");
                return;
            }

            int result = _lib.Tracks.Count;
            LogMessage("Got '" + result + "' Tracks in Base !");
        }
    }
}
