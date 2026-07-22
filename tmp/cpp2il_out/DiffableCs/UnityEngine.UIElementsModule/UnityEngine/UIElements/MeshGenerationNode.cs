namespace UnityEngine.UIElements;

[NativeContainer]
public struct MeshGenerationNode
{
	private UnsafeMeshGenerationNode m_UnsafeNode; //Field offset: 0x0

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal static void Create(GCHandle handle, out MeshGenerationNode node) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal Entry GetParentEntry() { }

}

