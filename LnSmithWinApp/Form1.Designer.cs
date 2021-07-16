
namespace LnSmithWinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBank = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRelationType = new System.Windows.Forms.Label();
            this.lblRelationName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.ddBank = new System.Windows.Forms.ComboBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ddRelationType = new System.Windows.Forms.ComboBox();
            this.txtRelationName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnGeneratePdf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrnament = new System.Windows.Forms.TextBox();
            this.txtGrossWeight = new System.Windows.Forms.TextBox();
            this.txtStoneWeight = new System.Windows.Forms.TextBox();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.txtNetWeight = new System.Windows.Forms.TextBox();
            this.txtMarketPrice = new System.Windows.Forms.TextBox();
            this.ddQuantity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTodayRate = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gridOrnaments = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrnaments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(68, 104);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(38, 15);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "Bank*";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(68, 139);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(49, 15);
            this.lblBranch.TabIndex = 1;
            this.lblBranch.Text = "Branch*";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name*";
            // 
            // lblRelationType
            // 
            this.lblRelationType.AutoSize = true;
            this.lblRelationType.Location = new System.Drawing.Point(68, 218);
            this.lblRelationType.Name = "lblRelationType";
            this.lblRelationType.Size = new System.Drawing.Size(82, 15);
            this.lblRelationType.TabIndex = 3;
            this.lblRelationType.Text = "Relation Type*";
            // 
            // lblRelationName
            // 
            this.lblRelationName.AutoSize = true;
            this.lblRelationName.Location = new System.Drawing.Point(68, 263);
            this.lblRelationName.Name = "lblRelationName";
            this.lblRelationName.Size = new System.Drawing.Size(90, 15);
            this.lblRelationName.TabIndex = 4;
            this.lblRelationName.Text = "Relation Name*";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(68, 315);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 15);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address*";
            // 
            // ddBank
            // 
            this.ddBank.FormattingEnabled = true;
            this.ddBank.Items.AddRange(new object[] {
            "State Bank Of India"});
            this.ddBank.Location = new System.Drawing.Point(244, 96);
            this.ddBank.Name = "ddBank";
            this.ddBank.Size = new System.Drawing.Size(121, 23);
            this.ddBank.TabIndex = 7;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(243, 136);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(120, 23);
            this.txtBranch.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 23);
            this.txtName.TabIndex = 9;
            // 
            // ddRelationType
            // 
            this.ddRelationType.FormattingEnabled = true;
            this.ddRelationType.Items.AddRange(new object[] {
            "Son of",
            "Daughter of",
            "Wife of"});
            this.ddRelationType.Location = new System.Drawing.Point(242, 218);
            this.ddRelationType.Name = "ddRelationType";
            this.ddRelationType.Size = new System.Drawing.Size(121, 23);
            this.ddRelationType.TabIndex = 10;
            // 
            // txtRelationName
            // 
            this.txtRelationName.Location = new System.Drawing.Point(243, 260);
            this.txtRelationName.Name = "txtRelationName";
            this.txtRelationName.Size = new System.Drawing.Size(121, 23);
            this.txtRelationName.TabIndex = 11;
            this.txtRelationName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(243, 312);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 65);
            this.txtAddress.TabIndex = 12;
            // 
            // btnGeneratePdf
            // 
            this.btnGeneratePdf.Location = new System.Drawing.Point(366, 415);
            this.btnGeneratePdf.Name = "btnGeneratePdf";
            this.btnGeneratePdf.Size = new System.Drawing.Size(109, 23);
            this.btnGeneratePdf.TabIndex = 14;
            this.btnGeneratePdf.Text = "Generate PDF";
            this.btnGeneratePdf.UseVisualStyleBackColor = true;
            this.btnGeneratePdf.Click += new System.EventHandler(this.btnGeneratePdf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ornament*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quantity*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gross weight in grams";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Stone weight in grams";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quality*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Net weight in grams";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Market Price";
            // 
            // txtOrnament
            // 
            this.txtOrnament.Location = new System.Drawing.Point(670, 42);
            this.txtOrnament.Multiline = true;
            this.txtOrnament.Name = "txtOrnament";
            this.txtOrnament.Size = new System.Drawing.Size(113, 56);
            this.txtOrnament.TabIndex = 22;
            // 
            // txtGrossWeight
            // 
            this.txtGrossWeight.Location = new System.Drawing.Point(670, 144);
            this.txtGrossWeight.Name = "txtGrossWeight";
            this.txtGrossWeight.Size = new System.Drawing.Size(113, 23);
            this.txtGrossWeight.TabIndex = 23;
            this.txtGrossWeight.TextChanged += new System.EventHandler(this.txtGrossWeight_TextChanged);
            this.txtGrossWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrossWeight_KeyPress);
            // 
            // txtStoneWeight
            // 
            this.txtStoneWeight.Location = new System.Drawing.Point(670, 182);
            this.txtStoneWeight.Name = "txtStoneWeight";
            this.txtStoneWeight.Size = new System.Drawing.Size(113, 23);
            this.txtStoneWeight.TabIndex = 24;
            this.txtStoneWeight.TextChanged += new System.EventHandler(this.txtStoneWeight_TextChanged);
            this.txtStoneWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStoneWeight_KeyPress);
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(670, 226);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(113, 23);
            this.txtQuality.TabIndex = 25;
            this.txtQuality.TextChanged += new System.EventHandler(this.txtQuality_TextChanged);
            this.txtQuality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuality_KeyPress);
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.Location = new System.Drawing.Point(670, 268);
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.ReadOnly = true;
            this.txtNetWeight.Size = new System.Drawing.Size(113, 23);
            this.txtNetWeight.TabIndex = 26;
            // 
            // txtMarketPrice
            // 
            this.txtMarketPrice.Location = new System.Drawing.Point(670, 338);
            this.txtMarketPrice.Name = "txtMarketPrice";
            this.txtMarketPrice.ReadOnly = true;
            this.txtMarketPrice.Size = new System.Drawing.Size(113, 23);
            this.txtMarketPrice.TabIndex = 27;
            // 
            // ddQuantity
            // 
            this.ddQuantity.FormattingEnabled = true;
            this.ddQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "24",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.ddQuantity.Location = new System.Drawing.Point(670, 104);
            this.ddQuantity.Name = "ddQuantity";
            this.ddQuantity.Size = new System.Drawing.Size(113, 23);
            this.ddQuantity.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Today Rate*";
            // 
            // txtTodayRate
            // 
            this.txtTodayRate.Location = new System.Drawing.Point(245, 51);
            this.txtTodayRate.Name = "txtTodayRate";
            this.txtTodayRate.Size = new System.Drawing.Size(120, 23);
            this.txtTodayRate.TabIndex = 30;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(670, 382);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(113, 23);
            this.btnAddNew.TabIndex = 31;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gridOrnaments
            // 
            this.gridOrnaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrnaments.Location = new System.Drawing.Point(41, 447);
            this.gridOrnaments.Name = "gridOrnaments";
            this.gridOrnaments.RowTemplate.Height = 25;
            this.gridOrnaments.Size = new System.Drawing.Size(840, 141);
            this.gridOrnaments.TabIndex = 32;
            this.gridOrnaments.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridOrnaments_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridOrnaments);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtTodayRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ddQuantity);
            this.Controls.Add(this.txtMarketPrice);
            this.Controls.Add(this.txtNetWeight);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.txtStoneWeight);
            this.Controls.Add(this.txtGrossWeight);
            this.Controls.Add(this.txtOrnament);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeneratePdf);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtRelationName);
            this.Controls.Add(this.ddRelationType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.ddBank);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblRelationName);
            this.Controls.Add(this.lblRelationType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblBank);
            this.Name = "Form1";
            this.Text = "SBI Estimation";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrnaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRelationType;
        private System.Windows.Forms.Label lblRelationName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox ddBank;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox ddRelationType;
        private System.Windows.Forms.TextBox txtRelationName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnGeneratePdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrnament;
        private System.Windows.Forms.TextBox txtGrossWeight;
        private System.Windows.Forms.TextBox txtStoneWeight;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.TextBox txtNetWeight;
        private System.Windows.Forms.TextBox txtMarketPrice;
        private System.Windows.Forms.ComboBox ddQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTodayRate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView gridOrnaments;
        private System.Windows.Forms.Button button1;
    }
}

