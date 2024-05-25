namespace Vuexy.Features.Shared.Menu;

public class MenuItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsOpen { get; set; } = false;
    public List<SubMenuItem> SubMenus { get; set; }
}
