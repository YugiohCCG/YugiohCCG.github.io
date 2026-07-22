namespace UnityEngine.UIElements.UIR;

internal class GPUBufferAllocator
{
	private BestFitAllocator m_Low; //Field offset: 0x10
	private BestFitAllocator m_High; //Field offset: 0x18

	public bool isEmpty
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 53
	}

	[CalledBy(Type = typeof(DataSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUBufferType), typeof(uint), typeof(uint), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GPUBufferAllocator(uint maxSize) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "TryAllocFromPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Page), typeof(uint), typeof(uint), typeof(Alloc&), typeof(Alloc&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BestFitAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Alloc))]
	[Calls(Type = typeof(BestFitAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public Alloc Allocate(uint size, bool shortLived) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "TryAllocFromPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Page), typeof(uint), typeof(uint), typeof(Alloc&), typeof(Alloc&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "AdvanceFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BestFitAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Free(Alloc alloc) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isEmpty() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool HighLowCollide() { }

}

