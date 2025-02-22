using Microsoft.AspNetCore.Mvc;

namespace MediOra.Components
{
    public class ExploreSystemComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
