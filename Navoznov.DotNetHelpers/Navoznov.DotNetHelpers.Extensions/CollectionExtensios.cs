using System;
using System.Collections.Generic;

namespace Navoznov.DotNetHelpers.Extensions
{
    /// <summary>
    /// Методы-расширения для <see cref="ICollection{T}"/>
    /// </summary>
    public static class CollectionExtensios
    {
        /// <summary>
        /// Выполняет метод <paramref name="action"/> последовательно для каждого элемента в коллекции <paramref name="collection"/>
        /// </summary>
        /// <param name="collection">коллекция элементов</param>
        /// <param name="action">метод, который надо выполнить для каждого из элементов коллекции <paramref name="collection"/></param>
        public static void ForEach<T>(this ICollection<T> collection, Action<T> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}