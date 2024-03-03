/*Напишите программу, которая бесконечно запрашивает целые числа с 
консоли. Программа завершается при вводе символа ‘q’ или при вводе 
числа, сумма цифр которого чётная.
*/


while (true)
        {
            string input;
            Console.WriteLine("Введите целое число: ");
            input = Console.ReadLine()!;

            if (input == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            else
            {
                Console.WriteLine("Введите еще одно целое число: ");
                input = Console.ReadLine()!;
            }
        }
    

    
