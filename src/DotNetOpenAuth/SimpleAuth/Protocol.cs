﻿// <auto-generated/> // disable StyleCop on this file
//-----------------------------------------------------------------------
// <copyright file="Protocol.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.SimpleAuth {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	/// <summary>
	/// Protocol constants for Simple Auth.
	/// </summary>
	internal class Protocol {
		/// <summary>
		/// The default (latest) version of the Simple Auth protocol.
		/// </summary>
		internal static readonly Version DefaultVersion = V10;

		/// <summary>
		/// The initial (1.0) version of Simple Auth.
		/// </summary>
		internal static readonly Version V10 = new Version(1, 0);

		/// <summary>
		/// The HTTP authorization scheme "SimpleAPIAuth";
		/// </summary>
		internal const string HttpAuthorizationScheme = "SimpleAPIAuth";

		/// <summary>
		/// The "sa_consumer_state" string.
		/// </summary>
		internal const string sa_consumer_state = "sa_consumer_state";

		/// <summary>
		/// The "sa_callback" string.
		/// </summary>
		internal const string sa_callback = "sa_callback";

		/// <summary>
		/// The "sa_consumer_key" string.
		/// </summary>
		internal const string sa_consumer_key = "sa_consumer_key";

		/// <summary>
		/// The "sa_consumer_secret" string.
		/// </summary>
		internal const string sa_consumer_secret = "sa_consumer_secret";

		/// <summary>
		/// The "sa_delegation_code" string.
		/// </summary>
		internal const string sa_delegation_code = "sa_delegation_code";

		/// <summary>
		/// The "sa_error_reason" string.
		/// </summary>
		internal const string sa_error_reason = "sa_error_reason";

		/// <summary>
		/// The "user_denied" string.
		/// </summary>
		internal const string sa_error_reason_denied = "user_denied";

		/// <summary>
		/// The "sa_token" string.
		/// </summary>
		internal const string sa_token = "sa_token";

		/// <summary>
		/// The "sa_token_expires_in" string.
		/// </summary>
		internal const string sa_token_expires_in = "sa_token_expires_in";

		/// <summary>
		/// The "expired_delegation_code" string.
		/// </summary>
		internal const string expired_delegation_code = "expired_delegation_code";
	}
}