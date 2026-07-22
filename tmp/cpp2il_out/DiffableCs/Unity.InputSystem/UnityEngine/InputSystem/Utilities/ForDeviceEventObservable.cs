namespace UnityEngine.InputSystem.Utilities;

internal class ForDeviceEventObservable : IObservable<InputEventPtr>
{
	private class ForDevice : IObserver<InputEventPtr>
	{
		private IObserver<InputEventPtr> m_Observer; //Field offset: 0x10
		private InputDevice m_Device; //Field offset: 0x18
		private Type m_DeviceType; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public ForDevice(Type deviceType, InputDevice device, IObserver<InputEventPtr> observer) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void OnCompleted() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		public override void OnError(Exception error) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEventPtr), Member = "get_deviceId", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputSystem), Member = "GetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public override void OnNext(InputEventPtr value) { }

	}

	private IObservable<InputEventPtr> m_Source; //Field offset: 0x10
	private InputDevice m_Device; //Field offset: 0x18
	private Type m_DeviceType; //Field offset: 0x20

	[CalledBy(Type = typeof(Observable), Member = "ForDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.IObservable`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(System.IObservable`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public ForDeviceEventObservable(IObservable<InputEventPtr> source, Type deviceType, InputDevice device) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override IDisposable Subscribe(IObserver<InputEventPtr> observer) { }

}

