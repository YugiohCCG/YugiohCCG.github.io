namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
[RequireComponent(typeof(Transform))]
public sealed class MeshFilter : Component
{

	public Mesh sharedMesh
	{
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetMeshFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "ClearMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<SubmeshInstruction>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "HandleRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "ClearState", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "LateUpdateMesh", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 177
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MeshFilter() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	private void DontStripMeshFilter() { }

	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetMeshFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "ClearMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<SubmeshInstruction>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "HandleRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "ClearState", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_sharedMesh(Mesh value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

}

