namespace DigitalRuby.Threading;

public class EZThread : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Action action; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass16_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal object <ExecuteInBackground>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Func<Object> a; //Field offset: 0x10
		public Action<Object> completion; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass7_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EZThread), Member = "ExecuteOnMainThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		internal void <InternalExecute>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_1
	{
		public object result; //Field offset: 0x10
		public <>c__DisplayClass7_0 CS$<>8__locals1; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass7_1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <InternalExecute>b__1() { }

	}

	internal class EZThreadRunner
	{
		private bool running; //Field offset: 0x10
		private Action action; //Field offset: 0x18
		[CompilerGenerated]
		private AutoResetEvent <SyncEvent>k__BackingField; //Field offset: 0x20

		public private AutoResetEvent SyncEvent
		{
			[CallerCount(Count = 12)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 10)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 13
		}

		[CalledBy(Type = typeof(EZThread), Member = "BeginThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(EZThreadRunner))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal EZThreadRunner(Action action, bool synchronizeWithUpdate) { }

		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public AutoResetEvent get_SyncEvent() { }

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_SyncEvent(AutoResetEvent value) { }

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		public void Stop() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void ThreadFunction() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private void ThreadFunctionSync() { }

	}

	private static GameObject singletonObject; //Field offset: 0x0
	private static EZThread singleton; //Field offset: 0x8
	private readonly List<KeyValuePair`2<Action, Single>> mainThreadActions; //Field offset: 0x20
	private readonly Queue<KeyValuePair`2<Object, Action`1<Object>>> mainThreadCompletions; //Field offset: 0x28
	private readonly List<EZThreadRunner> threads; //Field offset: 0x30

	public EZThread Instance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public EZThread() { }

	[CalledBy(Type = typeof(EZThread), Member = "BeginThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(EZThreadRunner))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EZThread), Member = "EnsureCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(EZThreadRunner), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static EZThreadRunner BeginThread(Action action, bool synchronizeWithUpdate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EZThread), Member = "BeginThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(EZThreadRunner))]
	public static EZThreadRunner BeginThread(Action action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void EndThread(EZThreadRunner thread) { }

	[CalledBy(Type = typeof(EZThread), Member = "ExecuteInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EZThread), Member = "ExecuteInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>), typeof(System.Action`1<System.Object>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EZThread), Member = "ExecuteOnMainThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EZThread), Member = "ExecuteOnMainThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EZThread), Member = "BeginThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(EZThreadRunner))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void EnsureCreated() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EZThread), Member = "EnsureCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(EZThread), Member = "InternalExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>), typeof(System.Action`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void ExecuteInBackground(Action action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EZThread), Member = "EnsureCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(EZThread), Member = "InternalExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>), typeof(System.Action`1<System.Object>)}, ReturnType = typeof(void))]
	public static void ExecuteInBackground(Func<Object> action, Action<Object> completion) { }

	[CalledBy(Type = typeof(<>c__DisplayClass7_0), Member = "<InternalExecute>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "RequestAuthenticationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnSetCustomBotData>d__83", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EZThread), Member = "EnsureCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void ExecuteOnMainThread(Action action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EZThread), Member = "EnsureCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void ExecuteOnMainThread(Action action, float delaySeconds) { }

	[CallerCount(Count = 0)]
	public EZThread get_Instance() { }

	[CalledBy(Type = typeof(EZThread), Member = "ExecuteInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EZThread), Member = "ExecuteInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>), typeof(System.Action`1<System.Object>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void InternalExecute(Func<Object> a, Action<Object> completion) { }

	[CalledBy(Type = typeof(EZThread), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void NotifyThreads() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EZThread), Member = "Reset", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void OnApplicationQuit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EZThread), Member = "Reset", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void OnDestroy() { }

	[CalledBy(Type = typeof(EZThread), Member = "SceneManagerSceneUnloaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scene)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EZThread), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EZThread), Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void Reset() { }

	[CalledBy(Type = typeof(EZThread), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue`1), Member = "Dequeue", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void RunMainThreadActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EZThread), Member = "Reset", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void SceneManagerSceneUnloaded(Scene arg0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "add_sceneUnloaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`1<UnityEngine.SceneManagement.Scene>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EZThread), Member = "RunMainThreadActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(EZThread), Member = "NotifyThreads", ReturnType = typeof(void))]
	private void Update() { }

}

