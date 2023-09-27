using Interface.Enums;
using System.Drawing;

namespace Interface.Model.Entities
{
  abstract class AbstractShape : IShape
  {

    public Colors Color { get; set; }

    public abstract double Area();
  }
}