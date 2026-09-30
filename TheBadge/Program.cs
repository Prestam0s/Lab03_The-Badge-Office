Random rng = new Random();
string badgeLabel = "ETSU STUDENT BADGE";


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

//Create Student ID and Locker
int studentID = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);


//Find Distance to students first class
Console.Write("Please provie your Dorm x Location on the Campus map: ");
double dormX = Convert.ToInt32(Console.ReadLine());
Console.Write("Please provie your Dorm Y Location on the Campus map: ");
int dormY = Convert.ToInt32(Console.ReadLine());
Console.Write("Please provie the X Location of your first class on the Campus map: ");
int firstClassX = Convert.ToInt32(Console.ReadLine());
Console.Write("Please provie the Y Location of your first class on the Campus map: ");
double firstClassY = Convert.ToInt32(Console.ReadLine());
Console.Write("What is your walking speed in feet per second? ");
int walkingSpeed = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((firstClassX - dormX),2) + Math.Pow((firstClassY - dormY),2));
double timeToFirstClass = Math.Round(distance/walkingSpeed);

int timeMinutes = Convert.ToInt32(timeToFirstClass/60);
int timeSeconds = Convert.ToInt32(timeToFirstClass % 60);
int checkDigit = studentID % 9;

Console.WriteLine($"==================================\n {badgeLabel.PadLeft(20)}\n==================================\n");
Console.WriteLine($"NAME {fullName.PadLeft(14)}\nUSERNAME{username.PadLeft(12)}\nID{Convert.ToString(studentID).PadLeft(18)}-{checkDigit}\nLOCKER{Convert.ToString(lockerNumber).PadLeft(14)}\nWALK{Convert.ToString(timeMinutes).PadLeft(16)} min {timeSeconds} sec");
Console.WriteLine("\n==================================");


