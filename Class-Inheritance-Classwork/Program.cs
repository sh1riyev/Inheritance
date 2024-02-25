using System;
using Class_Inheritance_Classwork;

//Person person = new()
//{
//    id = 1,
//    fullName = "Ilqar Shiriyev",
//    age = 26,
//    position = "Student"
//};


//Person person = new(1, "Gunel Memmedli", 28, "doctor");
//Console.WriteLine(person.fullName);

//Person person = new("Azerbaycan","Turkiye");


Person GetStudentById(Person[]student,int id)
{
  Person person= student.FirstOrDefault(m => m.id == id);
    return person;
}

//Console.WriteLine(result!=null ? $"Id:{result.id} Fullname:{result.fullName} Age:{result.age}" : "Datas not correct");

void ShowStudentById(Person person)
{
    
    if (person != null)
    {
        string response = $"Id: {person.id} Fullname:{person.fullName} Age:{person.age}";
        Console.WriteLine(response);
    }
    else
    {
        Console.WriteLine("Datas are not correct");
    }
}

//ShowStudentById(result);

Person[] GetAllPeople()
{
    Person person1 = new()
    {
        id = 1,
        fullName = "Ilqar",
        age = 23
    };

    Person person2 = new()
    {
        id = 2,
        fullName = "Gunel Memmedova",
        age = 28
    };

    Person person3 = new()
    {
        id = 3,
        fullName = "Alima Rufulali",
        age = 29
    };
    Person person4 = new()
    {
        id = 4,
        fullName = "Tural Rzayev",
        age = 27
    };

     Person[] student = { person1, person2, person3, person4 };
    return student;
}

void ShowAllPeople(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id: {item.id} Fullname:{item.fullName} Age:{item.age}";
        Console.WriteLine(response);
    }
}

//ShowAllPeople(GetAllPeople(student));


Person[] GetPeopleByName(Person[] data,string name)
{
   return data.Where(m => m.fullName == name).ToArray();
}

void ShowPeopleByName(Person[] data)
{
    foreach (var item in data)
    {
        string response = $"ID:{item.id} Fullname:{item.fullName} Age:{item.age}";
        Console.WriteLine(response);
    }
}

//ShowPeopleByName(GetPeopleByName(GetAllPeople(), "Ilqar"));


//Animal animal = new();
//animal.id = 5;
//animal.name = "qartal";
//Console.WriteLine(animal.name);

//Bird bird = new();
//bird.id = 1;
//bird.name = "qaranqush";

//Console.WriteLine(bird.name);

//bird.Sound();
//Fish fish = new();

Fish fish = new();