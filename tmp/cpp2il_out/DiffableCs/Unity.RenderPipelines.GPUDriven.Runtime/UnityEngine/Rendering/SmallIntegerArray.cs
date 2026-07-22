namespace UnityEngine.Rendering;

[DefaultMember("Item")]
internal struct SmallIntegerArray : IDisposable
{
	private FixedList32Bytes<Int32> m_FixedArray; //Field offset: 0x0
	private UnsafeList<Int32> m_List; //Field offset: 0x20
	private readonly bool m_IsEmbedded; //Field offset: 0x38
	[CompilerGenerated]
	private bool <Valid>k__BackingField; //Field offset: 0x39
	public readonly int Length; //Field offset: 0x3C

	public int Item
	{
		[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer+FindRenderersFromMaterialOrMeshJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FindUnsupportedRenderers_000000EB$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(ReadOnly<SmallIntegerArray>&), typeof(ReadOnly<Int32>&), typeof(NativeList`1<Int32>&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentDrawerBurst), Member = "FindUnsupportedRenderers$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(ReadOnly<SmallIntegerArray>&), typeof(ReadOnly<Int32>&), typeof(NativeList`1<Int32>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 233
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 251
	}

	public private bool Valid
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(UnsafeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public SmallIntegerArray(int length, Allocator allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer+FindRenderersFromMaterialOrMeshJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FindUnsupportedRenderers_000000EB$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(ReadOnly<SmallIntegerArray>&), typeof(ReadOnly<Int32>&), typeof(NativeList`1<Int32>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawerBurst), Member = "FindUnsupportedRenderers$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(ReadOnly<SmallIntegerArray>&), typeof(ReadOnly<Int32>&), typeof(NativeList`1<Int32>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public int get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_Valid() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_Item(int index, int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Valid(bool value) { }

}

