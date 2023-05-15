using ConsoleApp6.model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

cadastro cadastro = new cadastro();
cadastro.id = 1;
cadastro.nome = "laercio Pinzam";
cadastro.educaçao = "ensino superior";
cadastro.salario = 3.400f;
cadastro.tempodeservico = 8;
cadastro.Codigofunçao = 1;

foreach (var item in cadastro) ;
{
    Console.WriteLine(cadastro);
}

