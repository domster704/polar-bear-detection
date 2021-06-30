﻿
namespace PolatBearDetection
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.FindSubmenuPanel = new System.Windows.Forms.Panel();
            this.SaveResultImageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ChooseImageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FindButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FindBearSubMenuTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.CloseControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MaximizeControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimazeControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragPanelUp = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BearPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BordlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.UpPanelDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LogoDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FindSubmenuTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.SideMenuPanel.SuspendLayout();
            this.FindSubmenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.DragPanelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BearPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.SideMenuPanel.Controls.Add(this.FindSubmenuPanel);
            this.SideMenuPanel.Controls.Add(this.FindButton);
            this.SideMenuPanel.Controls.Add(this.LogoPictureBox);
            this.FindSubmenuTransition.SetDecoration(this.SideMenuPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.SideMenuPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(250, 600);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // FindSubmenuPanel
            // 
            this.FindSubmenuPanel.Controls.Add(this.SaveResultImageButton);
            this.FindSubmenuPanel.Controls.Add(this.ChooseImageButton);
            this.FindSubmenuTransition.SetDecoration(this.FindSubmenuPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.FindSubmenuPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindSubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FindSubmenuPanel.Location = new System.Drawing.Point(0, 175);
            this.FindSubmenuPanel.Name = "FindSubmenuPanel";
            this.FindSubmenuPanel.Size = new System.Drawing.Size(250, 155);
            this.FindSubmenuPanel.TabIndex = 2;
            this.FindSubmenuPanel.Visible = false;
            // 
            // SaveResultImageButton
            // 
            this.SaveResultImageButton.CheckedState.Parent = this.SaveResultImageButton;
            this.SaveResultImageButton.CustomImages.Parent = this.SaveResultImageButton;
            this.FindSubmenuTransition.SetDecoration(this.SaveResultImageButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.SaveResultImageButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SaveResultImageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveResultImageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveResultImageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveResultImageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveResultImageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveResultImageButton.DisabledState.Parent = this.SaveResultImageButton;
            this.SaveResultImageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveResultImageButton.FillColor = System.Drawing.Color.LightSkyBlue;
            this.SaveResultImageButton.FillColor2 = System.Drawing.Color.SkyBlue;
            this.SaveResultImageButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SaveResultImageButton.ForeColor = System.Drawing.Color.White;
            this.SaveResultImageButton.HoverState.Parent = this.SaveResultImageButton;
            this.SaveResultImageButton.Location = new System.Drawing.Point(0, 60);
            this.SaveResultImageButton.Name = "SaveResultImageButton";
            this.SaveResultImageButton.ShadowDecoration.Parent = this.SaveResultImageButton;
            this.SaveResultImageButton.Size = new System.Drawing.Size(250, 60);
            this.SaveResultImageButton.TabIndex = 1;
            this.SaveResultImageButton.Text = "Сохранить результат";
            // 
            // ChooseImageButton
            // 
            this.ChooseImageButton.CheckedState.Parent = this.ChooseImageButton;
            this.ChooseImageButton.CustomImages.Parent = this.ChooseImageButton;
            this.FindSubmenuTransition.SetDecoration(this.ChooseImageButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.ChooseImageButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ChooseImageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChooseImageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChooseImageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChooseImageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChooseImageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChooseImageButton.DisabledState.Parent = this.ChooseImageButton;
            this.ChooseImageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChooseImageButton.FillColor = System.Drawing.Color.LightSkyBlue;
            this.ChooseImageButton.FillColor2 = System.Drawing.Color.SkyBlue;
            this.ChooseImageButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ChooseImageButton.ForeColor = System.Drawing.Color.White;
            this.ChooseImageButton.HoverState.Parent = this.ChooseImageButton;
            this.ChooseImageButton.Location = new System.Drawing.Point(0, 0);
            this.ChooseImageButton.Name = "ChooseImageButton";
            this.ChooseImageButton.ShadowDecoration.Parent = this.ChooseImageButton;
            this.ChooseImageButton.Size = new System.Drawing.Size(250, 60);
            this.ChooseImageButton.TabIndex = 0;
            this.ChooseImageButton.Text = "Выбрать изображение";
            this.ChooseImageButton.Click += new System.EventHandler(this.ChooseImageButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.FindButton.CheckedState.Parent = this.FindButton;
            this.FindButton.CustomImages.Parent = this.FindButton;
            this.FindSubmenuTransition.SetDecoration(this.FindButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.FindButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FindButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FindButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FindButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FindButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FindButton.DisabledState.Parent = this.FindButton;
            this.FindButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FindButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(237)))), ((int)(((byte)(198)))));
            this.FindButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(237)))), ((int)(((byte)(198)))));
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.HoverState.Parent = this.FindButton;
            this.FindButton.Location = new System.Drawing.Point(0, 100);
            this.FindButton.Name = "FindButton";
            this.FindButton.ShadowDecoration.Parent = this.FindButton;
            this.FindButton.Size = new System.Drawing.Size(250, 75);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Поискать медведя";
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.BackgroundImage")));
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindBearSubMenuTransition.SetDecoration(this.LogoPictureBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindSubmenuTransition.SetDecoration(this.LogoPictureBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(250, 100);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // FindBearSubMenuTransition
            // 
            this.FindBearSubMenuTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.FindBearSubMenuTransition.DefaultAnimation = animation2;
            // 
            // CloseControlBox
            // 
            this.CloseControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindSubmenuTransition.SetDecoration(this.CloseControlBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.CloseControlBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CloseControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.CloseControlBox.HoverState.Parent = this.CloseControlBox;
            this.CloseControlBox.IconColor = System.Drawing.Color.White;
            this.CloseControlBox.Location = new System.Drawing.Point(654, 0);
            this.CloseControlBox.Name = "CloseControlBox";
            this.CloseControlBox.ShadowDecoration.Parent = this.CloseControlBox;
            this.CloseControlBox.Size = new System.Drawing.Size(45, 29);
            this.CloseControlBox.TabIndex = 2;
            // 
            // MaximizeControlBox
            // 
            this.MaximizeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.FindSubmenuTransition.SetDecoration(this.MaximizeControlBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.MaximizeControlBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MaximizeControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.MaximizeControlBox.HoverState.Parent = this.MaximizeControlBox;
            this.MaximizeControlBox.IconColor = System.Drawing.Color.White;
            this.MaximizeControlBox.Location = new System.Drawing.Point(609, 0);
            this.MaximizeControlBox.Name = "MaximizeControlBox";
            this.MaximizeControlBox.ShadowDecoration.Parent = this.MaximizeControlBox;
            this.MaximizeControlBox.Size = new System.Drawing.Size(45, 29);
            this.MaximizeControlBox.TabIndex = 3;
            // 
            // MinimazeControlBox
            // 
            this.MinimazeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimazeControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.MinimazeControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.FindSubmenuTransition.SetDecoration(this.MinimazeControlBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.MinimazeControlBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MinimazeControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.MinimazeControlBox.HoverState.Parent = this.MinimazeControlBox;
            this.MinimazeControlBox.IconColor = System.Drawing.Color.White;
            this.MinimazeControlBox.Location = new System.Drawing.Point(564, 0);
            this.MinimazeControlBox.Name = "MinimazeControlBox";
            this.MinimazeControlBox.ShadowDecoration.Parent = this.MinimazeControlBox;
            this.MinimazeControlBox.Size = new System.Drawing.Size(45, 29);
            this.MinimazeControlBox.TabIndex = 4;
            // 
            // DragPanelUp
            // 
            this.DragPanelUp.Controls.Add(this.MaximizeControlBox);
            this.DragPanelUp.Controls.Add(this.MinimazeControlBox);
            this.DragPanelUp.Controls.Add(this.CloseControlBox);
            this.FindSubmenuTransition.SetDecoration(this.DragPanelUp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.DragPanelUp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DragPanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanelUp.Location = new System.Drawing.Point(250, 0);
            this.DragPanelUp.Name = "DragPanelUp";
            this.DragPanelUp.ShadowDecoration.Parent = this.DragPanelUp;
            this.DragPanelUp.Size = new System.Drawing.Size(700, 28);
            this.DragPanelUp.TabIndex = 5;
            // 
            // label1
            // 
            this.FindBearSubMenuTransition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindSubmenuTransition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(245)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(250, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bear Found Label";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BearPictureBox
            // 
            this.BearPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindBearSubMenuTransition.SetDecoration(this.BearPictureBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindSubmenuTransition.SetDecoration(this.BearPictureBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BearPictureBox.Image = global::PolatBearDetection.Properties.Resources.logo1;
            this.BearPictureBox.ImageRotate = 0F;
            this.BearPictureBox.Location = new System.Drawing.Point(259, 100);
            this.BearPictureBox.Name = "BearPictureBox";
            this.BearPictureBox.ShadowDecoration.Parent = this.BearPictureBox;
            this.BearPictureBox.Size = new System.Drawing.Size(679, 410);
            this.BearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BearPictureBox.TabIndex = 7;
            this.BearPictureBox.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.FindSubmenuTransition.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(485, 531);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(196, 45);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Найти";
            // 
            // BordlessForm
            // 
            this.BordlessForm.AnimateWindow = true;
            this.BordlessForm.BorderRadius = 15;
            this.BordlessForm.ContainerControl = this;
            // 
            // UpPanelDragControl
            // 
            this.UpPanelDragControl.TargetControl = this.DragPanelUp;
            // 
            // LogoDragControl
            // 
            this.LogoDragControl.TargetControl = this.LogoPictureBox;
            // 
            // FindSubmenuTransition
            // 
            this.FindSubmenuTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.FindSubmenuTransition.DefaultAnimation = animation1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.BearPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DragPanelUp);
            this.Controls.Add(this.SideMenuPanel);
            this.FindSubmenuTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FindBearSubMenuTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polar Bear Detection";
            this.SideMenuPanel.ResumeLayout(false);
            this.FindSubmenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.DragPanelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BearPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private Guna.UI2.WinForms.Guna2Transition FindBearSubMenuTransition;
        private Guna.UI2.WinForms.Guna2BorderlessForm BordlessForm;
        private Guna.UI2.WinForms.Guna2ControlBox CloseControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox MinimazeControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeControlBox;
        private Guna.UI2.WinForms.Guna2Panel DragPanelUp;
        private Guna.UI2.WinForms.Guna2DragControl UpPanelDragControl;
        private Guna.UI2.WinForms.Guna2DragControl LogoDragControl;
        private Guna.UI2.WinForms.Guna2GradientButton FindButton;
        private Guna.UI2.WinForms.Guna2Transition FindSubmenuTransition;
        private System.Windows.Forms.Panel FindSubmenuPanel;
        private Guna.UI2.WinForms.Guna2GradientButton ChooseImageButton;
        private Guna.UI2.WinForms.Guna2GradientButton SaveResultImageButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox BearPictureBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

