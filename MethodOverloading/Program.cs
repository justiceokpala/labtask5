using System;

namespace MethodOverloading
{
  class Program
  {
      //method with the same name but differnt data type
    static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    static double PlusMethod(double x, double y)
    {
      return x + y;
    }



    // method with the same name but different different number of arguments
    static double area(double s) {
        double area = s * s;
        return area;
    }

    static double area(double l, double b) {
        double area = l * b;
        return area;
    }


    static void Main(string[] args)
    {
        //calling the method with the same name but different data type
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);

      //calling the method with the same name but differnt amount of arguments

      //note:To invoke the overloaded methods, call the method with the exact arguments. For example, if we want to invoke the area() method to find the area of a square, we will pass only one argument.

      double side = 3.3;
      double square = area(side);
      Console.WriteLine(square);


      double length = 3.3;
      double breadth = 4.9;
      double rect = area(length, breadth);
      Console.WriteLine(rect);

      
    }  
  }
}

