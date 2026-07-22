namespace System.ComponentModel;

public class PropertyChangedEventArgs : EventArgs
{
	private readonly string _propertyName; //Field offset: 0x10

	[CalledBy(Type = typeof(EventArgsCache), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "OnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataColumn", Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRelation", Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRelation", Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataRowView", Member = "RaisePropertyChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TryDeleteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PropertyChangedEventArgs(string propertyName) { }

}

