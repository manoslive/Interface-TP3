namespace Compact_Agenda
{
    partial class Form_WeekView
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
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.FBTN_DecrementWeek = new FlashButton.FlashButton();
            this.PN_Frame = new System.Windows.Forms.Panel();
            this.PN_Scroll = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Content = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Hours = new Compact_Agenda.DoubleBufferPanel();
            this.PN_DaysHeader = new Compact_Agenda.DoubleBufferPanel();
            this.CM_Event = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMI_Modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_Effacer = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_Reporter = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_Dupliquer = new System.Windows.Forms.ToolStripMenuItem();
            this.PN_Frame.SuspendLayout();
            this.PN_Scroll.SuspendLayout();
            this.CM_Event.SuspendLayout();
            this.SuspendLayout();
            // 
            // FBTN_IncrementWeek
            // 
            this.FBTN_IncrementWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBTN_IncrementWeek.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Right_Neutral;
            this.FBTN_IncrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_IncrementWeek.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Right_Click;
            this.FBTN_IncrementWeek.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Right_Disable;
            this.FBTN_IncrementWeek.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Right_Neutral;
            this.FBTN_IncrementWeek.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Right_Over;
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(1062, 3);
            this.FBTN_IncrementWeek.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(48, 49);
            this.FBTN_IncrementWeek.TabIndex = 3;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // FBTN_DecrementWeek
            // 
            this.FBTN_DecrementWeek.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Left_Neutral;
            this.FBTN_DecrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_DecrementWeek.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Left_Neutral;
            this.FBTN_DecrementWeek.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Left_Disable;
            this.FBTN_DecrementWeek.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Left_Neutral;
            this.FBTN_DecrementWeek.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Left_Over;
            this.FBTN_DecrementWeek.Location = new System.Drawing.Point(4, 3);
            this.FBTN_DecrementWeek.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FBTN_DecrementWeek.Name = "FBTN_DecrementWeek";
            this.FBTN_DecrementWeek.Size = new System.Drawing.Size(48, 49);
            this.FBTN_DecrementWeek.TabIndex = 2;
            this.FBTN_DecrementWeek.Click += new System.EventHandler(this.FBTN_DecrementWeek_Click);
            // 
            // PN_Frame
            // 
            this.PN_Frame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Frame.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PN_Frame.Controls.Add(this.PN_Scroll);
            this.PN_Frame.Controls.Add(this.FBTN_DecrementWeek);
            this.PN_Frame.Controls.Add(this.FBTN_IncrementWeek);
            this.PN_Frame.Controls.Add(this.PN_DaysHeader);
            this.PN_Frame.Location = new System.Drawing.Point(0, 0);
            this.PN_Frame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PN_Frame.Name = "PN_Frame";
            this.PN_Frame.Size = new System.Drawing.Size(1114, 906);
            this.PN_Frame.TabIndex = 4;
            // 
            // PN_Scroll
            // 
            this.PN_Scroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Scroll.AutoScroll = true;
            this.PN_Scroll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PN_Scroll.Controls.Add(this.PN_Content);
            this.PN_Scroll.Controls.Add(this.PN_Hours);
            this.PN_Scroll.Location = new System.Drawing.Point(4, 52);
            this.PN_Scroll.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Scroll.Name = "PN_Scroll";
            this.PN_Scroll.Size = new System.Drawing.Size(1106, 849);
            this.PN_Scroll.TabIndex = 1;
            this.PN_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PN_Scroll_Scroll);
            this.PN_Scroll.Resize += new System.EventHandler(this.PN_Scroll_Resize);
            // 
            // PN_Content
            // 
            this.PN_Content.Location = new System.Drawing.Point(54, 0);
            this.PN_Content.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PN_Content.Name = "PN_Content";
            this.PN_Content.Size = new System.Drawing.Size(942, 803);
            this.PN_Content.TabIndex = 0;
            this.PN_Content.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Content_Paint);
            this.PN_Content.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseClick);
            this.PN_Content.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDoubleClick);
            this.PN_Content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDown);
            this.PN_Content.MouseEnter += new System.EventHandler(this.PN_Scroll_MouseEnter);
            this.PN_Content.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseMove);
            this.PN_Content.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseUp);
            this.PN_Content.Resize += new System.EventHandler(this.PN_Content_Resize);
            // 
            // PN_Hours
            // 
            this.PN_Hours.Location = new System.Drawing.Point(0, 0);
            this.PN_Hours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PN_Hours.Name = "PN_Hours";
            this.PN_Hours.Size = new System.Drawing.Size(54, 797);
            this.PN_Hours.TabIndex = 1;
            this.PN_Hours.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Hours_Paint);
            // 
            // PN_DaysHeader
            // 
            this.PN_DaysHeader.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PN_DaysHeader.Location = new System.Drawing.Point(58, 3);
            this.PN_DaysHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PN_DaysHeader.Name = "PN_DaysHeader";
            this.PN_DaysHeader.Size = new System.Drawing.Size(942, 49);
            this.PN_DaysHeader.TabIndex = 0;
            this.PN_DaysHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_DaysHeader_Paint);
            // 
            // CM_Event
            // 
            this.CM_Event.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMI_Modifier,
            this.CMI_Effacer,
            this.CMI_Reporter,
            this.CMI_Dupliquer});
            this.CM_Event.Name = "CM_Event";
            this.CM_Event.Size = new System.Drawing.Size(273, 124);
            // 
            // CMI_Modifier
            // 
            this.CMI_Modifier.Name = "CMI_Modifier";
            this.CMI_Modifier.Size = new System.Drawing.Size(272, 30);
            this.CMI_Modifier.Text = "Modifier...";
            this.CMI_Modifier.Click += new System.EventHandler(this.CMI_Modifier_Click);
            // 
            // CMI_Effacer
            // 
            this.CMI_Effacer.Name = "CMI_Effacer";
            this.CMI_Effacer.Size = new System.Drawing.Size(272, 30);
            this.CMI_Effacer.Text = "Effacer...";
            this.CMI_Effacer.Click += new System.EventHandler(this.CMI_Effacer_Click);
            // 
            // CMI_Reporter
            // 
            this.CMI_Reporter.Name = "CMI_Reporter";
            this.CMI_Reporter.Size = new System.Drawing.Size(272, 30);
            this.CMI_Reporter.Text = "Reporter d\'une semaine";
            this.CMI_Reporter.Click += new System.EventHandler(this.CMI_Reporter_Click);
            // 
            // CMI_Dupliquer
            // 
            this.CMI_Dupliquer.Name = "CMI_Dupliquer";
            this.CMI_Dupliquer.Size = new System.Drawing.Size(272, 30);
            this.CMI_Dupliquer.Text = "Dupliquer...";
            this.CMI_Dupliquer.Click += new System.EventHandler(this.CMI_Dupliquer_Click);
            // 
            // Form_WeekView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 906);
            this.Controls.Add(this.PN_Frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(889, 739);
            this.Name = "Form_WeekView";
            this.Text = "Agenda compacte...";
            this.Load += new System.EventHandler(this.Form_WeekView_Load);
            this.PN_Frame.ResumeLayout(false);
            this.PN_Scroll.ResumeLayout(false);
            this.CM_Event.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel PN_DaysHeader;
        private DoubleBufferPanel PN_Scroll;
        private DoubleBufferPanel PN_Content;
        private DoubleBufferPanel PN_Hours;
        private FlashButton.FlashButton FBTN_DecrementWeek;
        private FlashButton.FlashButton FBTN_IncrementWeek;
        private System.Windows.Forms.Panel PN_Frame;
        private System.Windows.Forms.ContextMenuStrip CM_Event;
        private System.Windows.Forms.ToolStripMenuItem CMI_Modifier;
        private System.Windows.Forms.ToolStripMenuItem CMI_Effacer;
        private System.Windows.Forms.ToolStripMenuItem CMI_Reporter;
        private System.Windows.Forms.ToolStripMenuItem CMI_Dupliquer;

    }
}