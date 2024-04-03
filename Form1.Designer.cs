namespace Algoritmu_uzduotis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.deleteNodeButton = new System.Windows.Forms.Button();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.deleteEdgeButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.selectedFirstNodeLabel = new System.Windows.Forms.Label();
            this.eraseAllButton = new System.Windows.Forms.Button();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 444);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // addNodeButton
            // 
            this.addNodeButton.Location = new System.Drawing.Point(10, 470);
            this.addNodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(107, 22);
            this.addNodeButton.TabIndex = 1;
            this.addNodeButton.Text = "Add node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteNodeButton
            // 
            this.deleteNodeButton.Location = new System.Drawing.Point(10, 509);
            this.deleteNodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteNodeButton.Name = "deleteNodeButton";
            this.deleteNodeButton.Size = new System.Drawing.Size(107, 22);
            this.deleteNodeButton.TabIndex = 2;
            this.deleteNodeButton.Text = "Delete node";
            this.deleteNodeButton.UseVisualStyleBackColor = true;
            this.deleteNodeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Location = new System.Drawing.Point(144, 470);
            this.addEdgeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(107, 22);
            this.addEdgeButton.TabIndex = 3;
            this.addEdgeButton.Text = "Add edge";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.addEdgeButton_Click);
            // 
            // deleteEdgeButton
            // 
            this.deleteEdgeButton.Location = new System.Drawing.Point(144, 509);
            this.deleteEdgeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEdgeButton.Name = "deleteEdgeButton";
            this.deleteEdgeButton.Size = new System.Drawing.Size(107, 22);
            this.deleteEdgeButton.TabIndex = 4;
            this.deleteEdgeButton.Text = "Delete edge";
            this.deleteEdgeButton.UseVisualStyleBackColor = true;
            this.deleteEdgeButton.Click += new System.EventHandler(this.deleteEdgeButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(284, 470);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(107, 22);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Cancel";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // selectedFirstNodeLabel
            // 
            this.selectedFirstNodeLabel.AutoSize = true;
            this.selectedFirstNodeLabel.Location = new System.Drawing.Point(422, 477);
            this.selectedFirstNodeLabel.Name = "selectedFirstNodeLabel";
            this.selectedFirstNodeLabel.Size = new System.Drawing.Size(38, 15);
            this.selectedFirstNodeLabel.TabIndex = 6;
            this.selectedFirstNodeLabel.Text = "label1";
            this.selectedFirstNodeLabel.Click += new System.EventHandler(this.selectedFirstNodeLabel_Click);
            // 
            // eraseAllButton
            // 
            this.eraseAllButton.Location = new System.Drawing.Point(284, 509);
            this.eraseAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eraseAllButton.Name = "eraseAllButton";
            this.eraseAllButton.Size = new System.Drawing.Size(107, 22);
            this.eraseAllButton.TabIndex = 7;
            this.eraseAllButton.Text = "Erase All";
            this.eraseAllButton.UseVisualStyleBackColor = true;
            this.eraseAllButton.Click += new System.EventHandler(this.eraseAllButton_Click);
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(638, 470);
            this.startTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(44, 23);
            this.startTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 509);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(729, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(this.eraseAllButton);
            this.Controls.Add(this.selectedFirstNodeLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.deleteEdgeButton);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.deleteNodeButton);
            this.Controls.Add(this.addNodeButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button addNodeButton;
        private Button deleteNodeButton;
        private Button addEdgeButton;
        private Button deleteEdgeButton;
        private Button stopButton;
        private Label selectedFirstNodeLabel;
        private Button eraseAllButton;
        private TextBox startTextBox;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}