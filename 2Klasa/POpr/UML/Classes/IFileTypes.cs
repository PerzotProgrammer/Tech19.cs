namespace UML.Classes;

public interface IFileTypes
{
    string Name { get; set; }
    bool IsDirectory { get; set; }

    public void Show(int depth);
}

public class Directory : IFileTypes
{
    private List<IFileTypes> Childs;
    public string Name { get; set; }
    public bool IsDirectory { get; set; }

    public Directory(string name)
    {
        Name = name;
        Childs = new();
        IsDirectory = true;
    }

    public Directory(string name, List<IFileTypes> childs) : this(name)
    {
        Childs = childs;
        IsDirectory = true;
    }

    public void Show(int depth = 0)
    {
        if (IsDirectory)
        {
            Console.WriteLine($"Directory: {Name}");
            depth++;
        }

        foreach (IFileTypes child in Childs)
        {
            for (int i = 0; i < depth; i++) Console.Write("\t");
            child.Show(depth);
        }
    }
}

public class File : IFileTypes
{
    public string Name { get; set; }
    public bool IsDirectory { get; set; }
    private string Extension;

    public File(string name, string extension)
    {
        Name = name;
        Extension = extension;
        IsDirectory = false;
    }

    public void Show(int depth = 0)
    {
        Console.WriteLine($"File: {Name}.{Extension}");
    }
}