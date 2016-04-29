using System;

namespace Navoznov.DotNetHelpers.Extensions
{
    /// <summary>
    /// Методы-расширения для <see cref="DateTime"/>
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Возвращает дату-время на начало заданного дня
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime BeginOfDay(this DateTime dateTime)
        {
            return dateTime.Date;
        }

        /// <summary>
        /// Возвращает дату-время на конец заданного дня (23:59:59.999)
        /// </summary>
        public static DateTime EndOfDay(this DateTime dateTime)
        {
            return dateTime.Date.AddDays(1d).AddMilliseconds(-1d);
        }

        /// <summary>
        /// Начало месяца
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime BeginOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        /// <summary>
        /// Конец месяца
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime EndOfMonth(this DateTime dateTime)
        {
            return dateTime.BeginOfMonth().AddMonths(1).AddMilliseconds(-1d);
        }
    }
}