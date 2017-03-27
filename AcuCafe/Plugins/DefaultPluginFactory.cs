using System.Collections.Generic;

namespace AcuCafe.Plugins
{
    public class DefaultPluginFactory : IPluginsFactory
    {
        public IEnumerable<IDrinkPlugin> GetDrinkPlugins()
        {
            yield return new TeaPlugin();
            yield return new ExpressoPlugin();
            yield return new IceTeaPlugin();
        }
    }
}
