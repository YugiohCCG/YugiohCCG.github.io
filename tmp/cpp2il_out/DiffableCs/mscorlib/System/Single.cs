namespace System;

[IsReadOnly]
public struct float : IComparable, IConvertible, IFormattable, IComparable<Single>, IEquatable<Single>, ISpanFormattable
{
	private readonly float m_value; //Field offset: 0x0

	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "<DoLayout>b__50_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column", "UnityEngine.UIElements.Column"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "<DoLayout>b__50_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column", "UnityEngine.UIElements.Column"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "<RecomputeToMaxWidthProportionally>b__54_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column", "UnityEngine.UIElements.Column"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "<RecomputeToMinWidthProportionally>b__55_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column", "UnityEngine.UIElements.Column"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputBindingCompositeContext+DefaultComparer`1", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.PowerOfTwoTextureAtlas+<>c", Member = "<RelayoutEntries>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`2<Int32, Vector2Int>", "System.ValueTuple`2<Int32, Vector2Int>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.SingleStorage", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.SingleStorage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster+RaycastHitComparer", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.RaycastHit", "UnityEngine.RaycastHit"}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(float value) { }

	[CalledBy(Type = "System.Xml.Schema.Datatype_float", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(object value) { }

	[CallerCount(Count = 84)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(float obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 339)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override TypeCode GetTypeCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	public static bool IsFinite(float f) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	public static bool IsInfinity(float f) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public static bool IsNaN(float f) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	public static bool IsNegativeInfinity(float f) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	public static bool IsPositiveInfinity(float f) { }

	[CalledBy(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = "System.ComponentModel.SingleConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "ParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CalledBy(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "ParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	public static float Parse(string s, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(byte))]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(double))]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(short))]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(long))]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(sbyte))]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint))]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ulong))]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CallerCount(Count = 377)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider provider) { }

	[CalledBy(Type = "HostSettings", Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings", typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LoadingInfo", Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LoadingInfo", Member = "UpdateMinorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerFloatField", Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField", Member = "UpdateValueLabel", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.Extents", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.Mesh_Extents", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.SpriteAssetUtilities.TexturePacker_JsonArray+SpriteFrame", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.SpriteAssetUtilities.TexturePacker_JsonArray+SpriteSize", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.Extents", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	public string ToString(string format) { }

	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterFloatConverters>b__25_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.Angle", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.Length", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.TimeValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.TransformOrigin", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.Translate", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Dimension", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StyleSheetExtensions", Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheet", "UnityEngine.UIElements.StyleValueHandle"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlSingle", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_21", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	public override string ToString(IFormatProvider provider) { }

	[CallerCount(Count = 46)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "TryFormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[CalledBy(Type = "UnityEngine.UIElements.UxmlFloatAttributeDescription+<>c", Member = "<GetValueFromBag>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlFloatAttributeDescription", Member = "ConvertValueToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "SharpJson.Lexer", Member = "ParseFloatNumber", ReturnType = typeof(float))]
	[CalledBy(Type = "SharpJson.JsonDecoder", Member = "ParseValue", ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	[CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Number), Member = "TryParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryExtensions), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsUnknownMethods(Count = 4)]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out float result) { }

	[CalledBy(Type = "HostSettings", Member = "GetGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings&", typeof(UInt32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "ParseFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.DuelRules&", typeof(Int32&), typeof(Int16&), typeof(Byte&), typeof(Byte&), typeof(Byte&), typeof(Byte&), typeof(UInt32&), "Enumerator.DuelMode&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "ApplyCard", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "ApplySocial", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ValueSlider", Member = "OnInputChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnApplyButton", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterFloatConverters>b__25_12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField", Member = "CanTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Column+UxmlObjectTraits`1", Member = "ParseLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.UIElements.Length"}, ReturnType = "UnityEngine.UIElements.Length")]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_20", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(float))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, out float result) { }

}

