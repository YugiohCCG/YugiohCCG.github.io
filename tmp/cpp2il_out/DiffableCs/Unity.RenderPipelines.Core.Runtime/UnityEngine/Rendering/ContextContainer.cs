namespace UnityEngine.Rendering;

public class ContextContainer : IDisposable
{
	private struct Item
	{
		public ContextItem storage; //Field offset: 0x0
		public bool isSet; //Field offset: 0x8

	}

	private static class TypeId
	{
		public static uint value; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private static TypeId`1() { }

	}

	private static uint s_TypeCount; //Field offset: 0x0
	private Item[] m_Items; //Field offset: 0x10
	private List<UInt32> m_ActiveItemIndices; //Field offset: 0x18

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public ContextContainer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public bool Contains() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool Contains(uint typeId) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalCameraData")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateShadowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalShadowData")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreatePostProcessingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = "UnityEngine.Rendering.Universal.UniversalPostProcessingData")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateUniversalResourceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalResourceData")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", "Unity.Collections.NativeArray`1<VisibleLight>"}, ReturnType = "UnityEngine.Rendering.Universal.UniversalLightData")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ContextContainer), Member = "CreateAndGetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = "T")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public T Create() { }

	[CalledBy(Type = typeof(ContextContainer), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(ContextContainer), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private T CreateAndGetData(uint typeId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public override void Dispose() { }

	[CallerCount(Count = 352)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	public T Get() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "CreateAndGetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public T GetOrCreate() { }

}

