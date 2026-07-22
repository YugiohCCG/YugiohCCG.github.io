namespace UnityEngine.UIElements;

[IsReadOnly]
public struct BindablePropertyChangedEventArgs
{
	private readonly BindingId m_PropertyName; //Field offset: 0x0

	public BindingId propertyName
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 96
	}

	[CalledBy(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public BindablePropertyChangedEventArgs(in BindingId propertyName) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BindingId get_propertyName() { }

}

