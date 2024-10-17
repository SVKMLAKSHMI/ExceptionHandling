//Overflow Exception
//Write a console application that accepts very large integers and attempts to store them in an int variable. Handle the OverflowException.

namespace OverflowEx{
    public class OverflowEx{
        public static void Main(String[] args){

            try{

                int num1 = int.MaxValue;
                int num2 = int.MaxValue;

                checked{

                    int mul = num1 * num2;
                    Console.WriteLine("Multiplication: "+mul);
                }
                
            }
            catch(OverflowException ex){

                Console.WriteLine("You stored larger data in small datatype");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
