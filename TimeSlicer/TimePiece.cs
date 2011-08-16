using System;

namespace TimeSlicer
{
    public class TimePiece
    {
        public TimePiece(string time)
        {
            Hour = Convert.ToInt32(time.Split(Convert.ToChar(":"))[0]);
            MilitaryHour = Convert.ToInt32(time.Split(Convert.ToChar(":"))[0]) + 12;
            Minute = Convert.ToInt32(time.Split(Convert.ToChar(":"))[1]);
        }

        public string Error { get; set; }
        public int Hour { get; set; }
        public int MilitaryHour { get; set; }
        public int Minute { get; set; }
    }
}