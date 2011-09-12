using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace MailOMatic.Lib
{
    public class MailOMaticLibInstaller: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ISendMail>().ImplementedBy<SendMail>());
        }
    }
}
