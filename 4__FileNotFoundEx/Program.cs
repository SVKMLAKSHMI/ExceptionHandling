// File Not Found Exception
// Write a console application that attempts to read a non-existing file. Handle the FileNotFoundException.

namespace FileNotExceptionEx{

    public class FileNotFoundEx{
        
        public static void Main(String[] args){

            try{

                Console.Write("Enter the file path: ");
                string filePath = Console.ReadLine();
                if(!File.Exists(filePath)){
                    throw new FileNotFoundException();
                }
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("File content: "+fileContent);
            }
            catch(FileNotFoundException ex){
                Console.WriteLine("Enter valid file path");
                Console.WriteLine(ex.Message);
            }
        }
    }
}