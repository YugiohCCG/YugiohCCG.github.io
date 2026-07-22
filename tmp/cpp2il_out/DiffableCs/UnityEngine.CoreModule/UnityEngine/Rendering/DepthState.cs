namespace UnityEngine.Rendering;

public struct DepthState : IEquatable<DepthState>
{
	private byte m_WriteEnabled; //Field offset: 0x0
	private sbyte m_CompareFunction; //Field offset: 0x1

	public CompareFunction compareFunction
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 7
	}

	public static DepthState defaultValue
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 81
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetDetphState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CompareFunction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetDepthState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CompareFunction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DepthState(bool writeEnabled = true, CompareFunction compareFunction = 2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(DepthState other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public CompareFunction get_compareFunction() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DepthState get_defaultValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(sbyte), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

}

