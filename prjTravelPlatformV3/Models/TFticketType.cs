﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class TFticketType
{
    public int FTicketTypeId { get; set; }

    public string FTicketType { get; set; }

    public double? FTicketRate { get; set; }

    public virtual ICollection<TForderDetail> TForderDetails { get; set; } = new List<TForderDetail>();
}