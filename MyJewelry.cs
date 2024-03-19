using System;

namespace MyJewelry
{
    using System;

    // Абстрактный класс для ювелирных изделий
    public abstract class Jewelry
    {
        public int weight;
        public int price;

        // Методы, которые должны быть реализованы в производных классах
        public abstract void Init(int _weight, int _price); // Инициализация веса и цены
        public abstract void Read(); // Ввод данных
        public abstract void Display(); // Вывод данных
        public abstract int GetCost(); // Получение стоимости
    }

    // Базовый класс BasicHelper1 для первого вспомогательного изделия
    public class BasicHelper1 : Jewelry
    {
        public override void Init(int _weight, int _price)
        {
            weight = _weight;
            price = _price;
        }

        public override void Read()
        {
            // Ввод данных с консоли
            Console.Write("Введите вес изделия BasicHelper1: ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену за грамм изделия BasicHelper1: ");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            // Вывод данных в консоль
            Console.WriteLine($"Вес изделия BasicHelper1: {weight} грамм");
            Console.WriteLine($"Цена за грамм изделия BasicHelper1: {price} рублей");
            Console.WriteLine($"Стоимость изделия BasicHelper1: {GetCost()} рублей");
        }

        public override int GetCost()
        {
            return weight * price;
        }
    }

    // Класс BasicHelper2 для второго вспомогательного изделия
    public class BasicHelper2 : Jewelry
    {
        // Реализация методов базового класса
        public override void Init(int _weight, int _price)
        {
            weight = _weight;
            price = _price;
        }

        public override void Read()
        {
            Console.Write("Введите вес изделия для BasicHelper2: ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену за грамм изделия для BasicHelper2: ");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            Console.WriteLine($"Вес изделия BasicHelper2: {weight} грамм");
            Console.WriteLine($"Цена за грамм изделия BasicHelper2: {price} рублей");
            Console.WriteLine($"Стоимость изделия BasicHelper2: {GetCost()} рублей");
        }

        public override int GetCost()
        {
            return weight * price;
        }
    }

    // Класс DerivedHelper1 наследует от BasicHelper1 и добавляет новое поле
    public class DerivedHelper1 : BasicHelper1
    {
        public int derivedField1;

        // Инициализация полей базового и производного классов
        public void Init(int _weight, int _price, int _derivedField1)
        {
            base.Init(_weight, _price);
            derivedField1 = _derivedField1;
        }

        // Переопределение метода чтения данных
        public void Read()
        {
            base.Read();
            Console.Write("Введите значение для производного поля 1: ");
            derivedField1 = Convert.ToInt32(Console.ReadLine());
        }

        // Переопределение метода вывода данных
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Производное поле 1: {derivedField1}");
        }

        // Переопределение метода получения стоимости
        public int GetCost()
        {
            return base.GetCost() * derivedField1;
        }
    }

    // Класс DerivedHelper2 наследует от BasicHelper2 и добавляет новое поле
    public class DerivedHelper2 : BasicHelper2
    {
        public int derivedField2;

        public void Init(int _weight, int _price, int _derivedField2)
        {
            base.Init(_weight, _price);
            derivedField2 = _derivedField2;
        }

        public void Read()
        {
            base.Read();
            Console.Write("Введите значение для производного поля 2: ");
            derivedField2 = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine($"Производное поле 2: {derivedField2}");
        }

        public int GetCost()
        {
            return base.GetCost() * derivedField2;
        }
    }

    // Класс FirstDerivedJewelry представляет первое изделие, состоящее из двух базовых классов
    public class FirstDerivedJewelry : Jewelry
    {
        public BasicHelper1 helper1 = new BasicHelper1();
        public BasicHelper2 helper2 = new BasicHelper2();

        public override void Init(int _weight, int _price)
        {
            helper1.Init(_weight, _price);
            helper2.Init(_weight, _price);
        }

        public override void Read()
        {
            helper1.Read();
            helper2.Read();
        }

        public override void Display()
        {
            helper1.Display();
            helper2.Display();
        }

        public override int GetCost()
        {
            return helper1.GetCost() + helper2.GetCost();
        }
    }

    // Класс SecondDerivedJewelry представляет второе изделие, состоящее из двух производных классов
    public class SecondDerivedJewelry : Jewelry
    {
        public DerivedHelper1 helper1 = new DerivedHelper1();
        public DerivedHelper2 helper2 = new DerivedHelper2();

        public override void Init(int _weight, int _price)
        {
            helper1.Init(_weight, _price, 2);
            helper2.Init(_weight, _price, 2);
        }

        public override void Read()
        {
            helper1.Read();
            helper2.Read();
        }

        public override void Display()
        {
            helper1.Display();
            helper2.Display();
        }

        public override int GetCost()
        {
            return helper1.GetCost() + helper2.GetCost();
        }
    }

    // Класс ThirdDerivedJewelry представляет третье изделие, состоящее из базового и производного классов
    public class ThirdDerivedJewelry : Jewelry
    {
        public BasicHelper1 helper1 = new BasicHelper1();
        public DerivedHelper2 helper2 = new DerivedHelper2();

        public override void Init(int _weight, int _price)
        {
            helper1.Init(_weight, _price);
            helper2.Init(_weight, _price, 2);
        }

        public override void Read()
        {
            helper1.Read();
            helper2.Read();
        }

        public override void Display()
        {
            helper1.Display();
            helper2.Display();
        }

        public override int GetCost()
        {
            return helper1.GetCost() + helper2.GetCost();
        }
    }

    // Класс JewelryStore представляет ювелирный магазин с тремя типами изделий и количеством их продукции
    public class JewelryStore
    {
        public FirstDerivedJewelry jewelry1 = new FirstDerivedJewelry();
        public SecondDerivedJewelry jewelry2 = new SecondDerivedJewelry();
        public ThirdDerivedJewelry jewelry3 = new ThirdDerivedJewelry();

        public int quantity1;
        public int quantity2;
        public int quantity3;
        public int accessoriesCost;

        // Метод для инициализации данных о количестве и стоимости аксессуаров
        public void Init(int _quantity1, int _quantity2, int _quantity3, int _accessoriesCost, int _weight1, int _price1, int _weight2, int _price2, int _weight3, int _price3)
        {
            quantity1 = _quantity1;
            quantity2 = _quantity2;
            quantity3 = _quantity3;
            accessoriesCost = _accessoriesCost;

            jewelry1.Init(_weight1, _price1);
            jewelry2.Init(_weight2, _price2);
            jewelry3.Init(_weight3, _price3);
        }

        // Метод для ввода данных о количестве и стоимости изделий
        public void Read()
        {
            Console.Write("Введите количество колец: ");
            quantity1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество серег: ");
            quantity2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество цепочек: ");
            quantity3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость дополнительных аксессуаров: ");
            accessoriesCost = Convert.ToInt32(Console.ReadLine());

            jewelry1.Read();
            jewelry2.Read();
            jewelry3.Read();
        }

        // Метод для отображения информации о стоимости и изделиях
        public void Display()
        {
            Console.WriteLine($"Общая стоимость изделий: {(jewelry1.GetCost() * quantity1) + (jewelry2.GetCost() * quantity2) + (jewelry3.GetCost() * quantity3) + accessoriesCost} рублей");

            jewelry1.Display();
            jewelry2.Display();
            jewelry3.Display();
        }
    }

    class MyJewelry
    {
        static void Main(string[] args)
        {
            // Создание объекта магазина и инициализация данных
            JewelryStore jewelryStore = new JewelryStore();
            jewelryStore.Init(10, 20, 30, 500, 40, 500, 35, 120, 55, 200);

            // Ввод данных о количестве и стоимости изделий
            jewelryStore.Read();

            // Отображение информации о стоимости и изделиях
            jewelryStore.Display();

            // Ожидание нажатия клавиши для завершения программы
            Console.ReadKey();
        }
    }

}
