namespace UnityEngine;

[NativeClass("RenderingLayerMask", "struct RenderingLayerMask;")]
[NativeHeader("Runtime/Graphics/RenderingLayerMask.h")]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct RenderingLayerMask
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly RenderingLayerMask <defaultRenderingLayerMask>k__BackingField; //Field offset: 0x0
	internal const int maxRenderingLayerSize = 32; //Field offset: 0x0
	[NativeName("m_Bits")]
	private uint m_Bits; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static RenderingLayerMask() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+RenderingLayerField", Member = "Resize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+RenderingLayerField", Member = "get_renderingLayersNames", ReturnType = "System.String[]")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+RenderingLayerField", Member = "get_children", ReturnType = "UnityEngine.Rendering.ObservableList`1<Widget>")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+RenderingLayerField", Member = "GenerateQueryPath", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static int GetDefinedRenderingLayerCount() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_renderingLayerMaskNames", ReturnType = "System.String[]")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static String[] GetDefinedRenderingLayerNames() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingLayerUtils", Member = "ToValidRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static uint GetDefinedRenderingLayersCombinedMaskValue() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+RenderingLayerField", Member = "get_maxRenderingLayerCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+RenderingLayerField", Member = "Resize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingLayerUtils", Member = "RequireRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<ScriptableRendererFeature>", "UnityEngine.Rendering.Universal.RenderingMode", typeof(bool), typeof(int), "Event&", "MaskSize&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static int GetRenderingLayerCount() { }

	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	public static uint op_Implicit(RenderingLayerMask mask) { }

	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	public static RenderingLayerMask op_Implicit(uint intVal) { }

	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	public static int op_Implicit(RenderingLayerMask mask) { }

	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	public static RenderingLayerMask op_Implicit(int intVal) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+RenderingLayerField", Member = "Resize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("RenderingLayerToString")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static string RenderingLayerToName(int layer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RenderingLayerToName_Injected(int layer, out ManagedSpanWrapper ret) { }

}

