namespace System.Net;

internal class ResponseDescription
{
	internal bool Multiline; //Field offset: 0x10
	internal int Status; //Field offset: 0x14
	internal string StatusDescription; //Field offset: 0x18
	internal StringBuilder StatusBuffer; //Field offset: 0x20
	internal string StatusCodeString; //Field offset: 0x28

	internal bool InvalidStatusCode
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 20
	}

	internal bool PermanentFailure
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 23
	}

	internal bool PositiveCompletion
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 23
	}

	internal bool PositiveIntermediate
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 20
	}

	internal bool TransientFailure
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 23
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ResponseDescription() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_InvalidStatusCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_PermanentFailure() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_PositiveCompletion() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_PositiveIntermediate() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_TransientFailure() { }

}

