// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.TitleStorage
{
	/// <summary>
	/// Return results for <see cref="OnReadFileDataCallback" /> callbacks
	/// </summary>
	public enum ReadResult : int
	{
		/// <summary>
		/// Signifies the data was read successfully, and we should continue to the next chunk if possible
		/// </summary>
		RrContinuereading = 1,
		/// <summary>
		/// Signifies there was a failure reading the data, and the request should end
		/// </summary>
		RrFailrequest = 2,
		/// <summary>
		/// Signifies the request should be cancelled, but not due to an error
		/// </summary>
		RrCancelrequest = 3
	}
}