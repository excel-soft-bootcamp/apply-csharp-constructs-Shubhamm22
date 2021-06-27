using System;

namespace TataCarProgram
{

    public class TATACar
    {
        DiCorEngine _diCor;
        Iengine _engineName;
        
        public TataCar(Iengine  engineName)
        {
            this._engineName =engineName;
            diCor = new DiCorEngine();
        }

        public void Drive()
        {

            _diCor.Start();
        }
        public void Halt()
        {

            _diCor.Stop();
        }


    }

    public class DiCorEngine
    {
        public interface IEngine
        {
            public void Drive()
            {

                _diCor.Start();
            }
            public void Halt()
            {

                _diCor.Stop();
            }

        }

    public class VeriCorEngine: IEngine
    {
            public void Drive()
            {

                _diCor.Start();
            }
            public void Halt()
            {

                _diCor.Stop();
            }

            Console.WriteLine("harrier");
    }

    public class MultiJetEngine: IEngine
    {
            public void Drive()
            {

                _diCor.Start();
            }
            public void Halt()
            {

                _diCor.Stop();
            }

            Console.WriteLine("nexon);

    }
    public class RevorTron: IEngine
    {
            public void Drive()
            {

                _diCor.Start();
            }
            public void Halt()
            {

                _diCor.Stop();
            }
           Console.WriteLIne("hexa");
            }

    //BS IV 

    //BS VI

   

    class Program
    {
        static void Main(string[] args)
        {
                
            TATACar _harrier = new TATACar(VeriCorEngine);
            TATACar _nexon = new TATACar(MultiJetEngine);
            RevorTron _hexa = new TATACar(RevorTron);

        }
    }
}
