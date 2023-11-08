
namespace Program2
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
            this.label1 = new System.Windows.Forms.Label();
            this.agelabel = new System.Windows.Forms.Label();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.healthInsuranceLabel = new System.Windows.Forms.Label();
            this.carInsuranceLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.carYearTextBox = new System.Windows.Forms.TextBox();
            this.smokeYesButton = new System.Windows.Forms.RadioButton();
            this.smokeNoButton = new System.Windows.Forms.RadioButton();
            this.carYesButton = new System.Windows.Forms.RadioButton();
            this.carNoButton = new System.Windows.Forms.RadioButton();
            this.policyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.healthOutputLabel = new System.Windows.Forms.Label();
            this.carOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.smokeGroupBox = new System.Windows.Forms.GroupBox();
            this.accidentGroupBox = new System.Windows.Forms.GroupBox();
            this.healthComboBox = new System.Windows.Forms.ComboBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.smokeGroupBox.SuspendLayout();
            this.accidentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cardinal Insurance Policy Calculator";
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Location = new System.Drawing.Point(40, 45);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(85, 13);
            this.agelabel.TabIndex = 1;
            this.agelabel.Text = "Enter Your  Age:";
            // 
            // carYearLabel
            // 
            this.carYearLabel.AutoSize = true;
            this.carYearLabel.Location = new System.Drawing.Point(43, 85);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(126, 13);
            this.carYearLabel.TabIndex = 2;
            this.carYearLabel.Text = "Manufacture Year of Car:";
            // 
            // healthInsuranceLabel
            // 
            this.healthInsuranceLabel.AutoSize = true;
            this.healthInsuranceLabel.Location = new System.Drawing.Point(43, 122);
            this.healthInsuranceLabel.Name = "healthInsuranceLabel";
            this.healthInsuranceLabel.Size = new System.Drawing.Size(140, 13);
            this.healthInsuranceLabel.TabIndex = 3;
            this.healthInsuranceLabel.Text = "Health Insurance Coverage:";
            // 
            // carInsuranceLabel
            // 
            this.carInsuranceLabel.AutoSize = true;
            this.carInsuranceLabel.Location = new System.Drawing.Point(43, 155);
            this.carInsuranceLabel.Name = "carInsuranceLabel";
            this.carInsuranceLabel.Size = new System.Drawing.Size(125, 13);
            this.carInsuranceLabel.TabIndex = 4;
            this.carInsuranceLabel.Text = "Car Insurance Coverage:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(330, 37);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // carYearTextBox
            // 
            this.carYearTextBox.Location = new System.Drawing.Point(330, 77);
            this.carYearTextBox.Name = "carYearTextBox";
            this.carYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.carYearTextBox.TabIndex = 6;
            // 
            // smokeYesButton
            // 
            this.smokeYesButton.AutoSize = true;
            this.smokeYesButton.Location = new System.Drawing.Point(284, 15);
            this.smokeYesButton.Name = "smokeYesButton";
            this.smokeYesButton.Size = new System.Drawing.Size(43, 17);
            this.smokeYesButton.TabIndex = 8;
            this.smokeYesButton.TabStop = true;
            this.smokeYesButton.Text = "Yes";
            this.smokeYesButton.UseVisualStyleBackColor = true;
            // 
            // smokeNoButton
            // 
            this.smokeNoButton.AutoSize = true;
            this.smokeNoButton.Location = new System.Drawing.Point(284, 38);
            this.smokeNoButton.Name = "smokeNoButton";
            this.smokeNoButton.Size = new System.Drawing.Size(39, 17);
            this.smokeNoButton.TabIndex = 9;
            this.smokeNoButton.TabStop = true;
            this.smokeNoButton.Text = "No";
            this.smokeNoButton.UseVisualStyleBackColor = true;
            // 
            // carYesButton
            // 
            this.carYesButton.AutoSize = true;
            this.carYesButton.Location = new System.Drawing.Point(280, 19);
            this.carYesButton.Name = "carYesButton";
            this.carYesButton.Size = new System.Drawing.Size(43, 17);
            this.carYesButton.TabIndex = 11;
            this.carYesButton.TabStop = true;
            this.carYesButton.Text = "Yes";
            this.carYesButton.UseVisualStyleBackColor = true;
            // 
            // carNoButton
            // 
            this.carNoButton.AutoSize = true;
            this.carNoButton.Location = new System.Drawing.Point(280, 42);
            this.carNoButton.Name = "carNoButton";
            this.carNoButton.Size = new System.Drawing.Size(39, 17);
            this.carNoButton.TabIndex = 12;
            this.carNoButton.TabStop = true;
            this.carNoButton.Text = "No";
            this.carNoButton.UseVisualStyleBackColor = true;
            // 
            // policyButton
            // 
            this.policyButton.Location = new System.Drawing.Point(166, 364);
            this.policyButton.Name = "policyButton";
            this.policyButton.Size = new System.Drawing.Size(145, 29);
            this.policyButton.TabIndex = 14;
            this.policyButton.Text = "Calculate Policy Premiums";
            this.policyButton.UseVisualStyleBackColor = true;
            this.policyButton.Click += new System.EventHandler(this.policyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Health Coverage Cost per Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Car Coverage Cost per Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total Policy Cost per Year:";
            // 
            // healthOutputLabel
            // 
            this.healthOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthOutputLabel.Location = new System.Drawing.Point(330, 415);
            this.healthOutputLabel.Name = "healthOutputLabel";
            this.healthOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.healthOutputLabel.TabIndex = 18;
            // 
            // carOutputLabel
            // 
            this.carOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carOutputLabel.Location = new System.Drawing.Point(330, 452);
            this.carOutputLabel.Name = "carOutputLabel";
            this.carOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.carOutputLabel.TabIndex = 19;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutputLabel.Location = new System.Drawing.Point(330, 484);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalOutputLabel.TabIndex = 20;
            // 
            // smokeGroupBox
            // 
            this.smokeGroupBox.Controls.Add(this.smokeYesButton);
            this.smokeGroupBox.Controls.Add(this.smokeNoButton);
            this.smokeGroupBox.Location = new System.Drawing.Point(46, 187);
            this.smokeGroupBox.Name = "smokeGroupBox";
            this.smokeGroupBox.Size = new System.Drawing.Size(366, 71);
            this.smokeGroupBox.TabIndex = 21;
            this.smokeGroupBox.TabStop = false;
            this.smokeGroupBox.Text = "Do you Smoke?";
            // 
            // accidentGroupBox
            // 
            this.accidentGroupBox.Controls.Add(this.carYesButton);
            this.accidentGroupBox.Controls.Add(this.carNoButton);
            this.accidentGroupBox.Location = new System.Drawing.Point(46, 264);
            this.accidentGroupBox.Name = "accidentGroupBox";
            this.accidentGroupBox.Size = new System.Drawing.Size(366, 68);
            this.accidentGroupBox.TabIndex = 22;
            this.accidentGroupBox.TabStop = false;
            this.accidentGroupBox.Text = "Car Accident in the Past Year?";
            // 
            // healthComboBox
            // 
            this.healthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.healthComboBox.FormattingEnabled = true;
            this.healthComboBox.Items.AddRange(new object[] {
            "EPO",
            "PPO",
            "HDP"});
            this.healthComboBox.Location = new System.Drawing.Point(330, 113);
            this.healthComboBox.Name = "healthComboBox";
            this.healthComboBox.Size = new System.Drawing.Size(100, 21);
            this.healthComboBox.TabIndex = 23;
            // 
            // carComboBox
            // 
            this.carComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Items.AddRange(new object[] {
            "Full",
            "Liability"});
            this.carComboBox.Location = new System.Drawing.Point(330, 146);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(100, 21);
            this.carComboBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 544);
            this.Controls.Add(this.carComboBox);
            this.Controls.Add(this.healthComboBox);
            this.Controls.Add(this.accidentGroupBox);
            this.Controls.Add(this.smokeGroupBox);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.carOutputLabel);
            this.Controls.Add(this.healthOutputLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.policyButton);
            this.Controls.Add(this.carYearTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.carInsuranceLabel);
            this.Controls.Add(this.healthInsuranceLabel);
            this.Controls.Add(this.carYearLabel);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Insurance Policy Calculator";
            this.smokeGroupBox.ResumeLayout(false);
            this.smokeGroupBox.PerformLayout();
            this.accidentGroupBox.ResumeLayout(false);
            this.accidentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.Label carYearLabel;
        private System.Windows.Forms.Label healthInsuranceLabel;
        private System.Windows.Forms.Label carInsuranceLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox carYearTextBox;
        private System.Windows.Forms.RadioButton smokeYesButton;
        private System.Windows.Forms.RadioButton smokeNoButton;
        private System.Windows.Forms.RadioButton carYesButton;
        private System.Windows.Forms.RadioButton carNoButton;
        private System.Windows.Forms.Button policyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label healthOutputLabel;
        private System.Windows.Forms.Label carOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.GroupBox smokeGroupBox;
        private System.Windows.Forms.GroupBox accidentGroupBox;
        private System.Windows.Forms.ComboBox healthComboBox;
        private System.Windows.Forms.ComboBox carComboBox;
    }
}

