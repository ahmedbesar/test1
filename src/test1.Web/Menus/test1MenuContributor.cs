using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace test1.Web.Menus;

public class test1MenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(test1Menus.Prefix, displayName: "test1", "~/test1", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
