using System;
using System.Collections.Generic;

namespace TriangleTracker.Models {

  public class Triangle {

    private int[] _sides;

    public Triangle(int[] sides) {
      _sides = sides;
    }

    // public Triangle(int side1, int side2, int side3) {
    //   _sides[0] = side1;
    //   _sides[1] = side2;
    //   _sides[2] = side3;
    // }

    public int[] GetSides() {
      return _sides;
    }

    public void SetSides(int[] sides) {
      _sides = sides;
    }

    public string TriangleType()
    {
      int side1 = _sides[0];
      int side2 = _sides[1];
      int side3 = _sides[2];
      if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
      {
        return "These sides do not make a triangle";
      }
      else if (side1 == side2 && side2 == side3)
      {
        return "Equilateral";
      }
      else if (side1 == side2 || side1 == side3 || side2 ==side3)
      {
        return "Isosceles";
      }
      else 
      {
        return "Scalene";
      }
    }

  }
}