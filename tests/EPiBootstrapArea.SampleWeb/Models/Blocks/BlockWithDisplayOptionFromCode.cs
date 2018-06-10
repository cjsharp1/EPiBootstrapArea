using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EPiBootstrapArea.SampleWeb.Models.Blocks
{
    [ContentType(DisplayName = "Block with DisplayOption from Code (1/4)", GUID = "832c06b1-4a11-48aa-8c7e-5b01cc472bad", Description = "")]
    public class BlockWithDisplayOptionFromCode : SiteBlockData, IDefaultDisplayOption
    {
        public string DefaultDisplayOption => ContentAreaTags.OneQuarterWidth;
    }
}
