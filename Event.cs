﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compact_Agenda
{
    public class Event
    {
        public string Id { get; set; }
        public Color eventColor = Color.LightBlue;
        public string Title { get; set; }
        public string Description { get; set; }
        private DateTime _start;
        public DateTime Starting { get { return _start; } set { _start = RoundToMinutes(value, 5); } }
        private DateTime _End;
        public DateTime Ending { get { return _End; } set { _End = RoundToMinutes(value, 5); } }
        public System.Windows.Forms.Panel ParentPanel { get; set; }

        public Event()
        {
            Starting = DateTime.Now;
            Ending = DateTime.Now;
        }
        public Event(string Id, string Title, string Description, DateTime Starting, DateTime Ending)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description; ;
            this.Starting = Starting;
            this.Ending = Ending;
        }
        public Event(string Id, string Title, string Description, string Starting, string Ending)
        {
            this.Id = Id;
            this.Title = TextFilter.FromSql(Title);
            this.Description = TextFilter.FromSql(Description);
            this.Starting = DateTime.Parse(Starting);
            this.Ending = DateTime.Parse(Ending);
        }

        public Event(Event copy)
        {
            Id = copy.Id;
            Title = copy.Title;
            Description = copy.Description;
            Starting = copy.Starting;
            Ending = copy.Ending;
            ParentPanel = copy.ParentPanel;
        }
        public Event Klone()
        {
            Event klone = new Event(this);
            return klone;
        }

        public static DateTime RoundToMinutes(DateTime date, int minutes)
        {
            float totaMinutes = date.Hour * 60 + date.Minute;
            int roundedMinutes = (int)Math.Truncate((totaMinutes + minutes / 2f) / minutes) * minutes;
            int hours = (int)Math.Truncate(roundedMinutes / 60F);
            roundedMinutes = roundedMinutes - hours * 60;
            return new DateTime(date.Year, date.Month, date.Day, hours, roundedMinutes, 0);
        }

        public static int PixelToMinutes(int Pixel, int Height)
        {
            float totalMinutesInDay = 24F * 60F;
            float minutes = (Pixel / (float)Height) * totalMinutesInDay;
            return (int)minutes;
        }

        public static int HourToPixel(int Hour, int Minute, int Height)
        {
            float minutes = Hour * 60F + Minute;
            float totalMinutesInDay = 24F * 60F;
            return (int)Math.Round((minutes / totalMinutesInDay) * Height);
        }
        public static int HourToPixel(DateTime date, int Height)
        {
            return HourToPixel(date.Hour, date.Minute, Height);
        }

        public static int DayOfWeekToPixel(int dayNum, int Width)
        {
            return (int)Math.Round(dayNum / 7F * Width);
        }

        public static int DayOfWeekToPixel(DateTime date, int Width)
        {
            return DayOfWeekToPixel((int)date.DayOfWeek, Width);
        }

        public Rectangle GetBorder()
        {
            if (ParentPanel != null)
            {
                Point Location = new Point(DayOfWeekToPixel(Starting, ParentPanel.Width) + 1, HourToPixel(Starting, ParentPanel.Height));
                int Height = HourToPixel(Ending, ParentPanel.Height) - HourToPixel(Starting, ParentPanel.Height);
                int width = (int)Math.Round(ParentPanel.Width / 7F);

                Rectangle border = new Rectangle(Location, new Size(width - 2, Height));
                return border;
            }
            return new Rectangle();
        }

        public static string TwoDigits(int n)
        {
            return (n < 10 ? "0" : "") + n.ToString();
        }
        public static string TimeToString(DateTime date)
        {
            return TwoDigits(date.Hour) + ":" + TwoDigits(date.Minute);
        }
        public void Draw(Graphics DC)
        {
            DC.FillRectangle(new SolidBrush(eventColor), GetBorder());
            DC.DrawRectangle(new Pen(Color.Black, 1), GetBorder());
            string time = TimeToString(Starting) + "-" + TimeToString(Ending);

            int fontSize = 8;
            System.Windows.Forms.TextFormatFlags flags = System.Windows.Forms.TextFormatFlags.WordEllipsis | System.Windows.Forms.TextFormatFlags.HorizontalCenter;
            Rectangle border = GetBorder();
            fontSize += 6;

            System.Windows.Forms.TextRenderer.DrawText(DC, time, Properties.Settings.Default.fontEvenement, border, Color.Black, flags);
            border = new Rectangle(border.Location.X, border.Location.Y + fontSize, border.Width, border.Height - fontSize);

            System.Windows.Forms.TextRenderer.DrawText(DC, Title, Properties.Settings.Default.fontEvenementBold, border, Color.Black, flags);
            border = new Rectangle(border.Location.X, border.Location.Y + fontSize, border.Width, border.Height - fontSize);

            flags = System.Windows.Forms.TextFormatFlags.WordBreak;
            System.Windows.Forms.TextRenderer.DrawText(DC, Description, Properties.Settings.Default.fontEvenement, border, Color.Black, flags);
        }
    }
}
