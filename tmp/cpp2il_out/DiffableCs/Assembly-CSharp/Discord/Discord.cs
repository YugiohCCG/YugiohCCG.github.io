namespace Discord;

public class Discord : IDisposable
{
	public struct FFICreateParams
	{
		internal long ClientId; //Field offset: 0x0
		internal ulong Flags; //Field offset: 0x8
		internal IntPtr Events; //Field offset: 0x10
		internal IntPtr EventData; //Field offset: 0x18
		internal IntPtr ApplicationEvents; //Field offset: 0x20
		internal uint ApplicationVersion; //Field offset: 0x28
		internal IntPtr UserEvents; //Field offset: 0x30
		internal uint UserVersion; //Field offset: 0x38
		internal IntPtr ImageEvents; //Field offset: 0x40
		internal uint ImageVersion; //Field offset: 0x48
		internal IntPtr ActivityEvents; //Field offset: 0x50
		internal uint ActivityVersion; //Field offset: 0x58
		internal IntPtr RelationshipEvents; //Field offset: 0x60
		internal uint RelationshipVersion; //Field offset: 0x68
		internal IntPtr LobbyEvents; //Field offset: 0x70
		internal uint LobbyVersion; //Field offset: 0x78
		internal IntPtr NetworkEvents; //Field offset: 0x80
		internal uint NetworkVersion; //Field offset: 0x88
		internal IntPtr OverlayEvents; //Field offset: 0x90
		internal uint OverlayVersion; //Field offset: 0x98
		internal IntPtr StorageEvents; //Field offset: 0xA0
		internal uint StorageVersion; //Field offset: 0xA8
		internal IntPtr StoreEvents; //Field offset: 0xB0
		internal uint StoreVersion; //Field offset: 0xB8
		internal IntPtr VoiceEvents; //Field offset: 0xC0
		internal uint VoiceVersion; //Field offset: 0xC8
		internal IntPtr AchievementEvents; //Field offset: 0xD0
		internal uint AchievementVersion; //Field offset: 0xD8

	}

	public struct FFIEvents
	{

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class DestroyHandler : MulticastDelegate
		{

			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public DestroyHandler(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr MethodsPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr MethodsPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetAchievementManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetAchievementManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetActivityManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetActivityManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetApplicationManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetApplicationManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetImageManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetImageManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetLobbyManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetLobbyManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetNetworkManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetNetworkManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetOverlayManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetOverlayManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetRelationshipManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetRelationshipManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetStorageManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetStorageManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetStoreManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetStoreManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetUserManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetUserManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetVoiceManagerMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public GetVoiceManagerMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class RunCallbacksMethod : MulticastDelegate
		{

			[CallerCount(Count = 21)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public RunCallbacksMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override Result EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override Result Invoke(IntPtr methodsPtr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetLogHookCallback : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public SetLogHookCallback(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr ptr, LogLevel level, string message, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr ptr, LogLevel level, string message) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetLogHookMethod : MulticastDelegate
		{

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public SetLogHookMethod(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, SetLogHookCallback callback, AsyncCallback __callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, SetLogHookCallback callback) { }

		}

		internal DestroyHandler Destroy; //Field offset: 0x0
		internal RunCallbacksMethod RunCallbacks; //Field offset: 0x8
		internal SetLogHookMethod SetLogHook; //Field offset: 0x10
		internal GetApplicationManagerMethod GetApplicationManager; //Field offset: 0x18
		internal GetUserManagerMethod GetUserManager; //Field offset: 0x20
		internal GetImageManagerMethod GetImageManager; //Field offset: 0x28
		internal GetActivityManagerMethod GetActivityManager; //Field offset: 0x30
		internal GetRelationshipManagerMethod GetRelationshipManager; //Field offset: 0x38
		internal GetLobbyManagerMethod GetLobbyManager; //Field offset: 0x40
		internal GetNetworkManagerMethod GetNetworkManager; //Field offset: 0x48
		internal GetOverlayManagerMethod GetOverlayManager; //Field offset: 0x50
		internal GetStorageManagerMethod GetStorageManager; //Field offset: 0x58
		internal GetStoreManagerMethod GetStoreManager; //Field offset: 0x60
		internal GetVoiceManagerMethod GetVoiceManager; //Field offset: 0x68
		internal GetAchievementManagerMethod GetAchievementManager; //Field offset: 0x70

	}

	internal sealed class SetLogHookHandler : MulticastDelegate
	{

		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public SetLogHookHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(LogLevel level, string message, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(LogLevel level, string message) { }

	}

	private GCHandle SelfHandle; //Field offset: 0x10
	private IntPtr EventsPtr; //Field offset: 0x18
	private FFIEvents Events; //Field offset: 0x20
	private IntPtr ApplicationEventsPtr; //Field offset: 0x28
	private FFIEvents ApplicationEvents; //Field offset: 0x30
	internal ApplicationManager ApplicationManagerInstance; //Field offset: 0x38
	private IntPtr UserEventsPtr; //Field offset: 0x40
	private FFIEvents UserEvents; //Field offset: 0x48
	internal UserManager UserManagerInstance; //Field offset: 0x50
	private IntPtr ImageEventsPtr; //Field offset: 0x58
	private FFIEvents ImageEvents; //Field offset: 0x60
	internal ImageManager ImageManagerInstance; //Field offset: 0x68
	private IntPtr ActivityEventsPtr; //Field offset: 0x70
	private FFIEvents ActivityEvents; //Field offset: 0x78
	internal ActivityManager ActivityManagerInstance; //Field offset: 0x98
	private IntPtr RelationshipEventsPtr; //Field offset: 0xA0
	private FFIEvents RelationshipEvents; //Field offset: 0xA8
	internal RelationshipManager RelationshipManagerInstance; //Field offset: 0xB8
	private IntPtr LobbyEventsPtr; //Field offset: 0xC0
	private FFIEvents LobbyEvents; //Field offset: 0xC8
	internal LobbyManager LobbyManagerInstance; //Field offset: 0x108
	private IntPtr NetworkEventsPtr; //Field offset: 0x110
	private FFIEvents NetworkEvents; //Field offset: 0x118
	internal NetworkManager NetworkManagerInstance; //Field offset: 0x128
	private IntPtr OverlayEventsPtr; //Field offset: 0x130
	private FFIEvents OverlayEvents; //Field offset: 0x138
	internal OverlayManager OverlayManagerInstance; //Field offset: 0x140
	private IntPtr StorageEventsPtr; //Field offset: 0x148
	private FFIEvents StorageEvents; //Field offset: 0x150
	internal StorageManager StorageManagerInstance; //Field offset: 0x158
	private IntPtr StoreEventsPtr; //Field offset: 0x160
	private FFIEvents StoreEvents; //Field offset: 0x168
	internal StoreManager StoreManagerInstance; //Field offset: 0x178
	private IntPtr VoiceEventsPtr; //Field offset: 0x180
	private FFIEvents VoiceEvents; //Field offset: 0x188
	internal VoiceManager VoiceManagerInstance; //Field offset: 0x190
	private IntPtr AchievementEventsPtr; //Field offset: 0x198
	private FFIEvents AchievementEvents; //Field offset: 0x1A0
	internal AchievementManager AchievementManagerInstance; //Field offset: 0x1A8
	private IntPtr MethodsPtr; //Field offset: 0x1B0
	private object MethodsStructure; //Field offset: 0x1B8
	private Nullable<GCHandle> setLogHook; //Field offset: 0x1C0

	private FFIMethods Methods
	{
		[CalledBy(Type = typeof(Discord), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Discord), Member = "GetAchievementManager", ReturnType = typeof(AchievementManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetVoiceManager", ReturnType = typeof(VoiceManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetStoreManager", ReturnType = typeof(StoreManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetStorageManager", ReturnType = typeof(StorageManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetOverlayManager", ReturnType = typeof(OverlayManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetLobbyManager", ReturnType = typeof(LobbyManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetNetworkManager", ReturnType = typeof(NetworkManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetActivityManager", ReturnType = typeof(ActivityManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetImageManager", ReturnType = typeof(ImageManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetUserManager", ReturnType = typeof(UserManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetApplicationManager", ReturnType = typeof(ApplicationManager))]
		[CalledBy(Type = typeof(Discord), Member = "SetLogHook", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogLevel), typeof(SetLogHookHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Discord), Member = "RunCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Discord), Member = "GetRelationshipManager", ReturnType = typeof(RelationshipManager))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 333
	}

	[CalledBy(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FFIEvents)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FFIEvents)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FFIEvents)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FFIEvents)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Discord), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public Discord(long clientId, ulong flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Result DiscordCreate(uint version, ref FFICreateParams createParams, out IntPtr manager) { }

	[CalledBy(Type = typeof(Discord), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(Discord), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Discord), Member = "GetRelationshipManager", ReturnType = typeof(RelationshipManager))]
	[CalledBy(Type = typeof(Discord), Member = "RunCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Discord), Member = "SetLogHook", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogLevel), typeof(SetLogHookHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Discord), Member = "GetApplicationManager", ReturnType = typeof(ApplicationManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetUserManager", ReturnType = typeof(UserManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetActivityManager", ReturnType = typeof(ActivityManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetImageManager", ReturnType = typeof(ImageManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetLobbyManager", ReturnType = typeof(LobbyManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetOverlayManager", ReturnType = typeof(OverlayManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetStorageManager", ReturnType = typeof(StorageManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetStoreManager", ReturnType = typeof(StoreManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetVoiceManager", ReturnType = typeof(VoiceManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetAchievementManager", ReturnType = typeof(AchievementManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetNetworkManager", ReturnType = typeof(NetworkManager))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	private FFIMethods get_Methods() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(AchievementManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AchievementManager GetAchievementManager() { }

	[CalledBy(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
	[CalledBy(Type = typeof(DiscordController), Member = "LeaveRoomLobby", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ActivityManager), Member = "InitEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public ActivityManager GetActivityManager() { }

	[CalledBy(Type = typeof(DiscordController), Member = "get_AppManager", ReturnType = typeof(ApplicationManager))]
	[CalledBy(Type = typeof(DiscordController), Member = "RequestAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthMethod), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public ApplicationManager GetApplicationManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ImageManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ImageManager GetImageManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(LobbyManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public LobbyManager GetLobbyManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(NetworkManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public NetworkManager GetNetworkManager() { }

	[CalledBy(Type = typeof(DiscordController), Member = "get_OverManager", ReturnType = typeof(OverlayManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(OverlayManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public OverlayManager GetOverlayManager() { }

	[CalledBy(Type = typeof(DiscordController), Member = "get_FriendsManager", ReturnType = typeof(RelationshipManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(RelationshipManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RelationshipManager GetRelationshipManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(StorageManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public StorageManager GetStorageManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(StoreManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public StoreManager GetStoreManager() { }

	[CalledBy(Type = typeof(DiscordController), Member = "get_PlayerManager", ReturnType = typeof(UserManager))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnChangeUser", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<UnityEngine.Texture2D>), typeof(ushort), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<Discord.User>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public UserManager GetUserManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(VoiceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public VoiceManager GetVoiceManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[CalledBy(Type = typeof(DiscordController), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void RunCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void SetLogHook(LogLevel minLevel, SetLogHookHandler callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback]
	private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message) { }

}

