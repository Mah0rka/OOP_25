namespace OOP_25
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fictionBDDataSet = new lab_25_KolV.FictionBDDataSet();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.textBoxBooksNames = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxWritters = new System.Windows.Forms.ComboBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReportByWritter = new System.Windows.Forms.Button();
            this.buttonReportByState = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.booksTableAdapter = new lab_25_KolV.FictionBDDataSetTableAdapters.BooksTableAdapter();
            this.fictionBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fictionBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fictionBDDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(578, 11);
            this.dataGridViewMovies.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.RowHeadersWidth = 51;
            this.dataGridViewMovies.RowTemplate.Height = 24;
            this.dataGridViewMovies.Size = new System.Drawing.Size(679, 247);
            this.dataGridViewMovies.TabIndex = 0;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.moviesBindingSource;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataSource = this.fictionBDDataSet;
            this.moviesBindingSource.Position = 0;
            // 
            // fictionBDDataSet
            // 
            this.fictionBDDataSet.DataSetName = "FictionBDDataSet";
            this.fictionBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(578, 279);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.Size = new System.Drawing.Size(679, 185);
            this.dataGridViewReport.TabIndex = 1;
            // 
            // textBoxBooksNames
            // 
            this.textBoxBooksNames.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBooksNames.Location = new System.Drawing.Point(156, 103);
            this.textBoxBooksNames.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBooksNames.Name = "textBoxBooksNames";
            this.textBoxBooksNames.Size = new System.Drawing.Size(402, 26);
            this.textBoxBooksNames.TabIndex = 2;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(156, 237);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(402, 26);
            this.textBoxYear.TabIndex = 3;
            // 
            // comboBoxWritters
            // 
            this.comboBoxWritters.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWritters.FormattingEnabled = true;
            this.comboBoxWritters.Location = new System.Drawing.Point(156, 150);
            this.comboBoxWritters.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWritters.Name = "comboBoxWritters";
            this.comboBoxWritters.Size = new System.Drawing.Size(402, 27);
            this.comboBoxWritters.TabIndex = 4;
            // 
            // comboBoxState
            // 
            this.comboBoxState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(156, 194);
            this.comboBoxState.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(402, 27);
            this.comboBoxState.TabIndex = 5;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(156, 327);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(402, 26);
            this.textBoxSearch.TabIndex = 6;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(16, 11);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(542, 27);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Завантажити базу";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(16, 279);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(542, 27);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReportByWritter
            // 
            this.buttonReportByWritter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReportByWritter.Location = new System.Drawing.Point(294, 437);
            this.buttonReportByWritter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportByWritter.Name = "buttonReportByWritter";
            this.buttonReportByWritter.Size = new System.Drawing.Size(264, 27);
            this.buttonReportByWritter.TabIndex = 9;
            this.buttonReportByWritter.Text = "За письменником";
            this.buttonReportByWritter.UseVisualStyleBackColor = true;
            this.buttonReportByWritter.Click += new System.EventHandler(this.buttonReportByWritters_Click);
            // 
            // buttonReportByState
            // 
            this.buttonReportByState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReportByState.Location = new System.Drawing.Point(16, 437);
            this.buttonReportByState.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportByState.Name = "buttonReportByState";
            this.buttonReportByState.Size = new System.Drawing.Size(274, 27);
            this.buttonReportByState.TabIndex = 10;
            this.buttonReportByState.Text = "За наявністтю";
            this.buttonReportByState.UseVisualStyleBackColor = true;
            this.buttonReportByState.Click += new System.EventHandler(this.buttonReportByState_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(16, 364);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(542, 27);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Почати пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Назва твору:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Рік написання:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Письменник:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Наявність:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Пошук";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(252, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = " Звіти";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 44);
            this.label7.TabIndex = 18;
            this.label7.Text = "Введіть дані, щоб додати до бази:\r\n ";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // fictionBDDataSetBindingSource
            // 
            this.fictionBDDataSetBindingSource.DataSource = this.fictionBDDataSet;
            this.fictionBDDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1276, 468);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReportByState);
            this.Controls.Add(this.buttonReportByWritter);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.comboBoxWritters);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxBooksNames);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.dataGridViewMovies);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "OOP_25";
            this.Load += new System.EventHandler(this.Video_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fictionBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fictionBDDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.TextBox textBoxBooksNames;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.ComboBox comboBoxWritters;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private System.Windows.Forms.Button buttonReportByWritter;
        private System.Windows.Forms.Button buttonReportByState;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private lab_25_KolV.FictionBDDataSet fictionBDDataSet;

        private System.Windows.Forms.BindingSource booksBindingSource;
        private lab_25_KolV.FictionBDDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource fictionBDDataSetBindingSource;
    }
}

