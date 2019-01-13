using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    class Program
    {
        static void Main(string[] args)
        {           
            Rectangle2D examle = new Rectangle2D(2, 2, 0, 0);
            Rectangle2D[] rectangles100 = Rectange2DMassive();
                        
            RectangleAnalis(rectangles100);

            // Practice.Lb8_P2_3();
            // Lesson.EnumExample();
            Console.ReadLine();
        }

        public static Rectangle2D[] Rectange2DMassive()
        {
            Random rnd = new Random(10);
            Rectangle2D[] rectange2DMassive =new Rectangle2D[100];
            for (int i = 0; i < 100; i++)
            {
                rectange2DMassive[i] = new Rectangle2D(rnd.Next(1, 5), rnd.Next(1, 5), rnd.Next(1, 5), rnd.Next(1, 5));
                Console.WriteLine(rectange2DMassive[i]);
            }
            return rectange2DMassive;            
        }

        public static void RectangleAnalis(Rectangle2D[] inputRectangles)
        {
            sbyte[] tempResult = new sbyte[inputRectangles.Length];

            for (int i = 0; i < inputRectangles.Length; i++)
            {
                for (int j = 0; j < inputRectangles.Length; j++)
                {
                    if (i != j && tempResult[j]==0)
                    {
                        if (inputRectangles[i].Equals(inputRectangles[j]))
                        {
                            tempResult[i]++;
                            tempResult[j]--;
                        }
                    }
                    else continue;
                }
            }

            for (int i = 0; i < inputRectangles.Length; i++)
            {
                if (tempResult[i]>0)
                {
                    Console.WriteLine($"квадрат № {i+1}   встречается  {tempResult[i]+1}  раз");
                }
            }
        }
    }
}
