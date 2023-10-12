// See https://aka.ms/new-console-template for more information
//Console.WriteLine("pedro pica piedras");


//programa que calcula el area de un rectangulo 
//int ladoA; //declaracion de variables
//int ladoB;
//int resultado;
//double ladoA; //declaracion de variables
//double ladoB;
//double resultado;
//var ladoA = 1.1; //declaracion de variables
//var ladoB = 1.1;
//var resultado =  1.1;
var ladoA = 0d; //declaracion de variables
var ladoB = 0d;
var resultado = 0d;
Console.WriteLine("Calcula el area de un rectangulo!!");
Console.WriteLine("Ingrese el valor del Lado A");
//ladoA = Convert.ToInt32(Console.ReadLine());
ladoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el valor del Lado B");
//ladoB = Convert.ToInt32(Console.ReadLine());
ladoB = Convert.ToDouble(Console.ReadLine());

//ladoA = ladoA + 1;
//ladoA++;
//ladoA--;

//resultado = (ladoA * ladoB)/2;
resultado = (ladoA % ladoB);

Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB+ "  Resultado es: " + resultado);