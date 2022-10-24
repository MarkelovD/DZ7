// 1 задача
// Кол-во строк 
//Console.WriteLine("введите число строк");
//int rows = int.Parse(Console.ReadLine()!);
// Кол-во столбцов
//Console.WriteLine("введите число столбцов");
//int columns = int.Parse(Console.ReadLine()!);
//int [,] array = GetArray(rows, columns, 0, 10); // вызов метода (rows)-строки (columns)-стобцы,мин знач, макс знач
//PrintArray(array); //печать массива

// 2 задача
//Кол-во строк 
Console.WriteLine("введите число строк");
int rows = int.Parse(Console.ReadLine()!);
//Кол-во столбцов
Console.WriteLine("введите число столбцов");
int columns = int.Parse(Console.ReadLine()!);
//вывод оригинального массива
int [,] array = GetArray(rows, columns, 0, 10); // вызов метода (rows)-строки (columns)-стобцы,мин знач, макс знач
PrintArray(array); //печать массива
// ввод индекса
Console.WriteLine("введите индес строки элемента массива");
int NumsRows = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите индес столбца элемента массива");
int NumsColumns = int.Parse(Console.ReadLine()!);
SearchItems(array, NumsRows, NumsColumns);


// блок методов

// метод поиска введенного элемента по индексу
void SearchItems(int[,] Array, int a, int b){
    //проверка на превышение размеров массива
    if (a>Array.GetLength(0)|b>Array.GetLength(1)){
            Console.WriteLine("вышли за пределы массива");
    }
// поиск значения соответствующее введенному индексу
     for(int i = 0; i < Array.GetLength(0); i++){ 
        for(int j = 0; j < Array.GetLength(1); j++){ 
            if (a==i){
                if (b==j){
                    Console.WriteLine($"элемент позиции [{i},{j}] = {Array[i,j]}");
                }
                }
        }   
    }
}


// метод создания 2х мерного массива
void PrintArray(int[,] Array){ 
    for(int i = 0; i < Array.GetLength(0); i++){ // заполнение строк (0)
        for(int j = 0; j < Array.GetLength(1); j++){ // заполнение столбцов (1)
            Console.Write($"{Array[i,j]} "); // вывод заполненого массива
                }
        Console.WriteLine(); // переход но новую строку массива
    }
}
// метод заполнения массива случайными числами
int[,] GetArray(int m, int n, int minValue, int maxValue){ 
    int [,] result = new int[m,n];// присвоение массиву временного значения
    for(int i = 0; i < m; i++){// проход по строкам
        for(int j = 0; j < n; j++){// проход по столбцам
            result[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return result; //возвращение заполненного массива
}