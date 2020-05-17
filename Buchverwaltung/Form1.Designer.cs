namespace Buchverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clearRequestText = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sendRequest = new System.Windows.Forms.Button();
            this.request = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.createAutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.autorName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.createVerlag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.verlagName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verlagSelect = new System.Windows.Forms.ComboBox();
            this.autorSelect = new System.Windows.Forms.ComboBox();
            this.createBuch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buchName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clearRequestText);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.sendRequest);
            this.tabPage1.Controls.Add(this.request);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Übersicht";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clearRequestText
            // 
            this.clearRequestText.Location = new System.Drawing.Point(86, 201);
            this.clearRequestText.Name = "clearRequestText";
            this.clearRequestText.Size = new System.Drawing.Size(173, 47);
            this.clearRequestText.TabIndex = 3;
            this.clearRequestText.Text = "Löschen";
            this.clearRequestText.UseVisualStyleBackColor = true;
            this.clearRequestText.Click += new System.EventHandler(this.clearRequestText_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 206);
            this.dataGridView1.TabIndex = 2;
            // 
            // sendRequest
            // 
            this.sendRequest.Location = new System.Drawing.Point(265, 201);
            this.sendRequest.Name = "sendRequest";
            this.sendRequest.Size = new System.Drawing.Size(247, 47);
            this.sendRequest.TabIndex = 1;
            this.sendRequest.Text = "Anfrage absenden";
            this.sendRequest.UseVisualStyleBackColor = true;
            this.sendRequest.Click += new System.EventHandler(this.sendRequest_Click);
            // 
            // request
            // 
            this.request.Location = new System.Drawing.Point(86, 23);
            this.request.Multiline = true;
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(426, 172);
            this.request.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.createAutor);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.autorName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Neuer Autor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // createAutor
            // 
            this.createAutor.Location = new System.Drawing.Point(258, 212);
            this.createAutor.Name = "createAutor";
            this.createAutor.Size = new System.Drawing.Size(100, 24);
            this.createAutor.TabIndex = 5;
            this.createAutor.Text = "Erstellen";
            this.createAutor.UseVisualStyleBackColor = true;
            this.createAutor.Click += new System.EventHandler(this.createAutor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // autorName
            // 
            this.autorName.Location = new System.Drawing.Point(258, 186);
            this.autorName.Name = "autorName";
            this.autorName.Size = new System.Drawing.Size(100, 20);
            this.autorName.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.createVerlag);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.verlagName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(621, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Neuer Verlag";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // createVerlag
            // 
            this.createVerlag.Location = new System.Drawing.Point(258, 210);
            this.createVerlag.Name = "createVerlag";
            this.createVerlag.Size = new System.Drawing.Size(100, 24);
            this.createVerlag.TabIndex = 5;
            this.createVerlag.Text = "Erstellen";
            this.createVerlag.UseVisualStyleBackColor = true;
            this.createVerlag.Click += new System.EventHandler(this.createVerlag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // verlagName
            // 
            this.verlagName.Location = new System.Drawing.Point(258, 184);
            this.verlagName.Name = "verlagName";
            this.verlagName.Size = new System.Drawing.Size(100, 20);
            this.verlagName.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.verlagSelect);
            this.tabPage4.Controls.Add(this.autorSelect);
            this.tabPage4.Controls.Add(this.createBuch);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.buchName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(621, 466);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Neues Buch";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Verlag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Autor";
            // 
            // verlagSelect
            // 
            this.verlagSelect.FormattingEnabled = true;
            this.verlagSelect.Location = new System.Drawing.Point(255, 208);
            this.verlagSelect.Name = "verlagSelect";
            this.verlagSelect.Size = new System.Drawing.Size(100, 21);
            this.verlagSelect.TabIndex = 9;
            // 
            // autorSelect
            // 
            this.autorSelect.FormattingEnabled = true;
            this.autorSelect.Location = new System.Drawing.Point(255, 181);
            this.autorSelect.Name = "autorSelect";
            this.autorSelect.Size = new System.Drawing.Size(100, 21);
            this.autorSelect.TabIndex = 8;
            // 
            // createBuch
            // 
            this.createBuch.Location = new System.Drawing.Point(255, 235);
            this.createBuch.Name = "createBuch";
            this.createBuch.Size = new System.Drawing.Size(100, 24);
            this.createBuch.TabIndex = 10;
            this.createBuch.Text = "Erstellen";
            this.createBuch.UseVisualStyleBackColor = true;
            this.createBuch.Click += new System.EventHandler(this.createBuch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // buchName
            // 
            this.buchName.Location = new System.Drawing.Point(255, 155);
            this.buchName.Name = "buchName";
            this.buchName.Size = new System.Drawing.Size(100, 20);
            this.buchName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(688, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "blapplications";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sendRequest;
        private System.Windows.Forms.TextBox request;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button clearRequestText;
        private System.Windows.Forms.Button createAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox autorName;
        private System.Windows.Forms.Button createVerlag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox verlagName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox verlagSelect;
        private System.Windows.Forms.ComboBox autorSelect;
        private System.Windows.Forms.Button createBuch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buchName;
        private System.Windows.Forms.Label label6;
    }
}

