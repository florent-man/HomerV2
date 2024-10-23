using System;
using HomerV2.Applications;

namespace HomerV2.ApplicationMenuTypes;

public class ApplicationMenuType
{
    public Guid ApplicationId { get; set; }
    public Application Application { get; set; }

    public string MenuTypeName { get; set; }
    public MenuTypes MenuType { get; set; }
}
