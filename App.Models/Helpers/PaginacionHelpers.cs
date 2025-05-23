﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Helpers;

public class PaginacionHelpers<T> where T : class
{
    public int PageIndex { get; private set;}
    public int PageSize { get; private set; }
    public int Total { get; private set; }
    public string Search { get; private set; }
    public IEnumerable<T> Registers { get; set;}
    public PaginacionHelpers(IEnumerable<T> registers, int total, int pageIndex, int pageSize, string search)
    {
        Registers = registers;
        Total = total;
        PageIndex = pageIndex;
        PageSize = pageSize;
        Search = search;
    }

    public int TotalPages
    {
        get
        {
            return (int)Math.Ceiling(Total / (double)PageSize);
        }
    }

    public bool HasPreviousPage
    {
        get
        {
            return (PageIndex > 1);
        }
    }

    public bool HasNextPage
    {
        get
        {
            return (PageIndex < TotalPages);
        }
    }
}
