﻿namespace NewPMS
{
    partial class AddPrintersToGroup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrintersToGroup));
            this.PrinterlistView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UsergroupBox = new System.Windows.Forms.GroupBox();
            this.AddUserToGroup = new System.Windows.Forms.Button();
            this.GroupNamecomboBox = new System.Windows.Forms.ComboBox();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.UsergroupBox.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrinterlistView
            // 
            this.PrinterlistView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrinterlistView.CheckBoxes = true;
            this.PrinterlistView.LargeImageList = this.imageList1;
            this.PrinterlistView.Location = new System.Drawing.Point(-4, 53);
            this.PrinterlistView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrinterlistView.Name = "PrinterlistView";
            this.PrinterlistView.Size = new System.Drawing.Size(453, 332);
            this.PrinterlistView.SmallImageList = this.imageList1;
            this.PrinterlistView.TabIndex = 1;
            this.PrinterlistView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "download (2).jpg");
            // 
            // UsergroupBox
            // 
            this.UsergroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsergroupBox.Controls.Add(this.AddUserToGroup);
            this.UsergroupBox.Controls.Add(this.GroupNamecomboBox);
            this.UsergroupBox.Location = new System.Drawing.Point(456, 73);
            this.UsergroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsergroupBox.Name = "UsergroupBox";
            this.UsergroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsergroupBox.Size = new System.Drawing.Size(192, 302);
            this.UsergroupBox.TabIndex = 2;
            this.UsergroupBox.TabStop = false;
            this.UsergroupBox.Text = "Select Group";
            // 
            // AddUserToGroup
            // 
            this.AddUserToGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddUserToGroup.Location = new System.Drawing.Point(12, 171);
            this.AddUserToGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserToGroup.Name = "AddUserToGroup";
            this.AddUserToGroup.Size = new System.Drawing.Size(165, 27);
            this.AddUserToGroup.TabIndex = 1;
            this.AddUserToGroup.Text = "Add PrintersTo Group";
            this.AddUserToGroup.UseVisualStyleBackColor = true;
            this.AddUserToGroup.Click += new System.EventHandler(this.AddUserToGroup_Click);
            // 
            // GroupNamecomboBox
            // 
            this.GroupNamecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupNamecomboBox.FormattingEnabled = true;
            this.GroupNamecomboBox.Location = new System.Drawing.Point(11, 92);
            this.GroupNamecomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupNamecomboBox.Name = "GroupNamecomboBox";
            this.GroupNamecomboBox.Size = new System.Drawing.Size(165, 23);
            this.GroupNamecomboBox.TabIndex = 0;
            this.GroupNamecomboBox.Text = "--Select Group-- ";
            this.GroupNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.GroupNamecomboBox_SelectedIndexChanged);
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-3, -3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(498, 50);
            this.topPanel.Click += new System.EventHandler(this.topPanel_Click);
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.topPanel});
            this.shapeContainer1.Size = new System.Drawing.Size(659, 429);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 381);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(659, 48);
            this.bottomPanel.TabIndex = 11;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(543, 14);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddPrintersToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 429);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.UsergroupBox);
            this.Controls.Add(this.PrinterlistView);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPrintersToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPrintersToGroup";
            this.Load += new System.EventHandler(this.AddPrintersToGroup_Load);
            this.UsergroupBox.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PrinterlistView;
        private System.Windows.Forms.GroupBox UsergroupBox;
        private System.Windows.Forms.Button AddUserToGroup;
        private System.Windows.Forms.ComboBox GroupNamecomboBox;
        private System.Windows.Forms.ImageList imageList1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}