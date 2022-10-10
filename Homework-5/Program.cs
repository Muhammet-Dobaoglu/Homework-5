#region Üniversite Not Hesapla

using System.Globalization;

Console.Write("Vize Notunuz : ");
int vize = int.Parse(Console.ReadLine());

Console.Write("Final Notunuz : ");
int final = int.Parse(Console.ReadLine());

double ort = vize * .4 + final * .6;


if (ort>=50)
{
    Console.WriteLine($"Notunuz : {ort} ");
}

else
{
    Console.Write("Bütünleme Notunuz : ");
    int but = int.Parse(Console.ReadLine());
    double ort2 = vize * .4 + but * .6;

    Console.WriteLine($"Notunuz : {ort2}");
}


#endregion
