namespace Unity.Hierarchy;

[IsReadOnly]
public struct HierarchyPropertyUnmanaged : IEquatable<HierarchyPropertyUnmanaged`1<T>>, IHierarchyProperty<T>
{
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0
	internal readonly HierarchyPropertyId m_Property; //Field offset: 0x0

	[CalledBy(Type = typeof(Hierarchy), Member = "GetOrCreatePropertyUnmanaged", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyStorageType)}, ReturnType = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyPropertyId), Member = "get_Null", ReturnType = typeof(HierarchyPropertyId&))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	internal HierarchyPropertyUnmanaged`1(Hierarchy hierarchy, in HierarchyPropertyId property) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public override bool Equals(HierarchyPropertyUnmanaged<T> other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "GetPropertyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyPropertyId&), typeof(HierarchyNode&), typeof(Int32&)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public T GetValue(in HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "SetPropertyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyPropertyId&), typeof(HierarchyNode&), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void SetValue(in HierarchyNode node, T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HierarchyPropertyId), Member = "ToString", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override T Unity.Hierarchy.IHierarchyProperty<T>.GetValue(in HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void Unity.Hierarchy.IHierarchyProperty<T>.SetValue(in HierarchyNode node, T value) { }

}

