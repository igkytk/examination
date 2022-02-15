
namespace bookkeeping
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_subT = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.numericUpDown_total = new System.Windows.Forms.NumericUpDown();
            this.comboBox_tax = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_subB = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_continue = new System.Windows.Forms.CheckBox();
            this.button_decide = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel_main.SuspendLayout();
            this.tableLayoutPanel_subT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_total)).BeginInit();
            this.tableLayoutPanel_subB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 1;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Controls.Add(this.tableLayoutPanel_subT, 0, 0);
            this.tableLayoutPanel_main.Controls.Add(this.tableLayoutPanel_subB, 0, 1);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 2;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(284, 161);
            this.tableLayoutPanel_main.TabIndex = 0;
            // 
            // tableLayoutPanel_subT
            // 
            this.tableLayoutPanel_subT.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel_subT.ColumnCount = 2;
            this.tableLayoutPanel_subT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_subT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_subT.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_subT.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel_subT.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel_subT.Controls.Add(this.textBox_name, 1, 0);
            this.tableLayoutPanel_subT.Controls.Add(this.numericUpDown_total, 1, 1);
            this.tableLayoutPanel_subT.Controls.Add(this.comboBox_tax, 1, 2);
            this.tableLayoutPanel_subT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_subT.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_subT.Name = "tableLayoutPanel_subT";
            this.tableLayoutPanel_subT.RowCount = 3;
            this.tableLayoutPanel_subT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subT.Size = new System.Drawing.Size(278, 106);
            this.tableLayoutPanel_subT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "項目名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "合計";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "税率";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(88, 8);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(185, 19);
            this.textBox_name.TabIndex = 3;
            // 
            // numericUpDown_total
            // 
            this.numericUpDown_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_total.Location = new System.Drawing.Point(88, 42);
            this.numericUpDown_total.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown_total.Name = "numericUpDown_total";
            this.numericUpDown_total.Size = new System.Drawing.Size(185, 19);
            this.numericUpDown_total.TabIndex = 4;
            this.numericUpDown_total.ThousandsSeparator = true;
            // 
            // comboBox_tax
            // 
            this.comboBox_tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_tax.FormattingEnabled = true;
            this.comboBox_tax.Items.AddRange(new object[] {
            "10%",
            "8%"});
            this.comboBox_tax.Location = new System.Drawing.Point(88, 77);
            this.comboBox_tax.Name = "comboBox_tax";
            this.comboBox_tax.Size = new System.Drawing.Size(185, 20);
            this.comboBox_tax.TabIndex = 5;
            this.comboBox_tax.Text = "10%";
            // 
            // tableLayoutPanel_subB
            // 
            this.tableLayoutPanel_subB.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_subB.ColumnCount = 3;
            this.tableLayoutPanel_subB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_subB.Controls.Add(this.checkBox_continue, 0, 0);
            this.tableLayoutPanel_subB.Controls.Add(this.button_decide, 1, 0);
            this.tableLayoutPanel_subB.Controls.Add(this.button_cancel, 2, 0);
            this.tableLayoutPanel_subB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_subB.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel_subB.Name = "tableLayoutPanel_subB";
            this.tableLayoutPanel_subB.RowCount = 1;
            this.tableLayoutPanel_subB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_subB.Size = new System.Drawing.Size(278, 43);
            this.tableLayoutPanel_subB.TabIndex = 1;
            // 
            // checkBox_continue
            // 
            this.checkBox_continue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_continue.AutoSize = true;
            this.checkBox_continue.Location = new System.Drawing.Point(4, 13);
            this.checkBox_continue.Name = "checkBox_continue";
            this.checkBox_continue.Size = new System.Drawing.Size(85, 16);
            this.checkBox_continue.TabIndex = 0;
            this.checkBox_continue.Text = "続行";
            this.checkBox_continue.UseVisualStyleBackColor = true;
            // 
            // button_decide
            // 
            this.button_decide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_decide.Location = new System.Drawing.Point(96, 4);
            this.button_decide.Name = "button_decide";
            this.button_decide.Size = new System.Drawing.Size(85, 35);
            this.button_decide.TabIndex = 1;
            this.button_decide.Text = "決定";
            this.button_decide.UseVisualStyleBackColor = true;
            this.button_decide.Click += new System.EventHandler(this.button_decide_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_cancel.Location = new System.Drawing.Point(188, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(86, 35);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "キャンセル";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Name = "InputForm";
            this.Text = "入力";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_subT.ResumeLayout(false);
            this.tableLayoutPanel_subT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_total)).EndInit();
            this.tableLayoutPanel_subB.ResumeLayout(false);
            this.tableLayoutPanel_subB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_subT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.NumericUpDown numericUpDown_total;
        private System.Windows.Forms.ComboBox comboBox_tax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_subB;
        private System.Windows.Forms.CheckBox checkBox_continue;
        private System.Windows.Forms.Button button_decide;
        private System.Windows.Forms.Button button_cancel;
    }
}