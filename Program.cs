using System;
using System.Numerics;
namespace benny
{
    class Program
    {
        
        static void Main(string[] args)
        {
         string d = "r";
         long  time = 0;  
         for (int i = 0; i < 3; ){ 
              if (d == "r"){
         long c = 0;
        Console.WriteLine ("number_1");
        long v = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine ("number_2");      
        long a = Convert.ToInt64(Console.ReadLine());
         Console.WriteLine ("type_of_math");
        string bb = (Console.ReadLine());
        if (bb  == "+" ){
         c =  v + a;
        }
         else if (bb  == "-" ){
         c =  v - a;
        }
       else if (bb  == "*" ){
         c =  v * a;
        }
        else if (bb  == "/" ){
         c =  v / a;
        }
        else{
          Console.WriteLine ("error");
          return ;   
        }
        Console.WriteLine (c);
             i++;     
         Console.WriteLine (" write r to retry anything else to exit");
            time = time + 1;
            d = (Console.ReadLine());
         
    }else
    {
     Console.WriteLine ("times done");
     Console.WriteLine (time); 
     return ;    
    }
   
     }   
    
       
        }
    }

}
