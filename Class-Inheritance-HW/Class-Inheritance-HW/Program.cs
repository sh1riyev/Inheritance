using Class_Inheritance_HW;

CustomMath math = new();

int[] numbers = { 1, 3, 5, 4, 2 };
//Console.WriteLine(math.SumOfOddNumbers(numbers));

//Console.WriteLine(math.EvenOrOdd(5));

//Console.WriteLine(math.SquareOfEven(numbers));

//Console.WriteLine(math.MultiplicationOfNumbers(6));

Employee employe1 = new()
{
    id = 1,
    name = "Ilqar",
    surname = "Shiriyev",
    age = 27,
    email = "shirieyev@mail.com",
    adress = "Baki"
};
Employee employe2 = new()
{
    id = 2,
    name = "Orxan",
    surname = "Aliyev",
    age = 18,
    email = "aorxan@mail.com",
    adress = "Baku"
};
Employee employe3 = new()
{
    id = 3,
    name = "Anar",
    surname = "Aliyev",
    age = 33,
    email = "anar@mail.com",
    adress = "Baku"
};

Employee[] employees = { employe1, employe2, employe3 };


/////1)  Yashi methoda parametr kimi gelen yashdan boyuk olan employee - lerin  siyahisini qaytaran method.

void ShowByAge(int age)
{
    foreach (var person in employees)
    {
        if (person.age > age)
        {
            Console.WriteLine($"Id:{person.id} Name:{person.name} Surname:{person.surname} Age:{person.age} Email:{person.email} Adress:{person.adress}");
        }
    }
    
}

//ShowByAge(18);




/////2) Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.

int CountOfEmployyeByAge(Employee[] arr)
{
    int count = 0;
    foreach (var person in arr)
    {
        if(person.age>20 && person.age < 30)
        {
            count++;
        }
    }
    return count;
}

//Console.WriteLine(CountOfEmployyeByAge(employees));




/////3)Butun Employeelerin yashlarinin cemini qaytaran method.

int SumOfAge(Employee[] arr)
{
    int sum = 0;
    foreach (var person in arr)
    {
        sum += person.age;
    }
    return sum;
}

//Console.WriteLine(SumOfAge(employees));




// 4)Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method.

void ShowByEmail(Employee[]arr,string word)
{
    word.Trim().ToLower();
    foreach (var person in arr)
    {
        if (person.email.StartsWith(word))
        {
            Console.WriteLine($"Id:{person.id} Name:{person.name} Surname:{person.surname} Age:{person.age} Email:{person.email} Adress:{person.adress}");
        }
    }
}

//string word = "sh";
//ShowByEmail(employees, word);