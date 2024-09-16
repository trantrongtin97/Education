=========================================================================================================== Asp.Net Core Views
Layout Views là 1 shared template or master page.
Dùng để quản lí các thành phần nằm trong nó được sử dụng ở nhiều trang khác nhau như headers, footers, navigation bars, and sidebars.. giúp cho code ko bị lặp lại
The Layout Views include the following sections:
	- @RenderBody(): This is a placeholder where the content of the views that use this layout will be rendered.
	- @RenderSection(“SectionName”, required: false): This method is used to render optional sections that views might provide. 
													If required is set to true, the section must be defined in the views.

Để đưa 1 thành phần nào đó dùng chung vào trong view chúng ta có 2 tình huống:
	TH1: Thành phần dùng chung cho toàn bộ view
		-> Bỏ thẳng vào layout view
	TH2: Thành phần dùng chung ở 1 số view nhất định
		-> Sử dụng RenderSection(name, required:true) and RenderSectionAsync(name, required:true)
			+ name: tên của thành phần
			+ required : bắt buộc khai bao render thành phần ở mỗi view
		 
	Khác nhau giữa RenderSection and RenderSectionAsync