//using System;
//using System.Text;

//class Program
//{

//    static string BuildArrayString(int[][] array, int numLength)
//    {
//        var result = new StringBuilder();
//        int length = array.GetLength(0);

//        for (int i = 0; i < length; i++)
//        {
//            foreach (var num in array[i])
//                result.Append(num.ToString().PadLeft(numLength));
//            result.AppendLine();
//        }

//        return result.ToString();
//    }

//    static void Main()
//    {
//        const int arrayLength = -100;
//        const int maxNumber = 100;
//        const int numLength = 3;

//        var random = new Random();
//        var array = new int[arrayLength][];

//        for (int i = 0; i < arrayLength; i++)
//        {

//            array[i] = new int[arrayLength];
//            for (int k = 0; k < arrayLength; k++)
//                array[i][k] = random.Next(maxNumber);
//            {

//                Console.WriteLine(BuildArrayString(array, numLength));
//                Console.Write("Vajutage sortimiseks suvalist klahvi...");
//                Console.ReadKey(true);
//                Console.SetCursorPosition(0, 0);


//                for (int i = 0; i < arrayLength; i++)
//                {
//                    Array.Sort(array[i]);
//                    if (i % 2 == 1)
//                        Array.Reverse(array[i]);
//                }

//                Console.WriteLine(BuildArrayString(array, numLength));
//                Console.Write($"1 (с 1 по {arrayLength}): ");

//                int numCollumn;
//                if (int.TryParse(Console.ReadLine(), out numCollumn) && numCollumn > 0 && numCollumn <= arrayLength)
//                {
//                    numCollumn--;
//                    Console.Write("Tulemus: ");
//                    for (int i = 0; i < arrayLength; i++)
//                        Console.Write(array[i][numCollumn].ToString().PadLeft(numLength));
//                    Console.WriteLine();
//                }
//                else
//                    Console.WriteLine("Määratud vigane väärtus!");

//                Console.WriteLine();
//                Console.Write("Väljumiseks vajutage suvalist klahvi...");
//                Console.ReadKey(true);
//            }
//        }





//using System;

//class Student
//{
//    // Определение имён,фамилий класса 
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string GroupCode { get; set; }
//    public int[] Grades { get; set; }

//    public Student(string firstName, string lastName, string groupCode, int[] grades)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        GroupCode = groupCode;
//        Grades = grades;
//    }

//    // Метод определяющий, будет ли студент включен в приказ на отчисление
//    public bool IsEligibleForExpulsion()
//    {
//        int countLowGrades = 0;   // Переменная для подсчета количества оценок "2"
//        foreach (int grade in Grades)  // Перебор оценок в массиве
//        {
//            if (grade <= 2)  // Если оценка меньше или равна 2
//            {
//                countLowGrades++;  // Увеличивает счетчик оценок "2"
//            }
//        }
//        return countLowGrades >= 3; // Результат: если оценок "двойка"true; 3 или больше, иначе false
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Создаем массив студентов
//        Student[] students = new Student[]
//        {
//            new Student("Peter", "Lill", "LOGrv21", new int[] { 5, 4, 3, 2, 2 }),
//            new Student("Vladimir", "Pupkin", "LOGrv21", new int[] { 4, 3, 2, 2, 2 }),
//            new Student("Maksim", "Martsinkevitch", "SKINtv22", new int[] { 3, 3, 3, 3, 3 }),
//            new Student("Artur", "Valge", "VRONhp20", new int[] { 2, 3, 2, 2, 2 }),
//            new Student("Olga", "Smirnova", "LOBpv23", new int[] { 5, 4, 5, 4, 5 }),
//            new Student("Inga", "Pop", "LOBpv23", new int[] { 5, 2, 5, 2, 5, 2, 3}),
//        };

//        Console.WriteLine("Väljaarvamise korraldusse kaasatud õpilased:");
//        foreach (Student student in students)
//        {
//            if (student.IsEligibleForExpulsion()) //Если студент подлежит отчислению пишется его фамилия и группа
//            {
//                Console.WriteLine($"{student.LastName} - {student.GroupCode}");
//            }
//        }
//    }
//}
