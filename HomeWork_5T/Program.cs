/* 1) დაწერეთ კონსოლ აპლიკაცია , რომელიც მომხმარებელს მოსთხოვს შეიტანოს მასივის ზომა და შექმნის ამ ზომის მასივს
 ასევე მომხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ უნდა გადაავსოს მასივი შემოტანილი ინფორმაციით
საბოლოოდ დაბეჭდოს მასივის ყველა ელემენტი*/


//Console.Write("Enter array size: ");
//int arraySize = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[arraySize];
//for (int i = 0; i < arraySize; i++)
//{
//    Console.Write($"Enter number for index {i}: ");
//    int numbers = Convert.ToInt32(Console.ReadLine());
//    array[i] = numbers;
//}
//Console.WriteLine("Here is your array!");
//foreach (int number in array)
//    Console.WriteLine(number);



/* 2) დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს მასივის ზომა და შექმნის ამ ზომის მასივს ასევე 
 * მოხმარებელმა უნდა შეძლოს მასივის ყველა ელემნტის შეტანა და პროგრამამ უნდა გადაავსოს მასივი და შემოტანილი ინფორმაციით 
 * საბოლოოდ დაბეჭდოს მასივი შებრუნებული მიმდევრობით*/

//Console.Write("Enter array size: ");
//int arraySize = Convert.ToInt32(Console.ReadLine());
//int[] arrayReverse = new int[arraySize];
//for (int i = 0; i < arraySize; i++)
//{
//    Console.Write($"Enter number for index {i}: ");
//    int arrayNumb = Convert.ToInt32(Console.ReadLine());
//    arrayReverse[i] = arrayNumb;
//}

//Console.WriteLine("Here is your array in reverse order! ");
//foreach (var numb in arrayReverse.Reverse())
//{
//    Console.WriteLine(numb);
//}



/* 3) დაწერეთ კონსოლ აპლიკაცია რომელიც მომხამრებელს მოსთხოვს შეიტანოს მასივის ზომა და შექმნის ამ ზომის მასივს,
 * ასევე მოხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ უნდა გდაავსოს მასივი შემოტანილი ინფორმაციით.
 * საბოლოოდ დაბეჭდოს მასივის ელემენტების ჯამი*/


//Console.Write("Enter array size: ");
//int arraySize = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[arraySize];
//int sum = 0;
//for (int i = 0; i < arraySize; i++)
//{
//    Console.Write($"Enter number for index {i}: ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    array[i] = number;
//    sum += number;

//}
//Console.WriteLine($"Sum of array elements is {sum}");



/* 4) დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს მასივის ზომა და 
 შექმნის ამ ზომის მასივს ასევე მოხმარენელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ უნდა
გადაავსოს მასივი შემოტანილი ინფორმაციით. საბოლოოდ დაბეჭდოს მასივის ელემენტების ნამრავლი*/


//Console.Write("Enter array size: ");
//int arraySize = Convert.ToInt32(Console.ReadLine());
//if (arraySize <= 0)
//{
//    Console.WriteLine("Array size must be greater than 0.");
//    return;
//}


//int[] array = new int[arraySize];
//int multsum = 0;
//for (int i = 0; i < arraySize; i++)
//{
//    Console.Write($"Enter number for index {i}: ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    array[i] = number;
//    if (i == 0)
//    {
//        multsum = number;
//    }
//    else
//    {
//        multsum *= number;
//    }
//}
//Console.WriteLine($"Product of array elements is {multsum}");


/* 5) დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს მსივის ზომა და შექმნის
 * ამ ზომის მასივს ასევე მოხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ უნდა გადაავსოს
 მასივი შემოტანილი ინფორმაციით.
საბოლოოდ დაბეჭდოს მისი ყველა უნიკალური ელემენტი(უნიკალურია ელემენტი რომელიც მხოლოდ ერთხელ გხვდება მასივში)*/



//Console.Write("Enter array size: ");
//int size = Convert.ToInt32(Console.ReadLine());

//if (size <= 0)
//{
//    Console.WriteLine("Array size must be greater than 0.");
//    return;
//}

//int[] array = new int[size];

//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Enter number for index {i}: ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    array[i] = number;
//}

//Console.WriteLine("Unique elements in the array:");

//for (int i = 0; i < size; i++)
//{
//    bool isUnique = true;

//    for (int j = 0; j < size; j++)
//    {
//        if (i != j && array[i] == array[j])
//        {
//            isUnique = false;
//            break;
//        }
//    }

//    if (isUnique)
//    {
//        Console.WriteLine(array[i]);
//    }
//}



/* 6) დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს ორგანზომილებიანი
 * მასივის ზომები და შექმნის ამ ზომების მასივს ასევე მომხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის
 * შეტანა და პროგრამამ უნდა გადაავსოს მასივი შემოტანილი ინფორმაციით საბოლოოდ დაბეჭდოს მისი ყველა ელემენტი მატრიცის სახით*/


//Console.Write("Enter array row size: ");
//int rowSize = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter array column size: ");
//int columnSize = Convert.ToInt32(Console.ReadLine());
//int[,] array = new int[rowSize, columnSize];
//for (int i = 0; i < rowSize; i++)
//{
//    for (int j = 0; j < columnSize; j++)
//    {
//        Console.Write($"Enter number for index {i} , {j}: ");
//        array[i,j]= Convert.ToInt32(Console.ReadLine());

//    }
//}

//Console.WriteLine("Here is matrix view of multidimensional array");
//for (int i = 0; i < rowSize; i++)
//{
//    for (int j = 0; j < columnSize; j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}


/* 7)დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს ორი ორგანზომილებიანი მასივის ზომები
 * და შექმნის ამ ზომების მასივებს მნისვნელოვანია რომ პროგრამამ შეზღუდოს მოხმმარებელი მატრიცების განზომილებების ტოლობით
 (ამიტომ შეიძლიათ ზომები ერთხელ შეატანინოთ). ასევე მომხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ
უნდა გადაავსოს მასივები შემოტანილი ინფორმაციით საბოლოოდ დაბეჭდოს ამ ორი მასივის ელემტების შეკრების შდეგად მიღბული ახალი მატრიცა
(ორი მატრიცის შეკრება ნიშნავს ერთსა და იმავე პოზიციაზე მყოფი რიცხვების შეკრება)*/


//Console.Write("Enter array row size: ");
//int row = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter array column size: ");
//int column = Convert.ToInt32(Console.ReadLine());
//int[,] firstMatrix = new int[row, column];
//int[,] secondMatrix = new int[row, column];
//int[,] sumMatrix = new int[row, column];
//Console.WriteLine("Fill first matrix!");
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < column; j++)
//    {
//        Console.Write($"Enter number for index {i} , {j}: ");
//        firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
//        sumMatrix[i, j] = firstMatrix[i, j];
//    }

//}
//Console.WriteLine("Fill second matrix!");
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < column; j++)
//    {
//        Console.Write($"Enter number for index {i} , {j}: ");
//        secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
//        sumMatrix[i, j] += secondMatrix[i, j];
//    }

//}
//Console.WriteLine("Here is sum of two matrices");
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < column; j++)
//    {
//        Console.Write(sumMatrix[i, j] + ", ");
//    }
//    Console.WriteLine();
//}


/* 8) ავაგოთ ნახაზე მოცემული ორ განზომილებიანი მასივი მოვახდინოთ ინიციალიზაცია ისე როგორ პირველ სურათზეა და დავწეროთ
 კონსოლ აპლიკაცია რომელიც ჩვენს მასივს გადააქცევს მეორე სურათზე მოცემულ მასივად.*/


int[][] array = new int[10][]
{
    new int[] {0,0,0,0,0,0,0,0,0,0},
    new int[] {0,0,0,0,0,0,0,0,0,1},
    new int[] {0,0,0,0,0,0,0,0,1,1},
    new int[] {0,0,0,0,0,0,0,1,1,1},
    new int[] {0,0,0,0,0,0,1,1,1,1},
    new int[] {0,0,0,0,0,1,1,1,1,1},
    new int[] {0,0,0,0,1,1,1,1,1,1},
    new int[] {0,0,0,1,1,1,1,1,1,1},
    new int[] {0,0,1,1,1,1,1,1,1,1},
    new int[] {0,1,1,1,1,1,1,1,1,1}

};



for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length / 2; j++)
    {
        int temp = array[i][j];
        array[i][j] = array[i][array[i].Length - 1 - j];
        array[i][array[i].Length - 1 - j] = temp;
    }
}
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length; j++)
    {
        Console.Write(array[i][j] + " ");
    }
    Console.WriteLine();
}
//for (int i = 0; i < array.Length ; i++)
//{
//    for (int j = array[i].Length - 1; j > 0; j--)
//    {
//        array[i][j - 1] = array[i][j - 1] == 1 ? 0 : 1;
//    }
//}
//for (int i = 0; i < array.Length; i++)
//{
//    for (int j = 0; j < array[i].Length; j++)
//    {
//        Console.Write(array[i][j] + " ");
//    }
//    Console.WriteLine();
//}


