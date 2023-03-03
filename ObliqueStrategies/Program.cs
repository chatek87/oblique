using ObliqueStrategies;

Random randomColor = new Random();
int colorIndex = randomColor.Next(ColorChooser.Colors.Length - 1);

Console.ForegroundColor = ColorChooser.Colors[colorIndex];


Random randomCard = new Random();
int cardIndex = randomCard.Next(ObliqueStrategiesDeck.Cards.Length - 1);

Console.WriteLine(ObliqueStrategiesDeck.Cards[cardIndex]);



Console.ReadKey();