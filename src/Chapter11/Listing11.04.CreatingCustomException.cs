using System.Runtime.Serialization;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_04
{
    #region INCLUDE
    class DatabaseException : Exception
    {
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
        #region EXCLUDE
        // 用于反序列化异常
        public DatabaseException(
            SerializationInfo serializationInfo,
            StreamingContext context)
            : base(serializationInfo, context)
        {
            //...
        }
        #endregion EXCLUDE
    }
    #endregion INCLUDE

    // 创建数据库异常类的模拟版本，而不是引用真实的库
#pragma warning disable CA1032 // Implement standard exception constructors
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
#pragma warning restore CA1032 // Implement standard exception constructors
}

