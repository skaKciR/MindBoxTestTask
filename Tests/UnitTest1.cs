using AreaLibrary;

namespace Tests
{
    public class Tests
    {
        // Позитивные тесты круга
        [TestCase("Circle",4,50.24)]
        [TestCase("Circle", 10, 314)]
        [TestCase("Circle", 5, 78.5)]
        [TestCase("Circle", 1, 3.14)]
        [TestCase("Circle", 2.5, 19.625)]

        [Test]
        public void CirclePositiveTests(string name,double R,double exp)
        {
            Circle circle = new Circle(name, R);
            Assert.AreEqual(circle.Calc(), exp);
        }

        // Негативные тесты круга
        [TestCase("Circle", 0)]
        [TestCase("Circle", -1)]

        [Test]
        
        public void CircleNegativeTests(string name, double R)
        {
            Assert.Throws<ArgumentException>(() => new Circle(name, R));

        }


        // Позитивные тесты треугольника
        [TestCase("Triangle",3,4,5,6)]
        [TestCase("Triangle", 19, 12, 12, 69.64867191842211)]
        [TestCase("Triangle", 5, 5, 6, 12)]
        [TestCase("Triangle", 15, 13, 4, 24)]
        [TestCase("Triangle", 6, 7, 9, 20.97617696340303)]
        [TestCase("Triangle", 18, 18, 35, 73.72881051529313)]


        [Test]
        public void TriaPositiveTests(string name, double a, double b, double c,double exp)
        {
            Tria tria = new Tria(name,a,b,c);
            Assert.AreEqual(tria.Calc(), exp);
        }

        // Негативные тесты треугольника
        [TestCase("Triangle", 5, 2, 7)]
        [TestCase("Triangle", 14, 2, 8)]
        [TestCase("Triangle", 2, 14, 8)]
        [TestCase("Triangle", 0, 4, 5)]
        [TestCase("Triangle", 3, 0, 5)]
        [TestCase("Triangle", 3, 4, 0)]
        [TestCase("Triangle", 0, 0, 0)]
        [TestCase("Triangle", -1, 4, 5)]
        [TestCase("Triangle", 4, -1, 5)]
        [TestCase("Triangle", 4, 1, -5)]
        [TestCase("Triangle", -4, -1, -5)]


        [Test]
        public void TriaNegativeTests(string name, double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Tria(name, a,b,c));
        }


        // Проверка явл. ли прямоугольным
        [TestCase("Triangle", 3, 4, 5, true)]
        [TestCase("Triangle", 4, 7, 5, false)]
        [TestCase("Triangle", 5, 12, 13, true)]

        [Test]
        public void IsPryam(string name, double a, double b, double c,bool exp)
        {
            Tria tria = new Tria(name, a, b, c);
            Assert.AreEqual(tria.IsPryam(),exp);
        }

    }
}