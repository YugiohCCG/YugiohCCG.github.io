namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

internal struct ResourceVersionedData
{
	public bool written; //Field offset: 0x0
	public int writePassId; //Field offset: 0x4
	public int numReaders; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void RegisterReadingPass(CompilerContextData ctx, ResourceHandle h, int passId, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 5)]
	public void RemoveReadingPass(CompilerContextData ctx, ResourceHandle h, int passId) { }

	[CallerCount(Count = 0)]
	public void SetWritingPass(CompilerContextData ctx, ResourceHandle h, int passId) { }

}

