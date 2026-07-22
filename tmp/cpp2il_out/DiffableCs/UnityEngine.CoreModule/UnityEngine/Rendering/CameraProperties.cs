namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct CameraProperties : IEquatable<CameraProperties>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <layerCullDistances>e__FixedBuffer
	{
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_CameraCullPlanes>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_ShadowCullPlanes>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	private const int k_NumLayers = 32; //Field offset: 0x0
	private const int k_PlaneCount = 6; //Field offset: 0x0
	private Rect screenRect; //Field offset: 0x0
	private Vector3 viewDir; //Field offset: 0x10
	private float projectionNear; //Field offset: 0x1C
	private float projectionFar; //Field offset: 0x20
	private float cameraNear; //Field offset: 0x24
	private float cameraFar; //Field offset: 0x28
	private float cameraAspect; //Field offset: 0x2C
	private Matrix4x4 cameraToWorld; //Field offset: 0x30
	private Matrix4x4 actualWorldToClip; //Field offset: 0x70
	private Matrix4x4 cameraClipToWorld; //Field offset: 0xB0
	private Matrix4x4 cameraWorldToClip; //Field offset: 0xF0
	private Matrix4x4 implicitProjection; //Field offset: 0x130
	private Matrix4x4 stereoWorldToClipLeft; //Field offset: 0x170
	private Matrix4x4 stereoWorldToClipRight; //Field offset: 0x1B0
	private Matrix4x4 worldToCamera; //Field offset: 0x1F0
	private Vector3 up; //Field offset: 0x230
	private Vector3 right; //Field offset: 0x23C
	private Vector3 transformDirection; //Field offset: 0x248
	private Vector3 cameraEuler; //Field offset: 0x254
	private Vector3 velocity; //Field offset: 0x260
	private float farPlaneWorldSpaceLength; //Field offset: 0x26C
	private uint rendererCount; //Field offset: 0x270
	[FixedBuffer(typeof(byte), 96)]
	internal <m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes; //Field offset: 0x274
	[FixedBuffer(typeof(byte), 96)]
	internal <m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes; //Field offset: 0x2D4
	private float baseFarDistance; //Field offset: 0x334
	private Vector3 shadowCullCenter; //Field offset: 0x338
	[FixedBuffer(typeof(float), 32)]
	internal <layerCullDistances>e__FixedBuffer layerCullDistances; //Field offset: 0x344
	private int layerCullSpherical; //Field offset: 0x3C4
	private CoreCameraValues coreCameraValues; //Field offset: 0x3C8
	private uint cameraType; //Field offset: 0x3D4
	private int projectionIsOblique; //Field offset: 0x3D8
	private int isImplicitProjectionMatrix; //Field offset: 0x3DC
	internal bool useInteractiveLightBakingData; //Field offset: 0x3E0

	[CalledBy(Type = typeof(CameraProperties), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScriptableCullingParameters), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraProperties), Member = "GetShadowCullingPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(CameraProperties), Member = "GetCameraCullingPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(Rect), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(CameraProperties other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraProperties), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraProperties)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(CameraProperties), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraProperties)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CameraProperties), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Plane GetCameraCullingPlane(int index) { }

	[CalledBy(Type = typeof(ScriptableCullingParameters), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rect), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CameraProperties), Member = "GetShadowCullingPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CameraProperties), Member = "GetCameraCullingPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Plane))]
	[CallsUnknownMethods(Count = 8)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(CameraProperties), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraProperties)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CameraProperties), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Plane GetShadowCullingPlane(int index) { }

}

