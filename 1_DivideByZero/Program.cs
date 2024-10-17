namespace DivideByZeroEx{
    public class DivideByZeroEx{
        public static void Main(String[] args){

            try{
                Console.WriteLine("Enter a value: ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter b value: ");
                int b = int.Parse(Console.ReadLine());
                int res = a / b;
                Console.WriteLine($"{a}/{b} = {res}");
            }
            catch(DivideByZeroException ex){
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Another way");

            try{
                Console.WriteLine("Enter num value: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter deno value: ");
                int deno = int.Parse(Console.ReadLine());

                double res = Div(num,deno);
                Console.WriteLine($"{num}/{deno} = {res}");
            }
            catch(DivideByZeroException ex){
                Console.WriteLine(ex.Message);
            }
        }

        public static double Div(int num, int deno){
            if(deno == 0){
                throw new DivideByZeroException();
            }
            return num/deno;
        }
    }
}
