using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DnDBattleClock
{
    public partial class CombatTimerForm : Form
    {
        #region CONSTRUCTOR

        public CombatTimerForm(Form1 form1)
        {
            _form1 = form1;

            InitializeComponent();

            ResetTimer();

            UpdateLabels();
        }

        #endregion

        #region VARIABLES

        Form1 _form1; // Reference to Form1
        int _curTurnTimerVal = 60;
        int _curPlayerIndex = 0;

        bool _pauseState = false;

        #endregion

        #region FUNCTIONS

        private void UpdateLabels()
        {
            PlayerNameLabel.Text = String.Format("Current Player: {0}", _form1.playerOrder[_curPlayerIndex].Item1);
            CurrentInitiativeLabel.Text = String.Format("Initiative: {0}", _form1.playerOrder[_curPlayerIndex].Item2);
            NextPlayerLabel.Text = String.Format("Next Player: {0}", _form1.playerOrder[(_curPlayerIndex + 1) % _form1.playerOrder.Count].Item1);

            UpdateTurnTimerLabel();
        }

        private void UpdateTurnTimerLabel()
        {
            TimeRemainingLabel.Text = String.Format("{0} s", _curTurnTimerVal);
        }

        private void NextPlayer()
        {
            _curPlayerIndex = (_curPlayerIndex + 1) % _form1.playerOrder.Count;

            UpdateLabels();
            ResetTimer();
        }

        private void ResetTimer()
        {
            _curTurnTimerVal = _form1.turnTime;
            CombatSecondsTimer.Start();
            UpdateTurnTimerLabel();
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

        private void RestartTurnButton_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void PauseTurnButton_Click(object sender, EventArgs e)
        {
            _pauseState = !_pauseState;

            if (_pauseState)
            {
                CombatSecondsTimer.Stop();
                PauseTurnButton.Text = "Continue";
            }
            else
            {
                CombatSecondsTimer.Start();
                PauseTurnButton.Text = "Pause";
            }
        }

        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            NextPlayer();
        }
    }
}
