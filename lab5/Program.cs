using BCrypt.Net;

string password = "Secret Password";
string passwordInput = "Secret password";
string passwordTrueHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);

int startIndex = 7;
int length = 16;
string passwordSalt = passwordTrueHash.Substring(startIndex, length);

UserRepository myUserRepository = new UserRepository();
var allUsers = myUserRepository.GetAll();
var newUser = new User() { Id = 3, Name = "Софія", Email = "sofia@gmail.com" };
myUserRepository.Add(newUser);

passwordInput = password;
int i = 0;

if (passwordSalt + passwordInput == passwordSalt + password)
{
    Console.WriteLine("Password correct");
    Console.WriteLine("Id: " + allUsers[i].Id);
    Console.WriteLine("Name: " + allUsers[i].Name);
    Console.WriteLine("Email: " + allUsers[i].Email);
}
else
{
    Console.WriteLine("Password incorrect");
}

//string passwordFalseHash = BCrypt.Net.BCrypt.EnhancedHashPassword(passwordInput, 13);

/*if (passwordSalt + passwordInput == passwordSalt + password)
{
    Console.WriteLine("Password correct");
    Console.WriteLine("Id: " + newUser.Id);
    Console.WriteLine("Name: " + newUser.Name);
    Console.WriteLine("Email: " + newUser.Email);
}
else
{
    Console.WriteLine("Password incorrect");
}*/

//PasswordCheck checkThisPassword = new PasswordCheck();
//PasswordCheck.Compare(password, passwordInput, passwordSalt);

/*bool passwordCheck = BCrypt.Net.BCrypt.EnhancedVerify("Secret Password", passwordFalseHash);
Console.WriteLine(passwordCheck);

passwordCheck = BCrypt.Net.BCrypt.EnhancedVerify("Secret Password", passwordTrueHash);
Console.WriteLine(passwordCheck);*/

/*Console.WriteLine(passwordSalt);
Console.WriteLine(passwordTrueHash);
Console.WriteLine(password);*/

//int choosenId = 0;
//Console.WriteLine(allUsers[choosenId].Name);

/*foreach (var user in allUsers)
{
    Console.WriteLine(user.Name);
}*/

//Console.WriteLine(newUser.Name);

//Console.WriteLine(allUsers.Count);
//myUserRepository.GetById(1);

/*foreach (var user in allUsers)
{
    Console.WriteLine(user);
}*/