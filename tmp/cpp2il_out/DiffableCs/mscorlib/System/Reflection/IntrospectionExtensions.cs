namespace System.Reflection;

[Extension]
public static class IntrospectionExtensions
{

	[CalledBy(Type = "SQLite.Orm", Member = "InflateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomAttributeData)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.TableMapping+Column", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), "SQLite.CreateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.TableMapping+Column", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.TableMapping", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "SQLite.CreateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.EnumCacheInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.Orm", Member = "SqlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.TableMapping+Column", typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "SQLite.Orm", Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeInfo), typeof(string)}, ReturnType = typeof(FieldInfo))]
	[CalledBy(Type = "SQLite.Orm", Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeInfo), typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "SQLite.SQLite3+ColType", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter", Member = "GetFastSetter", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.SQLiteConnection", "SQLite.TableMapping+Column"}, ReturnType = "System.Action`3<T, IntPtr, Int32>")]
	[CalledBy(Type = "SQLite.FastColumnSetter", Member = "CreateNullableTypedSetterDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ObjectType", "ColumnMemberType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.TableMapping+Column", "System.Func`3<IntPtr, Int32, ColumnMemberType>"}, ReturnType = "System.Action`3<ObjectType, IntPtr, Int32>")]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "IsValidInstanceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "FindGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static TypeInfo GetTypeInfo(Type type) { }

}

