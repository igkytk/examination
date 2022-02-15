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
    public partial class MonthlyInputPage : UserControl
    {
        private DataSet bookData;
        private DataTable IncomeTable => (bookData != null ? bookData.Tables[Book.Monthly.IncomeTableName] : null);
        private DataTable ExpenseTable => (bookData != null ? bookData.Tables[Book.Monthly.ExpenseTableName] : null);

        public MonthlyInputPage()
        {
            InitializeComponent();
        }

        public void Reset(Book.Monthly monthly)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { Reset(monthly); });
            }
            else
            {
                var dataSet = monthly.ToDataSet();

                dataGridView_income.DataSource = dataSet.Tables[Book.Monthly.IncomeTableName];
                dataGridView_expense.DataSource = dataSet.Tables[Book.Monthly.ExpenseTableName];
                bookData = dataSet;
            }
        }

        public Book.Monthly ToMonthly()
        {
            var monthly = new Book.Monthly();

            if (bookData != null)
            {
                foreach (DataRow dataRow in bookData.Tables[Book.Monthly.IncomeTableName].Rows)
                {
                    monthly.Income.Add(new Book.Item() { Name = dataRow[0].ToString(), TotalAmount = (int)dataRow[1], TaxRate = (int)dataRow[2] });
                }

                foreach (DataRow dataRow in bookData.Tables[Book.Monthly.ExpenseTableName].Rows)
                {
                    monthly.Expense.Add(new Book.Item() { Name = dataRow[0].ToString(), TotalAmount = (int)dataRow[1], TaxRate = (int)dataRow[2] });
                }
            }

            return monthly;
        }

        private void button_add_Clicked(object sender, EventArgs e)
        {
            try
            {
                foreach(var button_and_table in new Tuple<Button, DataTable>[] { 
                    new Tuple<Button, DataTable>(button_income_add, IncomeTable),
                    new Tuple<Button, DataTable>(button_expense_add, ExpenseTable),
                })
                {
                    if (sender.Equals(button_and_table.Item1))
                    {
                        var table = button_and_table.Item2;
                        using (var inputForm = new InputForm((item) => { table.Rows.Add(item.ToObjects()); }))
                        {
                            inputForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_edit_Clicked(object sender, EventArgs e)
        {
            try
            {
                foreach (var button_and_table_and_view in new Tuple<Button, DataTable, DataGridView>[] {
                    new Tuple<Button, DataTable, DataGridView>(button_income_edit, IncomeTable, dataGridView_income),
                    new Tuple<Button, DataTable, DataGridView>(button_expense_edit, ExpenseTable, dataGridView_expense),
                })
                {
                    if (sender.Equals(button_and_table_and_view.Item1))
                    {
                        var dataGridView = button_and_table_and_view.Item3;
                        if (dataGridView.SelectedCells.Count > 0)
                        {
                            var rowIndex = dataGridView.SelectedCells[0].RowIndex;
                            var table = button_and_table_and_view.Item2;
                            var edit = new Action<Book.Item>((item) => {
                                foreach (var (obj, i) in item.ToObjects().ToList().Select((v, i) => (v, i)))
                                {
                                    table.Rows[rowIndex][i] = obj;
                                }
                            });

                            using (var inputForm = new InputForm(edit, DataRowToBookItem(table.Rows[rowIndex])))
                            {
                                inputForm.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_remove_Clicked(object sender, EventArgs e)
        {
            try
            {
                foreach (var button_and_table_and_view in new Tuple<Button, DataTable, DataGridView>[] {
                    new Tuple<Button, DataTable, DataGridView>(button_income_remove, IncomeTable, dataGridView_income),
                    new Tuple<Button, DataTable, DataGridView>(button_expense_remove, ExpenseTable, dataGridView_expense),
                })
                {
                    if (sender.Equals(button_and_table_and_view.Item1))
                    {
                        var dataGridView = button_and_table_and_view.Item3;
                        if (dataGridView.SelectedCells.Count > 0)
                        {
                            var rowIndex = dataGridView.SelectedCells[0].RowIndex;
                            var table = button_and_table_and_view.Item2;
                            table.Rows.RemoveAt(rowIndex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        static private Book.Item DataRowToBookItem(DataRow dataRow)
        {
            return new Book.Item() { Name = dataRow[0].ToString(), TotalAmount = (int)dataRow[1], TaxRate = (int)dataRow[2] };
        }
    }
}
