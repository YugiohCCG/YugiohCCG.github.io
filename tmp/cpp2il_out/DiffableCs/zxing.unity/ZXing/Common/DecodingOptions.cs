namespace ZXing.Common;

public class DecodingOptions
{
	[DefaultMember("Item")]
	private class ChangeNotifyDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
	{
		private readonly IDictionary<TKey, TValue> values; //Field offset: 0x0
		private Action<Object, EventArgs> ValueChanged; //Field offset: 0x0

		public event Action<Object, EventArgs> ValueChanged
		{
			[CalledBy(Type = typeof(DecodingOptions), Member = ".ctor", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 add { } //Length: 161
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 remove { } //Length: 161
		}

		public override int Count
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 73
		}

		public override bool IsReadOnly
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 76
		}

		public override TValue Item
		{
			[CallerCount(Count = 40)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 84
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			 set { } //Length: 126
		}

		public override ICollection<TKey> Keys
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 73
		}

		public override ICollection<TValue> Values
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 73
		}

		[CalledBy(Type = typeof(DecodingOptions), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ChangeNotifyDictionary`2() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override void Add(TKey key, TValue value) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override void Add(KeyValuePair<TKey, TValue> item) { }

		[CalledBy(Type = typeof(DecodingOptions), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void add_ValueChanged(Action<Object, EventArgs> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override void Clear() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override bool Contains(KeyValuePair<TKey, TValue> item) { }

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override bool ContainsKey(TKey key) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override int get_Count() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override bool get_IsReadOnly() { }

		[CallerCount(Count = 40)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override TValue get_Item(TKey key) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override ICollection<TKey> get_Keys() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override ICollection<TValue> get_Values() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private void OnValueChanged() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override bool Remove(TKey key) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override bool Remove(KeyValuePair<TKey, TValue> item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void remove_ValueChanged(Action<Object, EventArgs> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override void set_Item(TKey key, TValue value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override bool TryGetValue(TKey key, out TValue value) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IDictionary<DecodeHintType, Object> <Hints>k__BackingField; //Field offset: 0x10
	private Action<Object, EventArgs> ValueChanged; //Field offset: 0x18

	public event Action<Object, EventArgs> ValueChanged
	{
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Reader), "System.Func`4<T, Int32, Int32, LuminanceSource>", typeof(System.Func`2<ZXing.LuminanceSource, ZXing.Binarizer>), typeof(System.Func`5<Byte[], System.Int32, System.Int32, ZXing.RGBLuminanceSource+BitmapFormat, ZXing.LuminanceSource>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		 add { } //Length: 161
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		 remove { } //Length: 161
	}

	public string CharacterSet
	{
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "get_CharacterSet", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 149
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 162
	}

	[Browsable(False)]
	public private IDictionary<DecodeHintType, Object> Hints
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public IList<BarcodeFormat> PossibleFormats
	{
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "DecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(Result[]))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 188
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 159
	}

	public bool PureBarcode
	{
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "get_PureBarcode", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 227
	}

	public bool ReturnCodabarStartEnd
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 230
	}

	public bool TryHarder
	{
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "get_TryHarder", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 230
	}

	public bool UseCode39ExtendedMode
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 230
	}

	public bool UseCode39RelaxedExtendedMode
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 230
	}

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "get_Options", ReturnType = typeof(DecodingOptions))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ChangeNotifyDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChangeNotifyDictionary`2), Member = "add_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Object, System.EventArgs>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public DecodingOptions() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private void <DecodingOptions>m__0(object o, EventArgs args) { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Reader), "System.Func`4<T, Int32, Int32, LuminanceSource>", typeof(System.Func`2<ZXing.LuminanceSource, ZXing.Binarizer>), typeof(System.Func`5<Byte[], System.Int32, System.Int32, ZXing.RGBLuminanceSource+BitmapFormat, ZXing.LuminanceSource>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	public void add_ValueChanged(Action<Object, EventArgs> value) { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "get_CharacterSet", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string get_CharacterSet() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IDictionary<DecodeHintType, Object> get_Hints() { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "DecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public IList<BarcodeFormat> get_PossibleFormats() { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "get_PureBarcode", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_PureBarcode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_ReturnCodabarStartEnd() { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "get_TryHarder", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_TryHarder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_UseCode39ExtendedMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_UseCode39RelaxedExtendedMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	public void remove_ValueChanged(Action<Object, EventArgs> value) { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_CharacterSet(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Hints(IDictionary<DecodeHintType, Object> value) { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_PossibleFormats(IList<BarcodeFormat> value) { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_PureBarcode(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void set_ReturnCodabarStartEnd(bool value) { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_TryHarder(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void set_UseCode39ExtendedMode(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void set_UseCode39RelaxedExtendedMode(bool value) { }

}

