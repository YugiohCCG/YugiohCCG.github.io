namespace Unity.Properties.Internal;

internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int>
{
	private class XProperty : Property<Vector2Int, Int32>
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
		public XProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual int GetValue(ref Vector2Int container) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref Vector2Int container, int value) { }

	}

	private class YProperty : Property<Vector2Int, Int32>
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
		public YProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual int GetValue(ref Vector2Int container) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref Vector2Int container, int value) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public Vector2IntPropertyBag() { }

}

