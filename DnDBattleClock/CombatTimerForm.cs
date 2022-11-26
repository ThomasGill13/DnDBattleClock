using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDBattleClock
{
    public partial class CombatTimerForm : Form
    {
        #region CONSTRUCTOR

        public CombatTimerForm()
        {
            InitializeComponent();

            CombatSecondsTimer.Start();
        }

        #endregion

        #region VARIABLES

        int _curTurnTimerVal = 60;

        #endregion

        #region FUNCTIONS

        private void UpdateTurnTimerLabel()
        {
            TimeRemainingLabel.Text = String.Format("{0} s", _curTurnTimerVal);
        }

        #endregion

        private void CombatSecondsTimer_Tick(object sender, EventArgs e)
        {
            _curTurnTimerVal -= 1;

            if (_curTurnTimerVal <= 0)
            {
                CombatSecondsTimer.Stop();
            }

            UpdateTurnTimerLabel();
        }

        private void EndCombatButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
