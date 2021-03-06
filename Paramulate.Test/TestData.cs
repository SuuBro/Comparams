using System;

namespace Paramulate.Test
{
    public static class TestData
    {
        public const string NullStr = "null";

        public const int Int = 23;
        public const string IntStr = "23";

        public const string InvalidIntStr = "9223372036854775808";

        public const string UnquotedString = "A : [] \n �ATestString";
        public const string QuotedString = "'A : [] \n �ATestString'";
        public const string UnquotedStringWithQuote = "A : '[] \n �ATestString";
        public const string QuotedStringWithEscapedQuote = "'A : \\'[] \n �ATestString'";

        public const long Long = long.MinValue;
        public const string LongStr = "-9223372036854775808";

        public const float Float = 0.000034443f;
        public const string FloatStr = "0.000034443";

        public const float FloatNaN = float.NaN;
        public const string FloatNaNStr = "NaN";

        public const float FloatNegInfinity = float.NegativeInfinity;
        public const string FloatNegInfinityStr = "-Infinity";

        public const double Double = 0.123456789012345;
        public const string DoubleStr = "0.123456789012345";

        public static readonly DateTime DateTime = new DateTime(2016, 10, 16, 23, 54, 41, 1);
        public const string DateTimeStr = "2016-10-16T23:54:41.001Z";
        public const string QuotedDateTimeStr = "'2016-10-16T23:54:41.001Z'";

        public static readonly DateTime Date = new DateTime(2016, 10, 16);
        public const string DateStr = "2016-10-16";

        public static readonly TimeSpan TimeSpan = new TimeSpan(0, 9, 11, 12, 300);
        public const string TimeSpanStr = "09:11:12.3";
        public const string InvalidTimeSpanStr = "09::11";
        
        public enum TestEnum
        {
            Value0 = 0,
            Value1 = 1,
        }

        public const string EnumOne = "Value1";
        public const string InvalidEnumValue = "ValueInvalid";
        public const string QuotedEnumValue = "'Value1'";
        public const string NumericEnumValue = "1";
    }
}