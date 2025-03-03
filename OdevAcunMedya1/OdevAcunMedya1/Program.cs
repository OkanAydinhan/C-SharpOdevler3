// See https://aka.ms/new-console-template for more information
using OdevAcunMedya1.Classes;

Bmw b = new Bmw();
b.marka = "Bmw";
b.uc(b.marka);
b.yuz(b.marka);
b.cokHizliGit(b.marka);

Console.WriteLine();

Mercedes m = new Mercedes();
m.marka = "Mercedes";
m.uc(m.marka);
m.yuz(m.marka);

Console.WriteLine();

Porche p = new Porche();
p.marka = "Porche";
p.uc(p.marka);