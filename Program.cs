
// Вітаю, мене звати Семен, або просто Сем, так звуть у німецькому колективі. живу та працюю у Німеччині розробником програмного забезпечення для сонячних електростанцій.
// Back-end веб розробка на Python та DataScience це моє, знаю багато фреймворків. Але я був першим програмістом на цій фірмі і тому я можна сказати Full Stack.
// Вже багато проектів, деякі є на гітхаб але далеко не всі, та всі вони написані на Python, JavaScript, HTML, CSS. Працюю з API, базами даних.Ubuntu - це моя 
// основна робоча ОС, є також МacOS. Docker, Kubernetes - також використовую на практиці.

// Абсолютно не знайомий з .NET , C# та все що з ними зв'язано. Код нижче - це перший опит на С#.  
// Моя ціль - хочу розбиратись у Blazer, або подібному фреймворку на тому ж рівні що і у Python. Тому хочу винести з курсу як можно більше.
// Дякую.


// Створюємо змінну для імені
string name = "Vasya";

// Створюємо змінну для прізвища
string surname = "Pupkin";

// Створюємо змінну для віку
int age = 33;

// Виводимо значення змінних
Console.WriteLine(name);
Console.WriteLine(surname);
Console.WriteLine(age);

// Додаємо ще кілька змінних
string cityName = "Kyiv";
string countryName = "Ukraine";
int population = 2800000;

// Виводимо значення нових змінних
Console.WriteLine(cityName);
Console.WriteLine(countryName);
Console.WriteLine(population);


// Запитуємо користувача ввести ширину прямокутника
Console.Write("Enter the width of the rectangle: ");
int width = int.Parse(Console.ReadLine());

// Запитуємо користувача ввести висоту прямокутника
Console.Write("Enter the height of the rectangle: ");
int height = int.Parse(Console.ReadLine());

// Малюємо прямокутник з зірочок
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Запитуємо користувача ввести довжину прямокутника
Console.Write("Enter the length of the rectangle: ");
int length = int.Parse(Console.ReadLine());

// Запитуємо користувача ввести ширину прямокутника
Console.Write("Enter the width of the rectangle: ");
int newwidth = int.Parse(Console.ReadLine());

// Малюємо прямокутник з пустим серединкою
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < newwidth; j++)
    {
        if (i == 0 || i == length - 1 || j == 0 || j == newwidth -1)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}

// Запитуємо користувача ввести початок діапазону
Console.Write("Enter the start of the range: ");
int start = int.Parse(Console.ReadLine());

// Запитуємо користувача ввести кінець діапазону
Console.Write("Enter the end of the range: ");
int end = int.Parse(Console.ReadLine());

// Виводимо таблицю множення для чисел з діапазону
for (int i = start; i <= end; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{i}*{j} = {i * j} ");
    }
    Console.WriteLine();
}

// Запитуємо користувача ввести розмір клітинки шахової дошки
Console.Write("Enter the cell size of the chessboard: ");
int cellSize = int.Parse(Console.ReadLine());

// Малюємо шахову дошку
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        for (int k = 0; k < cellSize; k++)
        {
            if ((i + j) % 2 == 0)
                Console.Write("*");
            else
                Console.Write("-");
        }
    }
    Console.WriteLine();
}

// Запитуємо користувача ввести ціле число A
Console.Write("Enter an integer A: ");
int a = int.Parse(Console.ReadLine());

// Виводимо числа, які задовольняють умові задачі
for (int b = 1; b <= a; b++)
{
    if (a % (b * b * b) == 0 && a % (b * b * b * b) != 0)
    {
        Console.WriteLine(b);
    }
}
