namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

internal struct Name
{
	public readonly string name; //Field offset: 0x0
	public readonly int utf8ByteCount; //Field offset: 0x8

	[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public Name(string name, bool computeUTF8ByteCount = false) { }

}

