using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IMultiFunctionDevice
    {
        void Print();

        void Scan();

        void Fax();
    }

    public class OldPrinter : IMultiFunctionDevice
    {        
        public void Print()
        {
            //print logic
        }

        public void Scan()
        {
            //scan logic
        }

        public void Fax()
        {
            //fax logic
        }
    }
}
