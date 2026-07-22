namespace Unity.Properties.Internal;

internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt>
{
	private class PositionProperty : Property<BoundsInt, Vector3Int>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public PositionProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual Vector3Int GetValue(ref BoundsInt container) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref BoundsInt container, Vector3Int value) { }

	}

	private class SizeProperty : Property<BoundsInt, Vector3Int>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public SizeProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual Vector3Int GetValue(ref BoundsInt container) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref BoundsInt container, Vector3Int value) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public BoundsIntPropertyBag() { }

}

