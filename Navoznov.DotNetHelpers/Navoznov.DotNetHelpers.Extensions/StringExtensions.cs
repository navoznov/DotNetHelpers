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
        /// <returns></returns>
        public static string F(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}