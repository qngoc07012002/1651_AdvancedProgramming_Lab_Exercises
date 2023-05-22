using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    interface ILeutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
        void AddPrivate(IPrivate @private);
    }
}
