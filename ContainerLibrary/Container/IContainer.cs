using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLibrary.Container
{
    public interface IContainer<T>
    {
        int MaxLength { get; }
        bool TryAdd(T value);
        void ForceAdd(T value);
        T[] GetAll();
    }
}
