namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_03;

#region INCLUDE
using System.Diagnostics;
using System.IO;
using System.Reflection;

public partial class Program
{
    public static void Main(string[] args)
    {
        CommandLineInfo commandLine = new();
        if(!CommandLineHandler.TryParse(
            args, commandLine, out string? errorMessage))
        {
            Console.WriteLine(errorMessage);
            DisplayHelp();
        } 
        else if (commandLine.Help || string.IsNullOrWhiteSpace(commandLine.Out))
        {
            DisplayHelp();
        }
        else
        {
            if(commandLine.Priority !=
                ProcessPriorityClass.Normal)
            {
                // 更改线程优先级
            }
            #region EXCLUDE
            Console.WriteLine(
                @$"正在运行{
                    Path.GetFileName(Environment.GetCommandLineArgs()[0])} /Out:{
                        commandLine.Out} /Priority:{
                        commandLine.Priority}");

            #endregion EXCLUDE
        }
    }

    private static void DisplayHelp()
    {
        // 显示命令行帮助
        Console.WriteLine(
            "Compress.exe /Out:< 文件名 > /Help "
            + "/Priority:RealTime | High | "
            + "AboveNormal | Normal | BelowNormal | Idle");

    }
}

public partial class Program
{
    private class CommandLineInfo
    {
        public bool Help { get; set; }

        public string? Out { get; set; }

        public ProcessPriorityClass Priority { get; set; }
            = ProcessPriorityClass.Normal;
    }

}

public class CommandLineHandler
{
    public static void Parse(string[] args, object commandLine)
    {
        if (!TryParse(args, commandLine, out string? errorMessage))
        {
            throw new InvalidOperationException(errorMessage);
        }
    }

    public static bool TryParse(string[] args, object commandLine,
        out string? errorMessage)
    {
        bool success = false;
        errorMessage = null;
        foreach(string arg in args)
        {
            string option;
            if(arg[0] == '/' || arg[0] == '-')
            {
                string[] optionParts = arg.Split(
                    new char[] { ':' }, 2);

                // 删除斜杠或短划线
                option = optionParts[0].Remove(0, 1);
                #region HIGHLIGHT
                PropertyInfo? property =
                    commandLine.GetType().GetProperty(option,
                        BindingFlags.IgnoreCase |
                        BindingFlags.Instance |
                        BindingFlags.Public);
                if(property is not null)
                {
                    if(property.PropertyType == typeof(bool))
                    {
                        // 最后一个参数用于处理属性是索引器的情形
                        property.SetValue(
                            commandLine, true, null);
                        success = true;
                    }
                    else if(
                        property.PropertyType == typeof(string))
                    {
                        property.SetValue(
                            commandLine, optionParts[1], null);
                        success = true;
                    }
                    else if (
                        // property.PropertyType.IsEnum也是支持的
                        property.PropertyType ==
                            typeof(ProcessPriorityClass))
                    {
                        try
                        {
                            property.SetValue(commandLine,
                                Enum.Parse(
                                    typeof(ProcessPriorityClass),
                                    optionParts[1], true),
                                null);
                            success = true;
                        }
                        #endregion HIGHLIGHT
                        catch (ArgumentException)
                        {
                            success = false;
                            errorMessage =
                                $@"选项'{optionParts[1] 
                                }'对'{ option }'无效。";
                        }
                    }
                    else
                    {
                        success = false;
                        errorMessage = 
                            $@"不支持{ commandLine.GetType() 
                                }上的数据类型'{property.PropertyType}'。";
                    }
                }
                else
                {
                    success = false;
                    errorMessage = 
                       $"不支持'{ option }'选项。";
                }
            }
        }
        return success;
    }
}
#endregion INCLUDE
