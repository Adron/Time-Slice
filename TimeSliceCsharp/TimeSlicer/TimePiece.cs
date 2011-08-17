using System;

namespace TimeSlicer
{
    public class TimePiece
    {
        public TimePiece(string time)
        {
            Hour = Convert.ToInt32(time.Split(Convert.ToChar(":"))[0]);
            MilitaryHour = Convert.ToInt32(time.Split(Convert.ToChar(":"))[0]) + 12;
            var parsed = time.Split(Convert.ToChar(":"))[1];
            Minute = Convert.ToInt32(parsed.Remove(parsed.Length - 2, 2));
            Meridian = time.Substring(time.Length - 2, 2).ToUpper();
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