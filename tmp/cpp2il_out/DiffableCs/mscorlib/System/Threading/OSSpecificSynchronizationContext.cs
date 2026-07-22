namespace System.Threading;

internal class OSSpecificSynchronizationContext : SynchronizationContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static CreateValueCallback<Object, OSSpecificSynchronizationContext> <>9__3_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

	}

	private class InvocationContext
	{
		private SendOrPostCallback m_Delegate; //Field offset: 0x10
		private object m_State; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public InvocationContext(SendOrPostCallback d, object state) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void Invoke() { }

	}

	private sealed class InvocationEntryDelegate : MulticastDelegate
	{

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public InvocationEntryDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(IntPtr arg) { }

	}

	private static readonly ConditionalWeakTable<Object, OSSpecificSynchronizationContext> s_ContextCache; //Field offset: 0x0
	private object m_OSSynchronizationContext; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static OSSpecificSynchronizationContext() { }

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private OSSpecificSynchronizationContext(object osContext) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual SynchronizationContext CreateCopy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "System.Runtime.CompilerServices.ConditionalWeakTable`2<TKey, TValue>+CreateValueCallback<TKey, TValue>"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static OSSpecificSynchronizationContext Get() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static object GetOSContext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = "ReportUnhandledException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[MonoPInvokeCallback(typeof(InvocationEntryDelegate))]
	private static void InvocationEntry(IntPtr arg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public virtual void Post(SendOrPostCallback d, object state) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Send(SendOrPostCallback d, object state) { }

}

