# Mô tả bài toán

Xây dựng hệ thống **gửi thông báo** với các loại thông báo qua **email** và **SMS**:
* Interface ```INotification``` định nghĩa phương thức ```void Send(string message)``` chung cho mọi loại thông báo.
* Các lớp ```EmailNotification``` và ```SMSNotification``` triển khai interface này.