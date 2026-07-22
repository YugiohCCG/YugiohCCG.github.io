namespace System.Threading.Tasks;

internal class StackGuard
{
	private int m_inliningDepth; //Field offset: 0x10

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public StackGuard() { }

	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal void EndInliningScope() { }

	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool TryBeginInliningScope() { }

}

