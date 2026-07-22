namespace UnityEngine;

[NativeHeader("Runtime/GameCode/AsyncInstantiate/AsyncInstantiateOperation.h")]
[RequiredByNativeCode]
public class AsyncInstantiateOperation : AsyncOperation
{
	internal static CancellationTokenSource s_GlobalCancellation; //Field offset: 0x0
	internal Object[] m_Result; //Field offset: 0x20
	private CancellationToken m_CancellationToken; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static AsyncInstantiateOperation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal override Object[] CreateResultArray(int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[RequiredByNativeCode(GenerateProxy = True)]
	private bool IsCancellationRequested() { }

}

