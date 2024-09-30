using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApp.Validators
{
    public class TriangleValidator
    {
        public bool IsValid(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }
    }
}
