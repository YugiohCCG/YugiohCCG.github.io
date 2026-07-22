namespace System;

internal static class IOSelector
{

	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass355_0", Member = "<QueueIOSelectorJob>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendToCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static void Add(IntPtr handle, IOSelectorJob job) { }

}

