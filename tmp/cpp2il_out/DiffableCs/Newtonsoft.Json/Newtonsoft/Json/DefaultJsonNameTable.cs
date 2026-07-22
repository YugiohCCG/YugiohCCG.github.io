namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class DefaultJsonNameTable : JsonNameTable
{
	[Nullable(0)]
	private class Entry
	{
		internal readonly string Value; //Field offset: 0x10
		internal readonly int HashCode; //Field offset: 0x18
		internal Entry Next; //Field offset: 0x20

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal Entry(string value, int hashCode, Entry next) { }

	}

	private static readonly int HashCodeRandomizer; //Field offset: 0x0
	private int _count; //Field offset: 0x10
	private Entry[] _entries; //Field offset: 0x18
	private int _mask; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	private static DefaultJsonNameTable() { }

	[CalledBy(Type = typeof(CamelCasePropertyNamesContractResolver), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DefaultJsonNameTable() { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberSerialization)}, ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.JsonProperty>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultJsonNameTable), Member = "AddEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public string Add(string key) { }

	[CalledBy(Type = typeof(DefaultJsonNameTable), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private string AddEntry(string str, int hashCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 3)]
	public virtual string Get(Char[] key, int start, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	private void Grow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

