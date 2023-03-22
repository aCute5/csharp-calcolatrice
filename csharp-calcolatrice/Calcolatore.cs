using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
  
 //Il principio che ci permette di chiamare due funzioni con lo stesso nome è il polimorfismo; attraverso il quale possiamo chiamare 
// una funzione con lo stesso nome anche se sono due perchè cambia il tipo di argomento che essa tratta. Ecco perchè esiste un add dei
// dei numeri interi e un add dei numeri dispari e il compilatore non mi da errore. 
public static  class HelperCalc
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    //public static int Somma(int num1, int num2) => num1 + num2; // Versione corta che a me non piace personalmente :/ 
    public static double Add(double a,double b)
    {
        return a + b;
    }
    public static double Sottr(double a,double b)
    {
        return a - b;
    }
    public static int Sottr(int a,int b)
    {
        return a - b;
    }
    public static int Molt(int a,int b)
    {
        return a * b;
    }
    public static double Molt(int a,double b)
    {
        return a * b;
    }
    public static int Absolute(int a)
    {
        if (a < 0)
        {
            return a * -1;
        }
        else
        {
            return a;
        }
    }
    public static double Absolute(double a)
    {
        if (a < 0)
        {
            return a * -1;
        }
        else
        {
            return a;
        }
    }
    public static double Min(double a,double b)
    {
        if (a < b) { 
        return a;
        }
        else
        {
            return b;
        }
    }
    public static int Min(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    public static int Max(int a,int b)
    {
        if(a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    public static double Max(double a, double b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    // BONUS

    public static int Power(int a, int exponent)
    {
        if (exponent == 0)
        {
          a = 1;

        }else if (a == 0)
        {
          a = 0;
        }
        else
        {
           int  realA = a;
            for(int  i = 1; i < exponent; i++)
            {
                a *= realA; 
            }
        }
            return a;
    }
    public static int NOLoopPower(int _base ,int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else if (exponent < 0)
            {
                return _base * NOLoopPower(_base , exponent);
            }
        else
        {
            return _base * NOLoopPower(_base, --exponent);
        }
    }

}

}
