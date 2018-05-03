using System;

namespace Polimorfismo { 

    public class Poli3 {

    public static void Main(){
            DrawingObject[] ArrayObjetos = new DrawingObject[4];
            ArrayObjetos[0] = new Line();
            ArrayObjetos[1] = new Circle();
            ArrayObjetos[2] = new Square();
            ArrayObjetos[3] = new DrawingObject();

            foreach (DrawingObject X in ArrayObjetos)
            {
                X.Draw();
            }

            Console.Read();

        }

    }
}