// See https://aka.ms/new-console-template for more information

using OdevAcunMedya2.Classes;

GenelMudur gm = new GenelMudur();
Mudur m = new Mudur();
Programci p = new Programci();
Stajyer s = new Stajyer();

int toplamMaas = 0;
toplamMaas += gm.MaasHesapla();
toplamMaas += m.MaasHesapla();
toplamMaas += p.MaasHesapla();
toplamMaas += s.MaasHesapla();

Console.WriteLine("Toplam maas = "+toplamMaas+" TL");
