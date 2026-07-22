namespace System.ComponentModel;

public class PropertyChangingEventArgs : EventArgs
{
	private readonly string _propertyName; //Field offset: 0x10

	[CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "OnPropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PropertyChangingEventArgs(string propertyName) { }

}

