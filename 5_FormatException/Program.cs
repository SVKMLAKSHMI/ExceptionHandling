//Format Exception
//	Write a console application that takes user input and tries to convert it to an integer. 
//Handle the case where the input is not a valid number using a FormatException.

namespace FormatEx{

    public class FormatEx{

        public static void Main(String[] args){

            Console.Write("Enter the input: ");
            string input = Console.ReadLine();

            try{

                int output = int.Parse(input);
                Console.WriteLine("int value: "+output);
                
            }
            catch(FormatException ex){
                Console.WriteLine("Invalid data type value..");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
