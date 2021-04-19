namespace Laba7.Two
{
    public class Automobile
    {
        protected string name;
        protected int speed;
        protected string color;

        public Automobile()
        {
        }

        public Automobile(string name, int speed, string color)
        {
            this.name = name;
            this.speed = speed;
            this.color = color;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }
        
        public virtual int GetPrice()
        {
            return speed * 100;
        }

        public virtual void Update()
        {
            speed += 10;
        }

        public virtual string GetInfo()
        {
            return $"{nameof(name)}: {name}, " +
                   $"\n{nameof(speed)}: {speed}, " +
                   $"\n{nameof(color)}: {color}" +
                   $"\nprice: {GetPrice()}";
        }
    }
}