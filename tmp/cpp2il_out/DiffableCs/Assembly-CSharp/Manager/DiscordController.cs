namespace Manager;

public class DiscordController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static AcceptInviteHandler <>9__65_0; //Field offset: 0x8
		public static AcceptInviteHandler <>9__65_2; //Field offset: 0x10
		public static SendRequestReplyHandler <>9__67_0; //Field offset: 0x18
		public static SendRequestReplyHandler <>9__67_2; //Field offset: 0x20
		public static ClearActivityHandler <>9__95_0; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		internal void <LeaveRoomLobby>b__95_0(Result cb) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		internal void <OnActivityInvite>b__65_0(Result res) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		internal void <OnActivityInvite>b__65_2(Result res) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		internal void <OnActivityJoinRequest>b__67_0(Result res) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		internal void <OnActivityJoinRequest>b__67_2(Result res) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public Action<String> act; //Field offset: 0x10
		public string msg; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass59_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <RequestAuthenticationCallback>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public Action<String> onFinish; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass60_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal void <RequestAuthentication>b__0(Result r, ref OAuth2Token t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public long id; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass65_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
		[Calls(Type = typeof(ActivityManager), Member = "AcceptInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(AcceptInviteHandler)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <OnActivityInvite>b__1(bool r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public long id; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass67_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
		[Calls(Type = typeof(ActivityManager), Member = "SendRequestReply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ActivityJoinRequestReply), typeof(SendRequestReplyHandler)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <OnActivityJoinRequest>b__1(bool r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public Action<Texture2D> onFinish; //Field offset: 0x10
		public long userId; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass80_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DiscordController), Member = "DoGetPlayerAvatarFromWeb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(System.Action`1<UnityEngine.Texture2D>), typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DiscordController), Member = "LoadDefaultAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.Texture2D>)}, ReturnType = typeof(void))]
		internal void <DoGetPlayerAvatar>b__0(User u) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_0
	{
		public Action<String> onFinish; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass90_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DiscordController), Member = "CacheUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void <DoGetPlayerName>b__0(Result r, ref User u) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass91_0
	{
		public GetUserHandler callback; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass91_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <GetUser>b__0(Result r, ref User u) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass94_0
	{
		public Action<User> onFinish; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass94_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DiscordController), Member = "CacheUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void <DoGetPlayerData>b__0(Result r, ref User u) { }

	}

	[CompilerGenerated]
	private struct <DoGetPlayerAvatarFromWeb>d__81 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public long userId; //Field offset: 0x28
		public string avatar; //Field offset: 0x30
		public Action<Texture2D> onFinish; //Field offset: 0x38
		public ushort size; //Field offset: 0x40
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Helper+<GetTextureFromWeb>d__145"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetTextureFromWeb>d__145&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(DiscordController), Member = "CacheUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string), typeof(Texture2D)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DiscordController), Member = "LoadDefaultAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.Texture2D>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 26)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetUser>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GetUserHandler callback; //Field offset: 0x28
		public long userId; //Field offset: 0x30
		private <>c__DisplayClass91_0 <>8__1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(DiscordController), Member = "get_PlayerManager", ReturnType = typeof(UserManager))]
		[Calls(Type = typeof(UserManager), Member = "GetUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(GetUserHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateRichPresence>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string state; //Field offset: 0x28
		public string details; //Field offset: 0x30
		public string imgLarge; //Field offset: 0x38
		public string imgSmall; //Field offset: 0x40
		public string textLarge; //Field offset: 0x48
		public string textSmall; //Field offset: 0x50
		private Activity <act>5__2; //Field offset: 0x58
		private string <secret>5__3; //Field offset: 0xE8
		private TaskAwaiter<String> <>u__1; //Field offset: 0xF0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcNow", ReturnType = typeof(DateTimeOffset))]
		[Calls(Type = typeof(DateTimeOffset), Member = "ToUnixTimeSeconds", ReturnType = typeof(long))]
		[Calls(Type = typeof(RoomData), Member = "GenPwd", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<UpdateRichPresence>d__76)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<UpdateRichPresence>d__76&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "get_PlayerCount", ReturnType = typeof(byte))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DiscordController), Member = "UpdateActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Activity)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 23)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct CachedUser
	{
		public string Username; //Field offset: 0x0
		public string Avatar; //Field offset: 0x8
		public Texture2D AvatarTexture; //Field offset: 0x10

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public CachedUser(string name, string avatar, Texture2D img = null) { }

	}

	public static DiscordController Instance; //Field offset: 0x0
	private const string DISCORD_EXPIRATION = "expires_in"; //Field offset: 0x0
	private const float ACT_TIMER = 5; //Field offset: 0x0
	public const byte MSG_DELAY = 250; //Field offset: 0x0
	private const string DISCORD_STATE = "state"; //Field offset: 0x0
	private const string DISCORD_TOKEN = "access_token"; //Field offset: 0x0
	public const string DiscordAPI = "https://discord.com/api"; //Field offset: 0x0
	public const long ClientID = 617739889600888840; //Field offset: 0x0
	public const ulong Flags = 1; //Field offset: 0x0
	public const string DiscordCDN = "https://cdn.discordapp.com"; //Field offset: 0x0
	private static readonly Guid DiscordUniqueGUID; //Field offset: 0x8
	public static readonly string DiscordUniqueB64; //Field offset: 0x18
	private static readonly string EncodedDiscordB64; //Field offset: 0x20
	private static readonly string DiscordGrantWebCallback; //Field offset: 0x28
	private static readonly string DiscordGrantDeepLinkCallback; //Field offset: 0x30
	private static readonly string DiscordImplicitGrantWeb; //Field offset: 0x38
	private static readonly string DiscordImplicitGrantDeepLink; //Field offset: 0x40
	public static User LocalPlayer; //Field offset: 0x48
	[CompilerGenerated]
	private static OAuth2Token <LocalToken>k__BackingField; //Field offset: 0x70
	private static Discord _discord; //Field offset: 0x88
	public static bool InvalidateDiscord; //Field offset: 0x90
	public static readonly Dictionary<Int64, CachedUser> UserCache; //Field offset: 0x98
	public static readonly Dictionary<Int64, User> DiscordUserCache; //Field offset: 0xA0
	public static byte JoinRequest; //Field offset: 0xA8
	public static byte JoinInvite; //Field offset: 0xA9
	public static bool Joining; //Field offset: 0xAA
	public static MuteOptions ChatMuteOpt; //Field offset: 0xAC
	private static readonly SemaphoreSlim GetUserSemaphore; //Field offset: 0xB0
	private static Action<String> WebAuthSync; //Field offset: 0xB8
	private static Activity RequestedActivity; //Field offset: 0xC0
	private static Activity LiveActivity; //Field offset: 0x150
	private static readonly Queue<Tuple`4<Int64, Action`1<Texture2D>, UInt16, String>> AvatarQueue; //Field offset: 0x1E0
	private static readonly Queue<Tuple`2<Int64, Action`1<String>>> NameQueue; //Field offset: 0x1E8
	private static readonly Queue<Tuple`2<Int64, Action`1<User>>> UserQueue; //Field offset: 0x1F0
	private static readonly Dictionary<Int64, DateTime> LastChatPacket; //Field offset: 0x1F8
	private float ActUpdate; //Field offset: 0x20
	private bool IsRequestingAct; //Field offset: 0x24

	public static ActivityManager ActManager
	{
		[CalledBy(Type = typeof(<>c__DisplayClass65_0), Member = "<OnActivityInvite>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<>c__DisplayClass67_0), Member = "<OnActivityJoinRequest>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
		[CalledBy(Type = typeof(DiscordController), Member = "OnActivityInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityActionType), typeof(User&), typeof(Activity&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "OnActivityJoinRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
		[Calls(Type = typeof(Discord), Member = "GetActivityManager", ReturnType = typeof(ActivityManager))]
		 get { } //Length: 84
	}

	public static ApplicationManager AppManager
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
		[Calls(Type = typeof(Discord), Member = "GetApplicationManager", ReturnType = typeof(ApplicationManager))]
		 get { } //Length: 84
	}

	private static bool CanInviteJoin
	{
		[CalledBy(Type = typeof(DiscordController), Member = "OnActivityJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "OnActivityInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityActionType), typeof(User&), typeof(Activity&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "OnActivitySpectate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "OnActivityJoinRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LobbyScreen), Member = "get_IsInQueue", ReturnType = typeof(bool))]
		private get { } //Length: 279
	}

	public static Discord DiscordManager
	{
		[CalledBy(Type = typeof(DiscordController), Member = "get_IsValid", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
		[CalledBy(Type = typeof(DiscordController), Member = "get_OverManager", ReturnType = typeof(OverlayManager))]
		[CalledBy(Type = typeof(DiscordController), Member = "get_FriendsManager", ReturnType = typeof(RelationshipManager))]
		[CalledBy(Type = typeof(DiscordController), Member = "get_PlayerManager", ReturnType = typeof(UserManager))]
		[CalledBy(Type = typeof(DiscordController), Member = "get_AppManager", ReturnType = typeof(ApplicationManager))]
		[CalledBy(Type = typeof(DiscordController), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "RequestAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthMethod), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "OnChangeUser", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<UnityEngine.Texture2D>), typeof(ushort), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<Discord.User>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DiscordController), Member = "LeaveRoomLobby", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Discord), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DiscordController), Member = "get_PlayerManager", ReturnType = typeof(UserManager))]
		[Calls(Type = typeof(UserManager), Member = "add_OnCurrentUserUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CurrentUserUpdateHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
		[Calls(Type = typeof(ActivityManager), Member = "add_OnActivityJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityJoinHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ActivityManager), Member = "add_OnActivitySpectate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivitySpectateHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ActivityManager), Member = "add_OnActivityJoinRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityJoinRequestHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ActivityManager), Member = "add_OnActivityInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityInviteHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 13)]
		 get { } //Length: 1024
	}

	public static RelationshipManager FriendsManager
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
		[Calls(Type = typeof(Discord), Member = "GetRelationshipManager", ReturnType = typeof(RelationshipManager))]
		 get { } //Length: 84
	}

	public static bool IsValid
	{
		[CalledBy(Type = typeof(DiscordController), Member = "LeaveRoomLobby", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<>c", Member = "<PostConnection>b__34_0", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<PostConnection>d__34", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Packet), Member = "MakeLocalAuthPacket", ReturnType = typeof(BinaryWriter))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 166
	}

	public static OAuth2Token LocalToken
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 104
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 125
	}

	public static bool MuteChat
	{
		[CalledBy(Type = typeof(ChatWindow), Member = "SendChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DiscordController), Member = "get_MutePlayers", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DiscordController), Member = "get_MuteSpectators", ReturnType = typeof(bool))]
		 get { } //Length: 101
	}

	public static bool MutePlayers
	{
		[CalledBy(Type = typeof(DiscordController), Member = "get_MuteChat", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DiscordController), Member = "IsMessageBlocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 126
	}

	public static bool MuteSpectators
	{
		[CalledBy(Type = typeof(DiscordController), Member = "get_MuteChat", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DiscordController), Member = "IsMessageBlocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 126
	}

	public static OverlayManager OverManager
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
		[Calls(Type = typeof(Discord), Member = "GetOverlayManager", ReturnType = typeof(OverlayManager))]
		 get { } //Length: 84
	}

	public static UserManager PlayerManager
	{
		[CalledBy(Type = typeof(<GetUser>d__91), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
		[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
		[Calls(Type = typeof(Discord), Member = "GetUserManager", ReturnType = typeof(UserManager))]
		 get { } //Length: 84
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 47)]
	private static DiscordController() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DiscordController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <FixedUpdate>b__75_0(Result r) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake() { }

	[CalledBy(Type = typeof(<>c__DisplayClass90_0), Member = "<DoGetPlayerName>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(User&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass94_0), Member = "<DoGetPlayerData>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(User&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "CacheUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void CacheUser(User u) { }

	[CalledBy(Type = typeof(<DoGetPlayerAvatarFromWeb>d__81), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnChangeUser", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "CacheUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Manager.DiscordController+CachedUser>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CachedUser&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Manager.DiscordController+CachedUser>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CachedUser)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void CacheUser(long userId, string username, string avatar, Texture2D avatarTexture) { }

	[CalledBy(Type = typeof(DiscordController), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "DoGetPlayerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<Discord.User>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "DoGetPlayerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "DoGetPlayerAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<UnityEngine.Texture2D>), typeof(ushort), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void DequeueRequests() { }

	[CalledBy(Type = typeof(DiscordController), Member = "DequeueRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Manager.DiscordController+CachedUser>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CachedUser&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetUserManager", ReturnType = typeof(UserManager))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "DoGetPlayerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<Discord.User>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetPlayerAvatarFromWeb>d__81)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetPlayerAvatarFromWeb>d__81&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public static bool DoGetPlayerAvatar(long userId, Action<Texture2D> onFinish, ushort size = 128, string avatar = null) { }

	[AsyncStateMachine(typeof(<DoGetPlayerAvatarFromWeb>d__81))]
	[CalledBy(Type = typeof(<>c__DisplayClass80_0), Member = "<DoGetPlayerAvatar>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetPlayerAvatarFromWeb>d__81)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetPlayerAvatarFromWeb>d__81&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void DoGetPlayerAvatarFromWeb(long userId, string avatar, Action<Texture2D> onFinish, ushort size = 128) { }

	[CalledBy(Type = typeof(DiscordController), Member = "DequeueRequests", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<UnityEngine.Texture2D>), typeof(ushort), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Manager.DiscordController+CachedUser>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CachedUser&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetUserManager", ReturnType = typeof(UserManager))]
	[Calls(Type = typeof(DiscordController), Member = "GetUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(GetUserHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static bool DoGetPlayerData(long userId, Action<User> onFinish) { }

	[CalledBy(Type = typeof(DiscordController), Member = "DequeueRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Manager.DiscordController+CachedUser>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CachedUser&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "get_PlayerManager", ReturnType = typeof(UserManager))]
	[Calls(Type = typeof(DiscordController), Member = "GetUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(GetUserHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public static bool DoGetPlayerName(long userId, Action<String> onFinish) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
	[Calls(Type = typeof(ActivityManager), Member = "UpdateActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Activity), typeof(UpdateActivityHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void FixedUpdate() { }

	[CalledBy(Type = typeof(<>c__DisplayClass65_0), Member = "<OnActivityInvite>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass67_0), Member = "<OnActivityJoinRequest>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnActivityInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityActionType), typeof(User&), typeof(Activity&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnActivityJoinRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetActivityManager", ReturnType = typeof(ActivityManager))]
	public static ActivityManager get_ActManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetApplicationManager", ReturnType = typeof(ApplicationManager))]
	public static ApplicationManager get_AppManager() { }

	[CalledBy(Type = typeof(DiscordController), Member = "OnActivityJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnActivityInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityActionType), typeof(User&), typeof(Activity&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnActivitySpectate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnActivityJoinRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsInQueue", ReturnType = typeof(bool))]
	private static bool get_CanInviteJoin() { }

	[CalledBy(Type = typeof(DiscordController), Member = "get_IsValid", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
	[CalledBy(Type = typeof(DiscordController), Member = "get_OverManager", ReturnType = typeof(OverlayManager))]
	[CalledBy(Type = typeof(DiscordController), Member = "get_FriendsManager", ReturnType = typeof(RelationshipManager))]
	[CalledBy(Type = typeof(DiscordController), Member = "get_PlayerManager", ReturnType = typeof(UserManager))]
	[CalledBy(Type = typeof(DiscordController), Member = "get_AppManager", ReturnType = typeof(ApplicationManager))]
	[CalledBy(Type = typeof(DiscordController), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "RequestAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthMethod), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnChangeUser", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<UnityEngine.Texture2D>), typeof(ushort), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<Discord.User>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DiscordController), Member = "LeaveRoomLobby", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Discord), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "get_PlayerManager", ReturnType = typeof(UserManager))]
	[Calls(Type = typeof(UserManager), Member = "add_OnCurrentUserUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CurrentUserUpdateHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
	[Calls(Type = typeof(ActivityManager), Member = "add_OnActivityJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityJoinHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivityManager), Member = "add_OnActivitySpectate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivitySpectateHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivityManager), Member = "add_OnActivityJoinRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityJoinRequestHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivityManager), Member = "add_OnActivityInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityInviteHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public static Discord get_DiscordManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetRelationshipManager", ReturnType = typeof(RelationshipManager))]
	public static RelationshipManager get_FriendsManager() { }

	[CalledBy(Type = typeof(DiscordController), Member = "LeaveRoomLobby", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<>c", Member = "<PostConnection>b__34_0", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<PostConnection>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Packet), Member = "MakeLocalAuthPacket", ReturnType = typeof(BinaryWriter))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsValid() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static OAuth2Token get_LocalToken() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "SendChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DiscordController), Member = "get_MutePlayers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "get_MuteSpectators", ReturnType = typeof(bool))]
	public static bool get_MuteChat() { }

	[CalledBy(Type = typeof(DiscordController), Member = "get_MuteChat", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DiscordController), Member = "IsMessageBlocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_MutePlayers() { }

	[CalledBy(Type = typeof(DiscordController), Member = "get_MuteChat", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DiscordController), Member = "IsMessageBlocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_MuteSpectators() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetOverlayManager", ReturnType = typeof(OverlayManager))]
	public static OverlayManager get_OverManager() { }

	[CalledBy(Type = typeof(<GetUser>d__91), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetUserManager", ReturnType = typeof(UserManager))]
	public static UserManager get_PlayerManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Manager.DiscordController+CachedUser>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CachedUser&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public static bool GetCachedAvatar(long userId, out string avatar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Manager.DiscordController+CachedUser>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CachedUser&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public static bool GetCachedAvatarTexture(long userId, out Texture2D avatar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Manager.DiscordController+CachedUser>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CachedUser&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	public static bool GetCachedUserData(long userId, out User user) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Manager.DiscordController+CachedUser>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CachedUser&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public static bool GetCachedUsername(long userId, out string username) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateUserInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Tuple`4<System.Int64, System.Object, System.UInt16, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(object), typeof(ushort), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void GetPlayerAvatar(long userId, Action<Texture2D> onFinish, string avatar = null, ushort size = 128) { }

	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void GetPlayerData(long userId, Action<User> onFinish) { }

	[CalledBy(Type = "Scenes.Menu.ReplayList+<OnGetDecks>d__54", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Data.RoomData+<Setup>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void GetPlayerName(long userId, Action<String> onFinish) { }

	[AsyncStateMachine(typeof(<GetUser>d__91))]
	[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<System.String>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DiscordController), Member = "DoGetPlayerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<Discord.User>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetUser>d__91)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetUser>d__91&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void GetUser(long userId, GetUserHandler callback) { }

	[CalledBy(Type = typeof(Network), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(UserRank), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RoomData), Member = "GetIndexOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(DiscordController), Member = "get_MuteSpectators", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "get_MutePlayers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, System.DateTime>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, System.DateTime>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTime)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsMessageBlocked(long userId) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool IsSameAct(Activity a1, Activity a2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsValidState(string state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DiscordController), Member = "DequeueRequests", ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "RunCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void LateUpdate() { }

	[CalledBy(Type = typeof(DuelEnd), Member = "GoBackToLobby", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<EndConnection>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "get_IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetActivityManager", ReturnType = typeof(ActivityManager))]
	[Calls(Type = typeof(ActivityManager), Member = "ClearActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClearActivityHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void LeaveRoomLobby() { }

	[CalledBy(Type = typeof(<>c__DisplayClass80_0), Member = "<DoGetPlayerAvatar>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoGetPlayerAvatarFromWeb>d__81), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void LoadDefaultAvatar(Action<Texture2D> onFinish) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DiscordController), Member = "get_CanInviteJoin", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
	[Calls(Type = typeof(ActivityManager), Member = "AcceptInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(AcceptInviteHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void OnActivityInvite(ActivityActionType type, ref User user, ref Activity act) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DiscordController), Member = "get_CanInviteJoin", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Packet), Member = "JoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void OnActivityJoin(string joinSecret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DiscordController), Member = "get_CanInviteJoin", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "get_ActManager", ReturnType = typeof(ActivityManager))]
	[Calls(Type = typeof(ActivityManager), Member = "SendRequestReply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ActivityJoinRequestReply), typeof(SendRequestReplyHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static void OnActivityJoinRequest(ref User user) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DiscordController), Member = "get_CanInviteJoin", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SettingsMenu), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SettingsMenu), Member = "OnClickCancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Packet), Member = "JoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void OnActivitySpectate(string spectateSecret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetUserManager", ReturnType = typeof(UserManager))]
	[Calls(Type = typeof(UserManager), Member = "GetCurrentUser", ReturnType = typeof(User))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, Discord.User>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(User)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "CacheUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void OnChangeUser() { }

	[CalledBy(Type = "ClientAPI.WebServer+<OnDiscordAuth>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeepLink), Member = "ParseArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>))]
	[Calls(Type = typeof(DiscordController), Member = "ParseDiscordImplicitGrantURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(Int64&), typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>)}, ReturnType = typeof(bool))]
	public static bool ParseDiscordImplicitGrantURL(out string token, out long expiration, String[] args) { }

	[CalledBy(Type = typeof(DeepLink), Member = "OnDeepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "ParseDiscordImplicitGrantURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(Int64&), typeof(String[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool ParseDiscordImplicitGrantURL(out string token, out long expiration, Dictionary<String, String> dict) { }

	[CalledBy(Type = typeof(Network), Member = "StartAuth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthMethod)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DiscordController), Member = "get_DiscordManager", ReturnType = typeof(Discord))]
	[Calls(Type = typeof(Discord), Member = "GetApplicationManager", ReturnType = typeof(ApplicationManager))]
	[Calls(Type = typeof(ApplicationManager), Member = "GetOAuth2Token", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetOAuth2TokenHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void RequestAuthentication(AuthMethod method, Action<String> onFinish) { }

	[CalledBy(Type = "ClientAPI.WebServer+<OnDiscordAuth>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DiscordController), Member = "RequestAuthenticationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long), typeof(string)}, ReturnType = typeof(void))]
	public static void RequestAuthenticationCallback(string msg = null) { }

	[CalledBy(Type = typeof(DeepLink), Member = "OnDeepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "RequestAuthenticationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnDiscordAuth>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EZThread), Member = "ExecuteOnMainThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void RequestAuthenticationCallback(string token = null, long expiration = 0, string msg = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public static void set_LocalToken(OAuth2Token value) { }

	[CalledBy(Type = typeof(<UpdateRichPresence>d__76), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateActivity(Activity act) { }

	[AsyncStateMachine(typeof(<UpdateRichPresence>d__76))]
	[CalledBy(Type = typeof(MainMenu), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayList), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom+<UpdateDiscordPresence>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<CreateEditor>d__305", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "UpdateDiscordPresence", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateRichPresence>d__76)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateRichPresence>d__76&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static void UpdateRichPresence(string state, string details, string imgLarge = "", string textLarge = "", string imgSmall = "", string textSmall = "") { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool ValidateDiscordImplicitGrant(string token, string state) { }

}

