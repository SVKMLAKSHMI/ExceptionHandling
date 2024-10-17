//Catch Multiple Exceptions
//Write a console application that can throw multiple exceptions (DivideByZeroException, FormatException, and IndexOutOfRangeException). 
//Handle each exception separately in a try-catch block.

namespace CatchMulEx{

    public class CatchMulEx{

        public static void Main(String[] args){

            Console.WriteLine("Enter value: ");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter another value: ");
            string s2 = Console.ReadLine();

            try{

                int num1 = int.Parse(s1);
                int num2 = int.Parse(s2);

                int res=0;

                if(num2 == 0){

                    res = num1/num2;
                    throw new DivideByZeroException("Cannot possible to divide by zero");
                   
                }
                else{

                    Console.WriteLine($"{num1}/{num2} = {res}"); 

                }
                 
                throw new FormatException("Invalid input data");

                // int res = num1/num2;
                // Console.WriteLine("Divided: "+res);
            
            }
            
            catch(FormatException ex){
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex){
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}