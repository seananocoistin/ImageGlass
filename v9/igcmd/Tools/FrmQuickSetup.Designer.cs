﻿namespace igcmd.Tools
{
    partial class FrmQuickSetup
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
            ((System.ComponentModel.ISupportInitialize)Web2).BeginInit();
            SuspendLayout();
            // 
            // Web2
            // 
            Web2.DefaultBackgroundColor = Color.FromArgb(0, 255, 255, 255);
            Web2.Size = new Size(1200, 1500);
            Web2.Source = new Uri("about:blank", UriKind.Absolute);
            // 
            // FrmQuickSetup
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackdropStyle = ImageGlass.Base.BackdropStyle.Mica;
            ClientSize = new Size(1200, 1500);
            Name = "FrmQuickSetup";
            Text = "[ImageGlass Quick setup]";
            ((System.ComponentModel.ISupportInitialize)Web2).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}