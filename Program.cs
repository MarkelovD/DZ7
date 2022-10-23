// 1 задача
// Кол-во строк 
Console.WriteLine("введите число строк");
int rows = int.Parse(Console.ReadLine()!);
// Кол-во столбцов
Console.WriteLine("введите число столбцов");
int columns = int.Parse(Console.ReadLine()!);
int [,] array = GetArray(rows, columns, 0, 10); // вызов метода (rows)-строки (columns)-стобцы,мин знач, макс знач
PrintArray(array); //печать массива



// блок методов
void PrintArray(int[,] Array){ // метод создания 2х мерного массива
    for(int i = 0; i < Array.GetLength(0); i++){ // заполнение строк (0)
        for(int j = 0; j < Array.GetLength(1); j++){ // заполнение столбцов (1)
            Console.Write($"{Array[i,j]} "); // вывод заполненого массива
                }
        Console.WriteLine(); // переход но новую строку массива
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue){ // метод заполнения массива случайными числами
    int [,] result = new int[m,n];// присвоение массиву временного значения
    for(int i = 0; i < m; i++){// проход по строкам
        for(int j = 0; j < n; j++){// проход по столбцам
            result[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return result; //возвращение заполненного массива
}
