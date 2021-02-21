namespace DesignPatterns.Builder_Pattern
{
    public class Director
    {

        private readonly CarBuilder _carBuilder;
        public Director(CarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void Implement(bool isPassenger){
            _carBuilder.WireElectrics();
            _carBuilder.BuildEngine();
            _carBuilder.BuildBumpers();

            if(isPassenger) 
                _carBuilder.InstallRadio();
        }
    }
}