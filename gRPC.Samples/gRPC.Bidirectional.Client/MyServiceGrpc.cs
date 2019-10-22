// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MyService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GRPC.Bidirectional.Core {
  public static partial class MyService
  {
    static readonly string __ServiceName = "GRPC.Bidirectional.Core.MyService";

    static readonly grpc::Marshaller<global::GRPC.Bidirectional.Core.DoMessage> __Marshaller_GRPC_Bidirectional_Core_DoMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRPC.Bidirectional.Core.DoMessage.Parser.ParseFrom);

    static readonly grpc::Method<global::GRPC.Bidirectional.Core.DoMessage, global::GRPC.Bidirectional.Core.DoMessage> __Method_Do = new grpc::Method<global::GRPC.Bidirectional.Core.DoMessage, global::GRPC.Bidirectional.Core.DoMessage>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Do",
        __Marshaller_GRPC_Bidirectional_Core_DoMessage,
        __Marshaller_GRPC_Bidirectional_Core_DoMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GRPC.Bidirectional.Core.MyServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MyService</summary>
    [grpc::BindServiceMethod(typeof(MyService), "BindService")]
    public abstract partial class MyServiceBase
    {
      public virtual global::System.Threading.Tasks.Task Do(grpc::IAsyncStreamReader<global::GRPC.Bidirectional.Core.DoMessage> requestStream, grpc::IServerStreamWriter<global::GRPC.Bidirectional.Core.DoMessage> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MyService</summary>
    public partial class MyServiceClient : grpc::ClientBase<MyServiceClient>
    {
      /// <summary>Creates a new client for MyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MyServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::GRPC.Bidirectional.Core.DoMessage, global::GRPC.Bidirectional.Core.DoMessage> Do(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Do(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::GRPC.Bidirectional.Core.DoMessage, global::GRPC.Bidirectional.Core.DoMessage> Do(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Do, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MyServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MyServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Do, serviceImpl.Do).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MyServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Do, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::GRPC.Bidirectional.Core.DoMessage, global::GRPC.Bidirectional.Core.DoMessage>(serviceImpl.Do));
    }

  }
}
#endregion
