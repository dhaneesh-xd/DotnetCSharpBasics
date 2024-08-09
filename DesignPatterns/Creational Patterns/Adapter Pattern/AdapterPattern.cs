using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Adapter_Pattern
{
    public interface IMusic
    {
        void Player();
    }
    public class BluetoothEarphone
    {
        public void Playing()
        {
            Console.WriteLine("Vaada en machi.. vaazhaka bajji");
        }
    }
    public class WiredEarphone : IMusic
    {
        private BluetoothEarphone bluetoothEarphone;
        public WiredEarphone(BluetoothEarphone _bluetoothEarphone) //getting input of instance (delegating)
        {
            bluetoothEarphone = _bluetoothEarphone;
        }
        public void Player()
        {
            bluetoothEarphone.Playing();
        }
    }

}
