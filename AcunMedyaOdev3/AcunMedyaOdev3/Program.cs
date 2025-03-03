// See https://aka.ms/new-console-template for more information

using AcunMedyaOdev3.Classes;

Bmw b = new Bmw();
Mercedes m = new Mercedes();
Porche p = new Porche();

double toplamYakit = 0;

toplamYakit = b.yakitTuketimi() + m.yakitTuketimi() + p.yakitTuketimi();

Console.WriteLine("Tüketilen toplam yakıt = "+toplamYakit+" L");
