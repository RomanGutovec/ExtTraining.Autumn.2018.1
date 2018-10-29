using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExtension
{
    //maybe pattern adapter
    public class BookFormatExtension : IFormatProvider, ICustomFormatter
    {
        IFormatProvider _parent;

        public BookFormatExtension() : this(CultureInfo.CurrentCulture) { }
        public BookFormatExtension(IFormatProvider parent)
        {
            _parent = parent;
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter)) return this;
            return null;
        }

        public string Format(string format, object arg, IFormatProvider prov)
        {
            // If it's not our format string, defer to the parent provider:
            if (arg == null || format != "W")
                return string.Format(_parent, "{0:" + format + "}", arg);

            
            return String.Format("Book record: {0}", arg, prov);
        }
    }
}
