namespace UnityEngine.Rendering.Universal;

internal class DecalEntityIndexer
{
	internal struct DecalEntityItem
	{
		public int chunkIndex; //Field offset: 0x0
		public int arrayIndex; //Field offset: 0x4
		public int version; //Field offset: 0x8

	}

	private List<DecalEntityItem> m_Entities; //Field offset: 0x10
	private Queue<Int32> m_FreeIndices; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public DecalEntityIndexer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Int32>), Member = "Dequeue", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Int32>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyDecalEntity(DecalEntity decalEntity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public DecalEntityItem GetItem(DecalEntity decalEntity) { }

	[CalledBy(Type = typeof(DecalEntityManager), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecalEntityManager), Member = "UpdateAllDecalEntitiesData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalEntityManager), Member = "DestroyDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsValid(DecalEntity decalEntity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RemapChunkIndices(List<Int32> remaper) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateIndex(DecalEntity decalEntity, int newArrayIndex) { }

}

