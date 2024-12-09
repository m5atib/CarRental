using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common
{
    public interface ILogger
    {
        string Info();

        string Error();

        string Warn();
    }
}
