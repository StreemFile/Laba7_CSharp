namespace Laba7.Two
{
    public class Sportcar : Automobile
    {
        private int numberOfSeats;

        public Sportcar()
        {
        }

        public Sportcar(string name, int speed, string color, int numberOfSeats) 
            : base(name, speed, color)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats
        {
            get => numberOfSeats;
            set => numberOfSeats = value;
        }

        public override void Update()
        {
            speed += 100;
        }

        public override int GetPrice()
        {
            return speed * 350;
        }

        public override string GetInfo()
        {
            return base.GetInfo() 
                + $"\n{nameof(numberOfSeats)}: {numberOfSeats}";;
        }

    }
}