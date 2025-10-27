using System;
using System.Collections;

namespace Lists
{
    public interface IList<T> : IEnumerable
    {
        int Count();

        T Get(int index);

        void Add(T value);

        T Remove(int index);

        void Clear();
    }
}
