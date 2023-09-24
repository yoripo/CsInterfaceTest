using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsInterfaceTest
{
    /// <summary>
    /// 乗り物インターフェース
    /// </summary>
    public interface IVehicle
    {
        //string Name { get; set; }

        ////void Move();
        //void SetWheel(string wheel);
        //int GetWheel();
        string GetName();

        void SetName(string name);
        void Move();
    }

}
