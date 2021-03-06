﻿namespace Compact_Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WeekView));
            this.PN_Frame = new System.Windows.Forms.Panel();
            this.CM_Event = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMI_Modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_Effacer = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_Reporter = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_Dupliquer = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_EnteteJour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMI_CouleurFond = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_CouleurLigne = new System.Windows.Forms.ToolStripMenuItem();
            this.dateSemaineCouranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_SemaineCourante = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMI_Ligne = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurLignesSecondaires = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeDesÉvênementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeTitreÉvênementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_EnteteHeures = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.couleurDeFondToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeLaPoliceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PN_Scroll = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Content = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Hours = new Compact_Agenda.DoubleBufferPanel();
            this.PN_DaysHeader = new Compact_Agenda.DoubleBufferPanel();
            this.FBTN_DecrementWeek = new FlashButton.FlashButton();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.PN_Frame.SuspendLayout();
            this.CM_Event.SuspendLayout();
            this.CM_EnteteJour.SuspendLayout();
            this.CM_SemaineCourante.SuspendLayout();
            this.CM_EnteteHeures.SuspendLayout();
            this.PN_Scroll.SuspendLayout();
            this.SuspendLayout();
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
            this.PN_Frame.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Frame_Paint);
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
            // CM_EnteteJour
            // 
            this.CM_EnteteJour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMI_CouleurFond,
            this.CMI_CouleurLigne,
            this.dateSemaineCouranteToolStripMenuItem});
            this.CM_EnteteJour.Name = "CM_SemaineCourante";
            this.CM_EnteteJour.Size = new System.Drawing.Size(278, 94);
            // 
            // CMI_CouleurFond
            // 
            this.CMI_CouleurFond.Name = "CMI_CouleurFond";
            this.CMI_CouleurFond.Size = new System.Drawing.Size(277, 30);
            this.CMI_CouleurFond.Text = "Couleur de fond...";
            // 
            // CMI_CouleurLigne
            // 
            this.CMI_CouleurLigne.Name = "CMI_CouleurLigne";
            this.CMI_CouleurLigne.Size = new System.Drawing.Size(277, 30);
            this.CMI_CouleurLigne.Text = "Couleur des lignes...";
            // 
            // dateSemaineCouranteToolStripMenuItem
            // 
            this.dateSemaineCouranteToolStripMenuItem.Name = "dateSemaineCouranteToolStripMenuItem";
            this.dateSemaineCouranteToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.dateSemaineCouranteToolStripMenuItem.Text = "Date semaine courante...";
            // 
            // CM_SemaineCourante
            // 
            this.CM_SemaineCourante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMI_Ligne,
            this.couleurLignesSecondaires,
            this.couleurDeFondToolStripMenuItem,
            this.policeDesÉvênementsToolStripMenuItem,
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem,
            this.policeTitreÉvênementToolStripMenuItem});
            this.CM_SemaineCourante.Name = "CM_SemaineCourante";
            this.CM_SemaineCourante.Size = new System.Drawing.Size(374, 184);
            // 
            // CMI_Ligne
            // 
            this.CMI_Ligne.Name = "CMI_Ligne";
            this.CMI_Ligne.Size = new System.Drawing.Size(373, 30);
            this.CMI_Ligne.Text = "Couleur lignes verticales...";
            this.CMI_Ligne.Click += new System.EventHandler(this.CMI_Ligne_Click);
            // 
            // couleurLignesSecondaires
            // 
            this.couleurLignesSecondaires.Name = "couleurLignesSecondaires";
            this.couleurLignesSecondaires.Size = new System.Drawing.Size(373, 30);
            this.couleurLignesSecondaires.Text = "Couleur lignes secondaires";
            this.couleurLignesSecondaires.Click += new System.EventHandler(this.couleurLignesHorizontalesToolStripMenuItem_Click);
            // 
            // couleurDeFondToolStripMenuItem
            // 
            this.couleurDeFondToolStripMenuItem.Name = "couleurDeFondToolStripMenuItem";
            this.couleurDeFondToolStripMenuItem.Size = new System.Drawing.Size(373, 30);
            this.couleurDeFondToolStripMenuItem.Text = "Couleur de fond...";
            this.couleurDeFondToolStripMenuItem.Click += new System.EventHandler(this.couleurDeFondToolStripMenuItem_Click);
            // 
            // policeDesÉvênementsToolStripMenuItem
            // 
            this.policeDesÉvênementsToolStripMenuItem.Name = "policeDesÉvênementsToolStripMenuItem";
            this.policeDesÉvênementsToolStripMenuItem.Size = new System.Drawing.Size(373, 30);
            this.policeDesÉvênementsToolStripMenuItem.Text = "Police description évênement...";
            this.policeDesÉvênementsToolStripMenuItem.Click += new System.EventHandler(this.policeDesÉvênementsToolStripMenuItem_Click);
            // 
            // couleurDeLaPoliceDesÉvênementsToolStripMenuItem
            // 
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem.Name = "couleurDeLaPoliceDesÉvênementsToolStripMenuItem";
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem.Size = new System.Drawing.Size(373, 30);
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem.Text = "Couleur de la police des évênements";
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem.Click += new System.EventHandler(this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem_Click);
            // 
            // policeTitreÉvênementToolStripMenuItem
            // 
            this.policeTitreÉvênementToolStripMenuItem.Name = "policeTitreÉvênementToolStripMenuItem";
            this.policeTitreÉvênementToolStripMenuItem.Size = new System.Drawing.Size(373, 30);
            this.policeTitreÉvênementToolStripMenuItem.Text = "Police titre évênement...";
            this.policeTitreÉvênementToolStripMenuItem.Click += new System.EventHandler(this.policeTitreÉvênementToolStripMenuItem_Click);
            // 
            // CM_EnteteHeures
            // 
            this.CM_EnteteHeures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleurDeFondToolStripMenuItem1,
            this.policeToolStripMenuItem1,
            this.couleurDeLaPoliceToolStripMenuItem1});
            this.CM_EnteteHeures.Name = "CM_EnteteHeures";
            this.CM_EnteteHeures.Size = new System.Drawing.Size(253, 94);
            // 
            // couleurDeFondToolStripMenuItem1
            // 
            this.couleurDeFondToolStripMenuItem1.Name = "couleurDeFondToolStripMenuItem1";
            this.couleurDeFondToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.couleurDeFondToolStripMenuItem1.Text = "Couleur de fond...";
            // 
            // policeToolStripMenuItem1
            // 
            this.policeToolStripMenuItem1.Name = "policeToolStripMenuItem1";
            this.policeToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.policeToolStripMenuItem1.Text = "Police...";
            // 
            // couleurDeLaPoliceToolStripMenuItem1
            // 
            this.couleurDeLaPoliceToolStripMenuItem1.Name = "couleurDeLaPoliceToolStripMenuItem1";
            this.couleurDeLaPoliceToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.couleurDeLaPoliceToolStripMenuItem1.Text = "Couleur de la police...";
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
            this.PN_Hours.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_Hours_MouseClick);
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
            this.PN_DaysHeader.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_DaysHeader_MouseClick);
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
            // Form_WeekView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 906);
            this.Controls.Add(this.PN_Frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(889, 739);
            this.Name = "Form_WeekView";
            this.Text = "Agenda compacte...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_WeekView_FormClosing);
            this.Load += new System.EventHandler(this.Form_WeekView_Load);
            this.PN_Frame.ResumeLayout(false);
            this.CM_Event.ResumeLayout(false);
            this.CM_EnteteJour.ResumeLayout(false);
            this.CM_SemaineCourante.ResumeLayout(false);
            this.CM_EnteteHeures.ResumeLayout(false);
            this.PN_Scroll.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip CM_EnteteJour;
        private System.Windows.Forms.ToolStripMenuItem CMI_CouleurFond;
        private System.Windows.Forms.ToolStripMenuItem CMI_CouleurLigne;
        private System.Windows.Forms.ToolStripMenuItem dateSemaineCouranteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CM_SemaineCourante;
        private System.Windows.Forms.ToolStripMenuItem CMI_Ligne;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeDesÉvênementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurDeLaPoliceDesÉvênementsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CM_EnteteHeures;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem couleurDeLaPoliceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem policeTitreÉvênementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurLignesSecondaires;

    }
}