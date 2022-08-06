using System;
 
 namespace demoInher_Poly{
        
        
    class show{
        public string name;
        public int weight;
        public show(){
            this.name = name;
            this.weight =weight;
        }
    }
    class Lion : show{
        // public Lion(){

        // }
    }
    class Tiger : show{
        
    }
    public class testproduct{
    public static void Main(string[] args)
    {
        Lion lion2 = new Lion();
        lion2.name= "Lion";
        lion2.weight= 100;
        Console.Write("Name : "+lion2.name);
        Console.WriteLine(", Weight : "+lion2.weight);
        Tiger tiger2 = new Tiger();
        tiger2.name= "Tiger";
        tiger2.weight= 200;
        Console.Write("Name : "+tiger2.name);
        Console.WriteLine(", Weight : "+tiger2.weight);
    }
 }
 }