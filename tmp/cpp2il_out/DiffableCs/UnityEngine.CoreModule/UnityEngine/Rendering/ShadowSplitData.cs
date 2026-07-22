namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct ShadowSplitData : IEquatable<ShadowSplitData>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_CullingPlanes>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	private const int k_MaximumCullingPlaneCount = 10; //Field offset: 0x0
	public static readonly int maximumCullingPlaneCount; //Field offset: 0x0
	private int m_CullingPlaneCount; //Field offset: 0x0
	[FixedBuffer(typeof(byte), 160)]
	internal <m_CullingPlanes>e__FixedBuffer m_CullingPlanes; //Field offset: 0x4
	private Vector4 m_CullingSphere; //Field offset: 0xA4
	private float m_ShadowCascadeBlendCullingFactor; //Field offset: 0xB4
	private float m_CullingNearPlane; //Field offset: 0xB8
	private Matrix4x4 m_CullingMatrix; //Field offset: 0xBC

	public int cullingPlaneCount
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Vector4 cullingSphere
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "UnityEngine.Rendering.Universal.UniversalShadowData", typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), "UnityEngine.Rendering.Universal.ShadowSliceData&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		 get { } //Length: 14
	}

	public float shadowCascadeBlendCullingFactor
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "UnityEngine.Rendering.Universal.UniversalShadowData", typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), "UnityEngine.Rendering.Universal.ShadowSliceData&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ShadowDrawingSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 267
	}

	[CallerCount(Count = 0)]
	private static ShadowSplitData() { }

	[CalledBy(Type = typeof(ShadowDrawingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShadowSplitData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ShadowSplitData), Member = "GetCullingPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Plane))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(ShadowSplitData other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowSplitData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowSplitData)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int get_cullingPlaneCount() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "UnityEngine.Rendering.Universal.UniversalShadowData", typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), "UnityEngine.Rendering.Universal.ShadowSliceData&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	public Vector4 get_cullingSphere() { }

	[CalledBy(Type = typeof(ShadowSplitData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowSplitData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Plane GetCullingPlane(int index) { }

	[CalledBy(Type = typeof(ShadowDrawingSettings), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "UnityEngine.Rendering.Universal.UniversalShadowData", typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), "UnityEngine.Rendering.Universal.ShadowSliceData&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShadowDrawingSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void set_shadowCascadeBlendCullingFactor(float value) { }

}

