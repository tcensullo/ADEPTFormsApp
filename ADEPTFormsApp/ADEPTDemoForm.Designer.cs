namespace ADEPTFormsApp
{
    partial class ADEPTDemoForm
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
            this.txtThing = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbThings = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSymbols = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtThing
            // 
            this.txtThing.Location = new System.Drawing.Point(99, 134);
            this.txtThing.Name = "txtThing";
            this.txtThing.Size = new System.Drawing.Size(100, 20);
            this.txtThing.TabIndex = 17;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(99, 91);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(100, 20);
            this.txtSymbol.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbThings
            // 
            this.cmbThings.FormattingEnabled = true;
            this.cmbThings.Location = new System.Drawing.Point(219, 133);
            this.cmbThings.Name = "cmbThings";
            this.cmbThings.Size = new System.Drawing.Size(121, 21);
            this.cmbThings.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbSymbols
            // 
            this.cmbSymbols.FormattingEnabled = true;
            this.cmbSymbols.Location = new System.Drawing.Point(219, 90);
            this.cmbSymbols.Name = "cmbSymbols";
            this.cmbSymbols.Size = new System.Drawing.Size(121, 21);
            this.cmbSymbols.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(41, 298);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(925, 285);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Symbol";
            // 
            // btnUpsert
            // 
            this.btnUpsert.Location = new System.Drawing.Point(167, 195);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(173, 23);
            this.btnUpsert.TabIndex = 18;
            this.btnUpsert.Text = "Upsert";
            this.btnUpsert.UseVisualStyleBackColor = true;
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(377, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(173, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ADEPTDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 670);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpsert);
            this.Controls.Add(this.txtThing);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbThings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSymbols);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "ADEPTDemoForm";
            this.Text = "ADEPTDemoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThing;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbThings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSymbols;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpsert;
        private System.Windows.Forms.Button btnSearch;
    }
}