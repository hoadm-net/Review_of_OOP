namespace ObjectLifecycleExample;

public class ResourceManager : IDisposable
{
    private bool disposed = false;  // Flag để kiểm tra đã dispose chưa

    // 2. Tài nguyên không quản lý (ví dụ: mô phỏng kết nối tệp)
    private IntPtr unmanagedResource;

    // Constructor
    public ResourceManager()
    {
        Console.WriteLine("ResourceManager created.");
        unmanagedResource = new IntPtr(123456); // Giả sử đây là tài nguyên không quản lý
    }

    // 3. Finalizer (Destructor)
    ~ResourceManager()
    {
        Console.WriteLine("Finalizer called.");
        Dispose(false);
    }

    // 4. Dispose - Giải phóng tài nguyên
    public void Dispose()
    {
        Console.WriteLine("Dispose called.");
        Dispose(true);
        GC.SuppressFinalize(this);  // Ngừng gọi finalizer
    }

    // Phương thức Dispose thực hiện việc giải phóng tài nguyên
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Giải phóng tài nguyên quản lý (nếu có)
                Console.WriteLine("Disposing managed resources.");
            }

            // Giải phóng tài nguyên không quản lý
            if (unmanagedResource != IntPtr.Zero)
            {
                Console.WriteLine("Disposing unmanaged resource.");
                unmanagedResource = IntPtr.Zero; // Giải phóng tài nguyên không quản lý
            }

            disposed = true;
        }
    }
}