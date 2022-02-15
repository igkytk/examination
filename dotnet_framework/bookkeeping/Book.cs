using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace bookkeeping
{
    public class Book
    {
        public class Item
        {
            public string Name = "noname";
            public int TotalAmount;
            public int TaxRate;

            public int TaxedPrice => (TotalAmount - NonTaxedPrice);
            public int NonTaxedPrice => (int)Math.Round(TotalAmount / ((double)(100+TaxRate)/100.0));

            public object[] ToObjects()
            {
                return new object[] { this.Name, this.TotalAmount, this.TaxRate, this.TaxedPrice, this.NonTaxedPrice };
            }
        }

        public class Monthly
        {
            public const string IncomeTableName = "収入";
            public const string ExpenseTableName = "支出";

            public List<Item> Income = new List<Item>();
            public List<Item> Expense = new List<Item>();

            public DataSet ToDataSet(string dataSetName = "monthly")
            {
                var dataSet = new DataSet(dataSetName);

                dataSet.Tables.Add(ToDataTable(Income, IncomeTableName));
                dataSet.Tables.Add(ToDataTable(Expense, ExpenseTableName));

                return dataSet;
            }

            static private DataTable ToDataTable(List<Item> items, string tableName)
            {
                var dataTable = new DataTable(tableName);

                dataTable.Columns.AddRange(new DataColumn[] {
                    new DataColumn("項目", typeof(string)), 
                    new DataColumn("合計", typeof(int)), 
                    new DataColumn("税率", typeof(int)), 
                    new DataColumn("税金", typeof(int)), 
                    new DataColumn("税抜", typeof(int)) 
                });

                foreach (var item in items)
                {
                    var dataRow = dataTable.NewRow();
                    dataRow.ItemArray = new object[] { item.Name, item.TotalAmount, item.TaxRate, item.NonTaxedPrice };
                    dataTable.Rows.Add(dataRow);
                }

                return dataTable;
            }
        }

        public const int MONTH_NUM = 12;

        public List<Monthly> Monthlies = new List<Monthly>();

        public Book()
        {
        }

        public Book(Monthly[] monthlies)
        {
            Debug.Assert(monthlies.Length == MONTH_NUM);

            foreach (var monthly in monthlies)
            {
                Monthlies.Add(monthly);
            }
        }

        public void SaveXML(string path)
        {
            var s = new XmlSerializer(typeof(Book));
            using (var sw = new StreamWriter(path, false, new System.Text.UTF8Encoding(false)))
            {
                s.Serialize(sw, this);
            }
        }

        static public Book LoadXML(string path)
        {
            var s = new XmlSerializer(typeof(Book));
            using (var sr = new StreamReader(path, new System.Text.UTF8Encoding(false)))
            {
                var book = s.Deserialize(sr) as Book;
                return book;
            }
        }

        static public Book New()
        {
            var book = new Book();
            for (; book.Monthlies.Count < MONTH_NUM;)
            {
                book.Monthlies.Add(new Monthly());
            }
            return book;
        }
    }
}
