//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3069
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts.HostSideAdapters
{
    
    public class NewFrameEventArgsHostAdapter
    {
        internal static Multitouch.Contracts.NewFrameEventArgs ContractToViewAdapter(Multitouch.Contracts.Contracts.INewFrameEventArgsContract contract)
        {
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(NewFrameEventArgsViewToContractHostAdapter))))
            {
                return ((NewFrameEventArgsViewToContractHostAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new NewFrameEventArgsContractToViewHostAdapter(contract);
            }
        }
        internal static Multitouch.Contracts.Contracts.INewFrameEventArgsContract ViewToContractAdapter(Multitouch.Contracts.NewFrameEventArgs view)
        {
            if (view.GetType().Equals(typeof(NewFrameEventArgsContractToViewHostAdapter)))
            {
                return ((NewFrameEventArgsContractToViewHostAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new NewFrameEventArgsViewToContractHostAdapter(view);
            }
        }
    }
}
