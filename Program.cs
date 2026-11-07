// Задание 1.1
// // for (int i = 10; i >= 1; i--)
// // {
// //     Console.WriteLine(i);
// // }
// Задание 1.2
// for (int i = 2; i <= 50; i+=2) {
//     Console.WriteLine(i);
// }

// Задание 2
// int count = 0;
// int sum = 0;

// for (int i = 1; i <= 100; i++) {
//     if (i % 3 == 0){
//         sum += i;
//     }
        
//     if (i % 7 == 0){
//         count++;
//     }
// }
// Console.WriteLine($"Сумма кратных трём: {sum}");
// Console.WriteLine($"Кол-во кратных семи: {count}");



// // Задание 3
// int number = Convert.ToInt32(Console.ReadLine());
// int plus = 0;
// int minus = 0;

// while (number != 0) {
//     if (number > 0) {
//         plus++;
//     }
//     else {
//         minus++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"Положительных: {plus}");
// Console.WriteLine($"Отрицательных: {minus}");



// Задание 4
// bool access = false;

// for (int i = 1; i <= 3; i++) {
//     Console.Write("Введите пароль: ");
//     string password = Console.ReadLine();

//     if (password == "qwerty") {
//         Console.WriteLine("Доступ разрешён");
//         access = true;
//         break;
//     }
// }

// if (!access) {
//     Console.WriteLine("Доступ заблокирован");
// }

//задание 5

// int num = int.Parse(Console.ReadLine());

// for (int i = 1; i<=10; i++) {
//     Console.WriteLine($"{num} x {i} = {num*i}");
// }
    
//задагие 6
// for (int i = 1; i <= 30; i++) {
//     if (i % 10 == 0 && i > 20) {
//         break;
//     }

//     if (i % 3 == 0) {
//         continue;
//     }

//     Console.WriteLine(i);
// }




//задание 7 угадай число

// Итоговая задача
int secret = 42;
bool flag = false;

for (int i = 1; i <= 5; i++) {
    Console.Write($"Попытка {i}. Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num == secret) {
        Console.WriteLine($"Победа! Попыток: {i}");
        flag = true;
        break;
    }
    else if (num < secret) {
        Console.WriteLine("Больше");
    }
    else {
        Console.WriteLine("Меньше");
    }
}

if (!flag) {
    Console.WriteLine($"Вы проиграли, число было {secret}");
}