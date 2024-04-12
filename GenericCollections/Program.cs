//использование методов
using GenericCollections;

List<double> scores = new List<double>() { 2.3, 4.5, 1.1, 5.6, 3.8, 4.7 };
double maxScore = GenericCollectionCustomMethods.GetMaxScore(scores);
Console.WriteLine($"Наивысший рейтинг - {maxScore}");


List<double> prices = new List<double>() { 23, 10, 15.5, 42, 12};
List<double> pricesWithMarkup = GenericCollectionCustomMethods.CalculatePricesWithMarkup(prices, 18);
GenericCollectionCustomMethods.Print(pricesWithMarkup);

List<double> salesResults = new List<double>() { 32, 12.5, 25.5, 18, 29.3, 30, 15, 33.3 };
int failedClerks = GenericCollectionCustomMethods.CountUnderachievingClerks(salesResults, 20);
Console.WriteLine($"Количество работников, не выполнивших норму -  {failedClerks} ");