namespace UnityEngine.Rendering.Universal;

internal struct PinnedArray : IDisposable
{
	public T[] managedArray; //Field offset: 0x0
	public GCHandle handle; //Field offset: 0x0
	public NativeArray<T> nativeArray; //Field offset: 0x0

	public int length
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 16
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public PinnedArray`1(int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_length() { }

}

