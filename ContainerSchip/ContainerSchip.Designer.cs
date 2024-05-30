using System.Windows.Forms;

namespace ContainerSchip
{
    partial class ContainerSchip
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
            this.lblWidth = new System.Windows.Forms.Label();
            this.nupLength = new System.Windows.Forms.NumericUpDown();
            this.nupWidth = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.nupWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.gbBoatControls = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nupHeight = new System.Windows.Forms.NumericUpDown();
            this.gbContainerControls = new System.Windows.Forms.GroupBox();
            this.cbCoolable = new System.Windows.Forms.CheckBox();
            this.cbValuable = new System.Windows.Forms.CheckBox();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lbContainers = new System.Windows.Forms.ListBox();
            this.buttonRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).BeginInit();
            this.gbBoatControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).BeginInit();
            this.gbContainerControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(23, 36);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 16);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width";
            // 
            // nupLength
            // 
            this.nupLength.Location = new System.Drawing.Point(27, 55);
            this.nupLength.Margin = new System.Windows.Forms.Padding(4);
            this.nupLength.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nupLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupLength.Name = "nupLength";
            this.nupLength.Size = new System.Drawing.Size(77, 22);
            this.nupLength.TabIndex = 3;
            this.nupLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nupWidth
            // 
            this.nupWidth.Location = new System.Drawing.Point(25, 109);
            this.nupWidth.Margin = new System.Windows.Forms.Padding(4);
            this.nupWidth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nupWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupWidth.Name = "nupWidth";
            this.nupWidth.Size = new System.Drawing.Size(79, 22);
            this.nupWidth.TabIndex = 5;
            this.nupWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(25, 89);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(47, 16);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length";
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(30, 248);
            this.btnAddContainer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(129, 28);
            this.btnAddContainer.TabIndex = 8;
            this.btnAddContainer.Text = "AddContainer";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // nupWeight
            // 
            this.nupWeight.Location = new System.Drawing.Point(25, 52);
            this.nupWeight.Margin = new System.Windows.Forms.Padding(4);
            this.nupWeight.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupWeight.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nupWeight.Name = "nupWeight";
            this.nupWeight.Size = new System.Drawing.Size(79, 22);
            this.nupWeight.TabIndex = 11;
            this.nupWeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(25, 32);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(49, 16);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Weight";
            // 
            // gbBoatControls
            // 
            this.gbBoatControls.Controls.Add(this.buttonRun);
            this.gbBoatControls.Controls.Add(this.lblHeight);
            this.gbBoatControls.Controls.Add(this.nupHeight);
            this.gbBoatControls.Controls.Add(this.lblWidth);
            this.gbBoatControls.Controls.Add(this.nupLength);
            this.gbBoatControls.Controls.Add(this.lblLength);
            this.gbBoatControls.Controls.Add(this.nupWidth);
            this.gbBoatControls.Location = new System.Drawing.Point(236, 255);
            this.gbBoatControls.Margin = new System.Windows.Forms.Padding(4);
            this.gbBoatControls.Name = "gbBoatControls";
            this.gbBoatControls.Padding = new System.Windows.Forms.Padding(4);
            this.gbBoatControls.Size = new System.Drawing.Size(169, 284);
            this.gbBoatControls.TabIndex = 13;
            this.gbBoatControls.TabStop = false;
            this.gbBoatControls.Text = "Ship";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(25, 150);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(46, 16);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height";
            // 
            // nupHeight
            // 
            this.nupHeight.Location = new System.Drawing.Point(25, 170);
            this.nupHeight.Margin = new System.Windows.Forms.Padding(4);
            this.nupHeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupHeight.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nupHeight.Name = "nupHeight";
            this.nupHeight.Size = new System.Drawing.Size(79, 22);
            this.nupHeight.TabIndex = 7;
            this.nupHeight.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // gbContainerControls
            // 
            this.gbContainerControls.Controls.Add(this.cbCoolable);
            this.gbContainerControls.Controls.Add(this.cbValuable);
            this.gbContainerControls.Controls.Add(this.nupAmount);
            this.gbContainerControls.Controls.Add(this.label1);
            this.gbContainerControls.Controls.Add(this.lblType);
            this.gbContainerControls.Controls.Add(this.nupWeight);
            this.gbContainerControls.Controls.Add(this.btnAddContainer);
            this.gbContainerControls.Controls.Add(this.lblWeight);
            this.gbContainerControls.Location = new System.Drawing.Point(16, 255);
            this.gbContainerControls.Margin = new System.Windows.Forms.Padding(4);
            this.gbContainerControls.Name = "gbContainerControls";
            this.gbContainerControls.Padding = new System.Windows.Forms.Padding(4);
            this.gbContainerControls.Size = new System.Drawing.Size(200, 284);
            this.gbContainerControls.TabIndex = 14;
            this.gbContainerControls.TabStop = false;
            this.gbContainerControls.Text = "Container";
            // 
            // cbCoolable
            // 
            this.cbCoolable.AutoSize = true;
            this.cbCoolable.Location = new System.Drawing.Point(29, 139);
            this.cbCoolable.Margin = new System.Windows.Forms.Padding(4);
            this.cbCoolable.Name = "cbCoolable";
            this.cbCoolable.Size = new System.Drawing.Size(84, 20);
            this.cbCoolable.TabIndex = 18;
            this.cbCoolable.Text = "Coolable";
            this.cbCoolable.UseVisualStyleBackColor = true;
            // 
            // cbValuable
            // 
            this.cbValuable.AutoSize = true;
            this.cbValuable.Location = new System.Drawing.Point(29, 111);
            this.cbValuable.Margin = new System.Windows.Forms.Padding(4);
            this.cbValuable.Name = "cbValuable";
            this.cbValuable.Size = new System.Drawing.Size(83, 20);
            this.cbValuable.TabIndex = 17;
            this.cbValuable.Text = "Valuable";
            this.cbValuable.UseVisualStyleBackColor = true;
            // 
            // nupAmount
            // 
            this.nupAmount.Location = new System.Drawing.Point(27, 196);
            this.nupAmount.Margin = new System.Windows.Forms.Padding(4);
            this.nupAmount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(79, 22);
            this.nupAmount.TabIndex = 15;
            this.nupAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Amount";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(25, 91);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // lbContainers
            // 
            this.lbContainers.FormattingEnabled = true;
            this.lbContainers.ItemHeight = 16;
            this.lbContainers.Location = new System.Drawing.Point(26, 13);
            this.lbContainers.Margin = new System.Windows.Forms.Padding(4);
            this.lbContainers.Name = "lbContainers";
            this.lbContainers.Size = new System.Drawing.Size(379, 228);
            this.lbContainers.TabIndex = 15;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(25, 248);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(129, 28);
            this.buttonRun.TabIndex = 19;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // ContainerSchip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbContainers);
            this.Controls.Add(this.gbContainerControls);
            this.Controls.Add(this.gbBoatControls);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContainerSchip";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).EndInit();
            this.gbBoatControls.ResumeLayout(false);
            this.gbBoatControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).EndInit();
            this.gbContainerControls.ResumeLayout(false);
            this.gbContainerControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nupLength;
        private System.Windows.Forms.NumericUpDown nupWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nupWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.GroupBox gbBoatControls;
        private System.Windows.Forms.GroupBox gbContainerControls;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnAddContainer;
        private NumericUpDown nupAmount;
        private Label label1;
        private CheckBox cbValuable;
        private CheckBox cbCoolable;
        private ListBox lbContainers;
        private Label lblHeight;
        private NumericUpDown nupHeight;
        private Button buttonRun;
    }
}

