using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardCalculator
{
    public class StandardFunctions
    {
        public int AddingFunction(int num1, int num2)
        {
            int addtotal;
            return addtotal = num1 + num2;

        }
        public int SubtractingFunction(int num1, int num2)
        {
            int addtotal;
            return addtotal = num1 - num2;

        }

        public int MultiplicationFunction(int num1, int num2)
        {
            try
            {

                int product = num1 * num2;
                return product;
            }
            catch (OverflowException)
            {
                throw new Exception();                   
            }
            

        }

        public int DivisionFunction(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new Exception();
            }
            int addtotal;
            return addtotal = num1 / num2;

        }
    }
}
