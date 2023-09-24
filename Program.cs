using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsInterfaceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // オブジェクトの作成
            //IVehicle myCar = new Car("Toyota");
            //IVehicle myBicycle = new Bicycle("Bianchi");
            IVehicle myCar = new Car("Toyota");
            var myBicycle = new Bicycle("Bianchi");
            var Motorcycle = new Bicycle("Honda");

            // メソッドの呼び出し
            myCar.Move();  // "Toyota is moving on four wheels."と出力
            myBicycle.Move(); // "Bianchi is moving on two wheels."と出力
            Motorcycle.Move();

            // 配列の作成
            IVehicle[] vehicles = new IVehicle[3];
            vehicles[0] = new Car("Toyota");
            vehicles[1] = new Bicycle("Bianchi");
            vehicles[2] = new Motorcycle("Honda");

            // メソッドの呼び出し
            foreach (IVehicle vehicle in vehicles)
            {
                vehicle.Move();  // "Toyota is moving on 4 wheels."と出力
                                 // "Bianchi is moving on 2 wheels."と出力
                                 // "Honda is moving on 2 wheels with an engine."と出力
            }
        }
    }
}
