namespace UnityEngine.InputSystem.HID;

internal static class HIDParser
{
	private struct HIDItemStateGlobal
	{
		public Nullable<Int32> usagePage; //Field offset: 0x0
		public Nullable<Int32> logicalMinimum; //Field offset: 0x8
		public Nullable<Int32> logicalMaximum; //Field offset: 0x10
		public Nullable<Int32> physicalMinimum; //Field offset: 0x18
		public Nullable<Int32> physicalMaximum; //Field offset: 0x20
		public Nullable<Int32> unitExponent; //Field offset: 0x28
		public Nullable<Int32> unit; //Field offset: 0x30
		public Nullable<Int32> reportSize; //Field offset: 0x38
		public Nullable<Int32> reportCount; //Field offset: 0x40
		public Nullable<Int32> reportId; //Field offset: 0x48

		[CalledBy(Type = typeof(HIDParser), Member = "ParseReportDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(HIDDeviceDescriptor&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(Nullable`1), Member = "GetValueOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		public int GetPhysicalMax() { }

		[CalledBy(Type = typeof(HIDParser), Member = "ParseReportDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(HIDDeviceDescriptor&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(Nullable`1), Member = "GetValueOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		public int GetPhysicalMin() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = "UnityEngine.InputSystem.HID.HIDParser+HIDItemStateLocal", Member = "GetUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		public UsagePage GetUsagePage(int index, ref HIDItemStateLocal localItemState) { }

	}

	private struct HIDItemStateLocal
	{
		public Nullable<Int32> usage; //Field offset: 0x0
		public Nullable<Int32> usageMinimum; //Field offset: 0x8
		public Nullable<Int32> usageMaximum; //Field offset: 0x10
		public Nullable<Int32> designatorIndex; //Field offset: 0x18
		public Nullable<Int32> designatorMinimum; //Field offset: 0x20
		public Nullable<Int32> designatorMaximum; //Field offset: 0x28
		public Nullable<Int32> stringIndex; //Field offset: 0x30
		public Nullable<Int32> stringMinimum; //Field offset: 0x38
		public Nullable<Int32> stringMaximum; //Field offset: 0x40
		public List<Int32> usageList; //Field offset: 0x48

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HIDParser+HIDItemStateGlobal", Member = "GetUsagePage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HIDItemStateLocal&)}, ReturnType = typeof(UsagePage))]
		[CalledBy(Type = typeof(HIDParser), Member = "ParseReportDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(HIDDeviceDescriptor&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		public int GetUsage(int index) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static void Reset(ref HIDItemStateLocal state) { }

		[CalledBy(Type = typeof(HIDParser), Member = "ParseReportDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(HIDDeviceDescriptor&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public void SetUsage(int value) { }

	}

	private enum HIDItemTypeAndTag
	{
		Input = 128,
		Output = 144,
		Feature = 176,
		Collection = 160,
		EndCollection = 192,
		UsagePage = 4,
		LogicalMinimum = 20,
		LogicalMaximum = 36,
		PhysicalMinimum = 52,
		PhysicalMaximum = 68,
		UnitExponent = 84,
		Unit = 100,
		ReportSize = 116,
		ReportID = 132,
		ReportCount = 148,
		Push = 164,
		Pop = 180,
		Usage = 8,
		UsageMinimum = 24,
		UsageMaximum = 40,
		DesignatorIndex = 56,
		DesignatorMinimum = 72,
		DesignatorMaximum = 88,
		StringIndex = 120,
		StringMinimum = 136,
		StringMaximum = 152,
		Delimiter = 168,
	}

	private struct HIDReportData
	{
		public int reportId; //Field offset: 0x0
		public HIDReportType reportType; //Field offset: 0x4
		public int currentBitOffset; //Field offset: 0x8

		[CalledBy(Type = typeof(HIDParser), Member = "ParseReportDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(HIDDeviceDescriptor&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public static int FindOrAddReport(Nullable<Int32> reportId, HIDReportType reportType, List<HIDReportData> reports) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	public static bool ParseReportDescriptor(Byte[] buffer, ref HIDDeviceDescriptor deviceDescriptor) { }

	[CalledBy(Type = typeof(HID), Member = "ReadHIDDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = "GetValueOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(HIDItemStateLocal), Member = "SetUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HIDItemStateGlobal), Member = "GetPhysicalMax", ReturnType = typeof(int))]
	[Calls(Type = typeof(HIDItemStateGlobal), Member = "GetPhysicalMin", ReturnType = typeof(int))]
	[Calls(Type = typeof(HIDReportData), Member = "FindOrAddReport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>), typeof(HIDReportType), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.HID.HIDParser+HIDReportData>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(HIDItemStateLocal), Member = "GetUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(HIDParser), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte*), typeof(Byte*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static bool ParseReportDescriptor(Byte* bufferPtr, int bufferLength, ref HIDDeviceDescriptor deviceDescriptor) { }

	[CalledBy(Type = typeof(HIDParser), Member = "ParseReportDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(HIDDeviceDescriptor&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	private static int ReadData(int itemSize, Byte* currentPtr, Byte* endPtr) { }

}

