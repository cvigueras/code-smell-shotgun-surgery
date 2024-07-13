using Shotgun.Surgery.App;

int except = 18;
int randomNumber1 = new Random().Next(1, 21);
int randomNumber2 = new Random().Next(1, 21);
if(randomNumber1 == except)
{
    randomNumber1 +=1;
}
if (randomNumber2 == except)
{
    randomNumber2 += 1;
}
var givenNumber1 = Number.Create(randomNumber1);
var givenNumber2 = Number.Create(randomNumber2);
var calculator = new Calculator();
Console.WriteLine("El número Random primero es:" + randomNumber1);
Console.WriteLine("El número Random segundo es:" + randomNumber2);
Console.WriteLine("La suma de los dos números Random es:" + calculator.Sum(givenNumber1, givenNumber2).ToString());
Console.WriteLine("La resta de los dos números Random es:" + calculator.Subtract(givenNumber1, givenNumber2).ToString());
Console.WriteLine("La multiplicación de los dos números Random es:" + calculator.Multiply(givenNumber1, givenNumber2).ToString());
Console.WriteLine("La división de los dos números Random es:" + calculator.Split(givenNumber1, givenNumber2).ToString());
Console.ReadLine();
