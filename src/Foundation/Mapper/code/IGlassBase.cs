using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;


namespace Sitecore.Foundation.Mapper
{
    [SitecoreType]
    public interface IGlassBase
    {
        // Mandatory for Glassmapper DO NOT delete
        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }
        // Mandatory for Glassmapper DO NOT delete
        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string Template { get; set; }
        // Mandatory for Glassmapper DO NOT delete
        [SitecoreId]
        Guid Id { get; set; }
    }
}