using Luthetus.Common.RazorLib.Drags.Displays;
using Luthetus.Common.RazorLib.Drags.Models;

namespace Luthetus.Common.RazorLib.Drags.Extensions;

public static class IDragServiceExtension
{
    public static void WithAction(this IDragService dragService, 
        Func<DragState, DragState> action)
    {
        action(dragService.DragStateWrap.Value);
    }
}