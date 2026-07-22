namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JProperty : JContainer
{
	[CompilerGenerated]
	private struct <LoadAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<JProperty> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JsonLoadSettings settings; //Field offset: 0x30
		[Nullable(0)]
		private JProperty <p>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "MoveToContentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JContainer), Member = "ReadTokenFromAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 31)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteToAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JProperty <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public JsonWriter writer; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public JsonConverter[] converters; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JsonPath.QueryScanFilter+<ExecuteFilter>d__2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JsonPath.QueryFilter+<ExecuteFilter>d__2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JsonPath.ScanMultipleFilter+<ExecuteFilter>d__2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JsonPath.ArrayMultipleIndexFilter+<ExecuteFilter>d__2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter+<ExecuteFilter>d__2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JsonPath.FieldFilter+<ExecuteFilter>d__2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter+<ExecuteFilter>d__12", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JsonPath.ArrayIndexFilter+<ExecuteFilter>d__4", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JsonPath.ScanFilter+<ExecuteFilter>d__2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 13)]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[DefaultMember("Item")]
	[Nullable(0)]
	private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__1 : IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private JToken <>2__current; //Field offset: 0x18
			[Nullable(0)]
			public JPropertyList <>4__this; //Field offset: 0x20

			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(Count = 31)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 31)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 5
			}

			[CallerCount(Count = 36)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			public <GetEnumerator>d__1(int <>1__state) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			private override bool MoveNext() { }

			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[CallerCount(Count = 13327)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override void System.IDisposable.Dispose() { }

		}

		[Nullable(2)]
		internal JToken _token; //Field offset: 0x10

		public override int Count
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 10
		}

		public override bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public override JToken Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 83
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 94
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public JPropertyList() { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Add(JToken item) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Clear() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool Contains(JToken item) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		public override void CopyTo(JToken[] array, int arrayIndex) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public override int get_Count() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public override bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public override JToken get_Item(int index) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
		public override IEnumerator<JToken> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public override int IndexOf(JToken item) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override void Insert(int index, JToken item) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override bool Remove(JToken item) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override void RemoveAt(int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public override void set_Item(int index, JToken value) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private readonly JPropertyList _content; //Field offset: 0x58
	private readonly string _name; //Field offset: 0x60

	protected virtual IList<JToken> ChildrenTokens
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Name
	{
		[CallerCount(Count = 84)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual JTokenType Type
	{
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public JToken Value
	{
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object), typeof(Object&), typeof(String&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchema>))]
		[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ScanFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ScanMultipleFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerStepThrough]
		 get { } //Length: 27
		[CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
		[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 131
	}

	[CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "IsMultiContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
	[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public JProperty(string name, object content) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	public JProperty(string name, Object[] content) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public JProperty(JProperty other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal JProperty(JProperty other, JsonCloneSettings settings) { }

	[CalledBy(Type = typeof(JContainer), Member = "ReadProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings), typeof(IJsonLineInfo), typeof(JContainer)}, ReturnType = typeof(JProperty))]
	[CalledBy(Type = typeof(<LoadAsync>d__4), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JProperty), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JProperty))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WritePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal JProperty(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal virtual void ClearItems() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	internal virtual bool ContainsItem(JToken item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "ContentsEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual bool DeepEquals(JToken node) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	protected virtual IList<JToken> get_ChildrenTokens() { }

	[CallerCount(Count = 84)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	public virtual JTokenType get_Type() { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object), typeof(Object&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchema>))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ScanFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ScanMultipleFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerStepThrough]
	public JToken get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual int GetDeepHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal virtual JToken GetItem(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[NullableContext(2)]
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JProperty), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JProperty))]
	public static JProperty Load(JsonReader reader) { }

	[CalledBy(Type = typeof(JProperty), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JProperty))]
	[CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonReader), Member = "MoveToContent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "ReadTokenFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__4))]
	[CalledBy(Type = typeof(JProperty), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Newtonsoft.Json.Linq.JProperty>))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken+<ReadFromAsync>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadAsync>d__4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadAsync>d__4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JProperty), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Newtonsoft.Json.Linq.JProperty>))]
	public static Task<JProperty> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[NullableContext(2)]
	internal virtual bool RemoveItem(JToken item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal virtual void RemoveItemAt(int index) { }

	[CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
	[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_Value(JToken value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(IList), typeof(IList), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	internal virtual void SetItem(int index, JToken item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(<WriteToAsync>d__1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteToAsync>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteToAsync>d__1&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteToAsync>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteToAsync>d__1&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

