namespace Epicycloids
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.valCCycle = new System.Windows.Forms.TextBox();
            this.valBCycle = new System.Windows.Forms.TextBox();
            this.valACycle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pointACheck = new System.Windows.Forms.CheckBox();
            this.pointBCheck = new System.Windows.Forms.CheckBox();
            this.pointCCheck = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ABVisibleCheck = new System.Windows.Forms.CheckBox();
            this.BCVisibleCheck = new System.Windows.Forms.CheckBox();
            this.CAVisibleCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ARadius = new System.Windows.Forms.TextBox();
            this.BRadius = new System.Windows.Forms.TextBox();
            this.CRadius = new System.Windows.Forms.TextBox();
            this.xPos = new System.Windows.Forms.TextBox();
            this.yPos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.thetaText = new System.Windows.Forms.TextBox();
            this.intervalText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sizeCText = new System.Windows.Forms.TextBox();
            this.sizeBText = new System.Windows.Forms.TextBox();
            this.sizeAText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // valCCycle
            // 
            this.valCCycle.Location = new System.Drawing.Point(102, 91);
            this.valCCycle.Name = "valCCycle";
            this.valCCycle.Size = new System.Drawing.Size(100, 20);
            this.valCCycle.TabIndex = 6;
            this.valCCycle.Text = "1";
            this.valCCycle.TextChanged += new System.EventHandler(this.valCCycle_TextChanged);
            // 
            // valBCycle
            // 
            this.valBCycle.Location = new System.Drawing.Point(102, 61);
            this.valBCycle.Name = "valBCycle";
            this.valBCycle.Size = new System.Drawing.Size(100, 20);
            this.valBCycle.TabIndex = 5;
            this.valBCycle.Text = "1";
            this.valBCycle.TextChanged += new System.EventHandler(this.valBCycle_TextChanged);
            // 
            // valACycle
            // 
            this.valACycle.Location = new System.Drawing.Point(102, 32);
            this.valACycle.Name = "valACycle";
            this.valACycle.Size = new System.Drawing.Size(100, 20);
            this.valACycle.TabIndex = 4;
            this.valACycle.Text = "1";
            this.valACycle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First cycle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Second cycle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Third cycle:";
            // 
            // pointACheck
            // 
            this.pointACheck.AutoSize = true;
            this.pointACheck.Location = new System.Drawing.Point(208, 35);
            this.pointACheck.Name = "pointACheck";
            this.pointACheck.Size = new System.Drawing.Size(15, 14);
            this.pointACheck.TabIndex = 11;
            this.pointACheck.UseVisualStyleBackColor = true;
            this.pointACheck.CheckedChanged += new System.EventHandler(this.pointACheck_CheckedChanged);
            // 
            // pointBCheck
            // 
            this.pointBCheck.AutoSize = true;
            this.pointBCheck.Location = new System.Drawing.Point(208, 64);
            this.pointBCheck.Name = "pointBCheck";
            this.pointBCheck.Size = new System.Drawing.Size(15, 14);
            this.pointBCheck.TabIndex = 12;
            this.pointBCheck.UseVisualStyleBackColor = true;
            this.pointBCheck.CheckedChanged += new System.EventHandler(this.pointBCheck_CheckedChanged);
            // 
            // pointCCheck
            // 
            this.pointCCheck.AutoSize = true;
            this.pointCCheck.Location = new System.Drawing.Point(208, 94);
            this.pointCCheck.Name = "pointCCheck";
            this.pointCCheck.Size = new System.Drawing.Size(15, 14);
            this.pointCCheck.TabIndex = 13;
            this.pointCCheck.UseVisualStyleBackColor = true;
            this.pointCCheck.CheckedChanged += new System.EventHandler(this.pointCCheck_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ABVisibleCheck
            // 
            this.ABVisibleCheck.AutoSize = true;
            this.ABVisibleCheck.Location = new System.Drawing.Point(260, 34);
            this.ABVisibleCheck.Name = "ABVisibleCheck";
            this.ABVisibleCheck.Size = new System.Drawing.Size(73, 17);
            this.ABVisibleCheck.TabIndex = 15;
            this.ABVisibleCheck.Text = "AB Visible";
            this.ABVisibleCheck.UseVisualStyleBackColor = true;
            this.ABVisibleCheck.CheckedChanged += new System.EventHandler(this.ABVisibleCheck_CheckedChanged);
            // 
            // BCVisibleCheck
            // 
            this.BCVisibleCheck.AutoSize = true;
            this.BCVisibleCheck.Location = new System.Drawing.Point(260, 63);
            this.BCVisibleCheck.Name = "BCVisibleCheck";
            this.BCVisibleCheck.Size = new System.Drawing.Size(73, 17);
            this.BCVisibleCheck.TabIndex = 16;
            this.BCVisibleCheck.Text = "BC Visible";
            this.BCVisibleCheck.UseVisualStyleBackColor = true;
            this.BCVisibleCheck.CheckedChanged += new System.EventHandler(this.BCVisibleCheck_CheckedChanged);
            // 
            // CAVisibleCheck
            // 
            this.CAVisibleCheck.AutoSize = true;
            this.CAVisibleCheck.Location = new System.Drawing.Point(260, 93);
            this.CAVisibleCheck.Name = "CAVisibleCheck";
            this.CAVisibleCheck.Size = new System.Drawing.Size(73, 17);
            this.CAVisibleCheck.TabIndex = 17;
            this.CAVisibleCheck.Text = "CA Visible";
            this.CAVisibleCheck.UseVisualStyleBackColor = true;
            this.CAVisibleCheck.CheckedChanged += new System.EventHandler(this.CAVisibleCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Radius:";
            // 
            // ARadius
            // 
            this.ARadius.Location = new System.Drawing.Point(344, 32);
            this.ARadius.Name = "ARadius";
            this.ARadius.Size = new System.Drawing.Size(100, 20);
            this.ARadius.TabIndex = 19;
            this.ARadius.Text = "100";
            this.ARadius.TextChanged += new System.EventHandler(this.ARadius_TextChanged);
            // 
            // BRadius
            // 
            this.BRadius.Location = new System.Drawing.Point(344, 61);
            this.BRadius.Name = "BRadius";
            this.BRadius.Size = new System.Drawing.Size(100, 20);
            this.BRadius.TabIndex = 20;
            this.BRadius.Text = "100";
            this.BRadius.TextChanged += new System.EventHandler(this.BRadius_TextChanged);
            // 
            // CRadius
            // 
            this.CRadius.Location = new System.Drawing.Point(344, 91);
            this.CRadius.Name = "CRadius";
            this.CRadius.Size = new System.Drawing.Size(100, 20);
            this.CRadius.TabIndex = 21;
            this.CRadius.Text = "100";
            this.CRadius.TextChanged += new System.EventHandler(this.CRadius_TextChanged);
            // 
            // xPos
            // 
            this.xPos.Location = new System.Drawing.Point(101, 200);
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(100, 20);
            this.xPos.TabIndex = 22;
            this.xPos.Text = "50";
            this.xPos.TextChanged += new System.EventHandler(this.xPos_TextChanged);
            // 
            // yPos
            // 
            this.yPos.Location = new System.Drawing.Point(101, 226);
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(101, 20);
            this.yPos.TabIndex = 23;
            this.yPos.Text = "50";
            this.yPos.TextChanged += new System.EventHandler(this.yPos_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "x position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "y position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Angle:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Interval:";
            // 
            // thetaText
            // 
            this.thetaText.Location = new System.Drawing.Point(344, 119);
            this.thetaText.Name = "thetaText";
            this.thetaText.Size = new System.Drawing.Size(99, 20);
            this.thetaText.TabIndex = 28;
            this.thetaText.Text = "1";
            this.thetaText.TextChanged += new System.EventHandler(this.thetaText_TextChanged);
            // 
            // intervalText
            // 
            this.intervalText.Location = new System.Drawing.Point(344, 151);
            this.intervalText.Name = "intervalText";
            this.intervalText.Size = new System.Drawing.Size(100, 20);
            this.intervalText.TabIndex = 29;
            this.intervalText.Text = "10";
            this.intervalText.TextChanged += new System.EventHandler(this.intervalText_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Size:";
            // 
            // sizeCText
            // 
            this.sizeCText.Location = new System.Drawing.Point(465, 91);
            this.sizeCText.Name = "sizeCText";
            this.sizeCText.Size = new System.Drawing.Size(100, 20);
            this.sizeCText.TabIndex = 32;
            this.sizeCText.Text = "1";
            this.sizeCText.TextChanged += new System.EventHandler(this.sizeCText_TextChanged);
            // 
            // sizeBText
            // 
            this.sizeBText.Location = new System.Drawing.Point(465, 61);
            this.sizeBText.Name = "sizeBText";
            this.sizeBText.Size = new System.Drawing.Size(100, 20);
            this.sizeBText.TabIndex = 31;
            this.sizeBText.Text = "1";
            this.sizeBText.TextChanged += new System.EventHandler(this.sizeBText_TextChanged);
            // 
            // sizeAText
            // 
            this.sizeAText.Location = new System.Drawing.Point(464, 32);
            this.sizeAText.Name = "sizeAText";
            this.sizeAText.Size = new System.Drawing.Size(101, 20);
            this.sizeAText.TabIndex = 30;
            this.sizeAText.Text = "1";
            this.sizeAText.TextChanged += new System.EventHandler(this.sizeAText_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sizeCText);
            this.Controls.Add(this.sizeBText);
            this.Controls.Add(this.sizeAText);
            this.Controls.Add(this.intervalText);
            this.Controls.Add(this.thetaText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.xPos);
            this.Controls.Add(this.CRadius);
            this.Controls.Add(this.BRadius);
            this.Controls.Add(this.ARadius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CAVisibleCheck);
            this.Controls.Add(this.BCVisibleCheck);
            this.Controls.Add(this.ABVisibleCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pointCCheck);
            this.Controls.Add(this.pointBCheck);
            this.Controls.Add(this.pointACheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valCCycle);
            this.Controls.Add(this.valBCycle);
            this.Controls.Add(this.valACycle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox valCCycle;
        private System.Windows.Forms.TextBox valBCycle;
        private System.Windows.Forms.TextBox valACycle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox pointACheck;
        private System.Windows.Forms.CheckBox pointBCheck;
        private System.Windows.Forms.CheckBox pointCCheck;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ABVisibleCheck;
        private System.Windows.Forms.CheckBox BCVisibleCheck;
        private System.Windows.Forms.CheckBox CAVisibleCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ARadius;
        private System.Windows.Forms.TextBox BRadius;
        private System.Windows.Forms.TextBox CRadius;
        private System.Windows.Forms.TextBox xPos;
        private System.Windows.Forms.TextBox yPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox thetaText;
        private System.Windows.Forms.TextBox intervalText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sizeCText;
        private System.Windows.Forms.TextBox sizeBText;
        private System.Windows.Forms.TextBox sizeAText;
    }
}