Console.Write("Hangi sayıdan başlamak istediğinizi yazınız : ");
int baslangıc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------------------------------");
Console.Write("Hangi sayıya kadar sıralı toplama işlemi yapmak istediğinizi yazınız : ");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------------------------------");

int toplam = 0;



for (int i = baslangıc; i <= sayi; i++)
{
    toplam += i;

}
Console.WriteLine($"Sonuç : {toplam}");