

namespace taskmd;

public class tog{
    public static void toggle(int index){
        string[] lines = taskmd.indexFile("Task.md");
        //char[] arr = lines[index].ToCharArray();
        //arr[arr.Length-2] = '✓';
        string[] arr = lines[index].Split(' ');
        arr[arr.Length-1] = "[✓]";
        lines[index] = string.Join(" ", arr);
        Console.WriteLine(arr.ToString());
        taskmd.rewriteAll(lines);
    }
}