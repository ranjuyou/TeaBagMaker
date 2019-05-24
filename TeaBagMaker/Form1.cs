using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] List = { "홍차(2분)", "녹차(3분)", "루이보스차(5분)", "국화차(2분)"};
        int Time;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < List.Length; i++)
            {
                CBTea.Items.Insert(i, List[i]);
            }

            CBTea.SelectedIndex = 0;
        }

        private void CBTea_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CBTea.SelectedIndex)
            {
                case 0:
                    Time = 120;
                    break;
                case 1:
                    Time = 180;
                    break;
                case 2:
                    Time = 300;
                    break;
                case 3:
                    Time = 120;
                    break;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            CBTea.Enabled = false;
            TimerTB.Text = (Time / 60) + "분 " + (Time % 60) + "초 남았습니다.";
        }

        private void Tick_Count(object sender, EventArgs e)
        {
            if(Time < 1)
            {
                timer1.Enabled = false;
                CBTea.Enabled = true;
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TimerTB.Text = "";
            } else
            {
                Time--;
                TimerTB.Text = (Time / 60) + "분 " + (Time % 60) + "초 남았습니다.";
            }
        }
    }
}
