using System;
using System.Collections.Generic;
using System.Text;

namespace _3_basic_data_structures
{
    public interface IArray<T>
    {

        int Size();

        T Get(int index);
        void Add(T item);
        void Add(T item, int index);
        T Remove(int index);

        T Pop();
        T Shift();
        void Unshift(T item);
        void Swap(int source, int target);
    }
}
