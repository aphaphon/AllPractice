namespace demoapi
{
    public class PrimeLogic
    {
        // เอาไว้ทดสอบถามเราเขียน expected value ผิด
        // public int XXX;
        
        public string prime(int number)
        {
            // -1   x
            // 0    x
            // 1    x
            // 2    /
            // 3    /
            // 4    2,3
            // 5    2,3,4
            // 6    2,3,4,5
            // 7    2,3,4,5,6
            // 8    2,3,4,5,6,7
            // 9    2,3,4,5,6,7,8
            // 10   2,3,4,5,6,7,8,9

            if (number < 2) return "x";

            if (number == 2 || number == 3) return "o";

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    // เอาไว้ทดสอบถามเราเขียน expected value ผิด
                    // XXX = i;
                    return "x";
                }
            }

            return "o";
        }
        // public string prime(int number)
        // {
        //     if (number % 2 == 0 && number != 2)
        //         return "x";

        //     if (number % 3 == 0 && number != 3)
        //         return "x";
        //      if (number % 5 == 0 && number != 5)
        //         return "x";

        //     // if (number==4 
        //     // || number ==6 
        //     // || number ==8 
        //     // || number ==9
        //     // || number ==10
        //     // || number ==12
        //     // || number ==14
        //     // || number ==15
        //     // || number ==16)
        //     // return "x";
        //     return "o";


        // }


    }
}