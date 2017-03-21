namespace ExecuteJS
{
    partial class mainForm
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
            this.buttonModify = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddUpdate = new System.Windows.Forms.Button();
            this.buttonModifyUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddressScript = new System.Windows.Forms.TextBox();
            this.textBoxScript = new System.Windows.Forms.TextBox();
            this.listViewScripts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewScript = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(1076, 77);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(186, 31);
            this.buttonModify.TabIndex = 1;
            this.buttonModify.Text = "Modify Script";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 661);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1274, 661);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonAddUpdate);
            this.panel2.Controls.Add(this.buttonModifyUpdate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxAddressScript);
            this.panel2.Controls.Add(this.textBoxScript);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 661);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1249, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddUpdate
            // 
            this.buttonAddUpdate.Location = new System.Drawing.Point(13, 580);
            this.buttonAddUpdate.Name = "buttonAddUpdate";
            this.buttonAddUpdate.Size = new System.Drawing.Size(1249, 33);
            this.buttonAddUpdate.TabIndex = 10;
            this.buttonAddUpdate.Text = "Add";
            this.buttonAddUpdate.UseVisualStyleBackColor = true;
            this.buttonAddUpdate.Visible = false;
            this.buttonAddUpdate.Click += new System.EventHandler(this.buttonAddUpdate_Click);
            // 
            // buttonModifyUpdate
            // 
            this.buttonModifyUpdate.Location = new System.Drawing.Point(13, 581);
            this.buttonModifyUpdate.Name = "buttonModifyUpdate";
            this.buttonModifyUpdate.Size = new System.Drawing.Size(1249, 33);
            this.buttonModifyUpdate.TabIndex = 9;
            this.buttonModifyUpdate.Text = "Modify";
            this.buttonModifyUpdate.UseVisualStyleBackColor = true;
            this.buttonModifyUpdate.Visible = false;
            this.buttonModifyUpdate.Click += new System.EventHandler(this.buttonModifyUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Script:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address:";
            // 
            // textBoxAddressScript
            // 
            this.textBoxAddressScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddressScript.Location = new System.Drawing.Point(80, 17);
            this.textBoxAddressScript.Name = "textBoxAddressScript";
            this.textBoxAddressScript.Size = new System.Drawing.Size(1182, 23);
            this.textBoxAddressScript.TabIndex = 5;
            // 
            // textBoxScript
            // 
            this.textBoxScript.Location = new System.Drawing.Point(13, 69);
            this.textBoxScript.Multiline = true;
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxScript.Size = new System.Drawing.Size(1249, 507);
            this.textBoxScript.TabIndex = 6;
            // 
            // listViewScripts
            // 
            this.listViewScripts.CheckBoxes = true;
            this.listViewScripts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewScripts.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewScripts.FullRowSelect = true;
            this.listViewScripts.GridLines = true;
            this.listViewScripts.Location = new System.Drawing.Point(0, 0);
            this.listViewScripts.Name = "listViewScripts";
            this.listViewScripts.Size = new System.Drawing.Size(1274, 158);
            this.listViewScripts.TabIndex = 5;
            this.listViewScripts.UseCompatibleStateImageBehavior = false;
            this.listViewScripts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Address";
            this.columnHeader1.Width = 1065;
            // 
            // buttonNewScript
            // 
            this.buttonNewScript.Location = new System.Drawing.Point(1076, 40);
            this.buttonNewScript.Name = "buttonNewScript";
            this.buttonNewScript.Size = new System.Drawing.Size(186, 31);
            this.buttonNewScript.TabIndex = 6;
            this.buttonNewScript.Text = "New Script";
            this.buttonNewScript.UseVisualStyleBackColor = true;
            this.buttonNewScript.Click += new System.EventHandler(this.buttonNewScript_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1076, 114);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(186, 31);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete Script";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 819);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNewScript);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.listViewScripts);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "ExecuteJS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewScripts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonNewScript;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddUpdate;
        private System.Windows.Forms.Button buttonModifyUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddressScript;
        private System.Windows.Forms.TextBox textBoxScript;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}

