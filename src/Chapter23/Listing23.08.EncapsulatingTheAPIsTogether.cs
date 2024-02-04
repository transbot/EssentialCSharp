namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_08
{
    #region INCLUDE
    public class VirtualMemoryManager
    {
        // ...

        /// <summary>
        /// 内存分配的类型。此参数必须包含以下值之一。
        /// </summary>
        [Flags]
        private enum AllocationType : uint
        {
            /// <summary>
            /// 在内存中或磁盘上的分页文件中，为指定的预留内存页
            /// 分配物理存储。该值会使系统将内存初始化为零。
            /// </summary>
            Commit = 0x1000,
            /// <summary>
            /// 保留进程虚拟地址空间的范围，但不在内存或磁盘上的
            /// 分页文件中分配任何实际的物理存储。
            /// </summary>
            Reserve = 0x2000,
            /// <summary>
            /// 表示不再对lpAddress和dwSize指定的内存范围中
            /// 的数据感兴趣。页面不应该从分页读取，或者写入
            /// 分页文件。然而，内存块稍后会再次使用，所以不
            /// 应该取消提交。该值在使用时不能与其他值组合。
            /// </summary>
            Reset = 0x80000,
            /// <summary>
            /// 分配具有读写访问权限的物理内存。该值只能用于
            /// Address Windowing Extensions (AWE)内存。
            /// </summary>
            Physical = 0x400000,
            /// <summary>
            /// 在最高可能的地址分配内存
            /// </summary>
            TopDown = 0x100000,
        }

        /// <summary>
        /// 要分配的页面区域的内存保护选项
        /// </summary>
        [Flags]
        private enum ProtectionOptions : uint
        {
            /// <summary>
            /// 启用对已提交页面区域的执行访问，
            /// 尝试读取或写入已提交区域将导致访问违规。
            /// </summary>
            Execute = 0x10,
            /// <summary>
            /// 启用对已提交页面区域的执行和读取访问，
            /// 尝试写入已提交区域将导致访问违规。
            /// </summary>
            PageExecuteRead = 0x20,
            /// <summary>
            /// 启用对已提交页面区域的执行、读取和写入访问
            /// </summary>
            PageExecuteReadWrite = 0x40,
            // ...
        }

        /// <summary>
        /// 指定释放操作的类型
        /// </summary>
        [Flags]
        private enum MemoryFreeType : uint
        {
            /// <summary>
            /// 取消提交指定的已提交页面区域。操作完成后，
            /// 这些页面处于保留(reserved)状态。
            /// </summary>
            Decommit = 0x4000,
            /// <summary>
            /// 释放指定的页面区域。操作完成后，这些页面处于空闲(free)状态。
            /// </summary>
            Release = 0x8000
        }

        // ...
    }
    #endregion INCLUDE
}


//namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_08
//{
//    #region INCLUDE
//    public class VirtualMemoryManager
//    {
//        // ...

//        /// <summary>
//        /// The type of memory allocation. This parameter must
//        /// contain one of the following values.
//        /// </summary>
//        [Flags]
//        private enum AllocationType : uint
//        {
//            /// <summary>
//            /// Allocates physical storage in memory or in the
//            /// paging file on disk for the specified reserved
//            /// memory pages. The function initializes the memory
//            /// to zero.
//            /// </summary>
//            Commit = 0x1000,
//            /// <summary>
//            /// Reserves a range of the process's virtual address
//            /// space without allocating any actual physical
//            /// storage in memory or in the paging file on disk.
//            /// </summary>
//            Reserve = 0x2000,
//            /// <summary>
//            /// Indicates that data in the memory range specified by
//            /// lpAddress and dwSize is no longer of interest. The
//            /// pages should not be read from or written to the
//            /// paging file. However, the memory block will be used
//            /// again later, so it should not be decommitted. This
//            /// value cannot be used with any other value.
//            /// </summary>
//            Reset = 0x80000,
//            /// <summary>
//            /// Allocates physical memory with read-write access.
//            /// This value is solely for use with Address Windowing
//            /// Extensions (AWE) memory.
//            /// </summary>
//            Physical = 0x400000,
//            /// <summary>
//            /// Allocates memory at the highest possible address.
//            /// </summary>
//            TopDown = 0x100000,
//        }

//        /// <summary>
//        /// The memory protection for the region of pages to be
//        /// allocated.
//        /// </summary>
//        [Flags]
//        private enum ProtectionOptions : uint
//        {
//            /// <summary>
//            /// Enables execute access to the committed region of
//            /// pages. An attempt to read or write to the committed
//            /// region results in an access violation.
//            /// </summary>
//            Execute = 0x10,
//            /// <summary>
//            /// Enables execute and read access to the committed
//            /// region of pages. An attempt to write to the
//            /// committed region results in an access violation.
//            /// </summary>
//            PageExecuteRead = 0x20,
//            /// <summary>
//            /// Enables execute, read, and write access to the
//            /// committed region of pages.
//            /// </summary>
//            PageExecuteReadWrite = 0x40,
//            // ...
//        }

//        /// <summary>
//        /// The type of free operation.
//        /// </summary>
//        [Flags]
//        private enum MemoryFreeType : uint
//        {
//            /// <summary>
//            /// Decommits the specified region of committed pages.
//            /// After the operation, the pages are in the reserved
//            /// state.
//            /// </summary>
//            Decommit = 0x4000,
//            /// <summary>
//            /// Releases the specified region of pages. After this
//            /// operation, the pages are in the free state.
//            /// </summary>
//            Release = 0x8000
//        }

//        // ...
//    }
//    #endregion INCLUDE
//}