﻿namespace MyKoel_Domain.Interfaces
{
    public interface IDateTime
    {
        DateTime Now { get; }
         DateTime UtcNow { get; }
    }
}
