using System;

namespace DesignPatterns.Builder_Pattern
{
    public abstract class CarBuilder
    {
        public virtual void BuildEngine(){

        }

        public virtual void BuildBumpers(){
            
        }

        public virtual void WireElectrics(){
            
        }

        public virtual void InstallRadio(){

        }

         abstract public CarBrand GetResult();
    }
}