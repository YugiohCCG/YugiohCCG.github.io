namespace System.Runtime.InteropServices;

[IsReadOnly]
public struct HandleRef
{
	private readonly object _wrapper; //Field offset: 0x0
	private readonly IntPtr _handle; //Field offset: 0x8

	public IntPtr Handle
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public HandleRef(object wrapper, IntPtr handle) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public IntPtr get_Handle() { }

}

