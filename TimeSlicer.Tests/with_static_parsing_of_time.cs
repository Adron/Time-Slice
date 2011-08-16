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
            var timePiece = TimePiece.Parse(sampleTimeOne);
            timePiece.Minute.ShouldBe(12);
        }

        [Test]
        public void should_return_a_time_piece_with_correct_am_meridian()
        {
            var timePiece = TimePiece.Parse(sampleTimeOne);
            timePiece.Meridian.ShouldBe("AM");
        }

        [Test]
        public void should_return_a_time_piece_with_correct_pm_meridian()
        {
            var timePiece = TimePiece.Parse(sampleTimeTwo);
            timePiece.Meridian.ShouldBe("PM");
        }

        [Test]
        public void should_return_a_time_piece_with_correct_military_hour()
        {
            var timePiece = TimePiece.Parse(sampleTimeTwo);
            timePiece.Minute.ShouldBe(30);
        }
    }
}