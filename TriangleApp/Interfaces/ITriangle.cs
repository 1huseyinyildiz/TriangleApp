using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleApp.Models;

namespace TriangleApp.Interfaces
{
    public interface ITriangle 
    {
        TriangleType GetTriangleType();
    }
}
