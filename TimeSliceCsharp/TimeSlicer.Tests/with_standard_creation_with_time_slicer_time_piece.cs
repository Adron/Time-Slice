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
        public void should_provide_the_minute()
        {
            var timePiece = new TimePiece(sampleTimeOne);
            timePiece.Minute.ShouldBe(12);
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

        [Test]
        public void should_return_military_time_for_12_am()
        {
            var timePiece = new TimePiece("12:00am");
            timePiece.Military.ShouldBe(0);
        }

        [Test]
        public void should_return_military_time_for_12_am_plus_some()
        {
            var timePiece = new TimePiece("12:26am");
            timePiece.Military.ShouldBe(26);
        }

        [Test]
        public void should_return_military_time_for_12_pm()
        {
            var timePiece = new TimePiece("12:00pm");
            timePiece.Military.ShouldBe(1200);
        }

        [Test]
        public void should_return_military_time_for_pm_meridian_time()
        {
            var timePiece = new TimePiece("3:15pm");
            timePiece.Military.ShouldBe(315);
        }

        [Test]
        public void should_return_military_time_for_am_meridian_time()
        {
            var timePiece = new TimePiece("5:23am");
            timePiece.Military.ShouldBe(1723);
        }
    }
}
