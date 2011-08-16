using System;
using NUnit.Framework;
using Shouldly;

namespace TimeSlicer.Tests
{
    [TestFixture]
    public class with_time_slicer
    {
        protected string sampleTimeOne = "10:12am";
        protected string sampleTimeTwo = "2:30pm";

        protected string sampleBadTimeOne = "43:10am";
        protected string sampleBadTimeTwo = "2:120pm";

        public void should_provide_time_piece_for_valid_time()
        {
            var timePiece = new TimePiece(sampleTimeOne);
            timePiece.ShouldNotBe(null);
        }

        public void should_provide_the_hour_for_the_parsed_time()
        {
            var timePiece = new TimePiece(sampleTimeOne);
            timePiece.Hour.ShouldBe(10);
        }

        public void should_provide_the_hour_in_military_time_for_the_parsed_time()
        {
            var timePiece = new TimePiece(sampleTimeTwo);
            timePiece.MilitaryHour.ShouldBe(14);
        }

        public void should_provide_the_minute()
        {
            var timePiece = new TimePiece(sampleTimeOne);
            timePiece.Minute.ShouldBe(12);
        }

        public void should_provide_the_minute_for_military_parsing()
        {
            var timePiece = new TimePiece(sampleTimeTwo);
            timePiece.Minute.ShouldBe(30);
        }
    }

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
