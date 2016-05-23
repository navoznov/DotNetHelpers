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
    }
}