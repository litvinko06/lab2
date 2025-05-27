UserRepository myUserRepository = new UserRepository();
var allUsers = myUserRepository.GetAll();
var newUser = new User() { Id = 3, Name = "Софія", Email = "sofia@gmail.com" };
myUserRepository.Add(newUser);