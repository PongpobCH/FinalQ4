using System;

class Program
{
    
    
    static void Main()
    {
        
        int i = 0;
        Queue<string> queue = new Queue<string>(); 
        string input,input2;
        int inputint;
        Console.WriteLine("input = ");
        input = Console.ReadLine();
        
        
        
        
        queue.Push(input);

        
        if(input != "done")

        {
            Console.WriteLine("Price =");
            input2 = Console.ReadLine();
            Main();
            string value = queue.Pop();
            Console.WriteLine(value + " ({0}) ",input2 );
        }

        else
        {

            
        }
        

        
    
    }
    
       
}
