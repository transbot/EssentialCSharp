using System.Runtime.Serialization;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_05
{
    #region INCLUDE
    // 通过一个特性来支持序列化
    #region HIGHLIGHT
    [Serializable]
    #endregion HIGHLIGHT
    class DatabaseException : Exception
    {
        #region EXCLUDE
        public DatabaseException(
            string? message,
            System.Data.SqlClient.SQLException? exception)
            : base(message, innerException: exception)
        {
            // ...
        }

        public DatabaseException(
            string? message,
            System.Data.OracleClient.OracleException? exception)
            : base(message, innerException: exception)
        {
            // ...
        }

        public DatabaseException()
        {
            // ...
        }

        public DatabaseException(string? message)
            : base(message)
        {
            // ...
        }

        public DatabaseException(
            string? message, Exception? exception)
            : base(message, innerException: exception)
        {
            // ...
        }
        #endregion EXCLUDE

       // 用于反序列化异常
       public DatabaseException(
        #region HIGHLIGHT
           SerializationInfo serializationInfo,
           StreamingContext context)
           : base(serializationInfo, context)
        #endregion HIGHLIGHT
        {
            //...
        }
    }
    #endregion INCLUDE

    // 创建数据库异常类的模拟版本，而不是引用真实的库
    namespace System.Data
    {
        namespace SqlClient
        {
            class SQLException : Exception
            {
            }
        }
        namespace OracleClient
        {
            class OracleException : Exception
            {
            }
        }
    }
}

