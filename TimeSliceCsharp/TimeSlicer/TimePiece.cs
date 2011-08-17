using System;

namespace TimeSlicer
{
    public class TimePiece
    {
        public TimePiece(string time)
        {
            ParseTime(time);
        }

        private void ParseTime(string time)
        {
            SetHour(time);
            SetMilitaryHour(time);
            SetMinute(time);
            SetMeridian(time);
        }

        private void SetMeridian(string time)
        {
            Meridian = time.Substring(time.Length - 2, 2).ToUpper();
        }

        private void SetMinute(string time)
        {
            var parsed = time.Split(Convert.ToChar(":"))[1];
            Minute = Convert.ToInt32(parsed.Remove(parsed.Length - 2, 2));
        }

        private void SetMilitaryHour(string time)
        {
            MilitaryHour = Convert.ToInt32(time.Split(Convert.ToChar(":"))[0]) + 12;
        }

        private void SetHour(string time)
        {
            Hour = Convert.ToInt32(time.Split(Convert.ToChar(":"))[0]);
        }

        public string Error { get; set; }
        public int Hour { get; set; }
        public int MilitaryHour { get; set; }
        public int Minute { get; set; }
        public string Meridian { get; set; }

        public static TimePiece Parse(string time)
        {
            return new TimePiece(time);
        }
    }
}