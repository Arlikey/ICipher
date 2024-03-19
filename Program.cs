namespace ICipher
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World!";

            Cipher cipher = new Cipher();

            string encrypt = cipher.Encode(text, 5);
            string decrypt = cipher.Decode(encrypt, 5);

            Console.WriteLine($"Изначальная строка: {text}");
            Console.WriteLine($"Зашифрованная строка: {encrypt}");
            Console.WriteLine($"Расшифрованная строка: {decrypt}");
        }

        public interface ICipher
        {
            string Encode(string str, int key);
            string Decode(string str, int key);
        }

        public class Cipher : ICipher
        {
            public string Encode(string str, int key)
            {
                string encryptedString = "";
                for (int i = 0; i < str.Length; i++)
                {
                    encryptedString += (char)(str[i] + key);
                }
                return encryptedString;
            }

            public string Decode(string str, int key)
            {
                string decryptedString = "";
                for (int i = 0; i < str.Length; i++)
                {
                    decryptedString += (char)(str[i] - key);
                }
                return decryptedString;
            }
        }
    }*/

    /*public class AdditionalTask1
    {
        static void Main(string[] args)
        {
            Product[] products = {
                new Product(){Name = "Книга", Price = 14.99m},
                new Product(){Name = "Телефон", Price = 145.99m},
                new Product(){Name = "Яблоко", Price = 1.99m},
                new Product(){Name = "Нож", Price = 10.99m},
                new Product(){Name = "Машина", Price = 20999.99m}
            };


            Console.WriteLine("Массив до сортировки:\n");
            foreach (Product product in products)
            {
                Console.WriteLine($"Name = {product.Name} | Price = {product.Price}");
            }

            Array.Sort(products);

            Console.WriteLine("\n\nМассив после сортировки:\n");
            foreach (Product product in products)
            {
                Console.WriteLine($"Name = {product.Name} | Price = {product.Price}");
            }
        }

        public class Product : IComparable<Product>
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int CompareTo(Product? other)
            {
                return Price.CompareTo(other.Price);
            }
        }
    }*/

    /*public class AdditionalTask3
    {
        static void Main(string[] args)
        {
            CalculateSum(new int[] { 10, 5, 7, 23 }, (int value) => value > 5);

            CalculateSum(new int[] { 6, 23, 72, 45, 67 }, (int value) => value > 5 && value < 50);
        }

        public static void CalculateSum(int[] array, Predicate<int> predicate)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                    sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }*/

    /*public class AdditionalTask4
    {
        static void Main(string[] args)
        {
            string[] strings = {
                "hello",
                "123",
                "301",
                "1234",
                "31245135",
                "1"
            };

            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }

            Console.WriteLine("\n\n\n");

            string[] sortedStrings = SortStrings(strings, (str1, str2) =>
            {
                int flag = str1.CompareTo(str2);
                if (flag == -1)
                {
                    return true;
                }
                return false;
            }
            );

            for (int i = 0; i < sortedStrings.Length; i++)
            {
                Console.WriteLine(sortedStrings[i]);
            }
        }

        public static string[] SortStrings(string[] strings, Func<string, string, bool> func)
        {
            for (int i = 1; i < strings.Length; i++)
            {
                for (int j = 0; j < strings.Length - 1; j++)
                {
                    if (func(strings[j], strings[j + 1]))
                    {
                        (strings[j], strings[j + 1]) = (strings[j + 1], strings[j]);
                    }
                }
            }
            return strings;
        }
    }*/

    /*public class AdditionalTask5
    {
        static void Main(string[] args)
        {
            Func<string, int> closestToZero = str =>
            {
                string[] numbers = str.Split(' ');
                int closestNumber = int.Parse(numbers[0]);
                int currentNumber;
                for (int i = 1; i < numbers.Length; i++)
                {
                    currentNumber = int.Parse(numbers[i]);
                    if (Math.Abs(currentNumber) <= Math.Abs(closestNumber))
                    {
                        if (Math.Abs(closestNumber) == Math.Abs(currentNumber) && currentNumber < closestNumber) 
                        {
                            continue;
                        }
                        closestNumber = currentNumber;
                    }
                }

                return closestNumber;
            };

            Console.WriteLine(closestToZero("43728 423 935 -213 326 432 231 323 -1 1"));
        }
    }*/

    /*public class AdditionalTask7
    {
        static void Main(string[] args)
        {
            Func<string, int, string> value = (str, count) => 
            {
                if (count <= str.Length)
                {
                    return str.Remove(0, count);
                }
                else
                {
                    throw new Exception("Длина обрезки больше длины строки!");
                }
            };

            Console.WriteLine(value("Строка", 5));
        }

    }*/
}
