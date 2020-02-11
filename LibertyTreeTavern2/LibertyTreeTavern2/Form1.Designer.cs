namespace LibertyTreeTavern2
{
    partial class Form1
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
            this.mainTitle = new System.Windows.Forms.Label();
            this.numVisLabel = new System.Windows.Forms.Label();
            this.numNight = new System.Windows.Forms.Label();
            this.numVisBox = new System.Windows.Forms.TextBox();
            this.numNightBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.roomCheckBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.SystemColors.Control;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.Teal;
            this.mainTitle.Location = new System.Drawing.Point(158, 26);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(462, 55);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Liberty Tree Tavern";
            this.mainTitle.Click += new System.EventHandler(this.mainTitle_Click);
            // 
            // numVisLabel
            // 
            this.numVisLabel.AutoSize = true;
            this.numVisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVisLabel.Location = new System.Drawing.Point(12, 104);
            this.numVisLabel.Name = "numVisLabel";
            this.numVisLabel.Size = new System.Drawing.Size(204, 16);
            this.numVisLabel.TabIndex = 1;
            this.numVisLabel.Text = "Enter the Number of Visitors:";
            this.numVisLabel.Click += new System.EventHandler(this.numVisLabel_Click);
            // 
            // numNight
            // 
            this.numNight.AutoSize = true;
            this.numNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNight.Location = new System.Drawing.Point(12, 137);
            this.numNight.Name = "numNight";
            this.numNight.Size = new System.Drawing.Size(196, 16);
            this.numNight.TabIndex = 2;
            this.numNight.Text = "Enter the Number of Nights:";
            // 
            // numVisBox
            // 
            this.numVisBox.Location = new System.Drawing.Point(234, 104);
            this.numVisBox.Name = "numVisBox";
            this.numVisBox.Size = new System.Drawing.Size(100, 20);
            this.numVisBox.TabIndex = 3;
            this.numVisBox.TextChanged += new System.EventHandler(this.numVisBox_TextChanged);
            // 
            // numNightBox
            // 
            this.numNightBox.Location = new System.Drawing.Point(234, 137);
            this.numNightBox.Name = "numNightBox";
            this.numNightBox.Size = new System.Drawing.Size(100, 20);
            this.numNightBox.TabIndex = 4;
            this.numNightBox.TextChanged += new System.EventHandler(this.numNightBox_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Continental - Free",
            "Full Breakfast - $6.99",
            "Deluxe Breakfast - $10.99"});
            this.listBox1.Location = new System.Drawing.Point(195, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 56);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // roomCheckBox
            // 
            this.roomCheckBox.FormattingEnabled = true;
            this.roomCheckBox.Items.AddRange(new object[] {
            "Lincoln Suite",
            "Continental Room",
            "Jefferson Cabin"});
            this.roomCheckBox.Location = new System.Drawing.Point(15, 175);
            this.roomCheckBox.Name = "roomCheckBox";
            this.roomCheckBox.Size = new System.Drawing.Size(146, 64);
            this.roomCheckBox.TabIndex = 6;
            this.roomCheckBox.SelectedIndexChanged += new System.EventHandler(this.roomCheckBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cost:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(400, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Click Here For Room Info and Rates\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Location = new System.Drawing.Point(596, 145);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Lincoln Suite";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel2.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel2.Location = new System.Drawing.Point(596, 175);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(107, 13);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Continental Room";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel3.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel3.Location = new System.Drawing.Point(596, 211);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(95, 13);
            this.linkLabel3.TabIndex = 13;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Jefferson Cabin";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(39, 354);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(321, 20);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Text = "Enter the Information Above for Rates!";
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomCheckBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numNightBox);
            this.Controls.Add(this.numVisBox);
            this.Controls.Add(this.numNight);
            this.Controls.Add(this.numVisLabel);
            this.Controls.Add(this.mainTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label numVisLabel;
        private System.Windows.Forms.Label numNight;
        private System.Windows.Forms.TextBox numVisBox;
        private System.Windows.Forms.TextBox numNightBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox roomCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label errorLabel;
    }
}

