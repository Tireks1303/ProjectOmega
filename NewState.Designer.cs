namespace Abitur
{
    partial class NewState
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.bField = new System.Windows.Forms.TextBox();
            this.cField = new System.Windows.Forms.TextBox();
            this.numField = new System.Windows.Forms.TextBox();
            this.gField = new System.Windows.Forms.TextBox();
            this.dField = new System.Windows.Forms.TextBox();
            this.codeField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameField.Font = new System.Drawing.Font("Arial", 12F);
            this.nameField.Location = new System.Drawing.Point(340, 177);
            this.nameField.MaxLength = 50;
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(1012, 62);
            this.nameField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(223, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(223, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(787, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 63);
            this.label3.TabIndex = 4;
            this.label3.Text = "Гражданство:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(223, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 62);
            this.label4.TabIndex = 6;
            this.label4.Text = "Серия Номер:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(797, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 62);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата выдачи:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(223, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 62);
            this.label6.TabIndex = 10;
            this.label6.Text = "Выдан:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(674, 715);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 59);
            this.label7.TabIndex = 12;
            this.label7.Text = "Код подразделения:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(86, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1461, 80);
            this.label8.TabIndex = 14;
            this.label8.Text = "Введите данные студента";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(845, 921);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(412, 92);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(381, 921);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(412, 92);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Создать запись";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // bField
            // 
            this.bField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bField.Font = new System.Drawing.Font("Arial", 12F);
            this.bField.Location = new System.Drawing.Point(511, 322);
            this.bField.MaxLength = 50;
            this.bField.Multiline = true;
            this.bField.Name = "bField";
            this.bField.Size = new System.Drawing.Size(270, 62);
            this.bField.TabIndex = 17;
            // 
            // cField
            // 
            this.cField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cField.Font = new System.Drawing.Font("Arial", 12F);
            this.cField.Location = new System.Drawing.Point(1048, 322);
            this.cField.MaxLength = 50;
            this.cField.Multiline = true;
            this.cField.Name = "cField";
            this.cField.Size = new System.Drawing.Size(304, 62);
            this.cField.TabIndex = 18;
            // 
            // numField
            // 
            this.numField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numField.Font = new System.Drawing.Font("Arial", 12F);
            this.numField.Location = new System.Drawing.Point(511, 471);
            this.numField.MaxLength = 50;
            this.numField.Multiline = true;
            this.numField.Name = "numField";
            this.numField.Size = new System.Drawing.Size(270, 62);
            this.numField.TabIndex = 19;
            // 
            // gField
            // 
            this.gField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gField.Font = new System.Drawing.Font("Arial", 12F);
            this.gField.Location = new System.Drawing.Point(381, 591);
            this.gField.MaxLength = 50;
            this.gField.Multiline = true;
            this.gField.Name = "gField";
            this.gField.Size = new System.Drawing.Size(971, 62);
            this.gField.TabIndex = 20;
            // 
            // dField
            // 
            this.dField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dField.Font = new System.Drawing.Font("Arial", 12F);
            this.dField.Location = new System.Drawing.Point(1048, 471);
            this.dField.MaxLength = 50;
            this.dField.Multiline = true;
            this.dField.Name = "dField";
            this.dField.Size = new System.Drawing.Size(304, 62);
            this.dField.TabIndex = 21;
            // 
            // codeField
            // 
            this.codeField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.codeField.Font = new System.Drawing.Font("Arial", 12F);
            this.codeField.Location = new System.Drawing.Point(1048, 721);
            this.codeField.MaxLength = 50;
            this.codeField.Multiline = true;
            this.codeField.Name = "codeField";
            this.codeField.Size = new System.Drawing.Size(304, 62);
            this.codeField.TabIndex = 22;
            // 
            // NewState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 1156);
            this.ControlBox = false;
            this.Controls.Add(this.codeField);
            this.Controls.Add(this.dField);
            this.Controls.Add(this.gField);
            this.Controls.Add(this.numField);
            this.Controls.Add(this.cField);
            this.Controls.Add(this.bField);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Name = "NewState";
            this.Text = "Создание новой записи";
            this.Load += new System.EventHandler(this.NewState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox bField;
        private System.Windows.Forms.TextBox cField;
        private System.Windows.Forms.TextBox numField;
        private System.Windows.Forms.TextBox gField;
        private System.Windows.Forms.TextBox dField;
        private System.Windows.Forms.TextBox codeField;
    }
}