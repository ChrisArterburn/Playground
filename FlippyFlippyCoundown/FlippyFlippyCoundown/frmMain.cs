using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace FlippyFlippyCoundown
{
    public partial class frmMain : Form
    {
        CountdownData _data;
        string _filename = "countdowndata.json";
        BindingList<CountdownItem> _items = new BindingList<CountdownItem>();

        Timer _timer;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CountdownDataManager dataManager = new CountdownDataManager();
            _data = dataManager.Load(_filename);
            _data.Data.Sort((x, y) => x.EventTime.CompareTo(y.EventTime)); 
            _items = new BindingList<CountdownItem>(_data.Data);
            
            lstItems.DataSource = _items;
            lstItems.DisplayMember = "Display";


            _timer = new Timer();
            _timer.Interval = 5000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            _data.DoUpdate();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();

            CountdownDataManager dataManager = new CountdownDataManager();
            dataManager.Save(_filename, _data);
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count == 0) return;
            var selectedItem = lstItems.SelectedItem as CountdownItem;
            if (selectedItem != null)
            {
                if (MessageBox.Show($"Do you wish to delete {selectedItem.Name}", "Delete Event", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    _items.Remove(selectedItem);
                }
            }
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            dlgNewItem newItemDlg = new dlgNewItem();
            if (newItemDlg.ShowDialog() == DialogResult.OK)
            {
                CountdownItem newItem = new CountdownItem
                {
                    EventTime = newItemDlg.EventTime,
                    Name = newItemDlg.EventName
                };

                _items.Add(newItem);
                _data.Data.Sort((x, y) => x.EventTime.CompareTo(y.EventTime));

            }
        }

        private void lstItems_DoubleClick(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count == 0) return;
            var selectedItem = lstItems.SelectedItem as CountdownItem;
            if (selectedItem != null)
            {
                dlgNewItem newItemDlg = new dlgNewItem(selectedItem.Name, selectedItem.EventTime);

                if (newItemDlg.ShowDialog() == DialogResult.OK)
                {
                    selectedItem.Name = newItemDlg.EventName;
                    selectedItem.EventTime = newItemDlg.EventTime;
                }
            }

        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    lstItems_DoubleClick(sender, e);
                    break;
                case Keys.Insert:
                    mnuAdd_Click(sender, e);
                    break;
                case Keys.Delete:
                    mnuDelete_Click(sender, e);
                    break;
                default: break;
            }
        }
    }
}