namespace System.Threading;

[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView`1))]
public class ThreadLocal : IDisposable
{
	private class FinalizationHelper
	{
		internal LinkedSlotVolatile<T>[] SlotArray; //Field offset: 0x0
		private bool m_trackAllValues; //Field offset: 0x0

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal FinalizationHelper(LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 22)]
		[DeduplicatedMethod]
		protected virtual void Finalize() { }

	}

	private class IdManager
	{
		private int m_nextIdToTry; //Field offset: 0x0
		private List<Boolean> m_freeIds; //Field offset: 0x0

		[CalledBy(Type = typeof(ThreadLocal`1), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public IdManager() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal int GetId() { }

		[CalledBy(Type = typeof(ThreadLocal`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal void ReturnId(int id) { }

	}

	private sealed class LinkedSlot
	{
		internal LinkedSlot<T> Next; //Field offset: 0x0
		internal LinkedSlot<T> Previous; //Field offset: 0x0
		internal LinkedSlotVolatile<T>[] SlotArray; //Field offset: 0x0
		internal T Value; //Field offset: 0x0

		[CalledBy(Type = typeof(ThreadLocal`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadLocal`1), Member = "CreateLinkedSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]", typeof(int), "T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal LinkedSlot(LinkedSlotVolatile<T>[] slotArray) { }

	}

	private struct LinkedSlotVolatile
	{
		internal LinkedSlot<T> Value; //Field offset: 0x0

	}

	[ThreadStatic]
	private static LinkedSlotVolatile<T>[] ts_slotArray; //Field offset: 0xFFFFFFFF
	[ThreadStatic]
	private static FinalizationHelper<T> ts_finalizationHelper; //Field offset: 0xFFFFFFFF
	private static IdManager<T> s_idManager; //Field offset: 0x0
	private Func<T> m_valueFactory; //Field offset: 0x0
	private int m_idComplement; //Field offset: 0x0
	private bool m_initialized; //Field offset: 0x0
	private LinkedSlot<T> m_linkedSlot; //Field offset: 0x0
	private bool m_trackAllValues; //Field offset: 0x0

	public bool IsValueCreated
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 261
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	public T Value
	{
		[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
		[CalledBy(Type = "UnityEngine.Awaitable", Member = "FromNativeAwaitableHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(CancellationToken)}, ReturnType = "UnityEngine.Awaitable")]
		[CalledBy(Type = "UnityEngine.Awaitable", Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThreadLocal`1), Member = "GetValueSlow", ReturnType = "T")]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 240
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 258
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IdManager), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private static ThreadLocal`1() { }

	[CalledBy(Type = "UnityEngine.Awaitable", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkedSlot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public ThreadLocal`1(Func<T> valueFactory) { }

	[CalledBy(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkedSlot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	[DeduplicatedMethod]
	private void CreateLinkedSlot(LinkedSlotVolatile<T>[] slotArray, int id, T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IdManager), Member = "ReturnId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsValueCreated() { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "FromNativeAwaitableHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(CancellationToken)}, ReturnType = "UnityEngine.Awaitable")]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThreadLocal`1), Member = "GetValueSlow", ReturnType = "T")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public T get_Value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static int GetNewTableSize(int minSize) { }

	[CalledBy(Type = typeof(ThreadLocal`1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	private T GetValueSlow() { }

	[CalledBy(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	private void GrowTable(ref LinkedSlotVolatile<T>[] table, int minLength) { }

	[CalledBy(Type = typeof(ThreadLocal`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void Initialize(Func<T> valueFactory, bool trackAllValues) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void set_Value(T value) { }

	[CalledBy(Type = typeof(ThreadLocal`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = "GetValueSlow", ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThreadLocal`1), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "CreateLinkedSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]", typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 34)]
	[DeduplicatedMethod]
	private void SetValueSlow(T value, LinkedSlotVolatile<T>[] slotArray) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadLocal`1), Member = "GetValueSlow", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

