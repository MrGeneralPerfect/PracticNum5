using System;

namespace OfficeEquipment
{
    // Базовый класс для офисного оборудования
    public class OfficeEquip
    {
        public string Model { get; set; } = "Неизвестно"; // Модель оборудования
        private int price; // Цена оборудования
        private int scanSpeed; // Скорость сканирования

        // Свойство для установки и получения цены
        public int Price
        {
            get => price;
            set
            {
                if (value > 0) // Проверка на корректность цены
                    price = value;
                else
                    Console.WriteLine("Некорректная цена");
            }
        }

        // Свойство для установки и получения скорости сканирования
        public int ScanSpeed
        {
            get => scanSpeed;
            set
            {
                if (value > 0 && value <= 200) // Проверка на корректность скорости
                    scanSpeed = value;
                else
                    Console.WriteLine("Некорректная скорость сканирования");
            }
        }

        // Метод для вывода информации об оборудовании
        public virtual void Print()
        {
            Console.WriteLine($"\nМодель: {Model}\nЦена: {Price} рублей\nСкорость сканирования: {ScanSpeed} страниц в минуту");
        }

        // Переопределение метода ToString для вывода информации
        public override string ToString()
        {
            return $"Модель: {Model}, Цена: {Price} рублей, Скорость сканирования: {ScanSpeed} страниц в минуту";
        }
    }

    // Класс для принтера, наследующий от OfficeEquip
    public class Printer : OfficeEquip
    {
        private int storage; // Ёмкость картриджа

        // Свойство для установки и получения ёмкости
        public int Storage
        {
            get => storage;
            set
            {
                if (value > 500 && value <= 15000) // Проверка на корректность ёмкости
                    storage = value;
                else
                    Console.WriteLine("Некорректное значение ёмкости. Должно быть между 500 и 15000 страниц.");
            }
        }

        // Переопределение метода Print для вывода информации о принтере
        public override void Print()
        {
            base.Print(); // Вызов метода базового класса
            Console.WriteLine($"Ёмкость картриджа: {Storage} страниц");
        }

        // Переопределение метода ToString для вывода информации о принтере
        public override string ToString()
        {
            return base.ToString() + $", Ёмкость картриджа: {Storage} страниц";
        }
    }

    // Класс для факса, наследующий от OfficeEquip
    public class Fax : OfficeEquip
    {
        private int phoneLines; // Количество телефонных линий

        // Свойство для установки и получения количества линий
        public int PhoneLines
        {
            get => phoneLines;
            set
            {
                if (value > 0 && value <= 50) // Проверка на корректность количества линий
                    phoneLines = value;
                else
                    Console.WriteLine("Некорректное количество линий. Должно быть между 1 и 50.");
            }
        }

        // Переопределение метода Print для вывода информации о факсе
        public override void Print()
        {
            base.Print(); // Вызов метода базового класса
            Console.WriteLine($"Количество телефонных линий: {PhoneLines}");
        }

        // Переопределение метода ToString для вывода информации о факсе
        public override string ToString()
        {
            return base.ToString() + $", Количество телефонных линий: {PhoneLines}";
        }
    }
}
