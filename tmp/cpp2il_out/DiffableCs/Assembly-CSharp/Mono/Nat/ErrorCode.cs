namespace Mono.Nat;

public enum ErrorCode
{
	Unknown = -9999,
	InvalidArgs = 402,
	ActionFailed = 501,
	SpecifiedArrayIndexInvalid = 713,
	WildCardNotPermittedInSourceIP = 715,
	WildCardNotPermittedInExternalPort = 716,
	ConflictInMappingEntry = 718,
	SamePortValuesRequired = 724,
	Success = 0,
	UnsupportedVersion = 1,
	NotAuthorizedOrRefused = 2,
	NetworkFailure = 3,
	OutOfResources = 4,
	UnsupportedOperation = 5,
}

