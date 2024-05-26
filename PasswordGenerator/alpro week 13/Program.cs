internal class Program
{
    private static void Main(string[] args)
    {
        string special = "!@#$%^&*()_+=-\"\\[]{}';:.,<>/?`~|";
        string angka = "0123456789";
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        int simpan = 0;
        int kar = 0;
        int jumspc = 0;
        int jumang = 0;
        int jumlc = 0;
        int jumuc = 0;
        int a = 0;
        Random rnd = new Random();
        List<char> pass = new List<char>();
        Console.Write("Input panjang password: ");
        int panjang = Convert.ToInt32(Console.ReadLine());

            while (panjang < 8)
            {
                Console.WriteLine("Input Tidak Sesuai.");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Input panjang password: ");
                panjang = Convert.ToInt32(Console.ReadLine());
            }

        while (a == 0)
        {
            for (int i = 0; i < panjang; i++)
            {
                simpan = rnd.Next(1, 5);
                if (simpan == 1)
                {
                    kar = rnd.Next(0, special.Length);
                    pass.Add(special[kar]);
                    jumspc++;
                }
                if (simpan == 2)
                {
                    kar = rnd.Next(0, angka.Length);
                    pass.Add(angka[kar]);
                    jumang++; 
                }
                if (simpan == 3)
                {
                    kar = rnd.Next(0, lowercase.Length);
                    pass.Add(lowercase[kar]);
                    jumlc++;
                }
                if (simpan == 4)
                {
                    kar = rnd.Next(0, uppercase.Length);
                    pass.Add(uppercase[kar]);
                    jumuc++;
                }
            }
            if (jumspc == 0 || jumang == 0 || jumlc == 0 || jumuc == 0)
            {
                pass.Clear();
            }
            else
            {
                a = 1;
            }
        }
        Console.Write("Password: ");
        foreach (char i in pass)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}