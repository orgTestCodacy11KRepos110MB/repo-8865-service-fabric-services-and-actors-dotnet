// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Migration.Exceptions
{
    using System;
    using System.Fabric;
    using System.Runtime.Serialization;

    /// <summary>
    /// Exception to represent unresolved ambiguous actor id detection.
    /// </summary>
    [Serializable]
    public sealed class AmbiguousActorIdDetectedException : FabricException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmbiguousActorIdDetectedException"/> class.
        /// </summary>
        public AmbiguousActorIdDetectedException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmbiguousActorIdDetectedException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public AmbiguousActorIdDetectedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmbiguousActorIdDetectedException"/> class with a specified error message and
        /// a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public AmbiguousActorIdDetectedException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmbiguousActorIdDetectedException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown. </param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        private AmbiguousActorIdDetectedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
