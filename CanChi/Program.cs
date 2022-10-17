using System;

namespace CanChi
{
    class program
    {
        static void Main(string[] args)
        {
            int Year;
            string Can = "", Chi = "";
            bool isSuccess;
            while (true)
            {
                Console.WriteLine("Nhap 1 nam bat ky: ");
                //Year = Int32.Parse(Console.ReadLine());
                isSuccess = int.TryParse(Console.ReadLine(), out Year);
                while (isSuccess == false)
                {
                    Console.WriteLine("Nhap lai 1 nam bat ky: ");
                    isSuccess = int.TryParse(Console.ReadLine(), out Year);
                }
                switch (Year % 10)
                {
                    case 0:
                        Can = "Canh";
                        break;
                    case 1:
                        Can = "Tan";
                        break;
                    case 2:
                        Can = "Nham";
                        break;
                    case 3:
                        Can = "Quy";
                        break;
                    case 4:
                        Can = "Giap";
                        break;
                    case 5:
                        Can = "At";
                        break;
                    case 6:
                        Can = "Binh";
                        break;
                    case 7:
                        Can = "Dinh";
                        break;
                    case 8:
                        Can = "Mau";
                        break;
                    case 9:
                        Can = "Ky";
                        break;
                }
                switch (Year % 12)
                {
                    case 0:
                        Chi = "Than";
                        break;
                    case 1:
                        Chi = "Dau";
                        break;
                    case 2:
                        Chi = "Tuat";
                        break;
                    case 3:
                        Chi = "Hoi";
                        break;
                    case 4:
                        Chi = "Ty";
                        break;
                    case 5:
                        Chi = "Suu";
                        break;
                    case 6:
                        Chi = "Dan";
                        break;
                    case 7:
                        Chi = "Mao";
                        break;
                    case 8:
                        Chi = "Thin";
                        break;
                    case 9:
                        Chi = "Ty";
                        break;
                    case 10:
                        Chi = "Ngo";
                        break;
                    case 11:
                        Chi = "Mui";
                        break;
                }
                Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can, Chi);
                
            }
            Console.ReadLine();
        }
    }
}
