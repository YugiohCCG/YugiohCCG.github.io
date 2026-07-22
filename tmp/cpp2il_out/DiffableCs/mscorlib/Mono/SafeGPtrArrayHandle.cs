namespace Mono;

[DefaultMember("Item")]
internal struct SafeGPtrArrayHandle : IDisposable
{
	private RuntimeGPtrArrayHandle handle; //Field offset: 0x0

	internal IntPtr Item
	{
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(RuntimeGPtrArrayHandle), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal int Length
	{
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 25
	}

	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal SafeGPtrArrayHandle(IntPtr ptr) { }

	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RuntimeGPtrArrayHandle), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[DeduplicatedMethod]
	internal IntPtr get_Item(int i) { }

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal int get_Length() { }

}

