namespace Laba7.Two
{
    public class ExecutiveCar : Automobile
    {
        private bool hasAirConditioning;

        public ExecutiveCar()
        {
        }

        public ExecutiveCar(string name, int speed, string color, bool hasAirConditioning) : base(name, speed, color)
        {
            this.hasAirConditioning = hasAirConditioning;
        }

        public bool HasAirConditioning
        {
            get => hasAirConditioning;
            set => hasAirConditioning = value;
        }

        public override int GetPrice()
        {
            return speed * 250;
        }

        public override void Update()
        {
            speed += 50;
        }

        public override string GetInfo()
        {
            return base.GetInfo() 
                   + $"\n{nameof(hasAirConditioning)}: {hasAirConditioning}";
        }

    }
}