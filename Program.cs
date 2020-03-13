using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luhn
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int input = 1234567890;

            

            Console.WriteLine("Is it valid?");
            Console.WriteLine(lunhValidation(input));
        }

        public static bool lunhValidation(int input)
        {
            int[] myArray = input.ToString().ToList().Select(x => { return int.Parse(x.ToString()); }).ToArray(); // linq

            input.ToString().ToList().Where(y => y%2==0).ToList().ForEach(x => { 
                Console.WriteLine(int.Parse(x.ToString())); 
            });
            //input.ToString().ToList().ForEach(x => {
            //    Console.WriteLine(int.Parse(x.ToString()));
            //});

            int sum = 0;

            //sum = [1] + (2 *[2]) + [3}

            for (int i = 0; i < myArray.Length-1; i++)
            {
                

                if (i%2==0)
                {
                    sum += myArray[i];
                }
                else
                {
                    sum += myArray[i]*2;
                }
            }

            return myArray[myArray.Length-1]==(sum%10);
        }
    }

    
}
