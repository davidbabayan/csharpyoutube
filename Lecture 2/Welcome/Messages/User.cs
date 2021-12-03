public class User
{
    //Fields
    private string _name = "";
    private int _age = 0;

    //Functions
    public User(string name) => _name = name;
    public string GetName() => _name;
    public void ChangeName(string name) => _name = name;
    public void SetAge(int age) => _age = age;
    public int GetAge() => _age;
    public string PrintState() => $"Hello {this._name}, You are {this._age} years old!";
}