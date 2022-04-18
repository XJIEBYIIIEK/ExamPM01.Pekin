namespace Экзамен_ПМ._01
{
    partial class КаталогКниг
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this._Экзамен_ПМ_01_ПекинDataSet = new Экзамен_ПМ._01._Экзамен_ПМ_01_ПекинDataSet();
            this.экзаменПМ01ПекинDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new Экзамен_ПМ._01._Экзамен_ПМ_01_ПекинDataSetTableAdapters.КнигиTableAdapter();
            this.кодКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоВМагазинеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обложкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Экзамен_ПМ_01_ПекинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменПМ01ПекинDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(538, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить в корзину";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКнигиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.количествоВМагазинеDataGridViewTextBoxColumn,
            this.количествоНаСкладеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.обложкаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.книгиBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 398);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 398);
            this.panel1.TabIndex = 5;
            // 
            // _Экзамен_ПМ_01_ПекинDataSet
            // 
            this._Экзамен_ПМ_01_ПекинDataSet.DataSetName = "_Экзамен_ПМ_01_ПекинDataSet";
            this._Экзамен_ПМ_01_ПекинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // экзаменПМ01ПекинDataSetBindingSource
            // 
            this.экзаменПМ01ПекинDataSetBindingSource.DataSource = this._Экзамен_ПМ_01_ПекинDataSet;
            this.экзаменПМ01ПекинDataSetBindingSource.Position = 0;
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.экзаменПМ01ПекинDataSetBindingSource;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // кодКнигиDataGridViewTextBoxColumn
            // 
            this.кодКнигиDataGridViewTextBoxColumn.DataPropertyName = "КодКниги";
            this.кодКнигиDataGridViewTextBoxColumn.HeaderText = "КодКниги";
            this.кодКнигиDataGridViewTextBoxColumn.Name = "кодКнигиDataGridViewTextBoxColumn";
            this.кодКнигиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            // 
            // количествоВМагазинеDataGridViewTextBoxColumn
            // 
            this.количествоВМагазинеDataGridViewTextBoxColumn.DataPropertyName = "КоличествоВМагазине";
            this.количествоВМагазинеDataGridViewTextBoxColumn.HeaderText = "КоличествоВМагазине";
            this.количествоВМагазинеDataGridViewTextBoxColumn.Name = "количествоВМагазинеDataGridViewTextBoxColumn";
            // 
            // количествоНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "КоличествоНаСкладе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.HeaderText = "КоличествоНаСкладе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.Name = "количествоНаСкладеDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // обложкаDataGridViewTextBoxColumn
            // 
            this.обложкаDataGridViewTextBoxColumn.DataPropertyName = "Обложка";
            this.обложкаDataGridViewTextBoxColumn.HeaderText = "Обложка";
            this.обложкаDataGridViewTextBoxColumn.Name = "обложкаDataGridViewTextBoxColumn";
            // 
            // КаталогКниг
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "КаталогКниг";
            this.Text = "Каталог книг";
            this.Load += new System.EventHandler(this.КаталогКниг_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Экзамен_ПМ_01_ПекинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменПМ01ПекинDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource экзаменПМ01ПекинDataSetBindingSource;
        private _Экзамен_ПМ_01_ПекинDataSet _Экзамен_ПМ_01_ПекинDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private _Экзамен_ПМ_01_ПекинDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоВМагазинеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обложкаDataGridViewTextBoxColumn;
    }
}