# Bối cảnh
Một hệ thống quản lý thư viện bao gồm các thành phần sau:
* ```Library```: Quản lý các Books (sách).
* ```Book```: Đại diện cho sách trong thư viện, chứa thông tin cơ bản.
* ```Author```: Đại diện cho tác giả, một tác giả có thể viết nhiều sách.
* ```Member```: Thành viên có thể mượn sách.

Các mối quan hệ trong ví dụ này:
* **Dependency**: ```Member``` phụ thuộc vào ```Library``` để mượn sách.
* **Association**: ```Library``` liên kết với nhiều ```Book``` (Aggregation).
* **Composition**: ```Book``` có ```Author```, trong đó vòng đời của ```Author``` gắn chặt với ```Book```.
* **Inheritance**: ```Member``` được chia thành ```StudentMember``` và ```RegularMember```.