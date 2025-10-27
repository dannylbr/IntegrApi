record User(string Id, string Name, string Email)
{
    public string GetUserInfo() => $"User: {Name}, Email: {Email}";
}