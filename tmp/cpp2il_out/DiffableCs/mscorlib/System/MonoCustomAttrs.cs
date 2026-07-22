namespace System;

internal static class MonoCustomAttrs
{
	private class AttributeInfo
	{
		private AttributeUsageAttribute _usage; //Field offset: 0x10
		private int _inheritanceLevel; //Field offset: 0x18

		public int InheritanceLevel
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public AttributeUsageAttribute Usage
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel) { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public int get_InheritanceLevel() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public AttributeUsageAttribute get_Usage() { }

	}

	[ThreadStatic]
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; //Field offset: 0x80000000
	private static Assembly corlib; //Field offset: 0x0
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributeUsageAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttributeTargets)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static MonoCustomAttrs() { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetBaseMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetBaseMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetBaseMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Type[])}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(PropertyInfo))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 7)]
	private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property) { }

	[CalledBy(Type = typeof(Attribute), Member = "InternalGetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeModule), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsageNoCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(Attribute), Member = "InternalGetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CustomAttributeFormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 48)]
	internal static Object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	[CalledBy(Type = typeof(RuntimeAssembly), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeModule), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static Object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static Object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CustomAttributeFormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Array), Member = "AsReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesDataBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 77)]
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	[CalledBy(Type = typeof(CustomAttributeData), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "GetCustomAttributesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Module)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetCustomAttributesData", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetCustomAttributesData", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetCustomAttributesData", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "GetCustomAttributesData", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetCustomAttributesData", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesDataBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = false) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "AsReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_Attributes", ReturnType = typeof(TypeAttributes))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static Object[] GetPseudoCustomAttributes(Type type) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal static Object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesDataBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[Calls(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[Calls(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_Attributes", ReturnType = typeof(TypeAttributes))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(CustomAttributeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static CustomAttributeData[] GetPseudoCustomAttributesData(Type type) { }

	[CalledBy(Type = typeof(Attribute), Member = "InternalIsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeModule), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Attribute), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Attribute), Member = "InternalIsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesDataBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static bool IsUserCattrProvider(object obj) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsageNoCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsageNoCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeUsageAttribute))]
	[Calls(Type = typeof(AttributeUsageAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttributeTargets)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

}

