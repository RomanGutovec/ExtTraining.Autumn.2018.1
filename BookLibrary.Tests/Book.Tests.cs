using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BookLibrary.Tests
{
    [TestFixture]
    public class BookTest
    {
        [Test]
        public void StringFormatTestA()
        {
            Book actual = new Book
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
            string expectedResult = "Book record: Jon Skeet, C# in Depth, 2019, Manning";
            Assert.AreEqual(expectedResult, actual.ToString("A", culture));
        }

        [Test]
        public void StringFormatTestL()
        {
            Book actual = new Book
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
            string expectedResult = "Book record: Jon Skeet, C# in Depth, 2019";
            Assert.AreEqual(expectedResult, actual.ToString("L", culture));
        }

        [Test]
        public void StringFormatTestM()
        {
            Book actual = new Book
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
            string expectedResult = "Book record: Jon Skeet, C# in Depth";
            Assert.AreEqual(expectedResult, actual.ToString("M", culture));
        }

        [Test]
        public void StringFormatTestG()
        {
            Book actual = new Book
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
            string expectedResult = "Book record: Jon Skeet, C# in Depth, 2019, Manning, 4, 900";
            Assert.AreEqual(expectedResult, actual.ToString("G", culture));
        }
    }
}
