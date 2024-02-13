﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class Tdestination
{
    public int Fid { get; set; }

    public string FdestinationId { get; set; }

    public string FdestinationName { get; set; }

    public string FdestinationContent { get; set; }

    public int? FdestinationTypeId { get; set; }

    public int? FareaId { get; set; }

    public int? Fprice { get; set; }

    public int? Fstock { get; set; }

    public bool? Fstate { get; set; }

    public string Faddress { get; set; }

    public virtual TtravelArea Farea { get; set; }

    public virtual Ttype FdestinationType { get; set; }

    public virtual ICollection<TdestinationDetail> TdestinationDetails { get; set; } = new List<TdestinationDetail>();

    public virtual ICollection<TdestinationOrder> TdestinationOrders { get; set; } = new List<TdestinationOrder>();

    public virtual ICollection<TdestinationPhoto> TdestinationPhotos { get; set; } = new List<TdestinationPhoto>();
}