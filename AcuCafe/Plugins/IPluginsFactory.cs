using System.Collections.Generic;

namespace AcuCafe.Plugins
{
    public interface IPluginsFactory
    {
        IEnumerable<IDrinkPlugin> GetDrinkPlugins();
    }
}
