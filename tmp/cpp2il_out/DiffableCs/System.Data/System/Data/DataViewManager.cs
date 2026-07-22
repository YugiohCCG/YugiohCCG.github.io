namespace System.Data;

public class DataViewManager : MarshalByValueComponent
{
	private static NotSupportedException s_notSupported; //Field offset: 0x0
	private DataViewSettingCollection _dataViewSettingsCollection; //Field offset: 0x20
	internal int _nViews; //Field offset: 0x28

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public DataViewSettingCollection DataViewSettings
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static DataViewManager() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public DataViewSettingCollection get_DataViewSettings() { }

}

