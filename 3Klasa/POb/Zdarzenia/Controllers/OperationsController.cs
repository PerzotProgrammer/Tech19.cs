namespace Zdarzenia.Controllers;

public class OperationsController
{
    private const string PostsFolder = "./Posts/";

    static OperationsController()
    {
        if (!Directory.Exists(PostsFolder))
        {
            Directory.CreateDirectory(PostsFolder);
        }
    }

    public static void CreatePost(string title, string content)
    {
        string filePath = $"./{PostsFolder}/{title}.txt";
        if (File.Exists(filePath))
        {
            return;
        }

        StreamWriter sw = new StreamWriter(filePath);
        sw.WriteLine(content);
        sw.Close();
    }

    public static string? ReadPost(string title)
    {
        string filePath = $"./{PostsFolder}/{title}.txt";
        if (!File.Exists(filePath))
        {
            return null;
        }

        StreamReader sr = new StreamReader(filePath);
        string output = sr.ReadToEnd();
        sr.Close();
        return output;
    }

    public static void UpdatePost(string title, string content)
    {
        string filePath = $"./{PostsFolder}/{title}.txt";
        if (!File.Exists(filePath))
        {
            return;
        }

        StreamWriter sw = new StreamWriter(filePath, true);
        sw.WriteLine(content);
        sw.Close();
    }

    public static void DeletePost(string title)
    {
        string filePath = $"./{PostsFolder}/{title}.txt";
        if (!File.Exists(filePath))
        {
            return;
        }

        File.Delete($"./{PostsFolder}/{title}.txt");
    }
}