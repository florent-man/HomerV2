using System;
using System.Collections.Generic;
using HomerV2;
using HomerV2.Enums;

namespace Homer.Applications.Dtos;

public class ApplicationDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public string Url { get; set; }
    public string Target { get; set; }
    public MenuTypes MenuTypes { get; set; }
}
