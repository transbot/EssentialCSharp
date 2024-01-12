// Remove unused parameter disabled for elucidation.
#pragma warning disable IDE0060
using Chapter10;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_12;

#region INCLUDE
/// <summary>
/// DataStorage类用于在文件中存储和检索员工数据
/// </summary>
class DataStorage
{
    /// <summary>
    /// 将员工对象保存到以员工姓名命名的文件中    
    /// </summary>
    /// <remarks>
    /// 该方法使用<seealso cref="System.IO.FileStream"/>
    /// 以及
    /// <seealso cref="System.IO.StreamWriter"/>
    /// </remarks>
    /// <param name="employee">
    /// 要存储到文件中的员工</param>
    /// <date>January 1, 2000</date>
    public static void Store(Employee employee)
    {
        // ...
    }

    /** <summary>
     * 加载员工对象。
     * </summary>
     * <remarks>
     * 该方法使用<seealso cref="System.IO.FileStream"/>
     * 以及
     * <seealso cref="System.IO.StreamReader"/>
     * </remarks>
     * <param name="firstName">
     * 员工的名字（first name）</param>
     * <param name="lastName">
     * 员工的姓氏（last name）</param>
     * <returns>
     * 和姓名对应的员工对象
     * </returns>
     * <date>January 1, 2000</date> **/
    public static Employee Load(string firstName, string lastName)
    {
        #region EXCLUDE
        return new Employee();
        #endregion EXCLUDE
    }
}

class Program
{
    // ...
}
#endregion INCLUDE
