using System;

class Program
{
    static void Main()
    {
        Console.Write("nhap so luong day: ");
        int n = int.Parse(Console.ReadLine());



        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("nhap phan tu thu  " + (i + 1) + ":");
            a[i] = int.Parse(Console.ReadLine());
        }
        int max = 0, dem = 0;
         
        for (int i = 0; i < n; i++)
        {
            if(max < a[i])
            {
                max = a[i];
                dem = i+1;
            }
        }
        Console.WriteLine("so lon nhat la :" + max);
        Console.WriteLine("vi tri so lon nhat la: " + dem);
        Console.ReadKey();

    }
}