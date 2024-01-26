using System.Runtime.CompilerServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_27;

#if NET7_0_OR_GREATER
#region INCLUDE
public class SampleTests
{
    #region HIGHLIGHT
    [ExpectedException<DivideByZeroException>]
    #endregion HIGHLIGHT
    public static void ThrowArgumentNullExceptionTest()
    {
        var result = 1 / "".Length;
    }
}

[AttributeUsage(AttributeTargets.Method)]
public class ExpectedException<TException> :
    Attribute where TException : Exception
{
    #region HIGHLIGHT
    public static TException AssertExceptionThrown(
        Action testAction,
        [CallerArgumentExpression(nameof(testAction))]
            string testExpression = null!,
        [CallerMemberName] string testActionMemberName = null!,
        [CallerFilePath] string testActionFileName = null!
        )
    #endregion HIGHLIGHT
    {
        try
        {
            testAction();
            throw new InvalidOperationException(
                    $"在'{testActionFileName}'文件的'{testActionMemberName
                    }'方法中，表达式'{testExpression
                    }'没有抛出预期的异常{typeof(TException).FullName}。");
        }
        catch (TException exception)
        {
            return exception;
        }
    }

    // 特性检测
    // ...
}
#endregion INCLUDE
#endif // NET7_0_OR_GREATER
