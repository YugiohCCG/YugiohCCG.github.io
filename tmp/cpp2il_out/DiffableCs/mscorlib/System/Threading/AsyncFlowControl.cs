namespace System.Threading;

public struct AsyncFlowControl : IDisposable
{
	private bool useEC; //Field offset: 0x0
	private ExecutionContext _ec; //Field offset: 0x8
	private Thread _thread; //Field offset: 0x10

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "WireupCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Awaitable", typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncFlowControl), Member = "Undo", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Equals(AsyncFlowControl obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(ExecutionContext), Member = "SuppressFlow", ReturnType = typeof(AsyncFlowControl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[CallsUnknownMethods(Count = 5)]
	internal void Setup() { }

	[CalledBy(Type = typeof(AsyncFlowControl), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	public void Undo() { }

}

