namespace UnityEngine.Rendering.RenderGraphModule;

internal class TexturePool : RenderGraphResourcePool<RTHandle>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourcePool`1), Member = ".ctor", ReturnType = typeof(void))]
	public TexturePool() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual string GetResourceName(in RTHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Profiler), Member = "GetRuntimeMemorySizeLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual long GetResourceSize(in RTHandle res) { }

	[CallerCount(Count = 0)]
	protected virtual string GetResourceTypeName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandle), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual int GetSortIndex(RTHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void ReleaseInternalResource(RTHandle res) { }

}

