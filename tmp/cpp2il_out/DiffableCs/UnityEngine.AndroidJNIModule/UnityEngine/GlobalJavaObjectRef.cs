namespace UnityEngine;

internal class GlobalJavaObjectRef
{
	private bool m_disposed; //Field offset: 0x10
	protected IntPtr m_jobject; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GlobalJavaObjectRef(IntPtr jobject) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

}

