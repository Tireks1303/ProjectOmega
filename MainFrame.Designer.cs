namespace Abitur
{
    partial class MainFrame
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.abiturDataSet = new Abitur.abiturDataSet();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableAdapter = new Abitur.abiturDataSetTableAdapters.dataTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abiturDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(1830, 1057);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.MaximumSize = new System.Drawing.Size(231, 88);
            this.button1.MinimumSize = new System.Drawing.Size(231, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(46, 121);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 92;
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.Size = new System.Drawing.Size(1717, 1071);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список записей студентов";
            // 
            // btnNew
            // 
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNew.Location = new System.Drawing.Point(1830, 122);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10);
            this.btnNew.MaximumSize = new System.Drawing.Size(231, 88);
            this.btnNew.MinimumSize = new System.Drawing.Size(231, 88);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(231, 88);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Новая запись";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Location = new System.Drawing.Point(1830, 256);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelete.MaximumSize = new System.Drawing.Size(231, 88);
            this.btnDelete.MinimumSize = new System.Drawing.Size(231, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(231, 88);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить запись";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(1830, 391);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.MaximumSize = new System.Drawing.Size(231, 88);
            this.button2.MinimumSize = new System.Drawing.Size(231, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 88);
            this.button2.TabIndex = 5;
            this.button2.Text = "Изменить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // abiturDataSet
            // 
            this.abiturDataSet.DataSetName = "abiturDataSet";
            this.abiturDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "data";
            this.dataBindingSource.DataSource = this.abiturDataSet;
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.Location = new System.Drawing.Point(1830, 527);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdate.MaximumSize = new System.Drawing.Size(231, 88);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(231, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(231, 88);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Обновить список";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2154, 1211);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(2182, 1290);
            this.MinimumSize = new System.Drawing.Size(2182, 1290);
            this.Name = "MainFrame";
            this.Text = "Учет паспортных данных";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abiturDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private abiturDataSet abiturDataSet;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private abiturDataSetTableAdapters.dataTableAdapter dataTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
    }
}