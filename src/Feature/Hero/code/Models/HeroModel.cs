using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Mapper;

namespace Sitecore.Feature.Hero.Models
{
    [SitecoreType(TemplateId = "{48787556-6BF4-4954-9DF2-F744B9B71F95}", AutoMap = true)]
    public interface HeroModel : IGlassBase
    {
        [SitecoreField]
        string Title { get; set; }
        [SitecoreField("Body text")]
        string BodyText { get; set; }
        [SitecoreField]
        Glass.Mapper.Sc.Fields.Image Image { get; set; }

    }
}