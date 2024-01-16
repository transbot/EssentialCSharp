namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_31;

using System;
#region INCLUDE
public class EntityBase<T> where T : IComparable<T>
{
    // ...
}

// 错误: 
// 类型'U'不能用作泛型类型或方法'EntityBase<T>'
// 中的类型参数'T'。没有从'U'到'System.IComparable<U>'
// 的装箱转换或类型参数转换。	
// class Entity<U> : EntityBase<U>
// {
//     ...
// }
#endregion INCLUDE
