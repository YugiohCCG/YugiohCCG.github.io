namespace System;

public class UnhandledExceptionEventArgs : EventArgs
{
	private object _exception; //Field offset: 0x10
	private bool _isTerminating; //Field offset: 0x18

	public object ExceptionObject
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsTerminating
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UnhandledExceptionEventArgs(object exception, bool isTerminating) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public object get_ExceptionObject() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsTerminating() { }

}

