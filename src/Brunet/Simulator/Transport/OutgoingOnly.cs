/*
Copyright (C) 2010 David Wolinsky <davidiw@ufl.edu>, University of Florida

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
  
The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

using System.Collections;
using Brunet.Transport;

namespace Brunet.Simulator.Transport {
  public class OutgoingOnly : INat {
    readonly private TransportAddress[] _local_tas;

    public bool AllowingIncomingConnections { get { return false; } }
    public IEnumerable InternalTransportAddresses { get { return _local_tas; } }
    public IEnumerable ExternalTransportAddresses { get { return _local_tas; } }
    public IEnumerable KnownTransportAddresses { get { return _local_tas; } }

    public OutgoingOnly(TransportAddress local_ta)
    {
      _local_tas = new TransportAddress[1] { local_ta };
    }

    public bool Incoming(TransportAddress remote_ta)
    {
      return false;
    }

    public bool Outgoing(TransportAddress remote_ta)
    {
      return true;
    }

    public void UpdateTAs(TransportAddress remote_ta, TransportAddress local_ta)
    {
    }
  }
}
