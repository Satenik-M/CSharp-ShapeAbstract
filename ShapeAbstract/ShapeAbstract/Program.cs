﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int shapeIndex;
            int height;
            int width;
            Console.WriteLine("Please choose the preferred geometrical shape to be drawn or painted!\n 1 for rectangle \n 2 for right triangle \n 3 for isosceles triangle");
            while ((!Int32.TryParse(Console.ReadLine(), out shapeIndex))|shapeIndex>3)
            {
                Console.WriteLine("Please choose the preferred geometrical shape to be drawn or painted!\n 1 for rectangle \n 2 for right triangle \n 3 for isosceles triangle");
            }

            switch (shapeIndex)
            {
                case 1://ughankyun
                    {
                         bool heightIsInt;
                         bool widthIsInt;
                         do
                         {
                             Console.WriteLine("Please enter the height and the width of the rectangle");
                             Console.Write("Height:");
                             heightIsInt = Int32.TryParse(Console.ReadLine(), out height);

                        Console.Write("Width:");
                        widthIsInt= Int32.TryParse(Console.ReadLine(), out width);/*todo width max width to be 80*/
                         } while ((!heightIsInt||!widthIsInt));
                        Rectangle r = new Rectangle(height, width);
                        r.Draw();
                        Console.WriteLine();
                        r.Paint();
                        break;
                    }
                case 2: //ughankyun yerankyun
                    {
                        
                        do
                        {
                            Console.WriteLine("Please enter the left leg height of the right triangle");
                            Console.Write("Height:");
                        } while (!Int32.TryParse(Console.ReadLine(), out height));/*todo height max value to be 80*/
                            

                        
                        RightTriangle r = new RightTriangle(height);
                        r.Draw();
                        Console.WriteLine();
                        r.Paint();
                        break;
                    }
                case 3://havasarasrun yerankyun
                    {
                       
                        do
                        {
                            Console.WriteLine("Please enter the height of the isosceles triangle");
                            Console.Write("Height:");
                        } while (!Int32.TryParse(Console.ReadLine(), out height));/*todo height max value to be 40*/
                        

                        IsoscelesTriangle r = new IsoscelesTriangle(height);
                        r.Draw();
                        Console.WriteLine();
                        r.Paint();
                        break;
                    }

                default:
                    break;
            }
            Console.ReadLine();

           
        }
    }
}
