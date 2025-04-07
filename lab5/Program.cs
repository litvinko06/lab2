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
