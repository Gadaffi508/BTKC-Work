﻿// See https://aka.ms/new-console-template for more information
namespace Multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera cameraMark = Camera.GetCamera("Nıkon");
            Camera cameraMark2 = Camera.GetCamera("Canon");

            Console.WriteLine(cameraMark.Id);
            Console.WriteLine(cameraMark2.Id);

            Console.ReadLine();
        }
    }
    class Camera
    {
        static Dictionary<string, Camera> _cameras = new Dictionary<string, Camera>();
        static object _lock = new object();
        public Guid Id { get; set; }
        private Camera()
        {
            Id = Guid.NewGuid();
        }
        public static Camera GetCamera(string brand)
        {
            lock(_lock)
            {
                if (!_cameras.ContainsKey(brand))
                {
                    _cameras.Add(brand,new Camera());
                }
            }
            return _cameras[brand];
        }
    }
}
