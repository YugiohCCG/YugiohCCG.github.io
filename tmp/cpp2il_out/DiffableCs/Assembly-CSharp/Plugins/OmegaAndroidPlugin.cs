namespace Plugins;

public static class OmegaAndroidPlugin
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public string message; //Field offset: 0x10
		public int duration; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass10_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		internal void <ShowToast>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string path; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass13_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal void <InstallAPK>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public string path; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass14_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal void <OpenPath>b__0() { }

	}

	private static AndroidJavaObject Plugin; //Field offset: 0x0
	private const int TOAST_LONG = 1; //Field offset: 0x0
	private const int TOAST_SHORT = 0; //Field offset: 0x0
	private static AndroidJavaObject ActivityContext; //Field offset: 0x8

	private static int API_Level
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AndroidJavaObject), Member = "GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "FieldType")]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 140
	}

	public static bool IsInitialized
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 72
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "FieldType")]
	[CallsUnknownMethods(Count = 1)]
	private static int get_API_Level() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool get_IsInitialized() { }

	[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OmegaAndroidPlugin), Member = "RunJavaTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void InstallAPK(string path) { }

	[CalledBy(Type = typeof(Helper), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OmegaAndroidPlugin), Member = "RunJavaTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void OpenPath(string path) { }

	[CalledBy(Type = typeof(OmegaAndroidPlugin), Member = "ShowToast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OmegaAndroidPlugin), Member = "InstallAPK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OmegaAndroidPlugin), Member = "OpenPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Helper), Member = "get_IsMainThread", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AndroidJNI), Member = "AttachCurrentThread", ReturnType = typeof(int))]
	[Calls(Type = typeof(AndroidJNI), Member = "DetachCurrentThread", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static void RunJavaTask(Action task) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OmegaAndroidPlugin), Member = "ShowToast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	public static void ShowLongToastMessage(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OmegaAndroidPlugin), Member = "ShowToast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	public static void ShowShortToastMessage(string message) { }

	[CalledBy(Type = typeof(OmegaAndroidPlugin), Member = "ShowShortToastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OmegaAndroidPlugin), Member = "ShowLongToastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OmegaAndroidPlugin), Member = "RunJavaTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void ShowToast(string message, int duration) { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public static void Start() { }

}

