// string subject = "Программирование";

// foreach (char letter in subject) {
//     System.Console.WriteLine(letter);
// }
// System.Console.WriteLine(subject.Length);

// int[] grades = { 4, 5, 3, 5, 4 };
// int count = 0;

// foreach (int grade in grades) {
//     System.Console.WriteLine(grade);
//     count += grade;
// }
// int averageGrade = count / grades.Length;
// System.Console.WriteLine(averageGrade);

// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;

// foreach (string student in students) {
//     System.Console.WriteLine(student);
//     count++;
// }
// System.Console.WriteLine(count);

// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++) {
//     points[i] += 5;
//     System.Console.WriteLine(points[i]);
// }

// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students) {
//     System.Console.WriteLine($"{number}. {student}");
//     number++;
// }

// System.Console.WriteLine("Задача Б");

// string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// foreach (string day in days) {
//     System.Console.WriteLine($"{day}!");
// }

// System.Console.WriteLine("Задача Г");

// int[] scores = { 4, 5, 3, 5, 4 };
// int max = int.MinValue;

// foreach (int score in scores) {
//     if (max < score) {
//         max = score;
//     }
// }
// System.Console.WriteLine(max);

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;}
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

System.Console.WriteLine("Вариант 1");

int[] temperatures = { 8, 4, 10, 7, 18, 17, 3 };
int count = 0;

foreach (int temperature in temperatures) {
    count += temperature;
}
int averageTemperature = count / temperatures.Length;
System.Console.WriteLine($"Средняя температура за неделю: {averageTemperature}");

System.Console.WriteLine("Вариант 10");

string[] days = { "Суббота", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int countWeekend = 0;

foreach (string day in days) {
    if (day == "Суббота" || day == "Воскресенье") {
        countWeekend++;
    }
}
System.Console.WriteLine(countWeekend);