namespace UnityEngine.Events;

internal class UnityEventTools
{

	[CalledBy(Type = typeof(ArgumentCache), Member = "OnBeforeSerialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArgumentCache), Member = "OnAfterDeserialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PersistentCall), Member = "get_targetAssemblyTypeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(PersistentCall), Member = "OnBeforeSerialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PersistentCall), Member = "OnAfterDeserialize", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string TidyAssemblyTypeName(string assemblyTypeName) { }

}

