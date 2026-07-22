namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Delegate (4096), AllowMultiple = False, Inherited = False)]
[ComVisible(True)]
public sealed class UnmanagedFunctionPointerAttribute : Attribute
{
	private CallingConvention m_callingConvention; //Field offset: 0x10

	public CallingConvention CallingConvention
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public CallingConvention get_CallingConvention() { }

}

