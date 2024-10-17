namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_18;

using Listing18_17;
#region INCLUDE
using System.Reflection;
using System.Collections.Generic;
using System.Diagnostics;

public class CommandLineHandler
{
    // ...
    public static bool TryParse(
        string[] args, object commandLine,
        out string? errorMessage)
    {
        bool success = false;
        errorMessage = null;

        #region HIGHLIGHT
        Dictionary<string, PropertyInfo> options =
            CommandLineSwitchAliasAttribute.GetSwitches(
                commandLine);
        #endregion HIGHLIGHT

        foreach (string arg in args)
        {
            string option;
            if(arg[0] == '/' || arg[0] == '-')
            {
                string[] optionParts = arg.Split(
                    new char[] { ':' }, 2);
                option = optionParts[0].Remove(0, 1).ToLower();

                #region HIGHLIGHT
                if (options.TryGetValue(option, out PropertyInfo? property))
                #endregion HIGHLIGHT
                {
                    success = SetOption(
                        commandLine, property,
                        optionParts, ref errorMessage);
                }
                else
                {
                    success = false;
                    errorMessage = $"不支持'{ option }'选项。";
                }
            }
        }
        return success;
    }

    private static bool SetOption(
        object commandLine, PropertyInfo property,
        string[] optionParts, ref string? errorMessage)
    {
        bool success;

        if(property.PropertyType == typeof(bool))
        {
            // 最后一个参数用于处理属性是索引器的情形
            property.SetValue(
                commandLine, true, null);
            success = true;
        }
        else
        {

            if (optionParts.Length < 2
                || optionParts[1] == "")
            {
                // 没有为开关提供设置
                success = false;
                errorMessage =
                     $"必须为{ property.Name }选项提供值。";
            }
            else if(
                property.PropertyType == typeof(string))
            {
                property.SetValue(
                    commandLine, optionParts[1], null);
                success = true;
            }
            else if(
                // property.PropertyType.IsEnum也是支持的
                property.PropertyType ==
                    typeof(ProcessPriorityClass))
            {
                success = TryParseEnumSwitch(
                    commandLine, optionParts,
                    property, ref errorMessage);
            }
            else
            {
                success = false;
                errorMessage = 
                    $@"不支持{ commandLine.GetType().ToString() 
                    }上的数据类型'{property.PropertyType.ToString()}'。";
            }
        }
        return success;
    }
    #endregion INCLUDE

    // 说明 : 未完全实现
#pragma warning disable IDE0060 // 移除未使用的参数
    private static bool TryParseEnumSwitch(
        object commandLine, string[] optionParts, PropertyInfo property, ref string? errorMessage)
    {
        throw new NotImplementedException();
    }
#pragma warning restore IDE0060 // 移除未使用的参数
}
