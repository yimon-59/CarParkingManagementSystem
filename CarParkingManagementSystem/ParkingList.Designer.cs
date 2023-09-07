namespace CarParkingManagementSystem
{
    partial class ParkingList
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReciptUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carInfoDataSet = new CarParkingManagementSystem.CarInfoDataSet();
            this.carDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblShopName = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.carInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carInfoTableAdapter = new CarParkingManagementSystem.CarInfoDataSetTableAdapters.CarInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Number";
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Location = new System.Drawing.Point(134, 18);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCarNumber.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(48, 74);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "Park In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(191, 74);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Park Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // dgList
            // 
            this.dgList.AutoGenerateColumns = false;
            this.dgList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.receiptAmountDataGridViewTextBoxColumn,
            this.isReciptUsedDataGridViewTextBoxColumn});
            this.dgList.DataSource = this.carInfoBindingSource1;
            this.dgList.Location = new System.Drawing.Point(48, 117);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(544, 283);
            this.dgList.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlateNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Plate Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ShopName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Shop Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TimeIn";
            this.dataGridViewTextBoxColumn4.HeaderText = "Time In";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TimeOut";
            this.dataGridViewTextBoxColumn5.HeaderText = "Time Out";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn6.HeaderText = "Parking Fees";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // receiptAmountDataGridViewTextBoxColumn
            // 
            this.receiptAmountDataGridViewTextBoxColumn.DataPropertyName = "ReceiptAmount";
            this.receiptAmountDataGridViewTextBoxColumn.HeaderText = "Receipt Amount";
            this.receiptAmountDataGridViewTextBoxColumn.Name = "receiptAmountDataGridViewTextBoxColumn";
            this.receiptAmountDataGridViewTextBoxColumn.Visible = false;
            // 
            // isReciptUsedDataGridViewTextBoxColumn
            // 
            this.isReciptUsedDataGridViewTextBoxColumn.DataPropertyName = "IsReciptUsed";
            this.isReciptUsedDataGridViewTextBoxColumn.HeaderText = "IsReciptUsed";
            this.isReciptUsedDataGridViewTextBoxColumn.Name = "isReciptUsedDataGridViewTextBoxColumn";
            this.isReciptUsedDataGridViewTextBoxColumn.Visible = false;
            // 
            // carInfoBindingSource1
            // 
            this.carInfoBindingSource1.DataMember = "CarInfo";
            this.carInfoBindingSource1.DataSource = this.carInfoDataSet;
            // 
            // carInfoDataSet
            // 
            this.carInfoDataSet.DataSetName = "CarInfoDataSet";
            this.carInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carDetailBindingSource1
            // 
            this.carDetailBindingSource1.DataMember = "CarDetail";
            // 
            // carDetailBindingSource
            // 
            this.carDetailBindingSource.DataMember = "CarDetail";
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Location = new System.Drawing.Point(257, 25);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(63, 13);
            this.lblShopName.TabIndex = 5;
            this.lblShopName.Text = "Shop Name";
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(344, 18);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(100, 20);
            this.txtShopName.TabIndex = 6;
            // 
            // carInfoTableAdapter
            // 
            this.carInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ParkingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.lblShopName);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtCarNumber);
            this.Controls.Add(this.label1);
            this.Name = "ParkingList";
            this.Text = "ParkingList";
            this.Load += new System.EventHandler(this.ParkingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.BindingSource carDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptAmoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carDetailBindingSource1;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.BindingSource carInfoBindingSource;
        private CarInfoDataSet carInfoDataSet;
        private System.Windows.Forms.BindingSource carInfoBindingSource1;
        private CarInfoDataSetTableAdapters.CarInfoTableAdapter carInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isReciptUsedDataGridViewTextBoxColumn;
    }
}