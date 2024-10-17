//Argument Out of Range Exception
//Create a console application that uses Substring() on a string. Handle the ArgumentOutOfRangeException when the user enters invalid indices.

using System.Text;
namespace ArgumentOutOfRangeEx{
    public class ArgumentOutOfRangeEx{

        public static void Main(String[] args){

            Console.Write("Enter the string value: ");
            string s = Console.ReadLine();

            try{

                string newString = s.Substring(0,10);
                Console.WriteLine("Sub string: "+newString);
            }
            catch(ArgumentOutOfRangeException ex){
                Console.WriteLine("Enter valid length string");
                Console.WriteLine(ex.Message);
            }
        }
    }
}