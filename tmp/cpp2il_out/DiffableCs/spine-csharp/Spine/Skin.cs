namespace Spine;

public class Skin
{
	internal struct SkinEntry
	{
		internal readonly int slotIndex; //Field offset: 0x0
		internal readonly string name; //Field offset: 0x8
		internal readonly Attachment attachment; //Field offset: 0x10

		public Attachment Attachment
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string Name
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public int SlotIndex
		{
			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public SkinEntry(int slotIndex, string name, Attachment attachment) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public Attachment get_Attachment() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public string get_Name() { }

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public int get_SlotIndex() { }

	}

	private struct SkinKey
	{
		internal readonly int slotIndex; //Field offset: 0x0
		internal readonly string name; //Field offset: 0x8
		internal readonly int hashCode; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		public SkinKey(int slotIndex, string name) { }

	}

	private class SkinKeyComparer : IEqualityComparer<SkinKey>
	{
		internal static readonly SkinKeyComparer Instance; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static SkinKeyComparer() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SkinKeyComparer() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		private override bool System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>.Equals(SkinKey e1, SkinKey e2) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private override int System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>.GetHashCode(SkinKey e) { }

	}

	internal string name; //Field offset: 0x10
	private Dictionary<SkinKey, SkinEntry> attachments; //Field offset: 0x18
	internal readonly ExposedList<BoneData> bones; //Field offset: 0x20
	internal readonly ExposedList<ConstraintData> constraints; //Field offset: 0x28

	public ICollection<SkinEntry> Attachments
	{
		[CalledBy(Type = typeof(Skeleton), Member = "SortPathConstraintAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), typeof(Bone)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), "UnityEngine.Shader", "UnityEngine.Material&", "UnityEngine.Texture2D&", typeof(int), typeof(int), "UnityEngine.TextureFormat", typeof(bool), "UnityEngine.Material", typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(Skin))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 68
	}

	public ExposedList<BoneData> Bones
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<ConstraintData> Constraints
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(bool), typeof(bool)}, ReturnType = typeof(Skin))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), "UnityEngine.Shader", "UnityEngine.Material&", "UnityEngine.Texture2D&", typeof(int), typeof(int), "UnityEngine.TextureFormat", typeof(bool), "UnityEngine.Material", typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(Skin))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.Skin+SkinKey, Spine.Skin+SkinEntry>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<Spine.Skin+SkinKey>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public Skin(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<Spine.Skin+SkinKey, Spine.Skin+SkinEntry>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skin), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(Attachment)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public void AddSkin(Skin skin) { }

	[CalledBy(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<Spine.Skin+SkinKey, Spine.Skin+SkinEntry>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal void AttachAll(Skeleton skeleton, Skin oldSkin) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<Spine.Skin+SkinKey, Spine.Skin+SkinEntry>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshAttachment), Member = "NewLinkedMesh", ReturnType = typeof(MeshAttachment))]
	[Calls(Type = typeof(Skin), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(Attachment)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	public void CopySkin(Skin skin) { }

	[CalledBy(Type = typeof(Skeleton), Member = "SortPathConstraintAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), typeof(Bone)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), "UnityEngine.Shader", "UnityEngine.Material&", "UnityEngine.Texture2D&", typeof(int), typeof(int), "UnityEngine.TextureFormat", typeof(bool), "UnityEngine.Material", typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(Skin))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ICollection<SkinEntry> get_Attachments() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ExposedList<BoneData> get_Bones() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public ExposedList<ConstraintData> get_Constraints() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CalledBy(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SpineAttachment", Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.Unity.SkeletonDataAsset"}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.SpineAttachment", Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonData)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(string), typeof(string), typeof(string), "UnityEngine.Transform", typeof(bool)}, ReturnType = "UnityEngine.PolygonCollider2D")]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skin), Member = "AttachAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Skin)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.Skin+SkinKey, Spine.Skin+SkinEntry>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkinKey), typeof(SkinEntry&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public Attachment GetAttachment(int slotIndex, string name) { }

	[CalledBy(Type = "Spine.Unity.BlendModeMaterials", Member = "ApplyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BlendModeMaterialsAsset", Member = "ApplyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData), "UnityEngine.Material", "UnityEngine.Material", "UnityEngine.Material", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<Spine.Skin+SkinKey, Spine.Skin+SkinEntry>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void GetAttachments(int slotIndex, List<SkinEntry> attachments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.Skin+SkinKey, Spine.Skin+SkinEntry>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkinKey)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public void RemoveAttachment(int slotIndex, string name) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(bool), typeof(bool)}, ReturnType = typeof(Skin))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(Skin), Member = "AddSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skin), Member = "CopySkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), "UnityEngine.Shader", "UnityEngine.Material&", "UnityEngine.Texture2D&", typeof(int), typeof(int), "UnityEngine.TextureFormat", typeof(bool), "UnityEngine.Material", typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(Skin))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.Skin+SkinKey, Spine.Skin+SkinEntry>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkinKey), typeof(SkinEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public void SetAttachment(int slotIndex, string name, Attachment attachment) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

