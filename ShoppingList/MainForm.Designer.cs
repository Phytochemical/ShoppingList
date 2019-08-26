namespace ShoppingList
{
    partial class MainForm
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
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxShoppingList = new System.Windows.Forms.ListBox();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.comboBox1);
            this.groupBoxInput.Controls.Add(this.textBox1);
            this.groupBoxInput.Controls.Add(this.labelAmount);
            this.groupBoxInput.Controls.Add(this.c);
            this.groupBoxInput.Controls.Add(this.labelDescription);
            this.groupBoxInput.Location = new System.Drawing.Point(14, 13);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(338, 100);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(8, 58);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount";
            this.labelAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(74, 20);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(242, 20);
            this.c.TabIndex = 1;
            this.c.TextChanged += new System.EventHandler(this.c_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(8, 20);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(364, 48);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // listBoxShoppingList
            // 
            this.listBoxShoppingList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxShoppingList.FormattingEnabled = true;
            this.listBoxShoppingList.ItemHeight = 14;
            this.listBoxShoppingList.Location = new System.Drawing.Point(14, 129);
            this.listBoxShoppingList.Name = "listBoxShoppingList";
            this.listBoxShoppingList.Size = new System.Drawing.Size(494, 242);
            this.listBoxShoppingList.TabIndex = 2;
            this.listBoxShoppingList.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 397);
            this.Controls.Add(this.listBoxShoppingList);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxShoppingList;
    }
}

