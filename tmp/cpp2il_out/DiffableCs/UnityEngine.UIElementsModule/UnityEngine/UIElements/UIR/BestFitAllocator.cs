namespace UnityEngine.UIElements.UIR;

internal class BestFitAllocator
{
	private class Block : LinkedPoolItem<Block>
	{
		public uint start; //Field offset: 0x18
		public uint end; //Field offset: 0x1C
		public Block prev; //Field offset: 0x20
		public Block next; //Field offset: 0x28
		public Block prevAvailable; //Field offset: 0x30
		public Block nextAvailable; //Field offset: 0x38
		public bool allocated; //Field offset: 0x40

		public uint size
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public Block() { }

		[CallerCount(Count = 0)]
		public uint get_size() { }

	}

	private class BlockPool : LinkedPool<Block>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		public BlockPool() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private static Block CreateBlock() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		private static void ResetBlock(Block block) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly uint <totalSize>k__BackingField; //Field offset: 0x10
	private Block m_FirstBlock; //Field offset: 0x18
	private Block m_FirstAvailableBlock; //Field offset: 0x20
	private BlockPool m_BlockPool; //Field offset: 0x28
	private uint m_HighWatermark; //Field offset: 0x30

	public uint highWatermark
	{
		[CalledBy(Type = typeof(Allocator2D), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 6
	}

	public uint totalSize
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(Area), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Allocator2D), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Alloc2D&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Allocator2D), Member = "BuildAreas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.Allocator2D+Area>), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUBufferAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public BestFitAllocator(uint size) { }

	[CalledBy(Type = typeof(Allocator2D), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Alloc2D&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GPUBufferAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(Alloc))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Alloc))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public Alloc Allocate(uint size) { }

	[CallerCount(Count = 0)]
	private Block BestFitFindAvailableBlock(uint size) { }

	[CalledBy(Type = typeof(BestFitAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private Block CoalesceBlockWithPrevious(Block block) { }

	[CalledBy(Type = typeof(Allocator2D), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUBufferAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(Alloc))]
	[CalledBy(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BestFitAllocator), Member = "CoalesceBlockWithPrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block)}, ReturnType = typeof(Block))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void Free(Alloc alloc) { }

	[CalledBy(Type = typeof(Allocator2D), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public uint get_highWatermark() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public uint get_totalSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private void SplitBlock(Block block, uint size) { }

}

