namespace GenericExample;

class Program
{
    static void Main(string[] args)
    {
        MyStack<string> stack = new MyStack<string>();

        // Thêm phần tử vào Stack
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        // Lấy phần tử trên đỉnh Stack
        Console.WriteLine($"Top item: {stack.Peek()}"); // Output: Third

        // Lấy và xóa phần tử khỏi Stack
        Console.WriteLine($"Popped item: {stack.Pop()}"); // Output: Third
        Console.WriteLine($"Popped item: {stack.Pop()}"); // Output: Second

        // Hiển thị phần tử còn lại
        Console.WriteLine($"Top item: {stack.Peek()}"); // Output: First

        // Kiểm tra nếu Stack rỗng
        Console.WriteLine($"Is stack empty? {stack.IsEmpty()}"); // Output: False

        // Xóa phần tử cuối cùng
        stack.Pop();
        Console.WriteLine($"Is stack empty? {stack.IsEmpty()}"); // Output: True
    }
}