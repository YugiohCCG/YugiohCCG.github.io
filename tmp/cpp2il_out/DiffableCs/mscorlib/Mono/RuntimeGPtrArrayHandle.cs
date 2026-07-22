namespace Mono;

[DefaultMember("Item")]
internal struct RuntimeGPtrArrayHandle
{
	private GPtrArray* value; //Field offset: 0x0

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
	internal RuntimeGPtrArrayHandle(IntPtr ptr) { }

	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RuntimeGPtrArrayHandle), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[DeduplicatedMethod]
	internal IntPtr get_Item(int i) { }

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal int get_Length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void GPtrArrayFree(GPtrArray* value) { }

	[CalledBy(Type = typeof(RuntimeGPtrArrayHandle), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(SafeGPtrArrayHandle), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal IntPtr Lookup(int i) { }

}

