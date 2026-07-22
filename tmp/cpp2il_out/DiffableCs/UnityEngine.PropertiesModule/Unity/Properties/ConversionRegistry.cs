namespace Unity.Properties;

[IsReadOnly]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct ConversionRegistry : IEqualityComparer<ConversionRegistry>
{
	[IsReadOnly]
	private struct ConverterKey
	{
		public readonly Type SourceType; //Field offset: 0x0
		public readonly Type DestinationType; //Field offset: 0x8

		[CallerCount(Count = 68)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ConverterKey(Type source, Type destination) { }

	}

	private class ConverterKeyComparer : IEqualityComparer<ConverterKey>
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ConverterKeyComparer() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		public override bool Equals(ConverterKey x, ConverterKey y) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int GetHashCode(ConverterKey obj) { }

	}

	private static readonly ConverterKeyComparer Comparer; //Field offset: 0x0
	private readonly Dictionary<ConverterKey, Delegate> m_Converters; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static ConversionRegistry() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private ConversionRegistry(Dictionary<ConverterKey, Delegate> storage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Properties.ConversionRegistry+ConverterKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<Unity.Properties.ConversionRegistry+ConverterKey>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static ConversionRegistry Create() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(ConversionRegistry x, ConversionRegistry y) { }

	[CalledBy(Type = typeof(ConversionRegistry), Member = "TryGetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Delegate&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Properties.ConversionRegistry+ConverterKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public Delegate GetConverter(Type source, Type destination) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int GetHashCode(ConversionRegistry obj) { }

	[CalledBy(Type = typeof(TypeConversion), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Properties.ConversionRegistry+ConverterKey, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConverterKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void Register(Type source, Type destination, Delegate converter) { }

	[CalledBy(Type = typeof(TypeConversion), Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeConversion), Member = "TryConvertToUnityEngineObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConversionRegistry), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool TryGetConverter(Type source, Type destination, out Delegate converter) { }

}

