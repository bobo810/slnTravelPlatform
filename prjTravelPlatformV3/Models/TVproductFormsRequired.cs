﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class TVproductFormsRequired
{
    public int FId { get; set; }

    public int FProductId { get; set; }

    public int FFormId { get; set; }

    public virtual TVformPath FForm { get; set; }

    public virtual TVproduct FProduct { get; set; }
}