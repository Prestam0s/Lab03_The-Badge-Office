Random rng = new Random();


//get name
Console.Write("Please enter your first and last name: ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();

//seperate first and last name
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

//create username, initials and count letters in name
string username = fullName.Substring(0, 1) + fullName.Substring(spacePosition + 1);
username = username.ToLower();
string initials = $"{firstName.Substring(0,1)}.{lastName.Substring(0,1)}.";
int countOfLastName = lastName.Length;

Console.WriteLine($"Name on Badge: {fullName}\n Username: {username}\n Initials: {initials}\n Letters in last name: {countOfLastName}");
