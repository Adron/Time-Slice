using System;
using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;

namespace DateSlicer.Tests
{
    [TestFixture]
    public class with_a_month
    {
        [Test]
        public void should_return_the_month_for_january()
        {
            var slicer = new DateSlicer(DateTime.Parse("1/13/85 03:23:01"));
            slicer.MonthName().ShouldBe("January");
        }

        [Test]
        public void should_return_the_month_for_february()
        {
            var slicer = new DateSlicer(DateTime.Parse("2/13/85 03:23:01"));
            slicer.MonthName().ShouldBe("February");
        }

        [Test]
        public void should_return_the_month_for_july()
        {
            var slicer = new DateSlicer(DateTime.Parse("7/13/85 03:23:01"));
            slicer.MonthName().ShouldBe("July");
        }

        [Test]
        public void should_return_a_dictionary_of_months_with_the_first_being_january()
        {
            var months = DateSlicer.GetMonths();
            months[1].ShouldBe("January");
        }

        [Test]
        public void should_return_a_dictionary_of_months_with_the_last_being_december()
        {
            var months = DateSlicer.GetMonths();
            months[12].ShouldBe("December");
        }

        [Test]
        public void should_return_first_of_the_month()
        {
            var slicer = new DateSlicer(DateTime.Parse("7/13/85 03:23:01"));
            var result = DateTime.Parse("7/01/85");
            slicer.FirstOfMonth().ShouldBe(result);
        }

        [Test]
        public void should_return_the_last_day_of_the_month_for_july_of_85()
        {
            var slicer = new DateSlicer(DateTime.Parse("7/13/85"));
            var result = DateTime.Parse("7/31/85");
            slicer.LastOfMonth().ShouldBe(result);
        }

        [Test]
        public void should_return_the_last_day_of_the_month_for_february_of_2010()
        {
            var slicer = new DateSlicer(DateTime.Parse("2/13/10"));
            var result = DateTime.Parse("2/28/10");
            slicer.LastOfMonth().ShouldBe(result);
        }

        [Test]
        public void should_return_the_last_day_of_the_month_for_february_of_2012()
        {
            var slicer = new DateSlicer(DateTime.Parse("2/13/12"));
            var result = DateTime.Parse("2/29/12");
            slicer.LastOfMonth().ShouldBe(result);
        }
    }

  
}
