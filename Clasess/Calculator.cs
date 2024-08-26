namespace KALKULATOR.Classes{
    public class Calculator
    {
        public int FirstNumber{get; set;}   
        public int SecondNumber{get; set;}
        public string Operation { get; set; }


        public void GetInputs(){
            Console.WriteLine("1-raqamni kiriting: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Arifmetik amalni kiriting (+,-,/,*,%): ");
            Operation = Console.ReadLine();

            Console.WriteLine("2-raqamni kiriting: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
