#region task1
//using System.Reflection.Metadata.Ecma335;
//using System.Security.Cryptography;
//using System.Xml.Schema;
//Console.WriteLine("artimfaizini daxil edin ");
//int percent = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("arrayin olcusunu  daxil edin ");
//int size = Convert.ToInt32(Console.ReadLine());
//double[] arr = new double[size];
//Console.WriteLine("{0}olculu arrayi doldurun", size);
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());

//}
//PerIncrease(percent, arr);
//static void PerIncrease(double per, double[] arr)
//{
//    double total = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < 20)
//        {
//            arr[i] = arr[i] + (arr[i] * per) / 100;
  
//        }
//        total = total + arr[i];
//    }
//    Console.WriteLine("total:{0}", total);

//}


#endregion

#region task2
Console.Write("sozu daxil edin:");
string word = Console.ReadLine();
Console.Write("Silinecek indexi daxil edin:");
int index=Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < word.Length; i++)
{
    if (i != index)
    {
        Console.Write(word[i]);
    }
    else
    {
        continue;
    }
}


#endregion
