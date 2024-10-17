// Index Out of Range Exception
// Create an array of 5 elements. Prompt the user to enter an index and display the corresponding element. 
// Handle the IndexOutOfRangeException when the user enters an invalid index.

namespace IndexOutOfRangeEx{

    public class IndexOutOfRangeEx{

        public static void Main(String[] args){

            try{
                
                int[] arr = new int[5]{1,2,3,4,5};
                
                Console.Write("Enter the index position to know the element: ");
                int index = int.Parse(Console.ReadLine());

                if(index > 5){
                    throw new IndexOutOfRangeException();
                }
                else{

                for(int i=0; i<5; i++){
                    if(i == index){
                        Console.WriteLine($"Element at {index} is {arr[i]}");
                    }
                    
                }
                }
            }
            catch(IndexOutOfRangeException ex){
                Console.WriteLine("Give valid index position");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
