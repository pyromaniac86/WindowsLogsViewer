using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsLogsViewer
{
    public partial class WindowsLogsViewer : Form
    {
        public WindowsLogsViewer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string sourceName = "EventLoggingApp";
            string machineName = "arefev";
            String myEventType = null;
            EventLog myEventLog = new EventLog("Application");
            myEventLog.Source = sourceName;
            myEventLog.MachineName = machineName;

            EventLogEntryCollection myLogEntryCollection = myEventLog.Entries;
            int myCount = myLogEntryCollection.Count;
            // Iterate through all 'EventLogEntry' instances in 'EventLog'.
            for (int i = myCount - 1; i > 0; i--)
            {
                EventLogEntry myLogEntry = myLogEntryCollection[i];
                // Select the entry having desired EventType.
                if (myLogEntry.EntryType.ToString().Equals(myEventType))
                {
                    // Display Source of the event.
                    eventLogTable.Rows.Add(myLogEntry.Message);
                    return;
                }
            }

         }

        private void refreshRate_Click(object sender, EventArgs e)
        {

        }
    }
}
