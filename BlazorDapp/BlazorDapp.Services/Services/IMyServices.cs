﻿namespace BlazorDapp.Services.Services
{
    public interface IMyService
    {
        List<string> Names { get; set; }
        void AddName(string name);
    }
}