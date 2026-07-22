namespace Discord;

public class AchievementManager
{
	internal sealed class FetchUserAchievementsHandler : MulticastDelegate
	{

		[CallerCount(Count = 79)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public FetchUserAchievementsHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Result result) { }

	}

	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class UserAchievementUpdateHandler : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public UserAchievementUpdateHandler(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr ptr, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr ptr, ref UserAchievement userAchievement) { }

		}

		internal UserAchievementUpdateHandler OnUserAchievementUpdate; //Field offset: 0x0

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CountUserAchievementsMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public CountUserAchievementsMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(ref int count, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchUserAchievementsCallback : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public FetchUserAchievementsCallback(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchUserAchievementsMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public FetchUserAchievementsMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, FetchUserAchievementsCallback callback, AsyncCallback __callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, FetchUserAchievementsCallback callback) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetUserAchievementAtMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetUserAchievementAtMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetUserAchievementMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetUserAchievementMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetUserAchievementCallback : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public SetUserAchievementCallback(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetUserAchievementMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			public SetUserAchievementMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, SetUserAchievementCallback callback, AsyncCallback __callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, SetUserAchievementCallback callback) { }

		}

		internal SetUserAchievementMethod SetUserAchievement; //Field offset: 0x0
		internal FetchUserAchievementsMethod FetchUserAchievements; //Field offset: 0x8
		internal CountUserAchievementsMethod CountUserAchievements; //Field offset: 0x10
		internal GetUserAchievementMethod GetUserAchievement; //Field offset: 0x18
		internal GetUserAchievementAtMethod GetUserAchievementAt; //Field offset: 0x20

	}

	internal sealed class SetUserAchievementHandler : MulticastDelegate
	{

		[CallerCount(Count = 79)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public SetUserAchievementHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Result result) { }

	}

	internal sealed class UserAchievementUpdateHandler : MulticastDelegate
	{

		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public UserAchievementUpdateHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(ref UserAchievement userAchievement) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private UserAchievementUpdateHandler OnUserAchievementUpdate; //Field offset: 0x20

	public event UserAchievementUpdateHandler OnUserAchievementUpdate
	{
		[CallerCount(Count = 0)]
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
		[CalledBy(Type = typeof(AchievementManager), Member = "SetUserAchievement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(byte), typeof(SetUserAchievementHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AchievementManager), Member = "FetchUserAchievements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FetchUserAchievementsHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AchievementManager), Member = "CountUserAchievements", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AchievementManager), Member = "GetUserAchievement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(UserAchievement))]
		[CalledBy(Type = typeof(AchievementManager), Member = "GetUserAchievementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UserAchievement))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 278
	}

	[CalledBy(Type = typeof(Discord), Member = "GetAchievementManager", ReturnType = typeof(AchievementManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_OnUserAchievementUpdate(UserAchievementUpdateHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int CountUserAchievements() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void FetchUserAchievements(FetchUserAchievementsHandler callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback]
	private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result) { }

	[CalledBy(Type = typeof(AchievementManager), Member = "SetUserAchievement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(byte), typeof(SetUserAchievementHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AchievementManager), Member = "FetchUserAchievements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FetchUserAchievementsHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AchievementManager), Member = "CountUserAchievements", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AchievementManager), Member = "GetUserAchievement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(UserAchievement))]
	[CalledBy(Type = typeof(AchievementManager), Member = "GetUserAchievementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UserAchievement))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	private FFIMethods get_Methods() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public UserAchievement GetUserAchievement(long userAchievementId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public UserAchievement GetUserAchievementAt(int index) { }

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
	private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_OnUserAchievementUpdate(UserAchievementUpdateHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void SetUserAchievement(long achievementId, byte percentComplete, SetUserAchievementHandler callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback]
	private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result) { }

}

