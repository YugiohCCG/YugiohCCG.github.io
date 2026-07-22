namespace System;

[DefaultMember("Item")]
[IsReadOnly]
internal struct ParamsArray
{
	private static readonly Object[] s_oneArgArray; //Field offset: 0x0
	private static readonly Object[] s_twoArgArray; //Field offset: 0x8
	private static readonly Object[] s_threeArgArray; //Field offset: 0x10
	private readonly object _arg0; //Field offset: 0x0
	private readonly object _arg1; //Field offset: 0x8
	private readonly object _arg2; //Field offset: 0x10
	private readonly Object[] _args; //Field offset: 0x18

	public object Item
	{
		[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 164
	}

	public int Length
	{
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static ParamsArray() { }

	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public ParamsArray(object arg0) { }

	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public ParamsArray(object arg0, object arg1) { }

	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public ParamsArray(object arg0, object arg1, object arg2) { }

	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public ParamsArray(Object[] args) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public object get_Item(int index) { }

	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private object GetAtSlow(int index) { }

}

