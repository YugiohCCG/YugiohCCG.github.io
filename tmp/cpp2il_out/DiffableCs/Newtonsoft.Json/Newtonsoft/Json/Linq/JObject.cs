namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JObject : JContainer, IDictionary<String, JToken>, ICollection<KeyValuePair`2<String, JToken>>, IEnumerable<KeyValuePair`2<String, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
{
	[CompilerGenerated]
	private struct <<WriteToAsync>g__AwaitProperties|0_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JObject <>4__this; //Field offset: 0x28
		public int i; //Field offset: 0x30
		[Nullable(0)]
		public JsonWriter Writer; //Field offset: 0x38
		public CancellationToken CancellationToken; //Field offset: 0x40
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public JsonConverter[] Converters; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<JProperty, JToken> <>9__31_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(0)]
		internal JToken <PropertyValues>b__31_0(JProperty p) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__64 : IEnumerator<KeyValuePair`2<String, JToken>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		private KeyValuePair<String, JToken> <>2__current; //Field offset: 0x18
		[Nullable(0)]
		public JObject <>4__this; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x30

		private override KeyValuePair<String, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			private get { } //Length: 69
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetEnumerator>d__64(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override KeyValuePair<String, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CalledBy(Type = typeof(ValidationEventArgs), Member = "get_Path", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<JObject> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JsonLoadSettings settings; //Field offset: 0x30
		[Nullable(0)]
		private JObject <o>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "MoveToContentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JContainer), Member = "ReadTokenFromAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 29)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	private class JObjectDynamicProxy : DynamicProxy<JObject>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			[Nullable(0)]
			public static readonly <>c <>9; //Field offset: 0x0
			[Nullable(0)]
			public static Func<JProperty, String> <>9__2_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[NullableContext(0)]
			internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }

		}


		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public JObjectDynamicProxy() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual IEnumerable<String> GetDynamicMemberNames(JObject instance) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JToken))]
		[CallsUnknownMethods(Count = 2)]
		public virtual bool TryGetMember(JObject instance, GetMemberBinder binder, out object result) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public virtual bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	}

	private readonly JPropertyKeyedCollection _properties; //Field offset: 0x58
	[CompilerGenerated]
	[Nullable(2)]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x60
	[CompilerGenerated]
	[Nullable(2)]
	private PropertyChangingEventHandler PropertyChanging; //Field offset: 0x68

	[Nullable(2)]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[NullableContext(2)]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[NullableContext(2)]
		 remove { } //Length: 146
	}

	[Nullable(2)]
	public override event PropertyChangingEventHandler PropertyChanging
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[NullableContext(2)]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[NullableContext(2)]
		 remove { } //Length: 146
	}

	protected virtual IList<JToken> ChildrenTokens
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public virtual JToken Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(MiscellaneousUtils), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[ContainsInvalidInstructions]
		 get { } //Length: 244
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(MiscellaneousUtils), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 260
	}

	[Nullable(2)]
	public override JToken Item
	{
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object), typeof(Object&), typeof(String&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JObjectDynamicProxy), Member = "TryGetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject), typeof(GetMemberBinder), typeof(Object&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JPropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 127
		[CalledBy(Type = typeof(JObjectDynamicProxy), Member = "TrySetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject), typeof(SetMemberBinder), typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JToken)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
		[Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
		[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 293
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 84
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	private override ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 62
	}

	public virtual JTokenType Type
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer+<ReadContentFromAsync>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<LoadAsync>d__2), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JObject))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public JObject(JObject other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal JObject(JObject other, JsonCloneSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public JObject(Object[] content) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public JObject(object content) { }

	[AsyncStateMachine(typeof(<<WriteToAsync>g__AwaitProperties|0_0>d))]
	[CalledBy(Type = typeof(JObject), Member = "WriteToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(CancellationToken), typeof(JsonConverter[])}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<WriteToAsync>g__AwaitProperties|0_0>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<WriteToAsync>g__AwaitProperties|0_0>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CompilerGenerated]
	private Task <WriteToAsync>g__AwaitProperties|0_0(Task task, int i, JsonWriter Writer, CancellationToken CancellationToken, JsonConverter[] Converters) { }

	[CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Add(string propertyName, JToken value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[NullableContext(2)]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[NullableContext(2)]
	public override void add_PropertyChanging(PropertyChangingEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override bool ContainsKey(string propertyName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JPropertyKeyedCollection)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool DeepEquals(JToken node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(JToken))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static JObject FromObject(object o, JsonSerializer jsonSerializer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(JToken))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static JObject FromObject(object o) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	protected virtual IList<JToken> get_ChildrenTokens() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	public virtual JToken get_Item(object key) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object), typeof(Object&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JObjectDynamicProxy), Member = "TryGetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject), typeof(GetMemberBinder), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JPropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[CallsUnknownMethods(Count = 1)]
	public override JToken get_Item(string propertyName) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual JTokenType get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "ContentsHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	internal virtual int GetDeepHashCode() { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessSchemaProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<GetEnumerator>d__64))]
	public override IEnumerator<KeyValuePair`2<String, JToken>> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicProxyMetaObject`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "T", "Newtonsoft.Json.Utilities.DynamicProxy`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public JToken GetValue(string propertyName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public JToken GetValue(string propertyName, StringComparison comparison) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionUtils), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "T"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(IList), typeof(IList), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal void InternalPropertyChanged(JProperty childProperty) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void InternalPropertyChanging(JProperty childProperty) { }

	[CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsNull(JToken token) { }

	[CalledBy(Type = typeof(JObject), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JObject))]
	[CalledBy(Type = typeof(JObject), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonLoadSettings)}, ReturnType = typeof(JObject))]
	[CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "MoveToContent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "ReadTokenFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JObject))]
	public static JObject Load(JsonReader reader) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__2))]
	[CalledBy(Type = typeof(JObject), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Newtonsoft.Json.Linq.JObject>))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken+<ReadFromAsync>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadAsync>d__2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadAsync>d__2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Newtonsoft.Json.Linq.JObject>))]
	public static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[Calls(Type = typeof(JContainer), Member = "ValidateContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JObject), Member = "IsNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JProperty), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JObject), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPropertyChanged(string propertyName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyChangingEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPropertyChanging(string propertyName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonLoadSettings)}, ReturnType = typeof(JObject))]
	public static JObject Parse(string json) { }

	[CalledBy(Type = typeof(JObject), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JObject), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JObject))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static JObject Parse(string json, JsonLoadSettings settings) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.Extensions+<>c", Member = "<Properties>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JProperty>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	public IEnumerable<JProperty> Properties() { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object), typeof(Object&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JObject), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JObject), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JObject), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison), typeof(JToken&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JObject), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JProperty))]
	[CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "ReadProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings), typeof(IJsonLineInfo), typeof(JContainer)}, ReturnType = typeof(JProperty))]
	[CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public JProperty Property(string name, StringComparison comparison) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	public JProperty Property(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(JEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JEnumerable<JToken> PropertyValues() { }

	[CalledBy(Type = typeof(JTokenWriter), Member = "WritePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override bool Remove(string propertyName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[NullableContext(2)]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[NullableContext(2)]
	public override void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	[CalledBy(Type = typeof(JObjectDynamicProxy), Member = "TrySetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject), typeof(SetMemberBinder), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
	[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_Item(string propertyName, JToken value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public virtual void set_Item(object key, JToken value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<String, JToken> item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<String, JToken> item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<String, JToken>[] array, int arrayIndex) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<String, JToken> item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	[CallerCount(Count = 0)]
	private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	[CallerCount(Count = 0)]
	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	[CallerCount(Count = 0)]
	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	[CallerCount(Count = 0)]
	[NullableContext(2)]
	private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[CallsUnknownMethods(Count = 3)]
	public override bool TryGetValue(string propertyName, out JToken value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(JObject), Member = "<WriteToAsync>g__AwaitProperties|0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(int), typeof(JsonWriter), typeof(CancellationToken), typeof(JsonConverter[])}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

