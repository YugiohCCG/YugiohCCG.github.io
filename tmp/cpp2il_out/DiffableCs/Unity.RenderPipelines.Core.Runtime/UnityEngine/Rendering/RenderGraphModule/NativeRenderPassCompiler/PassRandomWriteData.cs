namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("PassRandomWriteData: Res({resource.index}):{index}:{preserveCounterValue}")]
internal struct PassRandomWriteData
{
	public ResourceHandle resource; //Field offset: 0x0
	public int index; //Field offset: 0xC
	public bool preserveCounterValue; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

}

