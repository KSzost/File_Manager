namespace FileManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnParentDirectory1 = new System.Windows.Forms.Button();
            this.btnParentDirectory2 = new System.Windows.Forms.Button();
            this.txtAlert1 = new System.Windows.Forms.TextBox();
            this.txtAlert2 = new System.Windows.Forms.TextBox();
            this.btnNewDir1 = new System.Windows.Forms.Button();
            this.btnNewDir2 = new System.Windows.Forms.Button();
            this.dataG1 = new System.Windows.Forms.DataGridView();
            this.dataG2 = new System.Windows.Forms.DataGridView();
            this.file_Icon2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCopy1 = new System.Windows.Forms.Button();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.btnCopy2 = new System.Windows.Forms.Button();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.File_icon1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creation_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.Location = new System.Drawing.Point(729, 13);
            this.btnOpen1.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(63, 30);
            this.btnOpen1.TabIndex = 2;
            this.btnOpen1.Text = "Open";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.BtnOpen1_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(13, 17);
            this.txtPath1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.ReadOnly = true;
            this.txtPath1.Size = new System.Drawing.Size(708, 22);
            this.txtPath1.TabIndex = 4;
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(849, 17);
            this.txtPath2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.ReadOnly = true;
            this.txtPath2.Size = new System.Drawing.Size(709, 22);
            this.txtPath2.TabIndex = 10;
            // 
            // btnOpen2
            // 
            this.btnOpen2.Location = new System.Drawing.Point(1566, 13);
            this.btnOpen2.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(63, 30);
            this.btnOpen2.TabIndex = 9;
            this.btnOpen2.Text = "Open";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.BtnOpen2_Click);
            // 
            // btnParentDirectory1
            // 
            this.btnParentDirectory1.Location = new System.Drawing.Point(13, 47);
            this.btnParentDirectory1.Name = "btnParentDirectory1";
            this.btnParentDirectory1.Size = new System.Drawing.Size(80, 32);
            this.btnParentDirectory1.TabIndex = 11;
            this.btnParentDirectory1.Text = "Up";
            this.btnParentDirectory1.UseVisualStyleBackColor = true;
            this.btnParentDirectory1.Click += new System.EventHandler(this.BtnParentDirectory1_Click);
            // 
            // btnParentDirectory2
            // 
            this.btnParentDirectory2.Location = new System.Drawing.Point(849, 47);
            this.btnParentDirectory2.Name = "btnParentDirectory2";
            this.btnParentDirectory2.Size = new System.Drawing.Size(80, 32);
            this.btnParentDirectory2.TabIndex = 12;
            this.btnParentDirectory2.Text = "Up";
            this.btnParentDirectory2.UseVisualStyleBackColor = true;
            this.btnParentDirectory2.Click += new System.EventHandler(this.BtnParentDirectory2_Click);
            // 
            // txtAlert1
            // 
            this.txtAlert1.Location = new System.Drawing.Point(13, 570);
            this.txtAlert1.Name = "txtAlert1";
            this.txtAlert1.ReadOnly = true;
            this.txtAlert1.Size = new System.Drawing.Size(780, 22);
            this.txtAlert1.TabIndex = 15;
            // 
            // txtAlert2
            // 
            this.txtAlert2.Location = new System.Drawing.Point(849, 570);
            this.txtAlert2.Name = "txtAlert2";
            this.txtAlert2.ReadOnly = true;
            this.txtAlert2.Size = new System.Drawing.Size(780, 22);
            this.txtAlert2.TabIndex = 16;
            // 
            // btnNewDir1
            // 
            this.btnNewDir1.Location = new System.Drawing.Point(99, 48);
            this.btnNewDir1.Name = "btnNewDir1";
            this.btnNewDir1.Size = new System.Drawing.Size(80, 32);
            this.btnNewDir1.TabIndex = 17;
            this.btnNewDir1.Text = "Dir";
            this.btnNewDir1.UseVisualStyleBackColor = true;
            this.btnNewDir1.Click += new System.EventHandler(this.BtnNewDir1_Click);
            // 
            // btnNewDir2
            // 
            this.btnNewDir2.Location = new System.Drawing.Point(935, 47);
            this.btnNewDir2.Name = "btnNewDir2";
            this.btnNewDir2.Size = new System.Drawing.Size(80, 32);
            this.btnNewDir2.TabIndex = 18;
            this.btnNewDir2.Text = "Dir";
            this.btnNewDir2.UseVisualStyleBackColor = true;
            this.btnNewDir2.Click += new System.EventHandler(this.BtnNewDir2_Click);
            // 
            // dataG1
            // 
            this.dataG1.AllowDrop = true;
            this.dataG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File_icon1,
            this.FName,
            this.Creation_Date});
            this.dataG1.Location = new System.Drawing.Point(12, 84);
            this.dataG1.MultiSelect = false;
            this.dataG1.Name = "dataG1";
            this.dataG1.ReadOnly = true;
            this.dataG1.RowHeadersVisible = false;
            this.dataG1.RowTemplate.Height = 24;
            this.dataG1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataG1.Size = new System.Drawing.Size(780, 480);
            this.dataG1.TabIndex = 21;
            this.dataG1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataG1_CellDoubleClick);
            this.dataG1.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataG1_DragDrop);
            this.dataG1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataG1_DragEnter);
            this.dataG1.DragOver += new System.Windows.Forms.DragEventHandler(this.DataG1_DragOver);
            this.dataG1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataG1_MouseDown);
            this.dataG1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataG1_MouseMove);
            // 
            // dataG2
            // 
            this.dataG2.AllowDrop = true;
            this.dataG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.file_Icon2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataG2.Location = new System.Drawing.Point(849, 84);
            this.dataG2.MultiSelect = false;
            this.dataG2.Name = "dataG2";
            this.dataG2.ReadOnly = true;
            this.dataG2.RowHeadersVisible = false;
            this.dataG2.RowTemplate.Height = 24;
            this.dataG2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataG2.Size = new System.Drawing.Size(780, 480);
            this.dataG2.TabIndex = 22;
            this.dataG2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataG2_CellDoubleClick);
            this.dataG2.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataG2_DragDrop);
            this.dataG2.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataG2_DragEnter);
            this.dataG2.DragOver += new System.Windows.Forms.DragEventHandler(this.DataG2_DragOver);
            this.dataG2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataG2_MouseDown);
            this.dataG2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataG2_MouseMove);
            // 
            // file_Icon2
            // 
            this.file_Icon2.HeaderText = "";
            this.file_Icon2.Name = "file_Icon2";
            this.file_Icon2.ReadOnly = true;
            this.file_Icon2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.file_Icon2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.file_Icon2.Width = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Creation_Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 190;
            // 
            // btnCopy1
            // 
            this.btnCopy1.Location = new System.Drawing.Point(185, 46);
            this.btnCopy1.Name = "btnCopy1";
            this.btnCopy1.Size = new System.Drawing.Size(80, 32);
            this.btnCopy1.TabIndex = 23;
            this.btnCopy1.Text = "Copy";
            this.btnCopy1.UseVisualStyleBackColor = true;
            this.btnCopy1.Click += new System.EventHandler(this.BtnCopy1_Click);
            // 
            // btnDel1
            // 
            this.btnDel1.Location = new System.Drawing.Point(271, 46);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(80, 32);
            this.btnDel1.TabIndex = 24;
            this.btnDel1.Text = "Delete";
            this.btnDel1.UseVisualStyleBackColor = true;
            this.btnDel1.Click += new System.EventHandler(this.BtnDel1_Click);
            // 
            // btnCopy2
            // 
            this.btnCopy2.Location = new System.Drawing.Point(1021, 46);
            this.btnCopy2.Name = "btnCopy2";
            this.btnCopy2.Size = new System.Drawing.Size(80, 32);
            this.btnCopy2.TabIndex = 25;
            this.btnCopy2.Text = "Copy";
            this.btnCopy2.UseVisualStyleBackColor = true;
            this.btnCopy2.Click += new System.EventHandler(this.BtnCopy2_Click);
            // 
            // btnDel2
            // 
            this.btnDel2.Location = new System.Drawing.Point(1107, 46);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(80, 32);
            this.btnDel2.TabIndex = 26;
            this.btnDel2.Text = "Delete";
            this.btnDel2.UseVisualStyleBackColor = true;
            this.btnDel2.Click += new System.EventHandler(this.BtnDel2_Click);
            // 
            // File_icon1
            // 
            this.File_icon1.HeaderText = "";
            this.File_icon1.Name = "File_icon1";
            this.File_icon1.ReadOnly = true;
            this.File_icon1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.File_icon1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.File_icon1.Width = 32;
            // 
            // FName
            // 
            this.FName.HeaderText = "Name";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Width = 400;
            // 
            // Creation_Date
            // 
            this.Creation_Date.HeaderText = "Creation_Date";
            this.Creation_Date.Name = "Creation_Date";
            this.Creation_Date.ReadOnly = true;
            this.Creation_Date.Width = 190;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1643, 601);
            this.Controls.Add(this.btnDel2);
            this.Controls.Add(this.btnCopy2);
            this.Controls.Add(this.btnDel1);
            this.Controls.Add(this.btnCopy1);
            this.Controls.Add(this.dataG2);
            this.Controls.Add(this.dataG1);
            this.Controls.Add(this.btnNewDir2);
            this.Controls.Add(this.btnNewDir1);
            this.Controls.Add(this.txtAlert2);
            this.Controls.Add(this.txtAlert1);
            this.Controls.Add(this.btnParentDirectory2);
            this.Controls.Add(this.btnParentDirectory1);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.btnOpen1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.dataG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnParentDirectory1;
        private System.Windows.Forms.Button btnParentDirectory2;
        private System.Windows.Forms.TextBox txtAlert1;
        private System.Windows.Forms.TextBox txtAlert2;
        private System.Windows.Forms.Button btnNewDir1;
        private System.Windows.Forms.Button btnNewDir2;
        private System.Windows.Forms.DataGridView dataG1;
        private System.Windows.Forms.DataGridView dataG2;
        private System.Windows.Forms.DataGridViewImageColumn file_Icon2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnCopy1;
        private System.Windows.Forms.Button btnDel1;
        private System.Windows.Forms.Button btnCopy2;
        private System.Windows.Forms.Button btnDel2;
        private System.Windows.Forms.DataGridViewImageColumn File_icon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creation_Date;
    }
}

