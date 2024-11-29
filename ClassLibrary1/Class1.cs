using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    // Абстрактний продукт A
    public interface IChair
    {
        string GetModel();
    }

    // Абстрактний продукт B
    public interface ITable
    {
        string GetMaterial();
    }

    // Абстрактна фабрика
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }

    // Реалізація продуктів для Стильної фабрики
    public class ModernChair : IChair
    {
        public string GetModel() => "Модерний стілець";
    }

    public class ModernTable : ITable
    {
        public string GetMaterial() => "Скляний стіл";
    }

    // Реалізація продуктів для Класичної фабрики
    public class ClassicChair : IChair
    {
        public string GetModel() => "Класичний стілець";
    }

    public class ClassicTable : ITable
    {
        public string GetMaterial() => "Дерев'яний стіл";
    }

    // Конкретна фабрика - Modern
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();
        public ITable CreateTable() => new ModernTable();
    }

    // Конкретна фабрика - Classic
    public class ClassicFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ClassicChair();
        public ITable CreateTable() => new ClassicTable();
    }
}
