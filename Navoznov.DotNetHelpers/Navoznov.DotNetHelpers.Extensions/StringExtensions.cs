namespace Navoznov.DotNetHelpers.Extensions
{
    /// <summary>
    /// Методы расширения для <see cref="string"/>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Более удобная обертка над string.Format(...)
        /// </summary>
        /// <param name="format">строка-шаблон</param>
        /// <param name="args">аргументы, подставляемые в шаблон</param>
        public static string Format(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        /// <summary>
        /// Более удобная обертка над string.Format(...)
        /// </summary>
        /// <param name="format">строка-шаблон</param>
        /// <param name="args">аргументы, подставляемые в шаблон</param>
        public static string F(this string format, params object[] args)
        {
            return Format(format,args);
        }
        
        /// <summary>
        /// Аналог функции slice из языка JavaScript.
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="startIndex">индекс начала подстроки. Если меньше нуля, то отсчитывается с конца строки.</param>
        /// <param name="endIndex">индекс конца подстроки (невключается в результат). Если меньше нуля, то отсчитывается с конца строки.</param>
        /// <returns>подстрока</returns>
        /// <example>
        /// <code>
        /// "Hello world!".Slice(-1);   // "!"
        /// "Hello world!".Slice(1,-3);   // "ello wor"
        /// </code>
        /// </example>
        public static string Slice(this string str, int startIndex, int endIndex = 0)
        {
            var realStartIndex = startIndex < 0 ? str.Length + startIndex : startIndex;
            var realEndIndex = endIndex <= 0 ? str.Length + endIndex : endIndex;
            return str.Substring(realStartIndex, realEndIndex - realStartIndex);
        }
    }
}