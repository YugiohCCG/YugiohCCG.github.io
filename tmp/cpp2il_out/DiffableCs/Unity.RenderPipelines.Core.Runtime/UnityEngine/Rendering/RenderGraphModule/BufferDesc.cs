namespace UnityEngine.Rendering.RenderGraphModule;

public struct BufferDesc
{
	public int count; //Field offset: 0x0
	public int stride; //Field offset: 0x4
	public string name; //Field offset: 0x8
	public Target target; //Field offset: 0x10
	public UsageFlags usageFlags; //Field offset: 0x14

	[CallerCount(Count = 0)]
	public BufferDesc(int count, int stride) { }

	[CalledBy(Type = typeof(RenderGraphResources), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraph), typeof(RenderGraphBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResources), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraph), typeof(RenderGraphBuilder)}, ReturnType = typeof(RenderGraphResources))]
	[CallerCount(Count = 7)]
	public BufferDesc(int count, int stride, Target target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashFNV1A32), Member = "Create", ReturnType = typeof(HashFNV1A32))]
	public virtual int GetHashCode() { }

}

