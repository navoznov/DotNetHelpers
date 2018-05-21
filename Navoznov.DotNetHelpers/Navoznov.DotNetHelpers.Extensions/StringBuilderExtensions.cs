using System;
using System.Text;

namespace Navoznov.DotNetHelpers.Extensions
{
    /// <summary>
    /// Методы расширения для <see cref="StringBuilder"/>
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Добавляет строку если выполняется условие
        /// </summary>
        /// <param name="sb">инстанс <see cref="StringBuilder"/></param>
        /// <param name="condition">условие</param>
        /// <param name="str">строка</param>
        /// <returns>тот же самый инстанс <see cref="StringBuilder"/></returns>
        public static StringBuilder AppendIf(this StringBuilder sb, bool condition, string str)
        {
            if (sb == null)
            {
                throw new ArgumentNullException(nameof(sb));
            }

            return condition ? sb.Append(str) : sb;
        }

        /// <summary>
        /// Добавляет строку и перенос на новую строку, если выполняется условие
        /// </summary>
        /// <param name="sb">инстанс <see cref="StringBuilder"/></param>
        /// <param name="condition">условие</param>
        /// <param name="str">строка</param>
        /// <returns>тот же самый инстанс <see cref="StringBuilder"/></returns>
        public static StringBuilder AppendLineIf(this StringBuilder sb, bool condition, string str)
        {
            if (sb == null)
            {
                throw new ArgumentNullException(nameof(sb));
            }

            return condition ? sb.Append(str).AppendLine() : sb;
        }
    }
}