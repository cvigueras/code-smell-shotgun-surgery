using Shotgun.Surgery.App;

var randomNumber1 = Number.Create();
var randomNumber2 = Number.Create();

var calculator = new Calculator();
Console.WriteLine("El número Random primero es:" + randomNumber1.Value);
Console.WriteLine("El número Random segundo es:" + randomNumber2.Value);
Console.WriteLine("La suma de los dos números Random es:" + calculator.Sum(randomNumber1, randomNumber2).ToString());
Console.WriteLine("La resta de los dos números Random es:" + calculator.Subtract(randomNumber1, randomNumber2).ToString());
Console.WriteLine("La multiplicación de los dos números Random es:" + calculator.Multiply(randomNumber1, randomNumber2).ToString());
Console.WriteLine("La división de los dos números Random es:" + calculator.Split(randomNumber1, randomNumber2).ToString());
Console.ReadLine();
