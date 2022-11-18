using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRE
{
    public partial class Form1 : Form
    {
        public static class Globals
        {
            public static short experimental = 0;
            public static bool RGB_SPEED_CHANGED = false;
            public static bool Enabled = false;
            public static bool RGB_enabled = false;
            public static bool Disabled = false;
            public static bool Standby = false;
            public static bool GoingUp = false;
            public static bool OneLogMode = false;
            public static short static_R = 255;
            public static short static_G = 100;
            public static int LOG_FILE = 0;
            public static int COMMAND_COUNT = 0;
            public static int COMMAND_COUNT_VIEW = 0;
            public static int RGB_SPEED = 5;
            public static ArrayList LG = new ArrayList();
            public static ArrayList pcomm = new ArrayList();

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.LG.Add("Current Logs: " + Globals.LOG_FILE + Environment.NewLine);
            comboBox1.Items.Add("Log" + Globals.LOG_FILE);
            comboBox1.SelectedItem = "Log" + Globals.LOG_FILE;
            Globals.LOG_FILE++;
            Globals.pcomm.Add("ALOG");
            Globals.COMMAND_COUNT++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writesv();
        }

        public static void writesv()
        {
            var from = new Form1();
            from.write();
        }

        void write()
        {
            Globals.LG.Add("Current Logs: " + Globals.LOG_FILE + Environment.NewLine);
            comboBox1.Items.Add("Log" + Globals.LOG_FILE);
            comboBox1.SelectedItem = "Log" + Globals.LOG_FILE;
            Globals.LOG_FILE++;
            Globals.pcomm.Add("ALOG");
            Globals.COMMAND_COUNT++;
        }
    }
}
