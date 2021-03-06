﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compact_Agenda
{
    public partial class DLG_Events : Form
    {
        public Event Event { get; set; }
        private bool blockUpdate;
        public bool delete = false;
        public bool deleteCM = false;
        public DLG_Events()
        {
            InitializeComponent();
        }

        private void DLG_Events_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.positionEvents;
            PB_General.BackColor = Properties.Settings.Default.colorGeneral;
            PB_Travail.BackColor = Properties.Settings.Default.colorTravail;
            PB_Sante.BackColor = Properties.Settings.Default.colorSante;
            PB_Important.BackColor = Properties.Settings.Default.colorImportant;
            PB_Loisir.BackColor = Properties.Settings.Default.colorLoisir;
            PB_Autre.BackColor = Properties.Settings.Default.colorAutre;
            delete = false;
            EventToDLG();
            if(deleteCM)
                Effacer();
        }

        public static DateTime Klone(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);
        }

        private void EventToDLG()
        {
            if (Event != null)
            {
                TBX_Title.Text = Event.Title;
                TBX_Description.Text = Event.Description;
                blockUpdate = true;
                DTP_Date.Value = Klone(Event.Starting);
                NUD_DebutHeure.Value = Convert.ToInt32((Klone(Event.Starting).Hour));
                NUD_DebutMinute.Value = Convert.ToInt32((Klone(Event.Starting).Minute));
                NUD_FinHeure.Value = Convert.ToInt32((Klone(Event.Ending).Hour));
                NUD_FinMinute.Value = Convert.ToInt32((Klone(Event.Ending).Minute));


                blockUpdate = false;
            }
            else
                Event = new Event();
        }

        private void TBX_Title_TextChanged(object sender, EventArgs e)
        {
            Event.Title = TBX_Title.Text;
        }

        private void TBX_Description_TextChanged(object sender, EventArgs e)
        {
            Event.Description = TBX_Description.Text;
        }

        private void DTP_Date_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                DTP_Date.Value.Month,
                                                DTP_Date.Value.Day,
                                                DTP_Starting.Value.Hour,
                                                DTP_Starting.Value.Minute,
                                                0);

                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                            DTP_Date.Value.Month,
                                            DTP_Date.Value.Day,
                                            DTP_Ending.Value.Hour,
                                            DTP_Ending.Value.Minute,
                                            0);
            }
        }

        private void DTP_Starting_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 DTP_Starting.Value.Hour,
                                                 DTP_Starting.Value.Minute,
                                                 0);
            }
        }

        private void DTP_Ending_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {

                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                            DTP_Date.Value.Month,
                                            DTP_Date.Value.Day,
                                            DTP_Ending.Value.Hour,
                                            DTP_Ending.Value.Minute,
                                            0);
            }
        }

        private void Effacer()
        {
            if (MessageBox.Show("Voulez vous vraiment effacer cet événement ?") == System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                delete = true;
                this.Close();
            }
        }

        private void BTN_Effacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        private void DLG_Events_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.positionEvents = this.Location;
            Properties.Settings.Default.Save();
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void FBTN_Accepter_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void NUD_DebutHeure_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 Convert.ToInt32(NUD_DebutHeure.Value),
                                                 Convert.ToInt32(NUD_DebutMinute.Value),
                                                 0);
            }
        }

        private void NUD_DebutMinute_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 Convert.ToInt32(NUD_DebutHeure.Value),
                                                 Convert.ToInt32(NUD_DebutMinute.Value),
                                                 0);
            }
        }

        private void NUD_FinHeure_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 Convert.ToInt32(NUD_FinHeure.Value),
                                                 Convert.ToInt32(NUD_FinMinute.Value),
                                                 0);
            }
        }

        private void NUD_FinMinute_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 Convert.ToInt32(NUD_FinHeure.Value),
                                                 Convert.ToInt32(NUD_FinMinute.Value),
                                                 0);
            }
        }

        private void PB_General_MouseHover(object sender, EventArgs e)
        {
        }

        private void PB_General_MouseHover(object sender, MouseEventArgs e)
        {

        }

        private void PB_General_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() ==  System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorGeneral = dlg.Color;
                Properties.Settings.Default.Save();
                PB_General.BackColor = Properties.Settings.Default.colorGeneral;
            }
            
        }

        private void PB_Travail_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorTravail = dlg.Color;
                Properties.Settings.Default.Save();
                PB_Travail.BackColor = Properties.Settings.Default.colorTravail;
            }
           
        }

        private void PB_Sante_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorSante = dlg.Color;
                Properties.Settings.Default.Save();
                PB_Sante.BackColor = Properties.Settings.Default.colorSante;
            }
            
        }

        private void PB_Important_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorImportant = dlg.Color;
                Properties.Settings.Default.Save();
                PB_Important.BackColor = Properties.Settings.Default.colorImportant;
            }
            
        }

        private void PB_Loisir_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorLoisir = dlg.Color;
                Properties.Settings.Default.Save();
                PB_Loisir.BackColor = Properties.Settings.Default.colorLoisir;
            }
            
        }

        private void PB_Autre_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorAutre = dlg.Color;
                Properties.Settings.Default.Save();
                PB_Autre.BackColor = Properties.Settings.Default.colorAutre;
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Event.eventColor = Properties.Settings.Default.colorGeneral;
        }
    }
}
