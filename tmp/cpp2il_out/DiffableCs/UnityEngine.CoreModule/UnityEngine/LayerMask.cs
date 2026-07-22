namespace UnityEngine;

[NativeClass("BitField", "struct BitField;")]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[NativeHeader("Runtime/BaseClasses/BitField.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct LayerMask
{
	[NativeName("m_Bits")]
	private int m_Mask; //Field offset: 0x0

	public int value
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int get_value() { }

	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("StringToLayer")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static int NameToLayer(string layerName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int NameToLayer_Injected(ref ManagedSpanWrapper layerName) { }

	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	public static int op_Implicit(LayerMask mask) { }

	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	public static LayerMask op_Implicit(int intVal) { }

}

