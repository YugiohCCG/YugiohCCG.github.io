namespace UnityEngine.Rendering;

[DebuggerDisplay("Size = {size} Capacity = {capacity}")]
public class DynamicString : DynamicArray<Char>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", ReturnType = typeof(void))]
	public DynamicString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	public DynamicString(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public DynamicString(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = "Reserve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Append(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Char>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.DynamicArray`1<System.Char>)}, ReturnType = typeof(void))]
	public void Append(DynamicString s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

