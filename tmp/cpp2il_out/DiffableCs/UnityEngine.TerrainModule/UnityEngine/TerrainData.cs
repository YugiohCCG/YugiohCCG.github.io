namespace UnityEngine;

[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[UsedByNativeCode]
public sealed class TerrainData : object
{
	private enum BoundaryValueType
	{
		MaxHeightmapRes = 0,
		MinDetailResPerPatch = 1,
		MaxDetailResPerPatch = 2,
		MaxDetailPatchCount = 3,
		MaxCoveragePerRes = 4,
		MinAlphamapRes = 5,
		MaxAlphamapRes = 6,
		MinBaseMapRes = 7,
		MaxBaseMapRes = 8,
	}

	internal static readonly int k_MaximumResolution; //Field offset: 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; //Field offset: 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; //Field offset: 0x8
	internal static readonly int k_MaximumDetailPatchCount; //Field offset: 0xC
	internal static readonly int k_MinimumAlphamapResolution; //Field offset: 0x10
	internal static readonly int k_MaximumAlphamapResolution; //Field offset: 0x14
	internal static readonly int k_MinimumBaseMapResolution; //Field offset: 0x18
	internal static readonly int k_MaximumBaseMapResolution; //Field offset: 0x1C

	public Vector3 size
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("GetHeightmap().GetSize")]
		 get { } //Length: 177
	}

	internal Terrain[] users
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 151
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	private static TerrainData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetHeightmap().GetSize")]
	public Vector3 get_size() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal Terrain[] get_users() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Terrain[] get_users_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	[RequiredByNativeCode]
	internal float GetAlphamapResolutionInternal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float GetAlphamapResolutionInternal_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType::DoubleColon (2))]
	[ThreadSafe]
	private static int GetBoundaryValue(BoundaryValueType type) { }

}

