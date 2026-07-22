namespace System.ComponentModel;

internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
{
	private class ReflectedTypeData
	{
		private Type _type; //Field offset: 0x10
		private AttributeCollection _attributes; //Field offset: 0x18
		private EventDescriptorCollection _events; //Field offset: 0x20
		private PropertyDescriptorCollection _properties; //Field offset: 0x28
		private TypeConverter _converter; //Field offset: 0x30
		private Object[] _editors; //Field offset: 0x38
		private Type[] _editorTypes; //Field offset: 0x40
		private int _editorCount; //Field offset: 0x48

		internal bool IsPopulated
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal get { } //Length: 35
		}

		[CallerCount(Count = 98)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ReflectedTypeData(Type type) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool get_IsPopulated() { }

		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute[]))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "get_Attributes", ReturnType = typeof(TypeAttributes))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(AttributeCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(OrderedDictionary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(OrderedDictionary), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(OrderedDictionary), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(OrderedDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
		[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		internal AttributeCollection GetAttributes() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string GetClassName(object instance) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		internal string GetComponentName(object instance) { }

		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(TypeConverter))]
		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(ReflectedTypeData), Member = "GetTypeFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "get_IntrinsicTypeConverters", ReturnType = typeof(Hashtable))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "SearchIntrinsicTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(Type)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 11)]
		internal TypeConverter GetConverter(object instance) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptorCollection))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(EventDescriptorCollection))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal EventDescriptor GetDefaultEvent(object instance) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptorCollection))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptorCollection))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal PropertyDescriptor GetDefaultProperty(object instance) { }

		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(ReflectedTypeData), Member = "GetEditorAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttributeCollection), typeof(Type)}, ReturnType = typeof(EditorAttribute))]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(ReflectedTypeData), Member = "GetTypeFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEditorTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Hashtable))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "SearchIntrinsicTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 22)]
		internal object GetEditor(object instance, Type editorBaseType) { }

		[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 12)]
		private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType) { }

		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptorCollection))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptor[]))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ValueCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 5)]
		internal EventDescriptorCollection GetEvents() { }

		[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptorCollection))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptor[]))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ValueCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 6)]
		internal PropertyDescriptorCollection GetProperties() { }

		[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
		[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private Type GetTypeFromName(string typeName) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		internal void Refresh() { }

	}

	private static Type[] _typeConstructor; //Field offset: 0x0
	private static Hashtable _editorTables; //Field offset: 0x8
	private static Hashtable _intrinsicTypeConverters; //Field offset: 0x10
	private static object _intrinsicReferenceKey; //Field offset: 0x18
	private static object _intrinsicNullableKey; //Field offset: 0x20
	private static object _dictionaryKey; //Field offset: 0x28
	private static Hashtable _propertyCache; //Field offset: 0x30
	private static Hashtable _eventCache; //Field offset: 0x38
	private static Hashtable _attributeCache; //Field offset: 0x40
	private static Hashtable _extendedPropertyCache; //Field offset: 0x48
	private static readonly Guid _extenderProviderKey; //Field offset: 0x50
	private static readonly Guid _extenderPropertiesKey; //Field offset: 0x60
	private static readonly Guid _extenderProviderPropertiesKey; //Field offset: 0x70
	private static readonly Type[] _skipInterfaceAttributeList; //Field offset: 0x80
	private static object _internalSyncObject; //Field offset: 0x88
	private Hashtable _typeData; //Field offset: 0x20

	private static Hashtable IntrinsicTypeConverters
	{
		[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 26)]
		[CallsUnknownMethods(Count = 5)]
		private get { } //Length: 2241
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	private static ReflectTypeDescriptionProvider() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal ReflectTypeDescriptionProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[]), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[]), typeof(Object[]), typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 9)]
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "SearchIntrinsicTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[]), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 6)]
	private static object CreateInstance(Type objectType, Type callingType) { }

	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 5)]
	private static Hashtable get_IntrinsicTypeConverters() { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CallsUnknownMethods(Count = 1)]
	internal AttributeCollection GetAttributes(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public virtual IDictionary GetCache(object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetClassName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string GetClassName(Type type) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetComponentName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[CallsUnknownMethods(Count = 6)]
	internal string GetComponentName(Type type, object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CallsUnknownMethods(Count = 1)]
	internal TypeConverter GetConverter(Type type, object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent", ReturnType = typeof(EventDescriptor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AttributeCollection))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptorCollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(EventDescriptorCollection))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal EventDescriptor GetDefaultEvent(Type type, object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty", ReturnType = typeof(PropertyDescriptor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AttributeCollection))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal object GetEditor(Type type, object instance, Type editorBaseType) { }

	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "RunClassConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(EventDescriptorCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetEvents", ReturnType = typeof(EventDescriptorCollection))]
	[CallsUnknownMethods(Count = 1)]
	internal EventDescriptorCollection GetEvents(Type type) { }

	[CallerCount(Count = 0)]
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetClassName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string GetExtendedClassName(object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetComponentName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[CallsUnknownMethods(Count = 6)]
	internal string GetExtendedComponentName(object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CallsUnknownMethods(Count = 1)]
	internal TypeConverter GetExtendedConverter(object instance) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal EventDescriptor GetExtendedDefaultEvent(object instance) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal object GetExtendedEditor(object instance, Type editorBaseType) { }

	[CallerCount(Count = 0)]
	internal EventDescriptorCollection GetExtendedEvents(object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider)}, ReturnType = typeof(PropertyDescriptor[]))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAssociation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtenders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(IExtenderProvider[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	protected private virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtenderProviders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IExtenderProvider[]))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 35)]
	[ContainsUnimplementedInstructions]
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[Calls(Type = typeof(ReflectedTypeData), Member = "GetProperties", ReturnType = typeof(PropertyDescriptorCollection))]
	[CallsUnknownMethods(Count = 1)]
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	[CalledBy(Type = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAssociation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "IsPopulated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedComponentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedClassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(EventDescriptor))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetComponentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetClassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptorCollection))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider)}, ReturnType = typeof(PropertyDescriptor[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Type GetTypeFromName(string typeName) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[ContainsUnimplementedInstructions]
	internal bool IsPopulated(Type type) { }

	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private static Attribute[] ReflectGetAttributes(Type type) { }

	[CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillEventInfoAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillSingleMethodAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetEvents", ReturnType = typeof(EventDescriptorCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventInfo), Member = "GetAddMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(EventInfo), Member = "GetRemoveMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ReflectEventDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(EventInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 31)]
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExtendedPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReflectPropertyDescriptor), typeof(Type), typeof(IExtenderProvider), typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type), typeof(Type), typeof(MethodInfo), typeof(MethodInfo), typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 62)]
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetProperties", ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyInfo), Member = "GetGetMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type), typeof(PropertyInfo), typeof(MethodInfo), typeof(MethodInfo), typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 28)]
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ReflectedTypeData))]
	[CallsUnknownMethods(Count = 6)]
	internal void Refresh(Type type) { }

	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = typeof(ReflectedTypeData), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 21)]
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

}

