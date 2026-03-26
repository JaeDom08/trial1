using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int function;

            console.Writeline("Welcome to Calculator!");

            console.Writeline("Please select function (pls select by singular number): 1. Add 2. Sub 3. Mult 4. Div"); //from W3S
            int function = Convert.Toint32(Console.Readline);
            console.Writeline("You have selectected function" + function);
            
        }
    }
    


}

