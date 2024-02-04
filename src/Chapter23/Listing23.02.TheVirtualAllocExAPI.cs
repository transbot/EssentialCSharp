namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_02
{
    #region INCLUDE
    LPVOID VirtualAllocEx(
        HANDLE hProcess,        // 进程句柄。函数在该进程
                                // 的虚拟地址空间内分配内存。
        LPVOID lpAddress,       // 指定想要开始分配页面区域
                                // 的地址的指针。如果lpAddress为NULL，
                                // 函数会判断在哪里分配区域。
        SIZE_T dwSize,          // 要分配的内存区域大小，
                                // 以字节为单位。如果lpAddress
                                // 为NULL，函数会将dwSize
                                // 上调到下一个页面边界。
        DWORD flAllocationType, // 内存分配的类型(例如，是否保留进程的虚拟地址空间范围）
        DWORD flProtect);       // 内存的保护属性（例如，页面是否可以读取、写入或执行）
    #endregion INCLUDE
}


//namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_02
//{
//    #region INCLUDE
//    LPVOID VirtualAllocEx(
//        HANDLE hProcess,        // The handle to a process. The
//                                // function allocates memory within
//                                // the virtual address space of this
//                                // process.
//        LPVOID lpAddress,       // The pointer that specifies a
//                                // desired starting address for the
//                                // region of pages that you want to
//                                // allocate. If lpAddress is NULL,
//                                // the function determines where to
//                                // allocate the region.
//        SIZE_T dwSize,          // The size of the region of memory to
//                                // allocate, in bytes. If lpAddress
//                                // is NULL, the function rounds dwSize
//                                // up to the next page boundary.
//        DWORD flAllocationType, // The type of memory allocation
//        DWORD flProtect);       // The type of memory allocation
//    #endregion INCLUDE
//}