namespace Unity.Properties.Internal;

internal class SystemVersionPropertyBag : ContainerPropertyBag<Version>
{
	private class BuildProperty : Property<Version, Int32>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MinAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public BuildProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetValue(ref Version container) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref Version container, int value) { }

	}

	private class MajorProperty : Property<Version, Int32>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MinAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public MajorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetValue(ref Version container) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref Version container, int value) { }

	}

	private class MinorProperty : Property<Version, Int32>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MinAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public MinorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetValue(ref Version container) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref Version container, int value) { }

	}

	private class RevisionProperty : Property<Version, Int32>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MinAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public RevisionProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetValue(ref Version container) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref Version container, int value) { }

	}


	[CalledBy(Type = typeof(PropertiesInitialization), Member = "InitializeProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MinAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	public SystemVersionPropertyBag() { }

}

