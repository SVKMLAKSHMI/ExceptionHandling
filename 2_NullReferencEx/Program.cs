//Null Reference Exception
//Write a console application that attempts to access a method or property of a null object. Handle the NullReferenceException.

namespace NullReferenceEx{

    public class NullReferenceEx{

        public static void Main(String[] args){

            try{

                Console.WriteLine("Enter the name: ");
                // string name = null;
                string name = Console.ReadLine();

                //Check if name is null or empty
                if(string.IsNullOrEmpty(name)){
                    // name = null;  //Explicitly set to null if input is empty
                    throw new NullReferenceException();
                }

                int res = GetName(name);
                Console.WriteLine("Length of the name: "+res);
            }
            catch(NullReferenceException ex){
                Console.WriteLine("You are trying to accessing the name by pass null value");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }

        }

        public static int GetName(string name){

            // this will throwss a null reference exception if input is null
            return name.Length;
        }
    }
}
