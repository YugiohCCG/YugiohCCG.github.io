namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("TextureResource ({desc.name})")]
internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle>
{
	private static int m_TextureCreationIndex; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TextureResource() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleFunc), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void CreateGraphicsResource() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureDesc), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetDescHashCode() { }

	[CallerCount(Count = 0)]
	public virtual string GetName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void LogCreation(RenderGraphLogger logger) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void LogRelease(RenderGraphLogger logger) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	public virtual void ReleaseGraphicsResource() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void UpdateGraphicsResource() { }

}

