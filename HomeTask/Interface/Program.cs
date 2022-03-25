using HomeTask;
using System;

LadaX4 LadaX4 = new LadaX4();
var A = LadaX4.Age();


int R = LadaX4.Move();
Console.WriteLine($"Время, затраченно на путь, при текущей скорости > or  =  {R} часов");
Console.WriteLine($"Вот столько лет вашей машинке: {A} ");