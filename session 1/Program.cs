using System;
using System.Text;

namespace ConsoleApp1
{
    class BaiTap1
    {
        public static double CalculateBaseTicketPrice(double height, int age)
        {

            if (age >= 60)
            {
                return 40000;
            }
            else if (height < 1.2)
            {
                return 50000;



            }
            else
            {
                return 100000;
            }


        }
            public static double ApplyDiscount(double totalAmount, string dayOfWeek, bool isMember)
            {
            
                if(dayOfWeek=="Tuesday")
                {
                    totalAmount *= 0.9;
                }
                else if(dayOfWeek=="Wednesday")
                {
                    totalAmount *= 0.85;
                }  
                if(isMember==true)
                {
                    totalAmount *= 0.95;
                }
                return totalAmount;
            }
           
        public static void ProcessSingleOrder()
        {
            Console.WriteLine("Nhập số lượng khách hàng trong nhóm");
            int n = int.Parse(Console.ReadLine());
            double totalbaseprice = 0;
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine("Nhập chiều cao của từng người");
                double height=double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập tuổi của từng người");
                int age= int.Parse(Console.ReadLine());
                totalbaseprice += CalculateBaseTicketPrice(height, age);
                Console.WriteLine($"Tổng tiền gốc là:{totalbaseprice}");
            }
            Console.WriteLine("Nhập vào thứ");
            string dayOfWeek = Console.ReadLine();
            Console.WriteLine("có phải thành viên hay không");
            bool isMember = bool.Parse(Console.ReadLine());
            double finalprice= ApplyDiscount(totalAmount, dayOfWeek, isMember);
            double discount = totalbaseprice - finalprice;
            Console.WriteLine($"số tiền giảm giá là:{discount}");
            Console.WriteLine($"Số tiền thực là:{finalprice}");

        }
    
public static void Run()
        {
            ProcessSingleOrder();
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                BaiTap1.Run();
               
                

                Console.ReadLine();
            }
        }
    

