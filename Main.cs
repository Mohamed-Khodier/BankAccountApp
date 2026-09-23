using System;

namespace BankDemo
{
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string holderName, double initialBalance)
        {
            AccountHolder = holderName;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"تم إضافة: [{amount}] ج.م، الرصيد الحالي: {Balance} ج.م");
            }
            else
            {
                Console.WriteLine("المبلغ يجب أن يكون أكبر من صفر [ج.م]!");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"تم سحب [{amount}] ج.م، الرصيد المتبقي: {Balance} ج.م");
            }
            else
            {
                Console.WriteLine("الرصيد غير كافٍ [ج.م]!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== برنامج إدارة الحساب البنكي ===");

            BankAccount myAccount = new BankAccount("أحمد", 1000.0);

            Console.WriteLine($"الرصيد الأولي: {myAccount.Balance} ج.م\n");

            myAccount.Deposit(500);
            myAccount.Withdraw(300);
            myAccount.Withdraw(2000);

            Console.WriteLine("\n--- طباعة كشف حساب مصغر ---");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"الحساب نشط: #{i} عملية مراجعة رقم");
            }

            Console.WriteLine("\nتم إنهاء البرنامج بنجاح");
        }
    }
}