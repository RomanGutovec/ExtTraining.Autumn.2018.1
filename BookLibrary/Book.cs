using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        private string title;
        private string author;
        private string publishingHouse;
        private int edition;
        private int year;
        private int pages;
        private decimal price;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string PublishingHouse
        {
            get { return publishingHouse; }
            set { publishingHouse = value; }
        }

        public int Edition
        {
            get { return edition; }
            set { edition = value; }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(year)} must be positive");
                }

                year = value;
            }
        }

        public int Pages
        {
            get
            {
                return pages;
            }

            set
            {
                if (pages <= 0)
                {
                    throw new ArgumentException($"{nameof(pages)} must be positive");
                }

                pages = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                if (price < 0)
                {
                    throw new ArgumentException($"{nameof(price)} must be positive");
                }

                price = value;
            }
        }

        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "G";
            }

            if (formatProvider == null)
            {
                formatProvider = CultureInfo.CurrentCulture;
            }

            switch (format.ToUpperInvariant())
            {
                case "G":
                    return string.Format("Book record: {0}, {1}, {2}, {3}, {4}, {5}", Author, Title, Year, PublishingHouse, Edition, Pages, formatProvider);
                case "A":
                    return string.Format("Book record: {0}, {1}, {2}, {3}", Author, Title, Year, PublishingHouse, formatProvider);
                case "L":
                    return string.Format("Book record: {0}, {1}, {2}", Author, Title, Year, formatProvider);
                case "M":
                    return string.Format("Book record: {0}, {1}", Author, Title, formatProvider);
                default:
                    throw new FormatException(string.Format("The {0} format string is not supported.", formatProvider));
            }
        }
    }
}
