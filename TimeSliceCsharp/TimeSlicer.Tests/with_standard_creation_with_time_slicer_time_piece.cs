using NUnit.Framework;
using Shouldly;

namespace TimeSlicer.Tests
{
    [TestFixture]
    public class with_standard_creation_with_time_slicer_time_piece
    {
        protected string sampleTimeOne = "10:12am";
        protected string sampleTimeTwo = "2:30pm";

        [Test]
        public void should_provide_time_piece_for_valid_time()
        {
            var timePiece = new TimePiece(sampleTimeOne);
            timePiece.ShouldNotBe(null);
        }

        [Test]
        public void should_provide_the_hour_for_the_parsed_time()
        {
            var timePiece = new TimePiece(sampleTimeOne);
            timePiece.Hour.ShouldBe(10);
        }

        [Test]
        public void should_provide_the_hour_in_military_time_for_the_parsed_time()
        {
            var timePiece = new TimePiece(sampleTimeTwo);
            timePiece.MilitaryHour.ShouldBe(14);
        }

        [Test]
        public void should_provide_the_minute()
        {
            var timePiece = new TimePiece(sampleTimeOne);
            timePiece.Minute.ShouldBe(12);
        }

        [Test]
        public void should_provide_the_minute_for_military_parsing()
        {
            var timePiece = new TimePiece(sampleTimeTwo);
            timePiece.Minute.ShouldBe(30);
        }

        [Test]
        public void should_provide_the_am_meridian()
        {
            var timePiece = new TimePiece(sampleTimeOne);
            timePiece.Meridian.ShouldBe("AM");
        }

        [Test]
        public void should_provide_the_pm_meridian()
        {
            var timePiece = new TimePiece(sampleTimeTwo);
            timePiece.Meridian.ShouldBe("PM");
        }
    }
}
