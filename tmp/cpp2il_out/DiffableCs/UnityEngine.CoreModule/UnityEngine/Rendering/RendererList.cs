namespace UnityEngine.Rendering;

[MovedFrom("UnityEngine.Rendering.RendererUtils")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/RendererList.h")]
public struct RendererList
{
	public static readonly RendererList nullRendererList; //Field offset: 0x0
	internal UIntPtr context; //Field offset: 0x0
	internal uint index; //Field offset: 0x8
	internal uint frame; //Field offset: 0xC
	internal uint type; //Field offset: 0x10
	internal uint contextID; //Field offset: 0x14

	public bool isValid
	{
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "IsRendererListCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RendererListHandle&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRendererLists", Member = "DrawWithRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "DrawWithRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(RendererList&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(RendererList&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 51
	}

	[CallerCount(Count = 0)]
	private static RendererList() { }

	[CallerCount(Count = 0)]
	internal RendererList(UIntPtr ctx, uint indx) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "IsRendererListCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RendererListHandle&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRendererLists", Member = "DrawWithRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "DrawWithRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(RendererList&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(RendererList&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_isValid() { }

}

