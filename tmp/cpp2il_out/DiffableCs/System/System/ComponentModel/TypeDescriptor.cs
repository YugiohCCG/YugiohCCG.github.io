namespace System.ComponentModel;

public sealed class TypeDescriptor
{
	private sealed class AttributeFilterCacheItem
	{
		private Attribute[] _filter; //Field offset: 0x10
		internal ICollection FilteredMembers; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal bool IsValid(Attribute[] filter) { }

	}

	private sealed class FilterCacheItem
	{
		private ITypeDescriptorFilterService _filterService; //Field offset: 0x10
		internal ICollection FilteredMembers; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool IsValid(ITypeDescriptorFilterService filterService) { }

	}

	private interface IUnimplemented
	{

	}

	private sealed class MemberDescriptorComparer : IComparer
	{
		public static readonly MemberDescriptorComparer Instance; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static MemberDescriptorComparer() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public MemberDescriptorComparer() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public override int Compare(object left, object right) { }

	}

	private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
	{
		private ICustomTypeDescriptor _primary; //Field offset: 0x10
		private ICustomTypeDescriptor _secondary; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	}

	private sealed class TypeDescriptionNode : TypeDescriptionProvider
	{
		private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
		{
			private TypeDescriptionNode _node; //Field offset: 0x0
			private object _instance; //Field offset: 0x8

			[CallerCount(Count = 68)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal DefaultExtendedTypeDescriptor(TypeDescriptionNode node, object instance) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedClassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 19)]
			private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedComponentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 19)]
			private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 19)]
			private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 19)]
			private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
			[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 23)]
			private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptorCollection))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptorCollection))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedPropertyOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(object))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 19)]
			private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

		}

		private struct DefaultTypeDescriptor : ICustomTypeDescriptor
		{
			private TypeDescriptionNode _node; //Field offset: 0x0
			private Type _objectType; //Field offset: 0x8
			private object _instance; //Field offset: 0x10

			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			internal DefaultTypeDescriptor(TypeDescriptionNode node, Type objectType, object instance) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetClassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 19)]
			private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetComponentName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 19)]
			private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(TypeConverter))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(EventDescriptor))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 19)]
			private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 19)]
			private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
			[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 23)]
			private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptorCollection))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptorCollection))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptorCollection))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptorCollection))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 36)]
			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetPropertyOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(object))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 19)]
			private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

		}

		internal TypeDescriptionNode Next; //Field offset: 0x20
		internal TypeDescriptionProvider Provider; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal TypeDescriptionNode(TypeDescriptionProvider provider) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 13)]
		public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public virtual IDictionary GetCache(object instance) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		protected private virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public virtual Type GetReflectionType(Type objectType, object instance) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	}

	[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	private sealed class TypeDescriptorComObject
	{

	}

	private sealed class TypeDescriptorInterface
	{

	}

	private static WeakHashtable _providerTable; //Field offset: 0x0
	private static Hashtable _providerTypeTable; //Field offset: 0x8
	private static Hashtable _defaultProviders; //Field offset: 0x10
	private static WeakHashtable _associationTable; //Field offset: 0x18
	private static int _metadataVersion; //Field offset: 0x20
	private static int _collisionIndex; //Field offset: 0x24
	private static BooleanSwitch TraceDescriptor; //Field offset: 0x28
	private static readonly Guid[] _pipelineInitializeKeys; //Field offset: 0x30
	private static readonly Guid[] _pipelineMergeKeys; //Field offset: 0x38
	private static readonly Guid[] _pipelineFilterKeys; //Field offset: 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; //Field offset: 0x48
	private static object _internalSyncObject; //Field offset: 0x50
	[CompilerGenerated]
	private static RefreshEventHandler Refreshed; //Field offset: 0x58

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static Type ComObjectType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static Type InterfaceType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	internal static int MetadataVersion
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BooleanSwitch), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private static TypeDescriptor() { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDescriptionProvider), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	private static void CheckDefaultProvider(Type type) { }

	[CalledBy(Type = typeof(PropertyDescriptor), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(Attribute[]), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeDescriptor), Member = "ShouldHideMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberDescriptor), typeof(Attribute)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public static Type get_ComObjectType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public static Type get_InterfaceType() { }

	[CallerCount(Count = 0)]
	internal static int get_MetadataVersion() { }

	[CalledBy(Type = typeof(PropertyDescriptor), Member = "GetInvocationTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MemberDescriptor), Member = "GetInvocationTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedPropertyOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetPropertyOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(PropertyDescriptor)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 24)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static object GetAssociation(Type type, object primary) { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(EventDescriptor))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(EventDescriptor))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider)}, ReturnType = typeof(PropertyDescriptor[]))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static AttributeCollection GetAttributes(Type componentType) { }

	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(EventDescriptor))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(EventDescriptor))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	public static AttributeCollection GetAttributes(object component) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtenderProviders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IExtenderProvider[]))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IExtenderProvider)}, ReturnType = typeof(PropertyDescriptor[]))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static IDictionary GetCache(object instance) { }

	[CalledBy(Type = typeof(NullableConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptor), Member = "get_Converter", ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "TryConvertToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "CanTypeDescriptorConvertString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TypeConverter&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.XMLSchema", Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CallsUnknownMethods(Count = 2)]
	public static TypeConverter GetConverter(Type type) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(TypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(EventDescriptor))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(EventDescriptor))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(EventDescriptor))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(EventDescriptor))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(EventDescriptorCollection))]
	public static EventDescriptorCollection GetEvents(object component) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(EventDescriptorCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(Attribute[]), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static Type GetNodeForBaseType(Type searchType) { }

	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = "System.Data.XMLSchema", Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttributeCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Xml.XmlAttribute[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "SetExtProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Xml.XmlAttribute[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "SetExtProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttributeCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "AddXdoProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlElement), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(PropertyDescriptor))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	[CalledBy(Type = typeof(ExpandableObjectConverter), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(ComponentConverter), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(DesignerOptionCollection), Member = "get_Properties", ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(Attribute[]), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IServiceProvider), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetExtendedTypeDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetExtenderProviders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IExtenderProvider[]))]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetReflectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[CalledBy(Type = typeof(AttributeCollection), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = typeof(EnumConverter), Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static Type GetReflectionType(Type type) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private static TypeDescriptionNode NodeFor(Type type) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDescriptionProvider), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IServiceProvider), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetProviderRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeDescriptionProvider))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetNodeForBaseType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 11)]
	private static TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeDescriptionNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsCOMObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	private static TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	private static TypeDescriptionNode NodeFor(object instance) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "FilterMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(Attribute[])}, ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetExtenderCollisionSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberDescriptor)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 102)]
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool)}, ReturnType = typeof(EventDescriptorCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 47)]
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RefreshEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void RaiseRefresh(Type type) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDescriptionProvider), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "IsPopulated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RefreshEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	public static void Refresh(Type type) { }

	[CalledBy(Type = typeof(TypeDescriptor), Member = "FilterMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(Attribute[])}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "InternalSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDescriptorCollection), Member = "InternalSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IComparer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "InternalSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "InternalSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IComparer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArrayList), Member = "Adapter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void SortDescriptorArray(IList infos) { }

}

