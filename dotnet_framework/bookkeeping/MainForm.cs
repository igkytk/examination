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

namespace bookkeeping
{
    public partial class MainForm : Form
    {
        private string savePath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for(; tabControl_monthly.TabPages.Count < Book.MONTH_NUM; )
            {
                var page = new TabPage(string.Format("{0}月", (int)tabControl_monthly.TabPages.Count+1));
                var page_content = new MonthlyInputPage();
                page_content.Dock = DockStyle.Fill;
                page.Controls.Add(page_content);
                tabControl_monthly.TabPages.Add(page);
            }

            Reset(Book.New());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void newData_MenuItem_Clicked(object sender, EventArgs e)
        {
            Reset(Book.New());
        }

        private void loadData_MenuItem_Clicked(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "XMLファイル(*.xml)|*.xml";
                ofd.FilterIndex = 0;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var newBook = Book.LoadXML(ofd.FileName);
                        Reset(newBook, ofd.FileName);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void overwrite_MenuItem_Clicked(object sender, EventArgs e)
        {
            if (savePath.Length > 0)
            {
                try
                {
                    var book = ToBook();
                    book.SaveXML(savePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                名前を付けて保存AToolStripMenuItem.PerformClick();
            }
        }

        private void saveOtherFile_MenuItem_Clicked(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "XMLファイル(*.xml)|*.xml";
                sfd.FilterIndex = 0;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    savePath = sfd.FileName;
                    上書き保存SToolStripMenuItem.PerformClick();
                }
            }
        }

        private void exit_MenuItem_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset(Book newBook, string loadPath = "")
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { Reset(newBook, loadPath); });
            }
            else
            {
                Debug.Assert(tabControl_monthly.TabPages.Count == newBook.Monthlies.Count);

                foreach (var (monthly, index) in newBook.Monthlies.Select((v,i) => (v, i)))
                {
                    foreach (MonthlyInputPage page in tabControl_monthly.TabPages[index].Controls)
                    {
                        page.Reset(monthly);
                    }
                }

                savePath = loadPath;
            }
        }

        private Book ToBook()
        {
            var monthlies = new List<Book.Monthly>();

            foreach (TabPage tabPage in tabControl_monthly.TabPages)
            {
                foreach (MonthlyInputPage page in tabPage.Controls)
                {
                    monthlies.Add(page.ToMonthly());
                }
            }

            return new Book(monthlies.ToArray());
        }
    }
}
