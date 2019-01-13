﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Lesson
    {
        public static void StructExample()
        {
            Coordinate coord0 = new Coordinate(0, 0);
            Coordinate coord1;
            Coordinate coord2;

            coord1.x = 15;
            coord1.y = 15;

            coord2 = coord1;
        }
        public static void StructExample2()
        {
            var array = new Coordinate[] { new Coordinate(20, 25) };
            var list = new List<Coordinate> { new Coordinate(20, 25) };

            var arrayElement1 = array[0];
            var listElement1 = list[0];

            arrayElement1.y = 1;
            listElement1.y = 1;
            Console.WriteLine();

        }
    }

    public struct Color
    {
        public string rgb;
        public string name;
    }

    public struct Coordinate
    {
        public int x;
        public int y;
        public double Length
        {
            get { return vector(); }
        }

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double vector()
        {
            var length = Math.Sqrt(x * x + y * y);
            return length;
        }

    }

    public class Rectangle2D   //изначально struct
    {
        public int height;
        public int lenght;
        public Coordinate rectangle2D_Coordinate;

        public Rectangle2D(int height, int lenght, int xCoord,  int yCoord)
        {
            this.height = height;
            this.lenght = lenght;
            rectangle2D_Coordinate = new Coordinate(xCoord, yCoord);
        }
        public override string ToString()
        {
            return $"высота- {height}  длина- {lenght}  координаты: {rectangle2D_Coordinate.x}  {rectangle2D_Coordinate.y}";
        }

        public bool Equals(Rectangle2D other)   // необходимо если    Rectangle2D    == class
        {
            bool result = false;

            if (height == other.height && lenght == other.lenght && rectangle2D_Coordinate.x
                == other.rectangle2D_Coordinate.x && rectangle2D_Coordinate.y == other.rectangle2D_Coordinate.y)
            {
                result = true;
            }
            return result;
        }
    }
}
