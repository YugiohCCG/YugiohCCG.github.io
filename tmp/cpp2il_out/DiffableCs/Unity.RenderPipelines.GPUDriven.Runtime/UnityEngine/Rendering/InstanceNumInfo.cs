namespace UnityEngine.Rendering;

internal struct InstanceNumInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <InstanceNums>e__FixedBuffer
	{
		public int FixedElementField; //Field offset: 0x0

	}

	[FixedBuffer(typeof(int), 2)]
	public <InstanceNums>e__FixedBuffer InstanceNums; //Field offset: 0x0

	[CallerCount(Count = 0)]
	public InstanceNumInfo(InstanceType type, int instanceNum) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public InstanceNumInfo(int meshRendererNum = 0, int speedTreeNum = 0) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int GetInstanceNum(InstanceType type) { }

	[CalledBy(Type = typeof(GPUInstanceDataBufferBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceNumInfo&)}, ReturnType = typeof(GPUInstanceDataBuffer))]
	[CalledBy(Type = typeof(InstanceNumInfo), Member = "GetInstanceNumIncludingChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceNumInfo), Member = "GetInstanceNumIncludingChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public int GetInstanceNumIncludingChildren(InstanceType type) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public int GetTotalInstanceNum() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void InitDefault() { }

}

