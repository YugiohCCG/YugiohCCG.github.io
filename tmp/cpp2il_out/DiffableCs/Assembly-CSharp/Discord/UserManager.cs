namespace Discord;

public class UserManager
{
	internal sealed class CurrentUserUpdateHandler : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public CurrentUserUpdateHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CurrentUserUpdateHandler : MulticastDelegate
		{

			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public CurrentUserUpdateHandler(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr ptr) { }

		}

		internal CurrentUserUpdateHandler OnCurrentUserUpdate; //Field offset: 0x0

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CurrentUserHasFlagMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public CurrentUserHasFlagMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref bool hasFlag, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetCurrentUserMethod : MulticastDelegate
		{

			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetCurrentUserMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref User currentUser, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref User currentUser, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, ref User currentUser) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetCurrentUserPremiumTypeMethod : MulticastDelegate
		{

			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetCurrentUserPremiumTypeMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref PremiumType premiumType, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref PremiumType premiumType, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, ref PremiumType premiumType) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetUserCallback : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetUserCallback(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref User user, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(ref User user, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr ptr, Result result, ref User user) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetUserMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetUserMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, IntPtr callbackData, GetUserCallback callback, AsyncCallback __callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, long userId, IntPtr callbackData, GetUserCallback callback) { }

		}

		internal GetCurrentUserMethod GetCurrentUser; //Field offset: 0x0
		internal GetUserMethod GetUser; //Field offset: 0x8
		internal GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType; //Field offset: 0x10
		internal CurrentUserHasFlagMethod CurrentUserHasFlag; //Field offset: 0x18

	}

	internal sealed class GetUserHandler : MulticastDelegate
	{

		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public GetUserHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(Result result, ref User user, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(ref User user, IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Result result, ref User user) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private CurrentUserUpdateHandler OnCurrentUserUpdate; //Field offset: 0x20

	public event CurrentUserUpdateHandler OnCurrentUserUpdate
	{
		[CalledBy(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	private FFIMethods Methods
	{
		[CalledBy(Type = typeof(UserManager), Member = "GetCurrentUser", ReturnType = typeof(User))]
		[CalledBy(Type = typeof(UserManager), Member = "GetUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(GetUserHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UserManager), Member = "GetCurrentUserPremiumType", ReturnType = typeof(PremiumType))]
		[CalledBy(Type = typeof(UserManager), Member = "CurrentUserHasFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserFlag)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 268
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal UserManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CalledBy(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_OnCurrentUserUpdate(CurrentUserUpdateHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool CurrentUserHasFlag(UserFlag flag) { }

	[CalledBy(Type = typeof(UserManager), Member = "GetCurrentUser", ReturnType = typeof(User))]
	[CalledBy(Type = typeof(UserManager), Member = "GetUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(GetUserHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UserManager), Member = "GetCurrentUserPremiumType", ReturnType = typeof(PremiumType))]
	[CalledBy(Type = typeof(UserManager), Member = "CurrentUserHasFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserFlag)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	private FFIMethods get_Methods() { }

	[CalledBy(Type = typeof(DiscordController), Member = "OnChangeUser", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public User GetCurrentUser() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public PremiumType GetCurrentUserPremiumType() { }

	[CalledBy(Type = "Manager.DiscordController+<GetUser>d__91", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(UserManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void GetUser(long userId, GetUserHandler callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback]
	private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback]
	private static void OnCurrentUserUpdateImpl(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_OnCurrentUserUpdate(CurrentUserUpdateHandler value) { }

}

