﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyShapes;
//using My3DShapes;
//using Lecture14.
//using My3DHexagon = My3DShapes.Hexagon;
using My3DHexagon = Lecture14.My3DShapes.Hexagon;

//using bfHome = System.Runtime.Serialization.Formatters.Binary;
//using bfHome = System.Runtime.Serialization.Formatters.Binary.BinaryFormatter;
//using System.Runtime.Serialization.Formatters.Binary;
    
namespace Ch14_P1_CustomNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hexagon h = new Hexagon();
            //Circle c = new Circle();
            //Square s = new Square();

            //    MyShapes.Hexagon h = new MyShapes.Hexagon();
            //    MyShapes.Circle c = new MyShapes.Circle();
            //    MyShapes.Square s = new MyShapes.Square();

            //My3DShapes.Hexagon h = new My3DShapes.Hexagon();
            //My3DShapes.Circle c = new My3DShapes.Circle();
            //MyShapes.Square s = new MyShapes.Square();

            My3DHexagon hexagon = new My3DHexagon();


            //bfHome.BinaryFormatter b = new bfHome.BinaryFormatter();
            //bfHome b = new bfHome();
            //BinaryFormatter b = new BinaryFormatter();

            Circle c = new Circle();
        }
    }
}
