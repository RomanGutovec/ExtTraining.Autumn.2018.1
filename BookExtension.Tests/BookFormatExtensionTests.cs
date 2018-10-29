using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace BookExtension.Tests
{
    [TestFixture]
    public class BookFormatExtensionTests
    {
        [Test]
        public void StringFormatTestW()
        {
            BookLibrary.Book actual = new BookLibrary.Book()
            {
                Title = "C# in Depth",
                Author = "Jon Skeet",
                Year = 2019,
                PublishingHouse = "Manning",
                Edition = 4,
                Pages = 900,
                Price = 40
            };

            CultureInfo culture = new CultureInfo("en-US");
            IFormatProvider fp = new BookFormatExtension();
            string expectedResult = "Book record: C# in Depth";
            Assert.AreEqual(expectedResult, string.Format(fp,"{0:W}",actual.Title));
        }
    }
}
