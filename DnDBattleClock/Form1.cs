using System.Data;
using System.Windows.Forms;

namespace DnDBattleClock
{
    public partial class Form1 : Form
    {
        #region CONSTRUCTOR

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < PlayerDataGridView.Columns.Count; i++)
            {
                PlayerDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }


        #endregion

        #region VARIABLES

        List<int> _playerOrder = new List<int>();

        #endregion


        #region FUNCTIONS

        private void UpdateInitiative()
        {
            List <int> bonusRank = new List<int>();

            // Iterate though each player in the dataset
            for (int i = 0; i < PlayerDataGridView.RowCount; i++)
            {
                // Update initiative score
                PlayerDataGridView.Rows[i].Cells[3].Value = Convert.ToString(TryConvertData(PlayerDataGridView.Rows[i].Cells[1].Value) + TryConvertData(PlayerDataGridView.Rows[i].Cells[2].Value));
            }

            // Sort by initiative bonus
            PlayerDataGridView.Sort(PlayerDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Descending);

            // Iterate though each player in the dataset
            for (int i = 0; i < PlayerDataGridView.RowCount; i++)
            {
                // Update initiative bonus rank
                PlayerDataGridView.Rows[i].Cells[5].Value = Convert.ToString(i + 1);

                // Update secret score
                PlayerDataGridView.Rows[i].Cells[6].Value = Convert.ToString(TryConvertData(PlayerDataGridView.Rows[i].Cells[3].Value) + (100.0f - TryConvertData(PlayerDataGridView.Rows[i].Cells[5].Value)) / 100.0f);
            }

            // Sort by secret score
            PlayerDataGridView.Sort(PlayerDataGridView.Columns[6], System.ComponentModel.ListSortDirection.Descending);

            // Iterate though each player in the dataset
            for (int i = 0; i < PlayerDataGridView.RowCount; i++)
            {
                // Update initiative rank
                PlayerDataGridView.Rows[i].Cells[4].Value = Convert.ToString(i + 1);
            }
        }

        #endregion

        #region STATIC_FUNCTIONS

        static private float TryConvertData(object data)
        {
            try
            {
                //int x = Convert.ToInt32(data);
                float x = float.Parse(Convert.ToString(data));
                return x;
            }
            catch
            {
                return 0.0f;
            }
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateInitiativeButton_Click(object sender, EventArgs e)
        {
            UpdateInitiative();
        }


        private void PlayerDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if 'Enter' is pressed
            if (e.KeyChar == (char)13)
            {
                PlayerDataGridView.AllowUserToAddRows = true;
                PlayerDataGridView.Rows.Add(new DataGridViewRow());
                PlayerDataGridView.AllowUserToAddRows = true;
                PlayerDataGridView.AllowUserToAddRows = false;
            }
        }

        private void PlayerDataGridView_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // Check that cells are ints
            var val1 = TryConvertData(e.CellValue1);
            var val2 = TryConvertData(e.CellValue2);

            if (val1 < val2)
            {
                e.SortResult = -1;
            }
            else
            {
                e.SortResult = 1;
            }

            e.Handled = true;
        }
    }
}