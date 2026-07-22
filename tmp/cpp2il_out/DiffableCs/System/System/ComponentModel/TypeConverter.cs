namespace System.ComponentModel;

[ComVisible(True)]
public class TypeConverter
{
	internal abstract class SimplePropertyDescriptor : PropertyDescriptor
	{
		private Type componentType; //Field offset: 0x88
		private Type propertyType; //Field offset: 0x90

		public virtual Type ComponentType
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AttributeCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 126
		}

		public virtual Type PropertyType
		{
			[CallerCount(Count = 57)]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType) { }

		[CalledBy(Type = "System.ComponentModel.ArrayConverter+ArrayPropertyDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ArrayConverter), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		public virtual bool CanResetValue(object component) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual Type get_ComponentType() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AttributeCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		public virtual Type get_PropertyType() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void ResetValue(object component) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool ShouldSerializeValue(object component) { }

	}

	[DefaultMember("Item")]
	internal class StandardValuesCollection : ICollection, IEnumerable
	{
		private ICollection values; //Field offset: 0x10
		private Array valueArray; //Field offset: 0x18

		public int Count
		{
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 101
		}

		public object Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
			[CallsUnknownMethods(Count = 6)]
			 get { } //Length: 250
		}

		private override int System.Collections.ICollection.Count
		{
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 101
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(Count = 182)]
			[DeduplicatedMethod]
			private get { } //Length: 3
		}

		[CalledBy(Type = typeof(BooleanConverter), Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
		[CalledBy(Type = typeof(CultureInfoConverter), Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
		[CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
		[CalledBy(Type = typeof(ReferenceConverter), Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
		[CalledBy(Type = typeof(TypeListConverter), Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
		[CalledBy(Type = typeof(EnumConverter), Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
		[CalledBy(Type = "System.Data.ColumnTypeConverter", Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public StandardValuesCollection(ICollection values) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public void CopyTo(Array array, int index) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public int get_Count() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 6)]
		public object get_Item(int index) { }

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public IEnumerator GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override int System.Collections.ICollection.get_Count() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior"; //Field offset: 0x0
	private static bool useCompatibleTypeConversion; //Field offset: 0x0

	private static bool UseCompatibleTypeConversion
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 65
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TypeConverter() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "System.Data.XMLSchema", Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttributeCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Xml.XmlAttribute[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool CanConvertFrom(Type sourceType) { }

	[CalledBy(Type = typeof(ReferenceConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseNumberConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BooleanConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CharConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CultureInfoConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GuidConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NullableConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StringConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeListConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EnumConverter), Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "TryConvertToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "CanTypeDescriptorConvertString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TypeConverter&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool CanConvertTo(Type destinationType) { }

	[CalledBy(Type = typeof(BaseNumberConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.RelationshipConverter", Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.PrimaryKeyTypeConverter", Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.ConstraintConverter", Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.ColumnTypeConverter", Member = "CanConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.ColumnTypeConverter", Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EnumConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NullableConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GuidConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CultureInfoConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeListConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	public object ConvertFrom(object value) { }

	[CalledBy(Type = typeof(UriTypeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.ColumnTypeConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(EnumConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TypeListConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TimeSpanConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(StringConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReferenceConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(GuidConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CharConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BooleanConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BaseNumberConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NullableConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(InstanceDescriptor), Member = "Invoke", ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeConverter), Member = "GetConvertFromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[CalledBy(Type = "System.Data.XMLSchema", Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttributeCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Xml.XmlAttribute[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	public object ConvertFromInvariantString(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public object ConvertFromString(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public object ConvertTo(object value, Type destinationType) { }

	[CalledBy(Type = typeof(BaseNumberConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.RelationshipConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.DefaultValueTypeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.ConstraintConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.ColumnTypeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DesignerOptionConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CollectionConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TypeListConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(EnumConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReferenceConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NullableConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MultilineStringConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(GuidConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CharConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TimeSpanConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeConverter), Member = "GetConvertToException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "TryConvertToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(TypeConverter), Member = "ConvertToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(string))]
	public string ConvertToInvariantString(object value) { }

	[CalledBy(Type = typeof(EnumConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(TypeConverter), Member = "ConvertToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(string))]
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	[CalledBy(Type = typeof(TypeConverter), Member = "ConvertToInvariantString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TypeConverter), Member = "ConvertToInvariantString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[CalledBy(Type = "System.ComponentModel.ReferenceConverter+ReferenceComparer", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "AddXdoProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object), typeof(XmlElement), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string ConvertToString(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public object CreateInstance(IDictionary propertyValues) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool get_UseCompatibleTypeConversion() { }

	[CalledBy(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	protected Exception GetConvertFromException(object value) { }

	[CalledBy(Type = typeof(TypeConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	protected Exception GetConvertToException(object value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetCreateInstanceSupported() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public PropertyDescriptorCollection GetProperties(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetPropertiesSupported() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ICollection GetStandardValues() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool GetStandardValuesExclusive() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetStandardValuesSupported() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsValid(object value) { }

	[CalledBy(Type = typeof(NullableConverter), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, String[] names) { }

}

