namespace System;

public class FormatException : SystemException
{

	[CalledBy(Type = "System.UriFormatException", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.CookieException", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public FormatException() { }

	[CallerCount(Count = 110)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public FormatException(string message) { }

	[CalledBy(Type = "System.Guid+GuidResult", Member = "GetGuidParseException", ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(Int64&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CustomAttributeFormatException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CustomAttributeFormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CustomAttributeFormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.BooleanConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.TimeSpanConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Net.IPAddressParser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Char>", typeof(bool)}, ReturnType = "System.Net.IPAddress")]
	[CalledBy(Type = "System.Net.CookieException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Numerics.BigNumber", Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Numerics.BigInteger", typeof(string), "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo), "System.Span`1<Char>", typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public FormatException(string message, Exception innerException) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected FormatException(SerializationInfo info, StreamingContext context) { }

}

