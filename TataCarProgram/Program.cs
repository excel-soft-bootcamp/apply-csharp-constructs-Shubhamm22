using System;

namespace TataCarProgram
{

    public class TATACar
    {
        static void Main(string[] args)
        {


            VericorEngine _harrier = new VericorEngine();
            Car _newcar = new Car(_harrier);
            _newcar.Drive();
            _newcar.Halt();

            MultiJetEngine _nexon = new MultiJetEngine();
            Car _newcar1 = new Car(_harrier);
            _newcar1.Drive();
            _newcar1.Halt();

            RevorTronEngine _hexa = new RevorTronEngine();
            Car _newcar2 = new Car(_hexa);
            _newcar2.Drive();
            _newcar2.Halt();
        }
       
    }
}