namespace System;

[AttributeUsage(6140, Inherited = False)]
public sealed class ObsoleteAttribute : Attribute
{
	private string _message; //Field offset: 0x10
	private bool _error; //Field offset: 0x18

	public bool IsError
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Message
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ObsoleteAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ObsoleteAttribute(string message) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ObsoleteAttribute(string message, bool error) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsError() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Message() { }

}

