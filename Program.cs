using Aves;
using Curso;
// See https://aka.ms/new-console-template for more information


/*
    Principio de sustitución de Liskov
    la noción de que los objetos de un programa
    deberian ser reemplazables por instancias
    de sus subtipos
    sin alterar el correcto funcionamiento del programa"
*/
Ave ave = new Pinguino(5);
AveVoladora aveVoladora = new Aguila(10,100);
AveNoVoladora noVoladora = new Pinguino(5);
Ave ave1 = new Aguila(10.100);

Printer.PrintAve(new Aguila(10,100));
Printer.PrintAve(new Pinguino(5));
Printer.PrintAveVoladora(new Aguila(10,100));
Printer.PrintAveNoVoladora(new Pinguino(5));

Foo foo= new(1,"Julián");
Foo foo1= new(1,"Julián Gómez");
Console.WriteLine(foo1.Equals(foo1));
// inferencia de tipos

// Sugar Sintax

var foo2= new Foo(2,"Julián Gómez González");

Console.WriteLine(foo.Name);
Console.WriteLine(foo1.Name);
