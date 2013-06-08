using System;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel;

public static class WsDualProxyHelper {
  public static void SetClientBaseAddress<T>(this DuplexClientBase<T> proxy, int port) where T : class {
    WSDualHttpBinding binding = proxy.Endpoint.Binding as WSDualHttpBinding;
    binding.ClientBaseAddress = new Uri("http://localhost:"+ port + "/");
  }

  public static void SetClientBaseAddress<T>(this DuplexClientBase<T> proxy) where T : class {
    lock (typeof(WsDualProxyHelper)) {
      int portNumber = FindPort();
      SetClientBaseAddress(proxy, portNumber);
      proxy.Open();
    }
  }

  internal static int FindPort() {
    IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
    using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)) {
      socket.Bind(endPoint);
      IPEndPoint local = (IPEndPoint) socket.LocalEndPoint;
      return local.Port;
    }
  }
}
