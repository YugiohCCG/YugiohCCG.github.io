namespace UnityEngine.UIElements;

internal struct SafeHandleAccess
{
	private IntPtr m_Handle; //Field offset: 0x0

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public SafeHandleAccess(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool IsNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr op_Implicit(SafeHandleAccess a) { }

}

