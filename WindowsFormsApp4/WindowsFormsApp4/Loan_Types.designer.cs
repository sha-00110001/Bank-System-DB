namespace WindowsFormsApp4
{
    partial class Loan_Types
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tYPELOANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new WindowsFormsApp4.BankDataSet();
            this.lOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOANTableAdapter = new WindowsFormsApp4.BankDataSetTableAdapters.LOANTableAdapter();
            this.bankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(303, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "LOAN_TYPES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tYPELOANDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lOANBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(288, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(176, 252);
            this.dataGridView1.TabIndex = 4;
            // 
            // tYPELOANDataGridViewTextBoxColumn
            // 
            this.tYPELOANDataGridViewTextBoxColumn.DataPropertyName = "TYPE_LOAN_";
            this.tYPELOANDataGridViewTextBoxColumn.HeaderText = "TYPE_LOAN_";
            this.tYPELOANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tYPELOANDataGridViewTextBoxColumn.Name = "tYPELOANDataGridViewTextBoxColumn";
            this.tYPELOANDataGridViewTextBoxColumn.ReadOnly = true;
            this.tYPELOANDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOANBindingSource1
            // 
            this.lOANBindingSource1.DataMember = "LOAN";
            this.lOANBindingSource1.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOANBindingSource
            // 
            this.lOANBindingSource.DataMember = "LOAN";
            this.lOANBindingSource.DataSource = this.bankDataSet;
            // 
            // lOANTableAdapter
            // 
            this.lOANTableAdapter.ClearBeforeFill = true;
            // 
            // bankDataSetBindingSource
            // 
            this.bankDataSetBindingSource.DataSource = this.bankDataSet;
            this.bankDataSetBindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Loan_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Loan_Types";
            this.Text = "Show_Loan_Types";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource lOANBindingSource;
        private BankDataSetTableAdapters.LOANTableAdapter lOANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPELOANDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lOANBindingSource1;
        private System.Windows.Forms.BindingSource bankDataSetBindingSource;
        private System.Windows.Forms.Button button2;
    }
}