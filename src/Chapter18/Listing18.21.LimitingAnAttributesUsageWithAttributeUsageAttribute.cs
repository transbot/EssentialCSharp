namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_21;

#region INCLUDE
// 限制该特性只能用于属性和字段
#region HIGHLIGHT
[AttributeUsage(
  AttributeTargets.Field | AttributeTargets.Property)]
#endregion HIGHLIGHT
public class CommandLineSwitchAliasAttribute : Attribute
{
    // ...
}
#endregion INCLUDE
