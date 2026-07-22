namespace SQLite;

internal class FastColumnSetter
{
	[CompilerGenerated]
	private sealed class <>c__0
	{
		public static readonly <>c__0<T> <>9; //Field offset: 0x0
		public static Func<IntPtr, Int32, Uri> <>9__0_19; //Field offset: 0x0
		public static Func<IntPtr, Int32, Guid> <>9__0_18; //Field offset: 0x0
		public static Func<IntPtr, Int32, Byte[]> <>9__0_17; //Field offset: 0x0
		public static Func<IntPtr, Int32, SByte> <>9__0_16; //Field offset: 0x0
		public static Func<IntPtr, Int32, Int16> <>9__0_15; //Field offset: 0x0
		public static Func<IntPtr, Int32, UInt16> <>9__0_14; //Field offset: 0x0
		public static Func<IntPtr, Int32, Byte> <>9__0_13; //Field offset: 0x0
		public static Func<IntPtr, Int32, Decimal> <>9__0_12; //Field offset: 0x0
		public static Func<IntPtr, Int32, UInt32> <>9__0_11; //Field offset: 0x0
		public static Func<IntPtr, Int32, Int64> <>9__0_10; //Field offset: 0x0
		public static Func<IntPtr, Int32, DateTimeOffset> <>9__0_9; //Field offset: 0x0
		public static Func<IntPtr, Int32, DateTime> <>9__0_7; //Field offset: 0x0
		public static Func<IntPtr, Int32, TimeSpan> <>9__0_6; //Field offset: 0x0
		public static Func<IntPtr, Int32, TimeSpan> <>9__0_5; //Field offset: 0x0
		public static Func<IntPtr, Int32, Single> <>9__0_4; //Field offset: 0x0
		public static Func<IntPtr, Int32, Double> <>9__0_3; //Field offset: 0x0
		public static Func<IntPtr, Int32, Boolean> <>9__0_2; //Field offset: 0x0
		public static Func<IntPtr, Int32, Int32> <>9__0_1; //Field offset: 0x0
		public static Func<IntPtr, Int32, String> <>9__0_0; //Field offset: 0x0
		public static Func<IntPtr, Int32, StringBuilder> <>9__0_20; //Field offset: 0x0
		public static Func<IntPtr, Int32, UriBuilder> <>9__0_21; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c__0`1() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[DeduplicatedMethod]
		internal string <GetFastSetter>b__0_0(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		internal int <GetFastSetter>b__0_1(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(long))]
		[DeduplicatedMethod]
		internal long <GetFastSetter>b__0_10(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(long))]
		[DeduplicatedMethod]
		internal uint <GetFastSetter>b__0_11(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(double))]
		[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(Decimal))]
		[DeduplicatedMethod]
		internal decimal <GetFastSetter>b__0_12(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		internal byte <GetFastSetter>b__0_13(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		internal ushort <GetFastSetter>b__0_14(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		internal short <GetFastSetter>b__0_15(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		internal sbyte <GetFastSetter>b__0_16(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Byte[]))]
		[DeduplicatedMethod]
		internal Byte[] <GetFastSetter>b__0_17(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal Guid <GetFastSetter>b__0_18(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal Uri <GetFastSetter>b__0_19(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <GetFastSetter>b__0_2(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal StringBuilder <GetFastSetter>b__0_20(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UriBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal UriBuilder <GetFastSetter>b__0_21(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(double))]
		[DeduplicatedMethod]
		internal double <GetFastSetter>b__0_3(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal float <GetFastSetter>b__0_4(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(long))]
		[DeduplicatedMethod]
		internal TimeSpan <GetFastSetter>b__0_5(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(TimeSpan), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TimeSpan), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
		[DeduplicatedMethod]
		internal TimeSpan <GetFastSetter>b__0_6(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal DateTime <GetFastSetter>b__0_7(IntPtr stmt, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal DateTimeOffset <GetFastSetter>b__0_9(IntPtr stmt, int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public SQLiteConnection conn; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass0_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal DateTime <GetFastSetter>b__8(IntPtr stmt, int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Func<IntPtr, Int32, ColumnMemberType> getColumnValue; //Field offset: 0x0
		public Action<ObjectType, Nullable`1<ColumnMemberType>> setProperty; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass1_0`2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(ColType))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <CreateNullableTypedSetterDelegate>b__0(ObjectType o, IntPtr stmt, int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Action<ObjectType, ColumnMemberType> setProperty; //Field offset: 0x0
		public Func<IntPtr, Int32, ColumnMemberType> getColumnValue; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass2_0`2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLite3), Member = "ColumnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(ColType))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <CreateTypedSetterDelegate>b__0(ObjectType o, IntPtr stmt, int i) { }

	}


	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FastColumnSetter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntrospectionExtensions), Member = "GetTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(FastColumnSetter), Member = "CreateTypedSetterDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ObjectType", "ColumnMemberType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), "System.Func`3<IntPtr, Int32, ColumnMemberType>"}, ReturnType = "System.Action`3<ObjectType, IntPtr, Int32>")]
	[Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(System.Action`3<System.Object, System.IntPtr, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private static Action<ObjectType, IntPtr, Int32> CreateNullableTypedSetterDelegate(Column column, Func<IntPtr, Int32, ColumnMemberType> getColumnValue) { }

	[CalledBy(Type = typeof(FastColumnSetter), Member = "CreateNullableTypedSetterDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ObjectType", "ColumnMemberType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), "System.Func`3<IntPtr, Int32, ColumnMemberType>"}, ReturnType = "System.Action`3<ObjectType, IntPtr, Int32>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(System.Action`3<System.Object, System.IntPtr, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private static Action<ObjectType, IntPtr, Int32> CreateTypedSetterDelegate(Column column, Func<IntPtr, Int32, ColumnMemberType> getColumnValue) { }

	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntrospectionExtensions), Member = "GetTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	internal static Action<T, IntPtr, Int32> GetFastSetter(SQLiteConnection conn, Column column) { }

}

