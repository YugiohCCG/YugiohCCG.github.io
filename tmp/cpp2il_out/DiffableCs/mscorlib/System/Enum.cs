namespace System;

[ComVisible(True)]
public abstract class Enum : IComparable, IFormattable, IConvertible
{
	private struct EnumResult
	{
		internal object parsedEnum; //Field offset: 0x0
		internal bool canThrow; //Field offset: 0x8
		internal ParseFailureKind m_failure; //Field offset: 0xC
		internal string m_failureMessageID; //Field offset: 0x10
		internal string m_failureParameter; //Field offset: 0x18
		internal object m_failureMessageFormatArgument; //Field offset: 0x20
		internal Exception m_innerException; //Field offset: 0x28

		[CalledBy(Type = typeof(EnumResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Enum+ParseFailureKind", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EnumResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Enum+ParseFailureKind", typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		internal Exception GetEnumParseException() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void Init(bool canMethodThrow) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void SetFailure(Exception unhandledException) { }

		[CalledBy(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(EnumResult), Member = "GetEnumParseException", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		internal void SetFailure(ParseFailureKind failure, string failureParameter) { }

		[CalledBy(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(EnumResult), Member = "GetEnumParseException", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 4)]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	}

	private enum ParseFailureKind
	{
		None = 0,
		Argument = 1,
		ArgumentNull = 2,
		ArgumentWithParameter = 3,
		UnhandledException = 4,
	}

	private class ValuesAndNames
	{
		public UInt64[] Values; //Field offset: 0x10
		public String[] Names; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ValuesAndNames(UInt64[] values, String[] names) { }

	}

	private static readonly Char[] enumSeperatorCharArray; //Field offset: 0x0
	private const string enumSeperator = ", "; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static Enum() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Enum() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public override int CompareTo(object target) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "System.Xml.Serialization.XmlReflectionImporter", Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Xml.Serialization.XmlReflectionMember", typeof(string)}, ReturnType = "System.Xml.Serialization.XmlTypeMapMember")]
	[CalledBy(Type = "System.Xml.Serialization.XmlReflectionImporter", Member = "GetDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Enum), Member = "InternalFlagsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Enum), Member = "InternalFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "InternalFormattedHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 63)]
	[ComVisible(True)]
	public static string Format(Type enumType, object value, string format) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private int get_hashcode() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private object get_value() { }

	[CalledBy(Type = typeof(Enum), Member = "InternalFlagsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enum), Member = "InternalGetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(UInt64[]))]
	[CalledBy(Type = typeof(Enum), Member = "InternalGetNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEnumNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEnumValues", ReturnType = typeof(Array))]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.UInt64>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.UInt64>))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(Object[]), typeof(System.Collections.Generic.IComparer`1<System.UInt64>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool GetEnumValuesAndNames(RuntimeType enumType, out UInt64[] values, out String[] names) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ScriptableRenderContext", "UnityEngine.Camera", "RequestData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ComVisible(True)]
	public static string GetName(Type enumType, object value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UxmlEnumAttributeDescription`1", Member = "GetEnumNameErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Serialization.XmlReflectionImporter", Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", "System.Xml.Serialization.XmlRootAttribute", typeof(string)}, ReturnType = "System.Xml.Serialization.XmlTypeMapping")]
	[CalledBy(Type = "UnityEngine.Rendering.SerializableEnum", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TProfilingSampler`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Shader", "UnityEngine.Shader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MaterialQualityUtilities", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.CameraTypeUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "InitializeValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StructMultiKey`2<Type, NamingStrategy>"}, ReturnType = "Newtonsoft.Json.Utilities.EnumInfo")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ComVisible(True)]
	public static String[] GetNames(Type enumType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 9)]
	public override TypeCode GetTypeCode() { }

	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Unity.Properties.TypeConversion", Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "Newtonsoft.Json.Serialization.NamingStrategy", typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "GetFlagsValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.IList`1<T>")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Boolean&)}, ReturnType = "Newtonsoft.Json.Utilities.PrimitiveTypeCode")]
	[CalledBy(Type = "UnityEngine.EnumDataUtility", Member = "GetCachedEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "UnityEngine.EnumDataUtility+CachedType", "System.Func`2<String, String>"}, ReturnType = "UnityEngine.EnumData")]
	[CalledBy(Type = "System.Xml.Serialization.TypeTranslator", Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = "System.Xml.Serialization.TypeData")]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationWriterInterpreter", Member = "MemberHasValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.XmlTypeMapMember", typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CalledBy(Type = typeof(Delegate), Member = "return_type_match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Delegate), Member = "arg_type_match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "TryConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enum), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EnumEqualityComparer`1), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ComVisible(True)]
	public static Type GetUnderlyingType(Type enumType) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal object GetValue() { }

	[CallerCount(Count = 44)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ComVisible(True)]
	public static Array GetValues(Type enumType) { }

	[CalledBy(Type = "Scenes.General.MultiPick+<>c", Member = "<.cctor>b__45_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.General.MultiPick+<CreateCheckbox>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick", Member = "ValidateExtraRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.ExtraRules&", "Enumerator.DuelRules"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick", Member = "SetCheckboxesForValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General+<GetUniqueFlags>d__19`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Extensions.General", Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public bool HasFlag(Enum flag) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int InternalCompareTo(object o1, object o2) { }

	[CalledBy(Type = typeof(Enum), Member = "InternalFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Enum), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Enum), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = typeof(ValuesAndNames))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	[CalledBy(Type = typeof(Enum), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "InternalFlagsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private static string InternalFormat(RuntimeType eT, object value) { }

	[CalledBy(Type = typeof(Enum), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Enum), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Convert), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeCode))]
	[ContainsInvalidInstructions]
	private static string InternalFormattedHexString(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = typeof(ValuesAndNames))]
	[CallsUnknownMethods(Count = 1)]
	internal static String[] InternalGetNames(RuntimeType enumType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = typeof(ValuesAndNames))]
	[CallsUnknownMethods(Count = 1)]
	internal static UInt64[] InternalGetValues(RuntimeType enumType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool InternalHasFlag(Enum flags) { }

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ComVisible(True)]
	public static bool IsDefined(Type enumType, object value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "UnityEngine.Event", Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.Event")]
	[CalledBy(Type = "Spine.SkeletonJson", Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<String, Object>", "Spine.Skin", typeof(int), typeof(string), "Spine.SkeletonData"}, ReturnType = "Spine.Attachment")]
	[CalledBy(Type = "Spine.SkeletonJson", Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = "Spine.SkeletonData")]
	[CalledBy(Type = "Spine.Atlas+<>c__DisplayClass10_0", Member = "<.ctor>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Atlas+<>c__DisplayClass10_0", Member = "<.ctor>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.PDF417.PDF417EncodingOptions", Member = "get_ErrorCorrection", ReturnType = "ZXing.PDF417.Internal.PDF417ErrorCorrectionLevel")]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlReflectionImporter", Member = "ImportElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(string), typeof(Type), "System.Xml.Serialization.XmlTypeMapMemberElement", "System.Xml.Serialization.XmlAttributes"}, ReturnType = "System.Xml.Serialization.XmlTypeMapElementInfoList")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionMap+ReadActionJson", Member = "ToAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputAction")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"}, ReturnType = "UnityEngine.UIElements.StyleSheets.Syntax.Expression")]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlEnumAttributeDescription`1", Member = "ConvertValueToEnum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "U"}, ReturnType = "U")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "SetCustomErrorsMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "SQLite.SQLite3+ColType", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "GetEnumValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.XmlTypeMapping", typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(EnumResult), Member = "GetEnumParseException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ComVisible(True)]
	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext"}, ReturnType = "System.ComponentModel.TypeConverter+StandardValuesCollection")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+EnumField`1", Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeConversion", Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EnumResult), Member = "GetEnumParseException", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	[ComVisible(True)]
	public static object Parse(Type enumType, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallsUnknownMethods(Count = 1)]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallsUnknownMethods(Count = 1)]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallsUnknownMethods(Count = 1)]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallsUnknownMethods(Count = 1)]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallsUnknownMethods(Count = 1)]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallsUnknownMethods(Count = 1)]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CalledBy(Type = "Scenes.General.MultiPick+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick", Member = "GetCurrentValue", ReturnType = typeof(Enum))]
	[CalledBy(Type = "Scenes.General.MultiPick", Member = "OnLeave", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEnumValues", ReturnType = typeof(Array))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "Newtonsoft.Json.Serialization.NamingStrategy", typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[CLSCompliant(False)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, ulong value) { }

	[CalledBy(Type = "SQLite.TableMapping+Column", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "SetMemberValueFromAttr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.XmlTypeMapMember", typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_DefaultValue", ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "Newtonsoft.Json.Serialization.NamingStrategy", typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "EnsureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(object), typeof(CultureInfo), "Newtonsoft.Json.Serialization.JsonContract", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.CastToEnumInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ScriptingRuntimeHelpers", Member = "GetPrimitiveDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Unity.Properties.TypeConversion", Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Convert), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeCode))]
	[ComVisible(True)]
	[ContainsInvalidInstructions]
	public static object ToObject(Type enumType, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private static object ToObject(Type enumType, char value) { }

	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private static object ToObject(Type enumType, bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[CLSCompliant(False)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, sbyte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, short value) { }

	[CalledBy(Type = "UnityEngine.UIElements.EnumFieldHelpers", Member = "ExtractValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IUxmlAttributes", "UnityEngine.UIElements.CreationContext", typeof(Type&), typeof(Enum&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerBitField", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[CLSCompliant(False)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, ushort value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[CLSCompliant(False)]
	[ComVisible(True)]
	public static object ToObject(Type enumType, uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Obsolete("The provider argument is not used. Please use ToString(String).")]
	public override string ToString(string format, IFormatProvider provider) { }

	[CallerCount(Count = 263)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "InternalFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(Enum), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.TraceLevel", typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.StringEnumConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "InternalFlagsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "InternalFormattedHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public string ToString(string format) { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Obsolete("The provider argument is not used. Please use ToString().")]
	public override string ToString(IFormatProvider provider) { }

	[CalledBy(Type = typeof(Type), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Type), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Enum), Member = "InternalFlagsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Convert), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static ulong ToUInt64(object value) { }

	[CalledBy(Type = "UnityEngine.UIElements.EnumFieldHelpers", Member = "ExtractValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IUxmlAttributes", "UnityEngine.UIElements.CreationContext", typeof(Type&), typeof(Enum&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryParse(Type enumType, string value, bool ignoreCase, out object result) { }

	[CalledBy(Type = "UnityEngine.Rendering.SerializableEnum", Member = "get_value", ReturnType = typeof(Enum))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryParse(Type enumType, string value, out object result) { }

	[CalledBy(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enum), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enum), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EnumResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ulong)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(EnumResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = typeof(ValuesAndNames))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref EnumResult parseResult) { }

}

