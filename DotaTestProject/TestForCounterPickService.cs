using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DotaTestProject

{

//ТЕСТ 1. Модульный тест Фертиков
//Проверяется, что метод CalculateScores корректно суммирует преимущество героя против
//одного врага и возвращает ожидаемое значение.
    [TestClass]
    public class CalculateCheck
    {
        [TestMethod]
        public void CalculateScoresCalculateCheck()
        {
            var repo = DemoData.CreateRepository();
            var service = new CounterPickService(repo);

            var enemies = new List<string> { "Sniper" };
            var allies = new List<string>();
            var bans = new List<string>();

            var result = service.CalculateScores(enemies, allies, bans);

            Assert.IsTrue(result.ContainsKey("Phantom Assassin"));
            Assert.AreEqual(7, result["Phantom Assassin"]);
        }
    }
//ТЕСТ 2. Модульный тест Фертиков
//Проверяется, что герои, находящиеся во врагах, союзниках или банах, не попадают в результат.
    [TestClass]
    public class RepeatСheck
    {
        [TestMethod]
        public void CalculateScoresRepeatСheck()
        {
            var repo = DemoData.CreateRepository();
            var service = new CounterPickService(repo);

            var enemies = new List<string> { "Axe" };
            var allies = new List<string> { "Invoker" };
            var bans = new List<string> { "Sniper" };

            var result = service.CalculateScores(enemies, allies, bans);

            Assert.IsFalse(result.ContainsKey("Axe"));
            Assert.IsFalse(result.ContainsKey("Invoker"));
            Assert.IsFalse(result.ContainsKey("Sniper"));
        }
    }

//ТЕСТ 3. Модульный тест Конников
//Проверяется корректная работа метода при отсутствии врагов, союзников и банов.
    [TestClass]
    public class AbsenceCheck
    {
        [TestMethod]
        public void CalculateScoresAbsenceCheck()
        {
            var repo = DemoData.CreateRepository();
            var service = new CounterPickService(repo);

            var result = service.CalculateScores(
                new List<string>(),
                new List<string>(),
                new List<string>());

            Assert.IsTrue(result.Count > 0);
            Assert.IsTrue(result.All(x => x.Value == 0));
        }
    }
//ТЕСТ 4. Нагрузочный тест Чувашев
//Проверяется устойчивость метода при большом количестве входных данных.
    [TestClass]
    public class CheckingForBigData
    {
        [TestMethod]
        public void CalculateScoresCheckingForBigData()
        {
            var repo = DemoData.CreateRepository();
            var service = new CounterPickService(repo);

            var enemies = Enumerable.Repeat("Sniper", 100000).ToList();

            var result = service.CalculateScores(enemies, new List<string>(), new List<string>());

            Assert.IsNotNull(result);
        }
    }

}
