namespace UnityEngine.UIElements.UIR;

internal class MeshHandle : LinkedPoolItem<MeshHandle>
{
	internal Alloc allocVerts; //Field offset: 0x18
	internal Alloc allocIndices; //Field offset: 0x30
	internal uint triangleCount; //Field offset: 0x48
	internal Page allocPage; //Field offset: 0x50
	internal uint allocTime; //Field offset: 0x58
	internal uint updateAllocID; //Field offset: 0x5C

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice+<>c", Member = "<.ctor>b__58_0", ReturnType = typeof(MeshHandle))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MeshHandle() { }

}

