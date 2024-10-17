namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_08;

#region INCLUDE
public class CommandLineInfo
{
    #region HIGHLIGHT
    [CommandLineSwitchAlias("?")]
    #endregion HIGHLIGHT
    public bool Help { get; set; }

    #region HIGHLIGHT
    [CommandLineSwitchRequired]
    #endregion HIGHLIGHT
    public string? Out { get; set; }

    public System.Diagnostics.ProcessPriorityClass Priority
    { get; set; } = 
        System.Diagnostics.ProcessPriorityClass.Normal;
}
#endregion INCLUDE
// 禁止警告，因其尚未实现，或者未在书稿中讲述
#pragma warning disable CA1018 // 使用AttributeUsageAttribute标记特性
internal class CommandLineSwitchRequiredAttribute : Attribute
{
    // 未实现
}

internal class CommandLineSwitchAliasAttribute : Attribute
{
    public CommandLineSwitchAliasAttribute(string _)
    {
        // 未实现
    }
}