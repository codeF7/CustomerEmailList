namespace PersonAndCustomerClass
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxCustomerNumber = new System.Windows.Forms.TextBox();
            this.radioButtonMailingList = new System.Windows.Forms.RadioButton();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelTelephoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(112, 61);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 1;
            // 
            // textBoxTelephoneNumber
            // 
            this.textBoxTelephoneNumber.Location = new System.Drawing.Point(112, 83);
            this.textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            this.textBoxTelephoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelephoneNumber.TabIndex = 2;
            // 
            // textBoxCustomerNumber
            // 
            this.textBoxCustomerNumber.Location = new System.Drawing.Point(112, 109);
            this.textBoxCustomerNumber.Name = "textBoxCustomerNumber";
            this.textBoxCustomerNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerNumber.TabIndex = 3;
            // 
            // radioButtonMailingList
            // 
            this.radioButtonMailingList.AutoSize = true;
            this.radioButtonMailingList.Location = new System.Drawing.Point(12, 156);
            this.radioButtonMailingList.Name = "radioButtonMailingList";
            this.radioButtonMailingList.Size = new System.Drawing.Size(293, 17);
            this.radioButtonMailingList.TabIndex = 4;
            this.radioButtonMailingList.TabStop = true;
            this.radioButtonMailingList.Text = "Click here if you would like to be added to our mailing list.";
            this.radioButtonMailingList.UseVisualStyleBackColor = true;
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(58, 9);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(191, 13);
            this.labelPrompt.TabIndex = 5;
            this.labelPrompt.Text = "Please fill out the following information. ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(68, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(58, 64);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address:";
            // 
            // labelTelephoneNumber
            // 
            this.labelTelephoneNumber.AutoSize = true;
            this.labelTelephoneNumber.Location = new System.Drawing.Point(5, 86);
            this.labelTelephoneNumber.Name = "labelTelephoneNumber";
            this.labelTelephoneNumber.Size = new System.Drawing.Size(101, 13);
            this.labelTelephoneNumber.TabIndex = 8;
            this.labelTelephoneNumber.Text = "Telephone Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer Number:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(39, 200);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 50);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(155, 200);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 50);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 262);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTelephoneNumber);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.radioButtonMailingList);
            this.Controls.Add(this.textBoxCustomerNumber);
            this.Controls.Add(this.textBoxTelephoneNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Customer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxTelephoneNumber;
        private System.Windows.Forms.TextBox textBoxCustomerNumber;
        private System.Windows.Forms.RadioButton radioButtonMailingList;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelTelephoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonExit;

    }
}

