// See https://aka.ms/new-console-template for more information

using SaturdayStudies;

Person person = new Person();

List<Person> people = person.People();

string Name = "IyiOluwa";

Name = Name.Replace("O", "1").Replace("u", "2");

string Name2 = ("Victor, Iyioluwa, Iree, Deacon, Victor2");

Console.WriteLine(Name);

//if(people.Count > 0)
//{
//	string allTheNmae = string.Empty;
//	//Foreach lOOP
//	foreach (var item in people)
//	{
//        allTheNmae += $"Name: {item.Name.Replace("I", "V")}, Age: {item.Age.ToString()}, Height: {item.Height}, DOB: {item.DOB}";
//		var personArray = allTheNmae.Split(',');
//		Console.WriteLine($"First Person: {personArray[0]}");
//    }

//	Console.WriteLine(allTheNmae);

//	//FOR LOOP
//	for (int i = 0; i < people.Count; i++)
//	{
        
//    }

//	//DO WHILE LOOP
//	do
//	{
		
//	} while (people.Count > 0);
//}

Console.WriteLine("pROGRAM ENDED");
