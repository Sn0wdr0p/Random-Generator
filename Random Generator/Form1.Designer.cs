﻿namespace Random_Generator
{
    partial class mainWindow
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.password = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.excludedString = new System.Windows.Forms.TextBox();
            this.generatedPass = new System.Windows.Forms.Label();
            this.other = new System.Windows.Forms.CheckBox();
            this.extra = new System.Windows.Forms.CheckBox();
            this.common = new System.Windows.Forms.CheckBox();
            this.numbers = new System.Windows.Forms.CheckBox();
            this.lowerChars = new System.Windows.Forms.CheckBox();
            this.upperChars = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passLen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pin = new System.Windows.Forms.TabPage();
            this.pinLen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.colour = new System.Windows.Forms.RadioButton();
            this.bAndW = new System.Windows.Forms.RadioButton();
            this.savebtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.genBM = new System.Windows.Forms.Button();
            this.genPin = new System.Windows.Forms.Button();
            this.generatedPin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.password.SuspendLayout();
            this.pin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.password);
            this.tabControl.Controls.Add(this.pin);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(416, 410);
            this.tabControl.TabIndex = 0;
            // 
            // password
            // 
            this.password.Controls.Add(this.label3);
            this.password.Controls.Add(this.generate);
            this.password.Controls.Add(this.excludedString);
            this.password.Controls.Add(this.generatedPass);
            this.password.Controls.Add(this.other);
            this.password.Controls.Add(this.extra);
            this.password.Controls.Add(this.common);
            this.password.Controls.Add(this.numbers);
            this.password.Controls.Add(this.lowerChars);
            this.password.Controls.Add(this.upperChars);
            this.password.Controls.Add(this.label2);
            this.password.Controls.Add(this.passLen);
            this.password.Controls.Add(this.label1);
            this.password.Location = new System.Drawing.Point(4, 22);
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(3);
            this.password.Size = new System.Drawing.Size(408, 384);
            this.password.TabIndex = 0;
            this.password.Text = "Password";
            this.password.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Do not include the following characters:";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(96, 322);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(205, 36);
            this.generate.TabIndex = 13;
            this.generate.Text = "Generate Password";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // excludedString
            // 
            this.excludedString.Location = new System.Drawing.Point(201, 113);
            this.excludedString.Name = "excludedString";
            this.excludedString.Size = new System.Drawing.Size(100, 20);
            this.excludedString.TabIndex = 12;
            // 
            // generatedPass
            // 
            this.generatedPass.BackColor = System.Drawing.Color.Black;
            this.generatedPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generatedPass.Font = new System.Drawing.Font("Liberation Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedPass.ForeColor = System.Drawing.SystemColors.Control;
            this.generatedPass.Location = new System.Drawing.Point(9, 200);
            this.generatedPass.Name = "generatedPass";
            this.generatedPass.Size = new System.Drawing.Size(388, 105);
            this.generatedPass.TabIndex = 10;
            this.generatedPass.Text = "Generated password will display here...\r\n(Double click to copy to clipboard)";
            this.generatedPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generatedPass.DoubleClick += new System.EventHandler(this.generatedPass_DoubleClick);
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(221, 83);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(110, 17);
            this.other.TabIndex = 9;
            this.other.Text = "Other ( [\\]^_`{|}~ )";
            this.other.UseVisualStyleBackColor = true;
            // 
            // extra
            // 
            this.extra.AutoSize = true;
            this.extra.Checked = true;
            this.extra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.extra.Location = new System.Drawing.Point(61, 83);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(112, 17);
            this.extra.TabIndex = 8;
            this.extra.Text = "Extra ( ;:<=>?@£ )";
            this.extra.UseVisualStyleBackColor = true;
            // 
            // common
            // 
            this.common.AutoSize = true;
            this.common.Checked = true;
            this.common.CheckState = System.Windows.Forms.CheckState.Checked;
            this.common.Location = new System.Drawing.Point(249, 60);
            this.common.Name = "common";
            this.common.Size = new System.Drawing.Size(148, 17);
            this.common.TabIndex = 7;
            this.common.Text = "Common ( !\"#$%&\'()*+,-./\\ )";
            this.common.UseVisualStyleBackColor = true;
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Checked = true;
            this.numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbers.Location = new System.Drawing.Point(172, 60);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(47, 17);
            this.numbers.TabIndex = 6;
            this.numbers.Text = "0 - 9";
            this.numbers.UseVisualStyleBackColor = true;
            // 
            // lowerChars
            // 
            this.lowerChars.AutoSize = true;
            this.lowerChars.Checked = true;
            this.lowerChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowerChars.Location = new System.Drawing.Point(91, 60);
            this.lowerChars.Name = "lowerChars";
            this.lowerChars.Size = new System.Drawing.Size(46, 17);
            this.lowerChars.TabIndex = 5;
            this.lowerChars.Text = "a - z";
            this.lowerChars.UseVisualStyleBackColor = true;
            // 
            // upperChars
            // 
            this.upperChars.AutoSize = true;
            this.upperChars.Checked = true;
            this.upperChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upperChars.Location = new System.Drawing.Point(9, 60);
            this.upperChars.Name = "upperChars";
            this.upperChars.Size = new System.Drawing.Size(49, 17);
            this.upperChars.TabIndex = 4;
            this.upperChars.Text = "A - Z";
            this.upperChars.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please check the groups of characters you would like to make up the password...";
            // 
            // passLen
            // 
            this.passLen.Location = new System.Drawing.Point(143, 6);
            this.passLen.Name = "passLen";
            this.passLen.Size = new System.Drawing.Size(42, 20);
            this.passLen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desired Password Length:";
            // 
            // pin
            // 
            this.pin.Controls.Add(this.label8);
            this.pin.Controls.Add(this.generatedPin);
            this.pin.Controls.Add(this.genPin);
            this.pin.Controls.Add(this.pinLen);
            this.pin.Controls.Add(this.label4);
            this.pin.Location = new System.Drawing.Point(4, 22);
            this.pin.Name = "pin";
            this.pin.Padding = new System.Windows.Forms.Padding(3);
            this.pin.Size = new System.Drawing.Size(408, 384);
            this.pin.TabIndex = 1;
            this.pin.Text = "Pin";
            this.pin.UseVisualStyleBackColor = true;
            // 
            // pinLen
            // 
            this.pinLen.Location = new System.Drawing.Point(112, 10);
            this.pinLen.Name = "pinLen";
            this.pinLen.Size = new System.Drawing.Size(42, 20);
            this.pinLen.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Desired Pin Length:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.colour);
            this.tabPage1.Controls.Add(this.bAndW);
            this.tabPage1.Controls.Add(this.savebtn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.heightBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.widthBox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.genBM);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(408, 384);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Bitmap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // colour
            // 
            this.colour.AutoSize = true;
            this.colour.Checked = true;
            this.colour.Location = new System.Drawing.Point(188, 7);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(79, 17);
            this.colour.TabIndex = 8;
            this.colour.TabStop = true;
            this.colour.Text = "Multi-colour";
            this.colour.UseVisualStyleBackColor = true;
            // 
            // bAndW
            // 
            this.bAndW.AutoSize = true;
            this.bAndW.Location = new System.Drawing.Point(273, 7);
            this.bAndW.Name = "bAndW";
            this.bAndW.Size = new System.Drawing.Size(72, 17);
            this.bAndW.TabIndex = 7;
            this.bAndW.Text = "Grayscale";
            this.bAndW.UseVisualStyleBackColor = true;
            // 
            // savebtn
            // 
            this.savebtn.Enabled = false;
            this.savebtn.Location = new System.Drawing.Point(236, 327);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(169, 54);
            this.savebtn.TabIndex = 6;
            this.savebtn.Text = "Save This Image";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.saveImage);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Height:";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(141, 6);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(41, 20);
            this.heightBox.TabIndex = 4;
            this.heightBox.TextChanged += new System.EventHandler(this.widthHeightValidation);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Width:";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(47, 6);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(41, 20);
            this.widthBox.TabIndex = 2;
            this.widthBox.TextChanged += new System.EventHandler(this.widthHeightValidation);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // genBM
            // 
            this.genBM.Enabled = false;
            this.genBM.Location = new System.Drawing.Point(3, 327);
            this.genBM.Name = "genBM";
            this.genBM.Size = new System.Drawing.Size(169, 54);
            this.genBM.TabIndex = 0;
            this.genBM.Text = "Generate Bitmap Image";
            this.genBM.UseVisualStyleBackColor = true;
            this.genBM.Click += new System.EventHandler(this.genBitmap);
            // 
            // genPin
            // 
            this.genPin.Location = new System.Drawing.Point(9, 45);
            this.genPin.Name = "genPin";
            this.genPin.Size = new System.Drawing.Size(393, 52);
            this.genPin.TabIndex = 4;
            this.genPin.Text = "Generate your pin";
            this.genPin.UseVisualStyleBackColor = true;
            this.genPin.Click += new System.EventHandler(this.genPin_Click);
            // 
            // generatedPin
            // 
            this.generatedPin.BackColor = System.Drawing.Color.Black;
            this.generatedPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generatedPin.Font = new System.Drawing.Font("Liberation Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedPin.ForeColor = System.Drawing.SystemColors.Control;
            this.generatedPin.Location = new System.Drawing.Point(9, 162);
            this.generatedPin.Name = "generatedPin";
            this.generatedPin.Size = new System.Drawing.Size(393, 105);
            this.generatedPin.TabIndex = 11;
            this.generatedPin.Text = "(Double click to copy to clipboard)";
            this.generatedPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Your new randomly generated pin is:";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 434);
            this.Controls.Add(this.tabControl);
            this.Name = "mainWindow";
            this.Text = "Random Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.password.ResumeLayout(false);
            this.password.PerformLayout();
            this.pin.ResumeLayout(false);
            this.pin.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage password;
        private System.Windows.Forms.CheckBox upperChars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pin;
        private System.Windows.Forms.CheckBox lowerChars;
        private System.Windows.Forms.CheckBox other;
        private System.Windows.Forms.CheckBox extra;
        private System.Windows.Forms.CheckBox common;
        private System.Windows.Forms.CheckBox numbers;
        private System.Windows.Forms.TextBox excludedString;
        private System.Windows.Forms.Label generatedPass;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pinLen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button genBM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.RadioButton colour;
        private System.Windows.Forms.RadioButton bAndW;
        private System.Windows.Forms.Button genPin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label generatedPin;
    }
}

