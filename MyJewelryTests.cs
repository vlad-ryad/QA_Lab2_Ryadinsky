using System;
using System.IO;
using Xunit;

namespace MyJewelry.Tests
{
    public class MyJewelryTests
    {
        // Тест для проверки корректности расчета стоимости в BasicHelper1
        [Fact]
        public void BasicHelper1_GetCost_Returns_CorrectValue()
        {
            // Arrange
            int weight = 10;
            int price = 20;
            BasicHelper1 basicHelper1 = new BasicHelper1();
            basicHelper1.Init(weight, price);

            // Act
            int cost = basicHelper1.GetCost();

            // Assert
            Assert.Equal(weight * price, cost);
        }

        // Тест для проверки корректности ввода данных в BasicHelper2
        [Fact]
        public void BasicHelper2_Read_CorrectInput()
        {
            // Arrange
            var basicHelper2 = new BasicHelper2();
            var weight = 10;
            var price = 20;
            var expectedWeight = 30;
            var expectedPrice = 40;
            var input = new StringReader($"{expectedWeight}\n{expectedPrice}");

            // Act
            Console.SetIn(input);
            basicHelper2.Read();

            // Assert
            Assert.Equal(expectedWeight, basicHelper2.weight);
            Assert.Equal(expectedPrice, basicHelper2.price);
        }

        // Тест для проверки корректности расчета стоимости в DerivedHelper1
        [Fact]
        public void DerivedHelper1_GetCost_CorrectCalculation()
        {
            // Arrange
            var derivedHelper1 = new DerivedHelper1();
            var weight = 10;
            var price = 20;
            var derivedField1 = 3;
            derivedHelper1.Init(weight, price, derivedField1);

            // Act
            var cost = derivedHelper1.GetCost();

            // Assert
            Assert.Equal(weight * price * derivedField1, cost);
        }

        // Тест для проверки корректности расчета стоимости в DerivedHelper2
        [Fact]
        public void DerivedHelper2_GetCost_CorrectCalculation()
        {
            // Arrange
            var derivedHelper2 = new DerivedHelper2();
            var weight = 10;
            var price = 20;
            var derivedField2 = 4;
            derivedHelper2.Init(weight, price, derivedField2);

            // Act
            var cost = derivedHelper2.GetCost();

            // Assert
            Assert.Equal(weight * price * derivedField2, cost);
        }

        // Тест для проверки корректности расчета стоимости в ThirdDerivedJewelry
        [Fact]
        public void ThirdDerivedJewelry_GetCost_CorrectCalculation()
        {
            // Arrange
            var thirdDerivedJewelry = new ThirdDerivedJewelry();
            var weight = 10;
            var price = 20;
            var derivedField2 = 2;
            thirdDerivedJewelry.Init(weight, price);
            var expectedCost = (weight * price) + (weight * price * derivedField2);

            // Act
            var cost = thirdDerivedJewelry.GetCost();

            // Assert
            Assert.Equal(expectedCost, cost);
        }

        // Тест для проверки корректности расчета стоимости в FirstDerivedJewelry
        [Fact]
        public void FirstDerivedJewelry_GetCost_CorrectCalculation()
        {
            // Arrange
            var firstDerivedJewelry = new FirstDerivedJewelry();
            var weight = 10;
            var price = 20;
            firstDerivedJewelry.Init(weight, price);

            // Act
            var cost = firstDerivedJewelry.GetCost();

            // Assert
            Assert.Equal(weight * price * 2, cost); // Since it consists of two basic helpers
        }

        // Тест для проверки корректности расчета стоимости в SecondDerivedJewelry
        [Fact]
        public void SecondDerivedJewelry_GetCost_CorrectCalculation()
        {
            // Arrange
            var secondDerivedJewelry = new SecondDerivedJewelry();
            var weight = 10;
            var price = 20;
            secondDerivedJewelry.Init(weight, price);

            // Act
            var cost = secondDerivedJewelry.GetCost();

            // Assert
            Assert.Equal(weight * price * 2 * 2, cost); // Since it consists of two derived helpers with additional factor 2
        }

        // Тест для проверки корректной инициализации в JewelryStore
        [Fact]
        public void JewelryStore_Init_CorrectInitialization()
        {
            // Arrange
            var jewelryStore = new JewelryStore();
            var quantity1 = 10;
            var quantity2 = 20;
            var quantity3 = 30;
            var accessoriesCost = 500;
            var weight1 = 40;
            var price1 = 500;
            var weight2 = 35;
            var price2 = 120;
            var weight3 = 55;
            var price3 = 200;

            // Act
            jewelryStore.Init(quantity1, quantity2, quantity3, accessoriesCost, weight1, price1, weight2, price2, weight3, price3);

            // Assert
            Assert.Equal(quantity1, jewelryStore.quantity1);
            Assert.Equal(quantity2, jewelryStore.quantity2);
            Assert.Equal(quantity3, jewelryStore.quantity3);
            Assert.Equal(accessoriesCost, jewelryStore.accessoriesCost);
            Assert.Equal(weight1, jewelryStore.jewelry1.helper1.weight);
            Assert.Equal(price1, jewelryStore.jewelry1.helper1.price);
            Assert.Equal(weight2, jewelryStore.jewelry2.helper1.weight);
            Assert.Equal(price2, jewelryStore.jewelry2.helper1.price);
            Assert.Equal(weight3, jewelryStore.jewelry3.helper1.weight);
            Assert.Equal(price3, jewelryStore.jewelry3.helper1.price);
        }

        // Тест для проверки корректности ввода данных в BasicHelper2
        [Fact]
        public void BasicHelper2_Read_InputDataIsParsedCorrectly()
        {
            // Arrange
            var basicHelper2 = new BasicHelper2();
            var weight = 10;
            var price = 20;
            var expectedWeight = 30;
            var expectedPrice = 40;
            var input = new StringReader($"{expectedWeight}\n{expectedPrice}");

            // Act
            Console.SetIn(input);
            basicHelper2.Read();

            // Assert
            Assert.Equal(expectedWeight, basicHelper2.weight);
            Assert.Equal(expectedPrice, basicHelper2.price);
        }
        // 
        // Тест для проверки корректности расчета стоимости в FirstDerivedJewelry
        [Fact]
        public void FirstDerivedJewelry_GetCost_ReturnsCorrectValue()
        {
            // Arrange
            var firstDerivedJewelry = new FirstDerivedJewelry();
            var weight = 10;
            var price = 20;
            firstDerivedJewelry.Init(weight, price);

            // Act
            var cost = firstDerivedJewelry.GetCost();

            // Assert
            Assert.Equal(weight * price * 2, cost); // Since it consists of two basic helpers
        }
    }
}
