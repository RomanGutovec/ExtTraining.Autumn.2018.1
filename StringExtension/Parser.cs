using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public static class Parser
    {
        public static int ToDecimal(this string source, int @base)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"Argument {nameof(source)} can't be empty");
            }

            if (@base < 2 || @base > 16)
            {
                throw new ArgumentOutOfRangeException(nameof(@base));
            }

            source = source.ToUpper();

            const string sourceToInsert = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            long rank = 1, result = 0;
            for (var i = source.Length - 1; i >= 0; i--)
            {
                var index = sourceToInsert.IndexOf(source[i]);
                if (index < 0 || index >= @base)
                {
                    throw new ArgumentException("Symbol is not used");
                }

                result += rank * index;
                rank *= @base;
            }
            if (result >= int.MaxValue)
            {
                throw new ArgumentException("Result is too big");
            }

            return (int)result;
        }
    }
}
