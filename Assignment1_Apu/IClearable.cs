using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Apu
{
    /// <summary>
    /// Just a simple interface to implement a clear form method.
    /// This method clears inputs after a user adds a recipe or ingredient.
    /// </summary>
    public interface IClearable
    {
        void ClearForm();
    }
}
