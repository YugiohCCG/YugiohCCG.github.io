namespace UnityEngine.Rendering;

public struct Observable
{
	[CompilerGenerated]
	private Action<T> onValueChanged; //Field offset: 0x0
	private T m_Value; //Field offset: 0x0

	public event Action<T> onValueChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 282
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 282
	}

	public T value
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 192
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 25)]
		[DeduplicatedMethod]
		 set { } //Length: 876
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public Observable`1(T newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void add_onValueChanged(Action<T> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public T get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void remove_onValueChanged(Action<T> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	[DeduplicatedMethod]
	public void set_value(T value) { }

}

