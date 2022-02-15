
namespace bookkeeping
{
    partial class MonthlyInputPage
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_income = new System.Windows.Forms.GroupBox();
            this.groupBox_expense = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_subL = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_subL_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.button_income_add = new System.Windows.Forms.Button();
            this.button_income_edit = new System.Windows.Forms.Button();
            this.button_income_remove = new System.Windows.Forms.Button();
            this.tableLayoutPanel_subR = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_subR_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.button_expense_remove = new System.Windows.Forms.Button();
            this.button_expense_edit = new System.Windows.Forms.Button();
            this.button_expense_add = new System.Windows.Forms.Button();
            this.dataGridView_income = new System.Windows.Forms.DataGridView();
            this.dataGridView_expense = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_main.SuspendLayout();
            this.groupBox_income.SuspendLayout();
            this.groupBox_expense.SuspendLayout();
            this.tableLayoutPanel_subL.SuspendLayout();
            this.tableLayoutPanel_subL_bottom.SuspendLayout();
            this.tableLayoutPanel_subR.SuspendLayout();
            this.tableLayoutPanel_subR_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_income)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.Controls.Add(this.groupBox_income, 0, 0);
            this.tableLayoutPanel_main.Controls.Add(this.groupBox_expense, 1, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 1;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(600, 600);
            this.tableLayoutPanel_main.TabIndex = 0;
            // 
            // groupBox_income
            // 
            this.groupBox_income.Controls.Add(this.tableLayoutPanel_subL);
            this.groupBox_income.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_income.Location = new System.Drawing.Point(3, 3);
            this.groupBox_income.Name = "groupBox_income";
            this.groupBox_income.Size = new System.Drawing.Size(294, 594);
            this.groupBox_income.TabIndex = 0;
            this.groupBox_income.TabStop = false;
            this.groupBox_income.Text = "収入";
            // 
            // groupBox_expense
            // 
            this.groupBox_expense.Controls.Add(this.tableLayoutPanel_subR);
            this.groupBox_expense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_expense.Location = new System.Drawing.Point(303, 3);
            this.groupBox_expense.Name = "groupBox_expense";
            this.groupBox_expense.Size = new System.Drawing.Size(294, 594);
            this.groupBox_expense.TabIndex = 1;
            this.groupBox_expense.TabStop = false;
            this.groupBox_expense.Text = "支出";
            // 
            // tableLayoutPanel_subL
            // 
            this.tableLayoutPanel_subL.ColumnCount = 1;
            this.tableLayoutPanel_subL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_subL.Controls.Add(this.tableLayoutPanel_subL_bottom, 0, 1);
            this.tableLayoutPanel_subL.Controls.Add(this.dataGridView_income, 0, 0);
            this.tableLayoutPanel_subL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_subL.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel_subL.Name = "tableLayoutPanel_subL";
            this.tableLayoutPanel_subL.RowCount = 2;
            this.tableLayoutPanel_subL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_subL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_subL.Size = new System.Drawing.Size(288, 576);
            this.tableLayoutPanel_subL.TabIndex = 0;
            // 
            // tableLayoutPanel_subL_bottom
            // 
            this.tableLayoutPanel_subL_bottom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_subL_bottom.ColumnCount = 3;
            this.tableLayoutPanel_subL_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subL_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subL_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subL_bottom.Controls.Add(this.button_income_remove, 2, 0);
            this.tableLayoutPanel_subL_bottom.Controls.Add(this.button_income_edit, 1, 0);
            this.tableLayoutPanel_subL_bottom.Controls.Add(this.button_income_add, 0, 0);
            this.tableLayoutPanel_subL_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_subL_bottom.Location = new System.Drawing.Point(3, 521);
            this.tableLayoutPanel_subL_bottom.Name = "tableLayoutPanel_subL_bottom";
            this.tableLayoutPanel_subL_bottom.RowCount = 1;
            this.tableLayoutPanel_subL_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_subL_bottom.Size = new System.Drawing.Size(282, 52);
            this.tableLayoutPanel_subL_bottom.TabIndex = 0;
            // 
            // button_income_add
            // 
            this.button_income_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_income_add.Location = new System.Drawing.Point(4, 4);
            this.button_income_add.Name = "button_income_add";
            this.button_income_add.Size = new System.Drawing.Size(86, 44);
            this.button_income_add.TabIndex = 0;
            this.button_income_add.Text = "追加";
            this.button_income_add.UseVisualStyleBackColor = true;
            this.button_income_add.Click += new System.EventHandler(this.button_add_Clicked);
            // 
            // button_income_edit
            // 
            this.button_income_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_income_edit.Location = new System.Drawing.Point(97, 4);
            this.button_income_edit.Name = "button_income_edit";
            this.button_income_edit.Size = new System.Drawing.Size(86, 44);
            this.button_income_edit.TabIndex = 1;
            this.button_income_edit.Text = "編集";
            this.button_income_edit.UseVisualStyleBackColor = true;
            this.button_income_edit.Click += new System.EventHandler(this.button_edit_Clicked);
            // 
            // button_income_remove
            // 
            this.button_income_remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_income_remove.Location = new System.Drawing.Point(190, 4);
            this.button_income_remove.Name = "button_income_remove";
            this.button_income_remove.Size = new System.Drawing.Size(88, 44);
            this.button_income_remove.TabIndex = 2;
            this.button_income_remove.Text = "削除";
            this.button_income_remove.UseVisualStyleBackColor = true;
            this.button_income_remove.Click += new System.EventHandler(this.button_remove_Clicked);
            // 
            // tableLayoutPanel_subR
            // 
            this.tableLayoutPanel_subR.ColumnCount = 1;
            this.tableLayoutPanel_subR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_subR.Controls.Add(this.tableLayoutPanel_subR_bottom, 0, 1);
            this.tableLayoutPanel_subR.Controls.Add(this.dataGridView_expense, 0, 0);
            this.tableLayoutPanel_subR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_subR.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel_subR.Name = "tableLayoutPanel_subR";
            this.tableLayoutPanel_subR.RowCount = 2;
            this.tableLayoutPanel_subR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_subR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_subR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_subR.Size = new System.Drawing.Size(288, 576);
            this.tableLayoutPanel_subR.TabIndex = 1;
            // 
            // tableLayoutPanel_subR_bottom
            // 
            this.tableLayoutPanel_subR_bottom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_subR_bottom.ColumnCount = 3;
            this.tableLayoutPanel_subR_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subR_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subR_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subR_bottom.Controls.Add(this.button_expense_remove, 2, 0);
            this.tableLayoutPanel_subR_bottom.Controls.Add(this.button_expense_edit, 1, 0);
            this.tableLayoutPanel_subR_bottom.Controls.Add(this.button_expense_add, 0, 0);
            this.tableLayoutPanel_subR_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_subR_bottom.Location = new System.Drawing.Point(3, 521);
            this.tableLayoutPanel_subR_bottom.Name = "tableLayoutPanel_subR_bottom";
            this.tableLayoutPanel_subR_bottom.RowCount = 1;
            this.tableLayoutPanel_subR_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_subR_bottom.Size = new System.Drawing.Size(282, 52);
            this.tableLayoutPanel_subR_bottom.TabIndex = 0;
            // 
            // button_expense_remove
            // 
            this.button_expense_remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_expense_remove.Location = new System.Drawing.Point(190, 4);
            this.button_expense_remove.Name = "button_expense_remove";
            this.button_expense_remove.Size = new System.Drawing.Size(88, 44);
            this.button_expense_remove.TabIndex = 2;
            this.button_expense_remove.Text = "削除";
            this.button_expense_remove.UseVisualStyleBackColor = true;
            this.button_expense_remove.Click += new System.EventHandler(this.button_remove_Clicked);
            // 
            // button_expense_edit
            // 
            this.button_expense_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_expense_edit.Location = new System.Drawing.Point(97, 4);
            this.button_expense_edit.Name = "button_expense_edit";
            this.button_expense_edit.Size = new System.Drawing.Size(86, 44);
            this.button_expense_edit.TabIndex = 1;
            this.button_expense_edit.Text = "編集";
            this.button_expense_edit.UseVisualStyleBackColor = true;
            this.button_expense_edit.Click += new System.EventHandler(this.button_edit_Clicked);
            // 
            // button_expense_add
            // 
            this.button_expense_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_expense_add.Location = new System.Drawing.Point(4, 4);
            this.button_expense_add.Name = "button_expense_add";
            this.button_expense_add.Size = new System.Drawing.Size(86, 44);
            this.button_expense_add.TabIndex = 0;
            this.button_expense_add.Text = "追加";
            this.button_expense_add.UseVisualStyleBackColor = true;
            this.button_expense_add.Click += new System.EventHandler(this.button_add_Clicked);
            // 
            // dataGridView_income
            // 
            this.dataGridView_income.AllowUserToAddRows = false;
            this.dataGridView_income.AllowUserToDeleteRows = false;
            this.dataGridView_income.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_income.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_income.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_income.MultiSelect = false;
            this.dataGridView_income.Name = "dataGridView_income";
            this.dataGridView_income.ReadOnly = true;
            this.dataGridView_income.RowHeadersVisible = false;
            this.dataGridView_income.RowTemplate.Height = 21;
            this.dataGridView_income.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_income.Size = new System.Drawing.Size(282, 512);
            this.dataGridView_income.TabIndex = 1;
            // 
            // dataGridView_expense
            // 
            this.dataGridView_expense.AllowUserToAddRows = false;
            this.dataGridView_expense.AllowUserToDeleteRows = false;
            this.dataGridView_expense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_expense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_expense.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_expense.MultiSelect = false;
            this.dataGridView_expense.Name = "dataGridView_expense";
            this.dataGridView_expense.ReadOnly = true;
            this.dataGridView_expense.RowHeadersVisible = false;
            this.dataGridView_expense.RowTemplate.Height = 21;
            this.dataGridView_expense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_expense.Size = new System.Drawing.Size(282, 512);
            this.dataGridView_expense.TabIndex = 1;
            // 
            // MonthlyInputPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Name = "MonthlyInputPage";
            this.Size = new System.Drawing.Size(600, 600);
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.groupBox_income.ResumeLayout(false);
            this.groupBox_expense.ResumeLayout(false);
            this.tableLayoutPanel_subL.ResumeLayout(false);
            this.tableLayoutPanel_subL_bottom.ResumeLayout(false);
            this.tableLayoutPanel_subR.ResumeLayout(false);
            this.tableLayoutPanel_subR_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_income)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.GroupBox groupBox_income;
        private System.Windows.Forms.GroupBox groupBox_expense;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_subL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_subL_bottom;
        private System.Windows.Forms.Button button_income_remove;
        private System.Windows.Forms.Button button_income_edit;
        private System.Windows.Forms.Button button_income_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_subR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_subR_bottom;
        private System.Windows.Forms.Button button_expense_remove;
        private System.Windows.Forms.Button button_expense_edit;
        private System.Windows.Forms.Button button_expense_add;
        private System.Windows.Forms.DataGridView dataGridView_income;
        private System.Windows.Forms.DataGridView dataGridView_expense;
    }
}
