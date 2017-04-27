namespace Spare_Parts_Management
{
    partial class frmUtilizatori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtilizatori));
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.utilizatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeUtilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaUtilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMSDataSet = new Spare_Parts_Management.SMSDataSet();
            this.utilizatoriTableAdapter = new Spare_Parts_Management.SMSDataSetTableAdapters.UtilizatoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParola
            // 
            this.txtParola.Enabled = false;
            this.txtParola.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.ForeColor = System.Drawing.Color.Blue;
            this.txtParola.Location = new System.Drawing.Point(882, 262);
            this.txtParola.Margin = new System.Windows.Forms.Padding(6);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(294, 33);
            this.txtParola.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(712, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "Parola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(687, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nume utilizator";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Enabled = false;
            this.txtUtilizator.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilizator.ForeColor = System.Drawing.Color.Blue;
            this.txtUtilizator.Location = new System.Drawing.Point(882, 189);
            this.txtUtilizator.Margin = new System.Windows.Forms.Padding(6);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(294, 33);
            this.txtUtilizator.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Image = global::Spare_Parts_Management.Properties.Resources.Edit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1026, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 104);
            this.button1.TabIndex = 53;
            this.button1.Text = "Modifica";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.Image")));
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdCancel.Location = new System.Drawing.Point(862, 493);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(6);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(152, 104);
            this.cmdCancel.TabIndex = 55;
            this.cmdCancel.Text = "&Renunta";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Enabled = false;
            this.cmdUpdate.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpdate.Image")));
            this.cmdUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdUpdate.Location = new System.Drawing.Point(862, 353);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(152, 104);
            this.cmdUpdate.TabIndex = 52;
            this.cmdUpdate.Text = "Actualizeaza";
            this.cmdUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.Image")));
            this.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdDelete.Location = new System.Drawing.Point(717, 493);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(6);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(133, 104);
            this.cmdDelete.TabIndex = 54;
            this.cmdDelete.Text = "&Sterge";
            this.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Image = global::Spare_Parts_Management.Properties.Resources.exit;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdExit.Location = new System.Drawing.Point(1026, 493);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(6);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(132, 104);
            this.cmdExit.TabIndex = 56;
            this.cmdExit.Text = "&Iesire";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.Image")));
            this.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdAdd.Location = new System.Drawing.Point(717, 353);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(6);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(133, 104);
            this.cmdAdd.TabIndex = 51;
            this.cmdAdd.Text = "&Adauga";
            this.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilizatorIDDataGridViewTextBoxColumn,
            this.numeUtilizatorDataGridViewTextBoxColumn,
            this.parolaUtilizatorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilizatoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 598);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // utilizatorIDDataGridViewTextBoxColumn
            // 
            this.utilizatorIDDataGridViewTextBoxColumn.DataPropertyName = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.HeaderText = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.Name = "utilizatorIDDataGridViewTextBoxColumn";
            // 
            // numeUtilizatorDataGridViewTextBoxColumn
            // 
            this.numeUtilizatorDataGridViewTextBoxColumn.DataPropertyName = "NumeUtilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.HeaderText = "NumeUtilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.Name = "numeUtilizatorDataGridViewTextBoxColumn";
            // 
            // parolaUtilizatorDataGridViewTextBoxColumn
            // 
            this.parolaUtilizatorDataGridViewTextBoxColumn.DataPropertyName = "ParolaUtilizator";
            this.parolaUtilizatorDataGridViewTextBoxColumn.HeaderText = "ParolaUtilizator";
            this.parolaUtilizatorDataGridViewTextBoxColumn.Name = "parolaUtilizatorDataGridViewTextBoxColumn";
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.sMSDataSet;
            // 
            // sMSDataSet
            // 
            this.sMSDataSet.DataSetName = "SMSDataSet";
            this.sMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // frmUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 803);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUtilizator);
            this.Name = "frmUtilizatori";
            this.Text = "Creeaza si administreaza utilizatori!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmUtilizatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellClick_1(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SMSDataSet sMSDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private SMSDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeUtilizatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaUtilizatorDataGridViewTextBoxColumn;
    }
}