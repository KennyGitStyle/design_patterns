using System;

namespace DesignPatterns.Builder_Pattern
{
    public class ToyotaBuilder : CarBuilder
    {
        public override void BuildEngine()
        {

        }

        public override void BuildBumpers()
        {

        }

        public override void WireElectrics()
        {

        }

        public override void InstallRadio()
        {
            
        }

        public override CarBrand GetResult() => CarBrand.Toyota;
    }
}