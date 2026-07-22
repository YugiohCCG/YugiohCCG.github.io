namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct VisibleReflectionProbe : IEquatable<VisibleReflectionProbe>
{
	private Bounds m_Bounds; //Field offset: 0x0
	private Matrix4x4 m_LocalToWorldMatrix; //Field offset: 0x18
	private Vector4 m_HdrData; //Field offset: 0x58
	private Vector3 m_Center; //Field offset: 0x68
	private float m_BlendDistance; //Field offset: 0x74
	private int m_Importance; //Field offset: 0x78
	private int m_BoxProjection; //Field offset: 0x7C
	private int m_InstanceId; //Field offset: 0x80
	private int m_TextureId; //Field offset: 0x84

	public float blendDistance
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 8
	}

	public Bounds bounds
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeMinMaxZJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "<PreSetup>g__IsProbeGreater|40_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleReflectionProbe), typeof(VisibleReflectionProbe)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		 get { } //Length: 20
	}

	public Vector4 hdrData
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 11
	}

	public int importance
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public bool isBoxProjection
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 75
	}

	public Matrix4x4 localToWorldMatrix
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 35
	}

	public ReflectionProbe reflectionProbe
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 125
	}

	public Texture texture
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 151
	}

	[CalledBy(Type = typeof(VisibleReflectionProbe), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(VisibleReflectionProbe other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleReflectionProbe)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public float get_blendDistance() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeMinMaxZJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "<PreSetup>g__IsProbeGreater|40_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleReflectionProbe), typeof(VisibleReflectionProbe)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	public Bounds get_bounds() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public Vector4 get_hdrData() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public int get_importance() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool get_isBoxProjection() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public Matrix4x4 get_localToWorldMatrix() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	[CallsUnknownMethods(Count = 1)]
	public ReflectionProbe get_reflectionProbe() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	[CallsUnknownMethods(Count = 1)]
	public Texture get_texture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

}

