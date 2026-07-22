namespace UnityEngine.Rendering.Universal;

[BurstCompile(FloatMode = FloatMode::Default (0), DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct TilingJob : IJobFor
{
	[CompilerGenerated]
	private struct <>c__DisplayClass19_0
	{
		public VisibleLight light; //Field offset: 0x0
		public float3 lightPositionVS; //Field offset: 0x74
		public float3 lightDirectionVS; //Field offset: 0x80
		public float cosHalfAngle; //Field offset: 0x8C
		public float coneHeight; //Field offset: 0x90

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass20_0
	{
		public VisibleLight light; //Field offset: 0x0
		public float3 lightPosVS; //Field offset: 0x74
		public float3 lightDirVS; //Field offset: 0x80
		public float cosHalfAngle; //Field offset: 0x8C

	}

	private static readonly float3[] k_CubePoints; //Field offset: 0x0
	private static readonly int4[] k_CubeLineIndices; //Field offset: 0x8
	[ReadOnly]
	public NativeArray<VisibleLight> lights; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<VisibleReflectionProbe> reflectionProbes; //Field offset: 0x10
	[NativeDisableParallelForRestriction]
	public NativeArray<InclusiveRange> tileRanges; //Field offset: 0x20
	public int itemsPerTile; //Field offset: 0x30
	public int rangesPerItem; //Field offset: 0x34
	public Fixed2<float4x4> worldToViews; //Field offset: 0x38
	public float2 tileScale; //Field offset: 0xB8
	public float2 tileScaleInv; //Field offset: 0xC0
	public Fixed2<Single> viewPlaneBottoms; //Field offset: 0xC8
	public Fixed2<Single> viewPlaneTops; //Field offset: 0xD0
	public Fixed2<float4> viewToViewportScaleBiases; //Field offset: 0xD8
	public int2 tileCount; //Field offset: 0xF8
	public float near; //Field offset: 0x100
	public bool isOrthographic; //Field offset: 0x104
	private InclusiveRange m_TileYRange; //Field offset: 0x106
	private int m_Offset; //Field offset: 0x10C
	private int m_ViewIndex; //Field offset: 0x110
	private float2 m_CenterOffset; //Field offset: 0x114

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static TilingJob() { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static bool <TileLight>g__ConicPointIsValid|19_1(float3 p, ref <>c__DisplayClass19_0 unnamed_param_1) { }

	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool <TileLight>g__SpherePointIsValid|19_0(float3 p, ref <>c__DisplayClass19_0 unnamed_param_1) { }

	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool <TileLightOrthographic>g__SpherePointIsValid|20_0(float3 p, ref <>c__DisplayClass20_0 unnamed_param_1) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static float3 EvaluateNearConic(float near, float3 o, float3 d, float r, float3 u, float3 v, float theta) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TilingJob), Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TilingJob), Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public override void Execute(int jobIndex) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(TilingJob), Member = "ViewToTileSpaceOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(InclusiveRange), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void ExpandOrthographic(float3 positionVS) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TilingJob), Member = "ViewToTileSpaceOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(InclusiveRange), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void ExpandRangeOrthographic(ref InclusiveRange range, float xVS) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(TilingJob), Member = "ViewToTileSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(InclusiveRange), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void ExpandY(float3 positionVS) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(math), Member = "atan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	private static float2 FindNearConicTangentTheta(float2 o, float2 d, float r, float2 u, float2 v) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(math), Member = "atan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[CallsDeduplicatedMethods(Count = 50)]
	[CallsUnknownMethods(Count = 1)]
	private static float2 FindNearConicYTheta(float near, float3 o, float3 d, float r, float3 u, float3 v, float y) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool GetCircleClipPoints(float3 circleCenter, float3 circleNormal, float circleRadius, float near, out float3 p0, out float3 p1) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static void GetConeSideTangentPoints(float3 vertex, float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, float3 circleU, float3 circleV, out float3 l1, out float3 l2) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TilingJob), Member = "IntersectEllipseLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float3)}, ReturnType = typeof(System.ValueTuple`2<System.Single, System.Single>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetProjectedCircleHorizon(float2 center, float radius, float2 U, float2 V, out float2 uv1, out float2 uv2) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static void GetSphereHorizon(float2 center, float radius, float near, float clipRadius, out float2 p0, out float2 p1) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static void GetSphereYPlaneHorizon(float3 center, float sphereRadius, float near, float clipRadius, float y, out float3 left, out float3 right) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IntersectCircleYPlane(float y, float3 circleCenter, float3 circleNormal, float3 circleU, float3 circleV, float circleRadius, out float3 p1, out float3 p2) { }

	[CalledBy(Type = typeof(TilingJob), Member = "GetProjectedCircleHorizon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float), typeof(float2), typeof(float2), typeof(float2&), typeof(float2&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private static ValueTuple<Single, Single> IntersectEllipseLine(float a, float b, float3 line) { }

	[CallerCount(Count = 101)]
	[DeduplicatedMethod]
	private static float square(float x) { }

	[CalledBy(Type = typeof(TilingJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TilingJob), Member = "<TileLight>g__ConicPointIsValid|19_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(<>c__DisplayClass19_0&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(InclusiveRange), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InclusiveRange), typeof(InclusiveRange)}, ReturnType = typeof(InclusiveRange))]
	[Calls(Type = typeof(TilingJob), Member = "FindNearConicYTheta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float3), typeof(float3), typeof(float), typeof(float3), typeof(float3), typeof(float)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(TilingJob), Member = "IntersectCircleYPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float3), typeof(float3), typeof(float3), typeof(float3), typeof(float), typeof(float3&), typeof(float3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InclusiveRange), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(math), Member = "clamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TilingJob), Member = "ViewToTileSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(InclusiveRange), Member = "Clamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TilingJob), Member = "GetConeSideTangentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float3), typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TilingJob), Member = "EvaluateNearConic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float3), typeof(float3), typeof(float), typeof(float3), typeof(float3), typeof(float)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(TilingJob), Member = "FindNearConicTangentTheta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2), typeof(float), typeof(float2), typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(TilingJob), Member = "GetCircleClipPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3), typeof(float), typeof(float), typeof(float3&), typeof(float3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TilingJob), Member = "GetProjectedCircleHorizon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float), typeof(float2), typeof(float2), typeof(float2&), typeof(float2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TilingJob), Member = "GetSphereHorizon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float), typeof(float), typeof(float), typeof(float2&), typeof(float2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_range", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisibleLight), Member = "get_spotAngle", ReturnType = typeof(float))]
	[Calls(Type = typeof(TilingJob), Member = "ExpandY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(TilingJob), Member = "GetSphereYPlaneHorizon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void TileLight(int lightIndex) { }

	[CalledBy(Type = typeof(TilingJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(TilingJob), Member = "ExpandOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_spotAngle", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisibleLight), Member = "get_range", ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(TilingJob), Member = "ExpandRangeOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InclusiveRange&), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InclusiveRange), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InclusiveRange), typeof(InclusiveRange)}, ReturnType = typeof(InclusiveRange))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private void TileLightOrthographic(int lightIndex) { }

	[CalledBy(Type = typeof(TilingJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TilingJob), Member = "ExpandY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(TilingJob), Member = "ViewToTileSpaceOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(TilingJob), Member = "ViewToTileSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(InclusiveRange), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InclusiveRange), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InclusiveRange), typeof(InclusiveRange)}, ReturnType = typeof(InclusiveRange))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void TileReflectionProbe(int index) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "ExpandY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	private float2 ViewToTileSpace(float3 positionVS) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "ExpandOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "ExpandRangeOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InclusiveRange&), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	private float2 ViewToTileSpaceOrthographic(float3 positionVS) { }

}

