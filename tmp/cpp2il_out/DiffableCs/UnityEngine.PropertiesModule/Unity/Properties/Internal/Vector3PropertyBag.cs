namespace Unity.Properties.Internal;

internal class Vector3PropertyBag : ContainerPropertyBag<Vector3>
{
	private class XProperty : Property<Vector3, Single>
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
		public virtual float GetValue(ref Vector3 container) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref Vector3 container, float value) { }

	}

	private class YProperty : Property<Vector3, Single>
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
		public virtual float GetValue(ref Vector3 container) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref Vector3 container, float value) { }

	}

	private class ZProperty : Property<Vector3, Single>
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
		public ZProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual float GetValue(ref Vector3 container) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref Vector3 container, float value) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	public Vector3PropertyBag() { }

}

