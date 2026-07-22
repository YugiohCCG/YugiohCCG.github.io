namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RendererList ({handle})")]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public struct RendererListHandle
{
	internal RendererListHandleType type; //Field offset: 0x0
	private bool m_IsValid; //Field offset: 0x4
	[CompilerGenerated]
	private int <handle>k__BackingField; //Field offset: 0x8

	internal int handle
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 4
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	internal RendererListHandle(int handle, RendererListHandleType type = 0) { }

	[CallerCount(Count = 28)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal int get_handle() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsValid() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public static int op_Implicit(RendererListHandle handle) { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListResource>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RendererListResource&))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RendererListLegacyResource&))]
	[CallsUnknownMethods(Count = 1)]
	public static RendererList op_Implicit(RendererListHandle rendererList) { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_handle(int value) { }

}

