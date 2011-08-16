using NUnit.Framework;
using Shouldly;

namespace TimeSlicer.Tests
{
    [TestFixture]
    public class with_time_slicer
    {
        protected string sampleTimeOne = "2:30pm";
        protected string sampleTimeTwo = "10:12am";
        protected string sampleBadTimeOne = "43:10am";
        protected string sampleBadTimeTwo = "2:120pm";

        public void should_provide_time_piece_for_valid_time()
        {
            var timePiece = new TimePiece(sampleTimeOne);
            timePiece.ShouldNotBe(null);
        }

        public void should_provide_error_message_for_invalid_time()
        {
            var timePiece = new TimePiece(sampleBadTimeOne);
            timePiece.Error.ShouldMatch("Bad time entered. A valid time must be passed in for parsing.");
        }

        public void should_return_appropriate_hour()
        {
            
        }

        public void should_return_appropriate_minute()
        {

        }

        public void should_return_appropriate_meridian()
        {

        }


    }

    public class TimePiece
    {
        public TimePiece(string sampleTimeOne)
        {

        }

        public string Error
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}
