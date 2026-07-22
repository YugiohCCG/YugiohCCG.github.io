namespace UnityEngine.UIElements;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIPainter2D.bindings.h")]
internal static class UIPainter2D
{

	[CalledBy(Type = typeof(Painter2D), Member = "OnMeshGeneration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void ClearSnapshots(IntPtr handle) { }

	[CalledBy(Type = typeof(MeshGenerationContext), Member = "get_painter2D", ReturnType = typeof(Painter2D))]
	[CalledBy(Type = typeof(Painter2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static IntPtr Create(bool computeBBox = false) { }

	[CalledBy(Type = typeof(MeshGenerationContext), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void Destroy(IntPtr handle) { }

	[CalledBy(Type = "UnityEngine.UIElements.Painter2D+Painter2DJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static MeshWriteDataInterface ExecuteSnapshotFromJob(IntPtr painterHandle, int i) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ExecuteSnapshotFromJob_Injected(IntPtr painterHandle, int i, out MeshWriteDataInterface ret) { }

	[CalledBy(Type = typeof(MeshGenerationContext), Member = "get_painter2D", ReturnType = typeof(Painter2D))]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "End", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Painter2D), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static void Reset(IntPtr handle) { }

}

