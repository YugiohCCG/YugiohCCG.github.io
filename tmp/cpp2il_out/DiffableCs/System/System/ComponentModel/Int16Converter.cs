namespace System.ComponentModel;

public class Int16Converter : BaseNumberConverter
{

	internal virtual Type TargetType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		internal get { } //Length: 50
	}

	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Int16Converter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(short))]
	internal virtual object FromString(string value, int radix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	internal virtual Type get_TargetType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(short), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

