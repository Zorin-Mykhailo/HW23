using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW23;

public class Calculator
{
    public virtual void SomeMethod()
    {
        Console.WriteLine("SomeMethod");
    }

    public virtual double Sum(double a, double b) => a + b;

    public virtual double Substract(double a, double b) => a - b;

    public virtual double Multiply(double a, double b) => a * b;

    public virtual double Divide(double a, double b) => a / b;


    public virtual bool Compare(double a, double b)
    {
        SomeMethod();
        double sum = Sum(a, b);
        double multiply = Multiply(a, b);
        return multiply > sum;
    }

    public virtual bool CompareSimple(double a, double b) => a > b;
}