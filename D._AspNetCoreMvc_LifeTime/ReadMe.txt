=========================================================================================================== Asp.Net Core Dependency Injection Life Time

Timelife: Có 3 phương thức để đăng kí. Tất cả nằm trong IServiceCollection
	- Singleton - ( AddSingleton ): Được khởi tạo 1 lần duy nhất, tồn tại xuyên suốt ứng dụng
									One instance for the entire application lifetime. Use for shared, long-lived services

	- Transient - ( AddTransient ): Được khởi tạo mỗi lần service được gọi đến
									One instance per request. Use for maintaining state within a request.

	- Scoped    - ( AddScoped	 ): Được khởi tạo mỗi request (HTPP request)
									A new instance each time it is requested. Use for lightweight, stateless services.

With Demo: 
	Singleton : Call 2 api -> 1 row in file log
	Scoped : Call 2 api -> 2 row in file log 
	Transient : Call 2 api -> 4 row in file log