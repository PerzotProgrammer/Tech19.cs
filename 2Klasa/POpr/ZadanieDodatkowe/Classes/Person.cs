namespace ZadanieDodatkowe.Classes;

struct Person // Trochę ungabunga
{
    private string Name;
    private string SName;
    private int Age;

    public Person()
    {
        string name = "A" + RandomStringGenerator(3);
        Name = name;
        string rev = "";
        for (int i = name.Length - 1; i >= 0; i--)
        {
            rev += name[i];
        }

        SName = rev;
        Random random = new();
        Age = random.Next(20, 50);
    }

    public string GetInfo()
    {
        return $"Name: {Name} SName: {SName} Age: {Age}";
    }

    private string RandomStringGenerator(int lengthOfString)
    {
        string chars = "abcdefghijklmnopqrstuvwxyz";
        char[] stringChars = new char[lengthOfString];
        Random random = new();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        string finalString = new(stringChars);
        return finalString;
    }
}