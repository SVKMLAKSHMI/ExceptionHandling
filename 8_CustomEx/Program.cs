//Custom Exception Class
//Write a console application that defines a custom exception for when a specific condition is not met (e.g., age below 18 for a voting system). 
//Throw and handle the custom exception.

namespace CustomEx{

    public class CustomException : Exception{

        public CustomException(string message) : base (message){}
    }
    
    public class CustomEx{

        public static void Main(String[] args){

            Console.Write("Enter the age: ");
            int age = int.Parse(Console.ReadLine());

            try{
                if(age < 18){

                    throw new CustomException("A person who has below 18 is not available for voting");
                }
                else{
                    Console.WriteLine("Eligible for vote");
                }
            }
            catch(CustomException ex){
                Console.WriteLine("Custom exception: "+ex.Message);
            }
        }
    }
}
