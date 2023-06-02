﻿using System;
using System.Collections.Generic;

namespace MVC_EFC_Db1st;

public partial class Dessert
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public decimal Price { get; set; }

    public bool Available { get; set; }
}
