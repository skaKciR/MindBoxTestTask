namespace AreaLibrary
{
    //Абстрактный класс фигуры

    public abstract class Figure
    {
        public string Type { get; set; }
        public abstract double Calc();
        public Figure(string Type)
        {
            this.Type = Type;
        }
    }
    //Класс для круга

    public class Circle : Figure
    {
        public double R { get; set; }
        public Circle(string Type, double R) : base(Type)
        {
            if (R <= 0)
            {
                throw new ArgumentException("Некорректный радиус! Радиус круга - число положительное.");
            }
            this.R = R;
        }
        public override double Calc()
        {
            return (3.14 * R * R);
        }
    }

    //Класс для треугольника

    public class Tria : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Tria(string Type,double a,double b,double c) : base(Type) 
        {
            
            if((a<=0) || (b<=0) || (c <=0))
            {
                throw new ArgumentException("Введены некорректные длины сторон! Длины всех сторон должны быть больше нуля.");
            }
            else if(( (a + b) <= c) || ((a + c) <= b) || ((b + c) <= a))
            {
                throw new ArgumentException("Не существующий треугольник! Напоминание: Сумма любых двух сторон треугольника должна быть больше третьей стороны");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        // Проверка , является ли треугольник прямоугольным.
        public bool IsPryam()
        {
            if (a * a == b * b + c * c) return true;
            else if (b * b == a * a + c * c) return true;
            else if (c * c == a * a + b * b) return true;
            else return false;
                    
        }
        public override double Calc()
        {
            double P = (a + b + c);
            double p = P / 2;
            return (Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
        }
    }
}