﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shuttle.Recall {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Shuttle.Recall.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} &apos;{1}&apos; has no default constructor..
        /// </summary>
        public static string DefaultConstructorRequired {
            get {
                return ResourceManager.GetString("DefaultConstructorRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An event queue with name &apos;{0}&apos; has already been added..
        /// </summary>
        public static string DuplicateEventQueueName {
            get {
                return ResourceManager.GetString("DuplicateEventQueueName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The event processor has already been started.  Event queue &apos;{0}&apos; cannot be added..
        /// </summary>
        public static string EventProcessorStartedCannotAddQueue {
            get {
                return ResourceManager.GetString("EventProcessorStartedCannotAddQueue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The event stream for id &apos;{0}&apos; already at version &apos;{1}&apos; and cannot insert the new event.  The event will be ignored and be added to the event stream again as a newer version..
        /// </summary>
        public static string EventStreamConcurrencyException {
            get {
                return ResourceManager.GetString("EventStreamConcurrencyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not implement IEventHandler&lt;T&gt;..
        /// </summary>
        public static string InvalidEventHandlerType {
            get {
                return ResourceManager.GetString("InvalidEventHandlerType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received primitive events from the IPrimitiveEventRepository implementation that were not sequential.  Version on next primitive event is &apos;{0}&apos; but currently on version &apos;{1}&apos;..
        /// </summary>
        public static string InvalidEventOrderingException {
            get {
                return ResourceManager.GetString("InvalidEventOrderingException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compression algorithm &apos;{0}&apos; has not been registered..
        /// </summary>
        public static string MissingCompressionAlgorithmException {
            get {
                return ResourceManager.GetString("MissingCompressionAlgorithmException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encryption algorithm &apos;{0}&apos; has not been registered..
        /// </summary>
        public static string MissingEncryptionAlgorithmException {
            get {
                return ResourceManager.GetString("MissingEncryptionAlgorithmException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No &apos;IProjectionService implementation has been specified..
        /// </summary>
        public static string MissingProjectionServiceException {
            get {
                return ResourceManager.GetString("MissingProjectionServiceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module could not be instantiated: {0}.
        /// </summary>
        public static string ModuleInstantiationException {
            get {
                return ResourceManager.GetString("ModuleInstantiationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No `IComponentResolver` instance has been assigned to the configuration..
        /// </summary>
        public static string NullResolverException {
            get {
                return ResourceManager.GetString("NullResolverException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Observer with type name &apos;{0}&apos; does not have an interface with name &apos;I{0}&apos;..
        /// </summary>
        public static string ObserverInterfaceMissingException {
            get {
                return ResourceManager.GetString("ObserverInterfaceMissingException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a section named &apos;{0}&apos; in configuration file &apos;{1}&apos; that is of type &apos;{2}&apos;..
        /// </summary>
        public static string OpenSectionException {
            get {
                return ResourceManager.GetString("OpenSectionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handler type &apos;{0}&apos; does not have the required ProcessEvent method that handles domain event type &apos;{1}&apos;..
        /// </summary>
        public static string ProcessEventMethodMissingException {
            get {
                return ResourceManager.GetString("ProcessEventMethodMissingException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is not registered with the serializer so it cannot be serialized.  Please use [SerialierInstance].EnqueueKnownType to add the type before attempting to serialize or deserialize a EventEnvelope containing this type in the object graph of the message property..
        /// </summary>
        public static string SerializerUnknownTypeExcption {
            get {
                return ResourceManager.GetString("SerializerUnknownTypeExcption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Projection &apos;{0}&apos; does not handle type &apos;{1}&apos;..
        /// </summary>
        public static string TraceTypeNotHandled {
            get {
                return ResourceManager.GetString("TraceTypeNotHandled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call to &apos;{0}.{1}&apos; already contains an active TransactionScope..
        /// </summary>
        public static string TransactionAlreadyStartedException {
            get {
                return ResourceManager.GetString("TransactionAlreadyStartedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instance of type &apos;{0}&apos; does not have a method named &apos;{1}&apos; that accepts event of type &apos;{2}&apos;.  Ensure that the accessibility is correct (private | public)..
        /// </summary>
        public static string UnhandledEventException {
            get {
                return ResourceManager.GetString("UnhandledEventException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get type: {0}.
        /// </summary>
        public static string UnknownTypeException {
            get {
                return ResourceManager.GetString("UnknownTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransactionScope (&apos;{0}&apos;) using ambient transaction..
        /// </summary>
        public static string VerboseTransactionScopeAmbient {
            get {
                return ResourceManager.GetString("VerboseTransactionScopeAmbient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransactionScope (&apos;{0}&apos;) using ambient transaction has completed..
        /// </summary>
        public static string VerboseTransactionScopeAmbientCompleted {
            get {
                return ResourceManager.GetString("VerboseTransactionScopeAmbientCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransactionScope (&apos;{0}&apos;) has completed..
        /// </summary>
        public static string VerboseTransactionScopeCompleted {
            get {
                return ResourceManager.GetString("VerboseTransactionScopeCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransactionScope (&apos;{0}&apos;) created with isolation level &apos;{1}&apos; and timeout of &apos;{2}&apos;..
        /// </summary>
        public static string VerboseTransactionScopeCreated {
            get {
                return ResourceManager.GetString("VerboseTransactionScopeCreated", resourceCulture);
            }
        }
    }
}
