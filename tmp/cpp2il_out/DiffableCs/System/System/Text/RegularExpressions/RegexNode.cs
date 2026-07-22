namespace System.Text.RegularExpressions;

internal sealed class RegexNode
{
	public int NType; //Field offset: 0x10
	public List<RegexNode> Children; //Field offset: 0x18
	public string Str; //Field offset: 0x20
	public char Ch; //Field offset: 0x28
	public int M; //Field offset: 0x2C
	public int N; //Field offset: 0x30
	public readonly RegexOptions Options; //Field offset: 0x34
	public RegexNode Next; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RegexNode(int type, RegexOptions options) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RegexNode(int type, RegexOptions options, char ch) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RegexNode(int type, RegexOptions options, string str) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RegexNode(int type, RegexOptions options, int m) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RegexNode(int type, RegexOptions options, int m, int n) { }

	[CalledBy(Type = typeof(RegexNode), Member = "MakeQuantifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanReplacement", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddConcatenate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "PopGroup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddAlternate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddConcatenate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddConcatenate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddGroup", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void AddChild(RegexNode newChild) { }

	[CalledBy(Type = typeof(RegexFCD), Member = "Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexPrefix))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RegexNode Child(int i) { }

	[CalledBy(Type = typeof(RegexFCD), Member = "Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexPrefix))]
	[CallerCount(Count = 2)]
	public int ChildCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	[CallerCount(Count = 0)]
	private void MakeRep(int type, int min, int max) { }

	[CalledBy(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexNode), Member = "ReduceConcatenation", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexNode), Member = "ReduceRep", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsSingleton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsSingletonInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "SingletonChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private RegexNode Reduce() { }

	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsMergeable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RegexCharClass))]
	[Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexCharClass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexNode), Member = "StripEnation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RegexNode))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private RegexNode ReduceAlternation() { }

	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexNode), Member = "StripEnation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RegexNode))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private RegexNode ReduceConcatenation() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private RegexNode ReduceGroup() { }

	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private RegexNode ReduceRep() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexCharClass), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsSingleton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsSingletonInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "SingletonChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 3)]
	private RegexNode ReduceSet() { }

	[CalledBy(Type = typeof(RegexParser), Member = "AddAlternate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddGroup", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public RegexNode ReverseLeft() { }

	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceConcatenation", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private RegexNode StripEnation(int emptyType) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int Type() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool UseOptionR() { }

}

