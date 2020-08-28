namespace AraSinav
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelClear = new System.Windows.Forms.LinkLabel();
            this.checkedListBoxPrice = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxProduct = new System.Windows.Forms.CheckedListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTitleTotal = new System.Windows.Forms.Label();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabelClear);
            this.groupBox1.Controls.Add(this.checkedListBoxPrice);
            this.groupBox1.Controls.Add(this.checkedListBoxProduct);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Listesi";
            // 
            // linkLabelClear
            // 
            this.linkLabelClear.AutoSize = true;
            this.linkLabelClear.Location = new System.Drawing.Point(172, 76);
            this.linkLabelClear.Name = "linkLabelClear";
            this.linkLabelClear.Size = new System.Drawing.Size(51, 15);
            this.linkLabelClear.TabIndex = 8;
            this.linkLabelClear.TabStop = true;
            this.linkLabelClear.Text = "Temizle";
            this.linkLabelClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClear_LinkClicked);
            // 
            // checkedListBoxPrice
            // 
            this.checkedListBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxPrice.FormattingEnabled = true;
            this.checkedListBoxPrice.HorizontalScrollbar = true;
            this.checkedListBoxPrice.Items.AddRange(new object[] {
            "294,99",
            "1624,55",
            "454,45"});
            this.checkedListBoxPrice.Location = new System.Drawing.Point(163, 103);
            this.checkedListBoxPrice.Name = "checkedListBoxPrice";
            this.checkedListBoxPrice.Size = new System.Drawing.Size(153, 148);
            this.checkedListBoxPrice.TabIndex = 7;
            this.checkedListBoxPrice.TabStop = false;
            this.checkedListBoxPrice.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPrice_SelectedIndexChanged);
            // 
            // checkedListBoxProduct
            // 
            this.checkedListBoxProduct.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBoxProduct.CausesValidation = false;
            this.checkedListBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxProduct.FormattingEnabled = true;
            this.checkedListBoxProduct.HorizontalScrollbar = true;
            this.checkedListBoxProduct.Items.AddRange(new object[] {
            "RAM",
            "CPU",
            "HARDDISK"});
            this.checkedListBoxProduct.Location = new System.Drawing.Point(9, 103);
            this.checkedListBoxProduct.Name = "checkedListBoxProduct";
            this.checkedListBoxProduct.Size = new System.Drawing.Size(148, 148);
            this.checkedListBoxProduct.TabIndex = 6;
            this.checkedListBoxProduct.TabStop = false;
            this.checkedListBoxProduct.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxProduct_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(241, 54);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(241, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(93, 52);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(130, 21);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduct.Location = new System.Drawing.Point(93, 21);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(130, 21);
            this.textBoxProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonClose);
            this.groupBox2.Controls.Add(this.labelTotal);
            this.groupBox2.Controls.Add(this.labelTitleTotal);
            this.groupBox2.Controls.Add(this.listBoxPrice);
            this.groupBox2.Controls.Add(this.listBoxProduct);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(357, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satılan Malzeme";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(233, 232);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 4;
            this.ButtonClose.Text = "Çıkış";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(111, 236);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 15);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "0 TL";
            // 
            // labelTitleTotal
            // 
            this.labelTitleTotal.AutoSize = true;
            this.labelTitleTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTotal.Location = new System.Drawing.Point(14, 236);
            this.labelTitleTotal.Name = "labelTitleTotal";
            this.labelTitleTotal.Size = new System.Drawing.Size(97, 15);
            this.labelTitleTotal.TabIndex = 2;
            this.labelTitleTotal.Text = "Ödenecek Tutar:";
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.HorizontalScrollbar = true;
            this.listBoxPrice.ItemHeight = 15;
            this.listBoxPrice.Location = new System.Drawing.Point(162, 25);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(146, 199);
            this.listBoxPrice.TabIndex = 1;
            this.listBoxPrice.TabStop = false;
            this.listBoxPrice.SelectedIndexChanged += new System.EventHandler(this.listBoxPrice_SelectedIndexChanged);
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.HorizontalScrollbar = true;
            this.listBoxProduct.ItemHeight = 15;
            this.listBoxProduct.Location = new System.Drawing.Point(17, 25);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(139, 199);
            this.listBoxProduct.TabIndex = 0;
            this.listBoxProduct.TabStop = false;
            this.listBoxProduct.SelectedIndexChanged += new System.EventHandler(this.listBoxProduct_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 293);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Yetkin Akyüz - OOP Midterm Project";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxPrice;
        private System.Windows.Forms.CheckedListBox checkedListBoxProduct;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTitleTotal;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.LinkLabel linkLabelClear;
        private System.Windows.Forms.Button ButtonClose;
    }
}

