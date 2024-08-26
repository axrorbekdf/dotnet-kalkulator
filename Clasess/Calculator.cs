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

        public bool IsFirstNumberPositive(){
            return FirstNumber >= 0;
        }

        public bool IsSecontNumberPositive(){
            return SecondNumber >= 0;
        }

        public void ComparisonInputs(){

            if(FirstNumber > SecondNumber){
                Console.WriteLine("1-raqamni 2-raqamdan katta!");
            } else if(FirstNumber == SecondNumber){
                Console.WriteLine("1-raqamni 2-raqamdan teng!");
            }else{
                Console.WriteLine("1-raqamni 2-raqamdan kichik!");
            }
        }

        public string Calculate(){

            // int summary = 0;
            // switch (Operation)
            // {
            //     case "+":
            //         summary = FirstNumber + SecondNumber;
            //         break;

            //     case "-":
            //         summary = FirstNumber - SecondNumber;
            //         break;

            //     case "*":
            //         summary = FirstNumber * SecondNumber;
            //         break;

            //     case "/":
            //         if (SecondNumber == 0)
            //             Console.WriteLine("Sonni 0ga bo'lib bo'lmaydi!");
            //         else
            //             summary = FirstNumber / SecondNumber;
            //         break;

            //     case "%":
            //         summary = FirstNumber + SecondNumber;
            //         break;

            //     default:
            //         Console.WriteLine("Bunday amal mavjud emas!");
            //         break;
            // }

            // Console.WriteLine($"Natija: {summary}");


            return Operation switch{
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber+SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber-SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber*SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber/SecondNumber}",
                "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber%SecondNumber}",
                _ => "Bunday amal mavjud emas!"
            };
        }

        public void PrintEvenNumbers(){
            int counter = 2;

            Console.WriteLine("1-birinchi raqamgacha bo'lgan juft sonlar!");
            while(counter < FirstNumber){
                Console.WriteLine(counter);
                counter += 2;
            }
        }

        public void PrintMultiplicationTable(){

            for(int i = 1; i <= 10; i++){
                for(int j = 1; j <= 10; j++){
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
