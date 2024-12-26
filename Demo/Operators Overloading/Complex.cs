using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operators_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }


        #region Opeartor Overloading
        ///public static Complex operator + (Complex Left, Complex Right)
        ///{
        ///    return new Complex()
        /// <summary>
        /// public static Complex operator + (Complex Left, Complex Right)
        /// </summary>
        /// <returns></returns>   //        Imag = Left.Imag + Right.Imag
        ///   };
        ///}
        ///
         
        public static Complex operator ++ (Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        #endregion
        public override string ToString()
        {
            return  $"{Real} + {Imag}i"; 
        }
    }
}
