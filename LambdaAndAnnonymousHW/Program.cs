using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAndAnnonymousHW
{
    class Program
    { 
        
        static void Main(string[] args)
        {
            #region Annonymous
            
            ShalomDelagete delagete = delegate () { Console.WriteLine("Shalom"); };
            Greet greet = delegate (string nm) { Console.WriteLine($"Hello {nm}"); };
            CalculationDel caldl = delegate (int a, int b) { Console.WriteLine(a + b); };  
            
            greet("or");
            delagete();
            #endregion

            #region Lambda
            string name = "or";
;            ShalomDelagete shalom = () => { Console.WriteLine("Hello"); };
             Greet greet1 = (string ng) => { Console.WriteLine($"Hello {ng}"); };
            CalculationDel del = (int a, int b) => { Console.WriteLine(a + b); };
            greet1(name);
            del(1, 2);

            #endregion
        }
    }
}
