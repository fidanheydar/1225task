
#region  Task1
//Console.Write("Enter the text:");
//string text=Console.ReadLine();
//string result = "";
//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] != ' ')
//    {
//        result += text[i];
//    }
//}
//Console.Write("New text:"+result);
#endregion

#region Task2
//Console.Write("Array uzunlugunu daxil edin:");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write($"{i + 1} ci ededi daxil edin:");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}
//bool index = false;
//Console.Write("Ededi daxil edin: ");
//int indexNum = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == indexNum)
//    {
//        Console.Write("Ededin indexi: " + i);
//        index = true;
//        break;
//    }
//}

//if (!index)
//{
//    Console.WriteLine("Eded arrayde yoxdur!");
//}


#endregion

#region Task3

//Console.Write("Array uzunlugunu daxil edin:");
//int n =Convert.ToInt32(Console.ReadLine());
//string[] arrTxt= new string[n];
//int count= 0;
//for (int i = 0; i < arrTxt.Length; i++)
//{
//    Console.WriteLine($"{i+1} ci yazini daxil edin:");
//    arrTxt[i] = Console.ReadLine();
//}
//Console.Write("Herfi daxil edin:");
//char character=Convert.ToChar(Console.ReadLine());

//for (int i = 0;i < arrTxt.Length; i++)
//{
//    for (int j = 0; j < arrTxt[i].Length; j++)
//    {
//        if (arrTxt[i][j] == character) { count++; }
//    }
//}
//if (count > 0)
//{
//    Console.WriteLine("Verilmish herfden "+ count + "eded var");
//}
//else Console.WriteLine("Verilmish herf verilmish yazilarda yoxdur");

#endregion

#region Task4



#endregion

#region Task5
//Console.Write("Ilk ededi daxil edin: ");
//double firstNum = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ikinci ededi daxil edin: ");
//double secNum = Convert.ToInt32(Console.ReadLine());
//bool check = false;
//do
//{
//    Console.Write("Simvolu daxil edin: ");
//    string symbol = Console.ReadLine();
//    check = true;

//    switch (symbol)
//    {
//        case "+":
//            Console.WriteLine($"Cem: {firstNum + secNum}");
//            break;
//        case "-":
//            Console.WriteLine($"Ferq: {firstNum - secNum}");
//            break;
//        case "*":
//            Console.WriteLine($"Hasil: {firstNum * secNum}");
//            break;
//        case "/":
//            if (secNum != 0)
//            {
//                Console.WriteLine($"Nisbet: {firstNum / secNum}");
//            }
//            else
//            {
//                check = false;
//                Console.WriteLine("Xeta: 0-a bolmek mumkun deyil!");
//            }
//            break;
//        default:
//            check = false;
//            Console.WriteLine(" Yalnısh simvol. Duzgun simvol daxil edin!!");
//            break;
//    }
//} while (!check);





#endregion



Console.Write("Yazi daxil edin:");
string text = Console.ReadLine();
string newText = "";
int startIndex = 0;
while (startIndex < text.Length && text[startIndex] == ' ')
{
    startIndex++;
}
for (int i = startIndex; i < text.Length; i++)
{
    newText += text[i];
}

Console.Write("Netice:" + newText);





