namespace System.Diagnostics;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ProcessStartInfo
{
	private static readonly String[] empty; //Field offset: 0x0
	private string fileName; //Field offset: 0x10
	private string arguments; //Field offset: 0x18
	private string directory; //Field offset: 0x20
	private string verb; //Field offset: 0x28
	private ProcessWindowStyle windowStyle; //Field offset: 0x30
	private bool errorDialog; //Field offset: 0x34
	private IntPtr errorDialogParentHandle; //Field offset: 0x38
	private bool useShellExecute; //Field offset: 0x40
	private string userName; //Field offset: 0x48
	private string domain; //Field offset: 0x50
	private SecureString password; //Field offset: 0x58
	private string passwordInClearText; //Field offset: 0x60
	private bool loadUserProfile; //Field offset: 0x68
	private bool redirectStandardInput; //Field offset: 0x69
	private bool redirectStandardOutput; //Field offset: 0x6A
	private bool redirectStandardError; //Field offset: 0x6B
	private Encoding standardOutputEncoding; //Field offset: 0x70
	private Encoding standardErrorEncoding; //Field offset: 0x78
	private bool createNoWindow; //Field offset: 0x80
	private WeakReference weakParentProcess; //Field offset: 0x88
	internal StringDictionary environmentVariables; //Field offset: 0x90
	private Collection<String> _argumentList; //Field offset: 0x98
	private IDictionary<String, String> environment; //Field offset: 0xA0
	[CompilerGenerated]
	private Encoding <StandardInputEncoding>k__BackingField; //Field offset: 0xA8

	public Collection<String> ArgumentList
	{
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 134
	}

	[DefaultValue(null)]
	[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
	[NotifyParentProperty(True)]
	[SettingsBindable(True)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string Arguments
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[NotifyParentProperty(True)]
	public string Domain
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	[DefaultValue(null)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
	[NotifyParentProperty(True)]
	public StringDictionary EnvironmentVariables
	{
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariables", ReturnType = typeof(IDictionary))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 19)]
		 get { } //Length: 1085
	}

	[DefaultValue(null)]
	[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("The name of the application, document or URL to start.")]
	[NotifyParentProperty(True)]
	[SettingsBindable(True)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string FileName
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	internal bool HaveEnvVars
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 12
	}

	[NotifyParentProperty(True)]
	public bool LoadUserProfile
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public SecureString Password
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
	[NotifyParentProperty(True)]
	public bool RedirectStandardError
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
	[NotifyParentProperty(True)]
	public bool RedirectStandardInput
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
	[NotifyParentProperty(True)]
	public bool RedirectStandardOutput
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Encoding StandardErrorEncoding
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Encoding StandardInputEncoding
	{
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Encoding StandardOutputEncoding
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[NotifyParentProperty(True)]
	public string UserName
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	[DefaultValue(True)]
	[MonitoringDescription("Whether to use the operating system shell to start the process.")]
	[NotifyParentProperty(True)]
	public bool UseShellExecute
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[DefaultValue(null)]
	[MonitoringDescription("The verb to apply to the document specified by the FileName property.")]
	[NotifyParentProperty(True)]
	[TypeConverter("System.Diagnostics.Design.VerbConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string Verb
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[DefaultValue(null)]
	[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("The initial working directory for the process.")]
	[NotifyParentProperty(True)]
	[SettingsBindable(True)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string WorkingDirectory
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 30
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static ProcessStartInfo() { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "LaunchAsAdmin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ProcessStartInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ProcessStartInfo(Process parent) { }

	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public Collection<String> get_ArgumentList() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_Arguments() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public string get_Domain() { }

	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariables", ReturnType = typeof(IDictionary))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 19)]
	public StringDictionary get_EnvironmentVariables() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_FileName() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_HaveEnvVars() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_LoadUserProfile() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public SecureString get_Password() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_RedirectStandardError() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_RedirectStandardInput() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_RedirectStandardOutput() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public Encoding get_StandardErrorEncoding() { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Encoding get_StandardInputEncoding() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public Encoding get_StandardOutputEncoding() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_UserName() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public bool get_UseShellExecute() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public string get_WorkingDirectory() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Arguments(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_FileName(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_UseShellExecute(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Verb(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_WorkingDirectory(string value) { }

}

