namespace GenericExample;

public class MyStack<T>
{
    private T[] items;       // Mảng để lưu trữ phần tử
    private int count;       // Số lượng phần tử hiện tại
    private int capacity;    // Dung lượng của mảng

    // 2. Constructor: Khởi tạo Stack với dung lượng ban đầu
    public MyStack(int capacity = 10)
    {
        this.capacity = capacity;
        items = new T[capacity];
        count = 0;
    }

    // 3. Phương thức thêm phần tử vào Stack (Push)
    public void Push(T item)
    {
        if (count == capacity)
        {
            Resize(); // Tăng dung lượng nếu Stack đầy
        }
        items[count++] = item;
    }

    // 4. Phương thức lấy phần tử khỏi Stack (Pop)
    public T Pop()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = items[--count];
        items[count] = default(T); // Xóa phần tử khỏi Stack (giải phóng bộ nhớ)
        return item;
    }

    // 5. Phương thức xem phần tử trên đỉnh Stack (Peek)
    public T Peek()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return items[count - 1];
    }

    // 6. Phương thức kiểm tra Stack có rỗng không
    public bool IsEmpty()
    {
        return count == 0;
    }

    // 7. Phương thức trả về số lượng phần tử trong Stack
    public int Count()
    {
        return count;
    }

    // 8. Resize: Tăng dung lượng của mảng khi đầy
    private void Resize()
    {
        capacity *= 2;
        T[] newItems = new T[capacity];
        Array.Copy(items, newItems, count);
        items = newItems;
    }
}