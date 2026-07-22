namespace UnityEngine.UIElements.UIR;

internal static class Shaders
{
	public static readonly string k_AtlasBlit; //Field offset: 0x0
	public static readonly string k_Editor; //Field offset: 0x8
	public static readonly string k_Runtime; //Field offset: 0x10
	public static readonly string k_RuntimeWorld; //Field offset: 0x18
	public static readonly string k_ColorConversionBlit; //Field offset: 0x20
	public static readonly string k_ForceGammaKeyword; //Field offset: 0x28
	private static Material s_RuntimeMaterial; //Field offset: 0x30
	private static Material s_RuntimeWorldMaterial; //Field offset: 0x38
	private static Material s_EditorMaterial; //Field offset: 0x40
	private static int s_RefCount; //Field offset: 0x48

	public static Material editorMaterial
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
		 get { } //Length: 87
	}

	public static Material runtimeMaterial
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
		 get { } //Length: 87
	}

	public static Material runtimeWorldMaterial
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
		 get { } //Length: 87
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private static Shaders() { }

	[CallerCount(Count = 0)]
	public static void Acquire() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
	public static Material get_editorMaterial() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
	public static Material get_runtimeMaterial() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
	public static Material get_runtimeWorldMaterial() { }

	[CalledBy(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel), typeof(UIRenderDevice), typeof(AtlasBase), typeof(VectorImageManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shaders), Member = "get_runtimeMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(Shaders), Member = "get_runtimeWorldMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(Shaders), Member = "get_editorMaterial", ReturnType = typeof(Material))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Material GetOrCreateMaterial(ref Material material, string shaderName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void Release() { }

}

