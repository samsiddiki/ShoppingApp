﻿using System;
using System.Collections.Generic;

namespace DataModels.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public int? CategoryId { get; set; }

    public string? ImageUrl { get; set; }

    public int? Stock { get; set; }
}
