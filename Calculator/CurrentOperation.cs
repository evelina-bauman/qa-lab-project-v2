using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CurrentOperation
    {
        public double fNumber, sNumber, result;
        public string operation;

        public CurrentOperation() { }

        public CurrentOperation(double fNumber, double sNumber, string operation)
        {
            this.fNumber = fNumber;
            this.sNumber = sNumber;
            this.operation = operation;
            GetOperationResult();
        }

        public void GetOperationResult()
        {
            switch (operation)
            {
                case ("+"):
                    Add();
                    break;
                 case ("-"):
                    Subtract();
                    break;
                case ("/"):
                    Divide();
                    break;
                case ("*"):
                    Multiply();
                    break;
                default:
                    result = 0;
                    break;
            }
        }

        void Add()
        {
            result = fNumber + sNumber;
        }
        void Subtract()
        {
            result = fNumber - sNumber;
        }
        void Divide()
        {
            result = fNumber / sNumber;
        }
        void Multiply()
        {
            result = fNumber * sNumber;
        }
    }
}
