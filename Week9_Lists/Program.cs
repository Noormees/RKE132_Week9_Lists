
// ostude nimekiri

string folderPath = @"G:\Мой диск\TKTK\3 aasta\Programmeerimise alused\data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);

List<string> myShoppingList = new List<string>();



if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else 
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}



static List<string> GetItemsFromUser()  // 1 funktsioon
{
    List<string> userList = new List<string>(); // loome vahemalu andmestik

    while (true)
    {
        Console.WriteLine("Add an item (add) / Exit (exit)");
        string userChoise = Console.ReadLine();

        if (userChoise == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem); //lisame Item to userList
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }

    }
    return userList;

}


static void ShowItemsFromList(List<string> someList)    // 2 funktsioon
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list");

    int i = 1;
    foreach (string item in someList)
    {

        Console.WriteLine($"{i}. {item}");
        i++;

    }
}


