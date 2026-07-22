namespace UnityEngine;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainCallbacks
{
	internal sealed class HeightmapChangedCallback : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public HeightmapChangedCallback(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }

	}

	internal sealed class TextureChangedCallback : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public TextureChangedCallback(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public override void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static HeightmapChangedCallback heightmapChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static TextureChangedCallback textureChanged; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[RequiredByNativeCode]
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[RequiredByNativeCode]
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }

}

