namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_02;

#pragma warning disable 0168 // Disabled warning for unused variables for elucidation
using System.ComponentModel;
#region INCLUDE
using System;

public sealed class Program
{
    public static void Main(string[] args)
    {
        try
        {
            #region EXCLUDE
            //throw new Win32Exception(42);
            // ...
            //TextNumberParser.Parse("negative forty-two");
            #endregion EXCLUDE
            throw new InvalidOperationException(
                "任意异常");
            // ...
        }
        catch(Win32Exception exception) 
            when(exception.NativeErrorCode  == 42)
        {
            // 处理ErrorCode为42的Win32Exception
        }
        catch (ArgumentException exception)
        {
            // 处理ArgumentException
        }
        catch(InvalidOperationException exception)
        {
            bool exceptionHandled = false;
            // 处理InvalidOperationException
            // ...
            if(!exceptionHandled)
            {
                throw;
            }
        }
        catch(Exception exception)
        {
            // 处理所有异常的基类：Exception
        }
        finally
        {
            // 在这里写资源清理代码，因为
            // 不管是否发生异常，这里的代码
            // 都会执行。
            // ...
        }
    }
}
#endregion INCLUDE
