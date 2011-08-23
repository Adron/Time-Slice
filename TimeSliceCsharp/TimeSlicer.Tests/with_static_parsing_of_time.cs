using NUnit.Framework;
using Shouldly;

namespace TimeSlicer.Tests
{
    [TestFixture]
    public class with_static_parsing_of_time
    {
        protected string sampleTimeOne = "10:12am";
        protected string sampleTimeTwo = "2:30pm";

        [Test]
        public void should_return_a_time_piece_object()
        {
            var timePiece = TimePiece.Parse(sampleTimeOne);
            timePiece.ShouldBeTypeOf<TimePiece>();
        }

        [Test]
        public void should_return_a_time_piece_with_correct_hour()
        {
            var timePiece = TimePiece.Parse(sampleTimeOne);
            timePiece.Hour.ShouldBe(10);
        }

        [Test]
        public void should_return_a_time_piece_with_correct_minute()
        {
            var timePiece= TimePiece.Parse(sampleTimeOne);
            timePiece.Minute.ShouldBe(12);
        }

        [Test]
        public void should_return_a_time_piece_with_correct_am_meridian()
        {
            var timePiece= TimePiece.Parse(sampleTimeOne);
            timePiece.Meridian.ShouldBe("AM");
        }

        [Test]
        public void should_return_a_time_piece_with_correct_pm_meridian()
        {
            var timePiece= TimePiece.Parse(sampleTimeTwo);
            timePiece.Meridian.ShouldBe("PM");
        }

        [Test]
        public void should_return_military_time_for_12_am()
        {
            var timePiece = TimePiece.Parse("12:00am");
            timePiece.Military.ShouldBe(0);
        }

        [Test]
        public void should_return_military_time_for_12_am_plus_some()
        {
            var timePiece = TimePiece.Parse("12:26am");
            timePiece.Military.ShouldBe(26);
        }

        [Test]
        public void should_return_military_time_for_12_pm()
        {
            var timePiece = TimePiece.Parse("12:00pm");
            timePiece.Military.ShouldBe(1200);
        }

        [Test]
        public void should_return_military_time_for_pm_meridian_time()
        {
            var timePiece = TimePiece.Parse("3:15pm");
            timePiece.Military.ShouldBe(315);
        }

        [Test]
        public void should_return_military_time_for_am_meridian_time()
        {
            var timePiece = TimePiece.Parse("5:23am");
            timePiece.Military.ShouldBe(1723);
        }
    }
}