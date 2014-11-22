namespace Compact_Agenda
{
    partial class DLG_Events
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
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_Description = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP_Starting = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_Ending = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.FBTN_Close = new FlashButton.FlashButton();
            this.FBTN_Accepter = new FlashButton.FlashButton();
            this.NUD_DebutHeure = new System.Windows.Forms.NumericUpDown();
            this.NUD_DebutMinute = new System.Windows.Forms.NumericUpDown();
            this.NUD_FinHeure = new System.Windows.Forms.NumericUpDown();
            this.NUD_FinMinute = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DebutHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DebutMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FinHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FinMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Title
            // 
            this.TBX_Title.Location = new System.Drawing.Point(105, 18);
            this.TBX_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(186, 26);
            this.TBX_Title.TabIndex = 0;
            this.TBX_Title.TextChanged += new System.EventHandler(this.TBX_Title_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // TBX_Description
            // 
            this.TBX_Description.Location = new System.Drawing.Point(105, 58);
            this.TBX_Description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBX_Description.Multiline = true;
            this.TBX_Description.Name = "TBX_Description";
            this.TBX_Description.Size = new System.Drawing.Size(186, 255);
            this.TBX_Description.TabIndex = 1;
            this.TBX_Description.TextChanged += new System.EventHandler(this.TBX_Description_TextChanged);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(105, 329);
            this.DTP_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTP_Date.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DTP_Date.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(186, 26);
            this.DTP_Date.TabIndex = 3;
            this.DTP_Date.ValueChanged += new System.EventHandler(this.DTP_Date_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date :";
            // 
            // DTP_Starting
            // 
            this.DTP_Starting.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Starting.Location = new System.Drawing.Point(105, 370);
            this.DTP_Starting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTP_Starting.Name = "DTP_Starting";
            this.DTP_Starting.Size = new System.Drawing.Size(120, 26);
            this.DTP_Starting.TabIndex = 4;
            this.DTP_Starting.ValueChanged += new System.EventHandler(this.DTP_Starting_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Début :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fin :";
            // 
            // DTP_Ending
            // 
            this.DTP_Ending.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Ending.Location = new System.Drawing.Point(105, 410);
            this.DTP_Ending.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTP_Ending.Name = "DTP_Ending";
            this.DTP_Ending.Size = new System.Drawing.Size(120, 26);
            this.DTP_Ending.TabIndex = 45;
            this.DTP_Ending.ValueChanged += new System.EventHandler(this.DTP_Ending_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(320, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 295);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catégorie";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(11, 254);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(73, 24);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Autre";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(11, 211);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(71, 24);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Loisir";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(11, 168);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 24);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Important";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 125);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 24);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Santé";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 24);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Travail";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Général";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(497, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 28);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(497, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 28);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(497, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 28);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(497, 186);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 28);
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(497, 229);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 28);
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(497, 272);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 28);
            this.pictureBox6.TabIndex = 48;
            this.pictureBox6.TabStop = false;
            // 
            // FBTN_Close
            // 
            this.FBTN_Close.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Close.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Click;
            this.FBTN_Close.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Disable;
            this.FBTN_Close.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Close.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Over;
            this.FBTN_Close.Location = new System.Drawing.Point(464, 406);
            this.FBTN_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_Close.Name = "FBTN_Close";
            this.FBTN_Close.Size = new System.Drawing.Size(40, 40);
            this.FBTN_Close.TabIndex = 49;
            this.FBTN_Close.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // FBTN_Accepter
            // 
            this.FBTN_Accepter.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Neutral;
            this.FBTN_Accepter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Accepter.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Click;
            this.FBTN_Accepter.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Disable;
            this.FBTN_Accepter.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Neutral;
            this.FBTN_Accepter.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Over;
            this.FBTN_Accepter.Location = new System.Drawing.Point(526, 406);
            this.FBTN_Accepter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_Accepter.Name = "FBTN_Accepter";
            this.FBTN_Accepter.Size = new System.Drawing.Size(40, 40);
            this.FBTN_Accepter.TabIndex = 49;
            this.FBTN_Accepter.Click += new System.EventHandler(this.FBTN_Accepter_Click);
            // 
            // NUD_DebutHeure
            // 
            this.NUD_DebutHeure.Location = new System.Drawing.Point(281, 373);
            this.NUD_DebutHeure.Name = "NUD_DebutHeure";
            this.NUD_DebutHeure.Size = new System.Drawing.Size(37, 26);
            this.NUD_DebutHeure.TabIndex = 50;
            this.NUD_DebutHeure.ValueChanged += new System.EventHandler(this.NUD_DebutHeure_ValueChanged);
            // 
            // NUD_DebutMinute
            // 
            this.NUD_DebutMinute.Location = new System.Drawing.Point(341, 373);
            this.NUD_DebutMinute.Name = "NUD_DebutMinute";
            this.NUD_DebutMinute.Size = new System.Drawing.Size(37, 26);
            this.NUD_DebutMinute.TabIndex = 50;
            // 
            // NUD_FinHeure
            // 
            this.NUD_FinHeure.Location = new System.Drawing.Point(281, 410);
            this.NUD_FinHeure.Name = "NUD_FinHeure";
            this.NUD_FinHeure.Size = new System.Drawing.Size(37, 26);
            this.NUD_FinHeure.TabIndex = 50;
            // 
            // NUD_FinMinute
            // 
            this.NUD_FinMinute.Location = new System.Drawing.Point(341, 410);
            this.NUD_FinMinute.Name = "NUD_FinMinute";
            this.NUD_FinMinute.Size = new System.Drawing.Size(37, 26);
            this.NUD_FinMinute.TabIndex = 50;
            // 
            // DLG_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 460);
            this.Controls.Add(this.NUD_FinMinute);
            this.Controls.Add(this.NUD_DebutMinute);
            this.Controls.Add(this.NUD_FinHeure);
            this.Controls.Add(this.NUD_DebutHeure);
            this.Controls.Add(this.FBTN_Accepter);
            this.Controls.Add(this.FBTN_Close);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTP_Ending);
            this.Controls.Add(this.DTP_Starting);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DLG_Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DLG_Events";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_Events_FormClosing);
            this.Load += new System.EventHandler(this.DLG_Events_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DebutHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DebutMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FinHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FinMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_Description;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP_Starting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_Ending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private FlashButton.FlashButton FBTN_Close;
        private FlashButton.FlashButton FBTN_Accepter;
        private System.Windows.Forms.NumericUpDown NUD_DebutHeure;
        private System.Windows.Forms.NumericUpDown NUD_DebutMinute;
        private System.Windows.Forms.NumericUpDown NUD_FinHeure;
        private System.Windows.Forms.NumericUpDown NUD_FinMinute;
    }
}