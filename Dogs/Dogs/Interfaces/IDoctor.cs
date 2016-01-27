using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.Interfaces
{
    public interface IDoctor<T>
    {
        IList<T> ShowReceivings();
        bool TransferReceiving(T receiving, DateTime dateReceiving);
    }
}
