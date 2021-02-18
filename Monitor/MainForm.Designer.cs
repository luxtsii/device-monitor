namespace Monitor
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
            this.deviceContainer = new System.Windows.Forms.ListView();
            this.devicesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.devicesIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.devicesStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newDeviceButton = new System.Windows.Forms.Button();
            this.statusControls = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.theGoodPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusControls.SuspendLayout();
            this.theGoodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceContainer
            // 
            this.deviceContainer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.devicesName,
            this.devicesIP,
            this.devicesStatus});
            this.deviceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceContainer.HideSelection = false;
            this.deviceContainer.Location = new System.Drawing.Point(3, 3);
            this.deviceContainer.Name = "deviceContainer";
            this.deviceContainer.Scrollable = false;
            this.deviceContainer.Size = new System.Drawing.Size(268, 260);
            this.deviceContainer.TabIndex = 0;
            this.deviceContainer.UseCompatibleStateImageBehavior = false;
            this.deviceContainer.View = System.Windows.Forms.View.Details;
            // 
            // devicesName
            // 
            this.devicesName.Text = "Name";
            // 
            // devicesIP
            // 
            this.devicesIP.Text = "IP";
            // 
            // devicesStatus
            // 
            this.devicesStatus.Text = "Status";
            // 
            // newDeviceButton
            // 
            this.newDeviceButton.Location = new System.Drawing.Point(72, 154);
            this.newDeviceButton.Name = "newDeviceButton";
            this.newDeviceButton.Size = new System.Drawing.Size(110, 23);
            this.newDeviceButton.TabIndex = 0;
            this.newDeviceButton.Text = "Create New Device";
            this.newDeviceButton.UseVisualStyleBackColor = true;
            this.newDeviceButton.Click += new System.EventHandler(this.newDeviceButton_Click);
            // 
            // statusControls
            // 
            this.statusControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusControls.Controls.Add(this.label2);
            this.statusControls.Controls.Add(this.descBox);
            this.statusControls.Controls.Add(this.addressBox);
            this.statusControls.Controls.Add(this.addressLabel);
            this.statusControls.Controls.Add(this.label1);
            this.statusControls.Controls.Add(this.nameBox);
            this.statusControls.Controls.Add(this.newDeviceButton);
            this.statusControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusControls.Location = new System.Drawing.Point(277, 3);
            this.statusControls.Name = "statusControls";
            this.statusControls.Size = new System.Drawing.Size(230, 260);
            this.statusControls.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description:";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(72, 59);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(110, 89);
            this.descBox.TabIndex = 5;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(72, 33);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(110, 20);
            this.addressBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(6, 36);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(72, 7);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(110, 20);
            this.nameBox.TabIndex = 1;
            // 
            // theGoodPanel
            // 
            this.theGoodPanel.ColumnCount = 2;
            this.theGoodPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.theGoodPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.theGoodPanel.Controls.Add(this.deviceContainer, 0, 0);
            this.theGoodPanel.Controls.Add(this.statusControls, 1, 0);
            this.theGoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theGoodPanel.Location = new System.Drawing.Point(0, 0);
            this.theGoodPanel.Name = "theGoodPanel";
            this.theGoodPanel.RowCount = 1;
            this.theGoodPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.theGoodPanel.Size = new System.Drawing.Size(510, 266);
            this.theGoodPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 266);
            this.Controls.Add(this.theGoodPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 266);
            this.Name = "MainForm";
            this.Text = "Device Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.statusControls.ResumeLayout(false);
            this.statusControls.PerformLayout();
            this.theGoodPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView deviceContainer;
        private System.Windows.Forms.ColumnHeader devicesName;
        private System.Windows.Forms.ColumnHeader devicesIP;
        private System.Windows.Forms.ColumnHeader devicesStatus;
        private System.Windows.Forms.Button newDeviceButton;
        private System.Windows.Forms.Panel statusControls;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.TableLayoutPanel theGoodPanel;
    }
}