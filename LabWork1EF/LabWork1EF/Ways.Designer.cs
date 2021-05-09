namespace PolevikDatabaseADOMDK
{
    partial class Ways
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодмаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктназначенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.днидвиженияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времявпутиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпунктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коддняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автобусные_маршрутыDataSet5 = new PolevikDatabaseADOMDK.Автобусные_маршрутыDataSet5();
            this.автобусыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new PolevikDatabaseADOMDK.InventoryDataSetTableAdapters.OrdersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.автобусыTableAdapter = new PolevikDatabaseADOMDK.Автобусные_маршрутыDataSet4TableAdapters.АвтобусыTableAdapter();
            this.маршрутыTableAdapter = new PolevikDatabaseADOMDK.Автобусные_маршрутыDataSet5TableAdapters.МаршрутыTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусные_маршрутыDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодмаршрутаDataGridViewTextBoxColumn,
            this.пунктназначенияDataGridViewTextBoxColumn,
            this.днидвиженияDataGridViewTextBoxColumn,
            this.времявпутиDataGridViewTextBoxColumn,
            this.кодпунктаDataGridViewTextBoxColumn,
            this.коддняDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.маршрутыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодмаршрутаDataGridViewTextBoxColumn
            // 
            this.кодмаршрутаDataGridViewTextBoxColumn.DataPropertyName = "Код_маршрута";
            this.кодмаршрутаDataGridViewTextBoxColumn.HeaderText = "Код_маршрута";
            this.кодмаршрутаDataGridViewTextBoxColumn.Name = "кодмаршрутаDataGridViewTextBoxColumn";
            this.кодмаршрутаDataGridViewTextBoxColumn.Width = 125;
            // 
            // пунктназначенияDataGridViewTextBoxColumn
            // 
            this.пунктназначенияDataGridViewTextBoxColumn.DataPropertyName = "Пункт_назначения";
            this.пунктназначенияDataGridViewTextBoxColumn.HeaderText = "Пункт_назначения";
            this.пунктназначенияDataGridViewTextBoxColumn.Name = "пунктназначенияDataGridViewTextBoxColumn";
            this.пунктназначенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // днидвиженияDataGridViewTextBoxColumn
            // 
            this.днидвиженияDataGridViewTextBoxColumn.DataPropertyName = "Дни_движения";
            this.днидвиженияDataGridViewTextBoxColumn.HeaderText = "Дни_движения";
            this.днидвиженияDataGridViewTextBoxColumn.Name = "днидвиженияDataGridViewTextBoxColumn";
            this.днидвиженияDataGridViewTextBoxColumn.Width = 125;
            // 
            // времявпутиDataGridViewTextBoxColumn
            // 
            this.времявпутиDataGridViewTextBoxColumn.DataPropertyName = "Время_в_пути";
            this.времявпутиDataGridViewTextBoxColumn.HeaderText = "Время_в_пути";
            this.времявпутиDataGridViewTextBoxColumn.Name = "времявпутиDataGridViewTextBoxColumn";
            this.времявпутиDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодпунктаDataGridViewTextBoxColumn
            // 
            this.кодпунктаDataGridViewTextBoxColumn.DataPropertyName = "Код_пункта";
            this.кодпунктаDataGridViewTextBoxColumn.HeaderText = "Код_пункта";
            this.кодпунктаDataGridViewTextBoxColumn.Name = "кодпунктаDataGridViewTextBoxColumn";
            this.кодпунктаDataGridViewTextBoxColumn.Width = 125;
            // 
            // коддняDataGridViewTextBoxColumn
            // 
            this.коддняDataGridViewTextBoxColumn.DataPropertyName = "Код_дня";
            this.коддняDataGridViewTextBoxColumn.HeaderText = "Код_дня";
            this.коддняDataGridViewTextBoxColumn.Name = "коддняDataGridViewTextBoxColumn";
            this.коддняDataGridViewTextBoxColumn.Width = 125;
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.автобусные_маршрутыDataSet5;
            // 
            // автобусные_маршрутыDataSet5
            // 
            this.автобусные_маршрутыDataSet5.DataSetName = "Автобусные_маршрутыDataSet5";
            this.автобусные_маршрутыDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автобусыBindingSource
            // 
            this.автобусыBindingSource.DataMember = "Автобусы";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(816, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(816, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(816, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // автобусыTableAdapter
            // 
            this.автобусыTableAdapter.ClearBeforeFill = true;
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 426);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Routes";
            this.ShowIcon = false;
            this.Text = "Таблица Маршруты";
            this.Load += new System.EventHandler(this.Routes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусные_маршрутыDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource ordersBindingSource;
        public InventoryDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource автобусыBindingSource;
        public Автобусные_маршрутыDataSet4TableAdapters.АвтобусыTableAdapter автобусыTableAdapter;
        public Автобусные_маршрутыDataSet5 автобусные_маршрутыDataSet5;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        public Автобусные_маршрутыDataSet5TableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктназначенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn днидвиженияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времявпутиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпунктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коддняDataGridViewTextBoxColumn;

    }
}