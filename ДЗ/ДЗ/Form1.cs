using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ
{
    public partial class Form1 : Form
    {
        public struct Call
        {
            public string Type;
            public string PhoneNumber;
            public DateTime Time;
        }

        private List<Call> callLog = new List<Call>();


        public Form1()
        {
            InitializeComponent();

            callTypeComboBox.Items.Add("Входящий");
            callTypeComboBox.Items.Add("Исходящий");
            callTypeComboBox.Items.Add("Непринятый");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logButton_Click(object sender, EventArgs e)
        {
            
            string callType = callTypeComboBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            DateTime callTime = DateTime.Now;

            
            Call newCall = new Call
            {
                Type = callType,
                PhoneNumber = phoneNumber,
                Time = callTime
            };

            
            callLog.Add(newCall);

            
            UpdateCallLog();
        }

        private void UpdateCallLog()
        {
            
            callLogListBox.Items.Clear();

            
            foreach (var call in callLog)
            {
                callLogListBox.Items.Add($"{call.Type} звонок от {call.PhoneNumber} от {call.Time}");
            }
        }
    }
}
