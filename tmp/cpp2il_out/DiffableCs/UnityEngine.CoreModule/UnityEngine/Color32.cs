namespace UnityEngine;

[DefaultMember("Item")]
[UsedByNativeCode]
public struct Color32 : IEquatable<Color32>, IFormattable
{
	[Ignore(DoesNotContributeToSize = True)]
	private int rgba; //Field offset: 0x0
	public byte r; //Field offset: 0x0
	public byte g; //Field offset: 0x1
	public byte b; //Field offset: 0x2
	public byte a; //Field offset: 0x3

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Color32(byte r, byte g, byte b, byte a) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Color32 other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 116)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static Color32 op_Implicit(Color c) { }

	[CallerCount(Count = 0)]
	public static Color op_Implicit(Color32 c) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

