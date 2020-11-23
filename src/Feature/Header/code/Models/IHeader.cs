using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Feature.Header.Models
{
    [SitecoreType]
    public interface IHeader : IGlassBase
    {
        [SitecoreField]
        string Title { get; set; }
        [SitecoreField("Body text")]
        string BodyText { get; set; }
        [SitecoreField]
        Glass.Mapper.Sc.Fields.Image Image { get; set; }
    }
}
